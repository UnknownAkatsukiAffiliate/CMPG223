using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace CMPG223_Prac
{
    public partial class Reports : Form
    {
        private string connectionString = "Your_Connection_String_Here";

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            LoadDateFilters();
            LoadComboBoxes();
        }

        private void LoadDateFilters()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT MIN(EventDate), MAX(EventDate) FROM Events", conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                            dtpStart.Value = reader.GetDateTime(0);
                        if (!reader.IsDBNull(1))
                            dtpEnd.Value = reader.GetDateTime(1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading date filters: " + ex.Message);
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Load Events
                    using (SqlCommand cmd = new SqlCommand("SELECT EventName FROM Events", conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        cbxEvents.Items.Clear();
                        while (reader.Read())
                        {
                            cbxEvents.Items.Add(reader.GetString(0));
                        }
                        reader.Close();
                    }

                    // Load Authors
                    using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT AuthorName FROM Books", conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        cbxAuthors.Items.Clear();
                        while (reader.Read())
                        {
                            cbxAuthors.Items.Add(reader.GetString(0));
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading combo boxes: " + ex.Message);
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            string query = "";

            if (rbEvent.Checked)
            {
                query = "SELECT EventName, EventDate, Attendees FROM Events " +
                        "WHERE EventDate BETWEEN @startDate AND @endDate";
            }
            else if (rbAuthors.Checked)
            {
                query = "SELECT AuthorName, COUNT(BookID) AS BooksWritten " +
                        "FROM Books GROUP BY AuthorName";
            }
            else if (rbReader.Checked)
            {
                query = "SELECT ReaderName, COUNT(EventID) AS EventsAttended " +
                        "FROM ReaderEvents GROUP BY ReaderName";
            }
            else if (rbBooks.Checked)
            {
                query = "SELECT * FROM Books";
            }

            LoadReport(query);
        }

        private void LoadReport(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (rbEvent.Checked)
                    {
                        cmd.Parameters.AddWithValue("@startDate", dtpStart.Value);
                        cmd.Parameters.AddWithValue("@endDate", dtpEnd.Value);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DGVOutput.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (DGVOutput.DataSource is DataTable dt)
            {
                string filterText = tbx_search.Text.Trim().Replace("'", "''");
                if (!string.IsNullOrEmpty(filterText))
                {
                    dt.DefaultView.RowFilter =
                        $"Convert(EventName, 'System.String') LIKE '%{filterText}%' " +
                        $"OR Convert(AuthorName, 'System.String') LIKE '%{filterText}%' " +
                        $"OR Convert(ReaderName, 'System.String') LIKE '%{filterText}%'";
                }
                else
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }
            }
        }

        private void cbxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEvents.SelectedItem != null)
            {
                string selectedEvent = cbxEvents.SelectedItem.ToString();
                LoadReport("SELECT * FROM Events WHERE EventName = @eventName", "@eventName", selectedEvent);
            }
        }

        private void cbxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAuthors.SelectedItem != null)
            {
                string selectedAuthor = cbxAuthors.SelectedItem.ToString();
                LoadReport("SELECT * FROM Books WHERE AuthorName = @AuthorName", "@AuthorName", selectedAuthor);
            }
        }

        private void LoadReport(string query, string paramName, string paramValue)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(paramName, paramValue);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DGVOutput.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading filtered report: " + ex.Message);
            }
        }

        private void DGVOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVOutput.DataSource is DataTable dt)
            {
                string columnName = DGVOutput.Columns[e.ColumnIndex].Name;
                dt.DefaultView.Sort = columnName + " ASC";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;

            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDoc
            };
            preview.ShowDialog();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (DGVOutput.DataSource is DataTable dt)
            {
                int y = 100;
                int x = 50;

                // Print column headers
                foreach (DataColumn col in dt.Columns)
                {
                    e.Graphics.DrawString(col.ColumnName, new Font("Arial", 10, FontStyle.Bold),
                        Brushes.Black, x, y);
                    x += 150;
                }

                y += 30;
                x = 50;

                // Print rows
                foreach (DataRow row in dt.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        e.Graphics.DrawString(item.ToString(), new Font("Arial", 10),
                            Brushes.Black, x, y);
                        x += 150;
                    }
                    y += 25;
                    x = 50;
                }
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            if (DGVOutput.DataSource is DataTable dt)
            {
                SaveFileDialog saveFile = new SaveFileDialog
                {
                    Filter = "CSV file (*.csv)|*.csv",
                    FileName = "Report.csv"
                };

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();

                    // Column headers
                    IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>()
                                                    .Select(column => column.ColumnName);
                    sb.AppendLine(string.Join(",", columnNames));

                    // Rows
                    foreach (DataRow row in dt.Rows)
                    {
                        IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                        sb.AppendLine(string.Join(",", fields));
                    }

                    System.IO.File.WriteAllText(saveFile.FileName, sb.ToString());
                    MessageBox.Show("Report exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
