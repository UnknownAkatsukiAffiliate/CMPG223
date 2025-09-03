using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
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
            // Implement your printing logic here
            MessageBox.Show("Print functionality coming soon!");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Implement your export logic here (e.g., CSV/Excel)
            MessageBox.Show("Export functionality coming soon!");
        }
    }
}
