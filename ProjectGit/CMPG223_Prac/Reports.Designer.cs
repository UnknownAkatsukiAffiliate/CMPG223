namespace CMPG223_Prac
{
    partial class Reports
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupReportType = new System.Windows.Forms.GroupBox();
            this.rbBooks = new System.Windows.Forms.RadioButton();
            this.rbEvent = new System.Windows.Forms.RadioButton();
            this.rbAuthors = new System.Windows.Forms.RadioButton();
            this.rbReader = new System.Windows.Forms.RadioButton();
            this.groupDateFilter = new System.Windows.Forms.GroupBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.groupFilters = new System.Windows.Forms.GroupBox();
            this.cbxEvents = new System.Windows.Forms.ComboBox();
            this.cbxAuthors = new System.Windows.Forms.ComboBox();
            this.cbx_key_Reports = new System.Windows.Forms.ComboBox();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.DGVOutput = new System.Windows.Forms.DataGridView();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupReportType.SuspendLayout();
            this.groupDateFilter.SuspendLayout();
            this.groupFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // groupReportType
            // 
            this.groupReportType.Controls.Add(this.rbBooks);
            this.groupReportType.Controls.Add(this.rbEvent);
            this.groupReportType.Controls.Add(this.rbAuthors);
            this.groupReportType.Controls.Add(this.rbReader);
            this.groupReportType.Location = new System.Drawing.Point(12, 12);
            this.groupReportType.Name = "groupReportType";
            this.groupReportType.Size = new System.Drawing.Size(300, 100);
            this.groupReportType.TabIndex = 0;
            this.groupReportType.TabStop = false;
            this.groupReportType.Text = "Report Type";
            // 
            // rbBooks
            // 
            this.rbBooks.AutoSize = true;
            this.rbBooks.Location = new System.Drawing.Point(10, 20);
            this.rbBooks.Name = "rbBooks";
            this.rbBooks.Size = new System.Drawing.Size(68, 21);
            this.rbBooks.TabIndex = 0;
            this.rbBooks.Text = "Books";
            this.rbBooks.UseVisualStyleBackColor = true;
            // 
            // rbEvent
            // 
            this.rbEvent.AutoSize = true;
            this.rbEvent.Location = new System.Drawing.Point(10, 40);
            this.rbEvent.Name = "rbEvent";
            this.rbEvent.Size = new System.Drawing.Size(72, 21);
            this.rbEvent.TabIndex = 1;
            this.rbEvent.Text = "Events";
            this.rbEvent.UseVisualStyleBackColor = true;
            // 
            // rbAuthors
            // 
            this.rbAuthors.AutoSize = true;
            this.rbAuthors.Location = new System.Drawing.Point(150, 20);
            this.rbAuthors.Name = "rbAuthors";
            this.rbAuthors.Size = new System.Drawing.Size(78, 21);
            this.rbAuthors.TabIndex = 2;
            this.rbAuthors.Text = "Authors";
            this.rbAuthors.UseVisualStyleBackColor = true;
            // 
            // rbReader
            // 
            this.rbReader.AutoSize = true;
            this.rbReader.Location = new System.Drawing.Point(150, 40);
            this.rbReader.Name = "rbReader";
            this.rbReader.Size = new System.Drawing.Size(83, 21);
            this.rbReader.TabIndex = 3;
            this.rbReader.Text = "Readers";
            this.rbReader.UseVisualStyleBackColor = true;
            // 
            // groupDateFilter
            // 
            this.groupDateFilter.Controls.Add(this.dtpStart);
            this.groupDateFilter.Controls.Add(this.dtpEnd);
            this.groupDateFilter.Location = new System.Drawing.Point(12, 120);
            this.groupDateFilter.Name = "groupDateFilter";
            this.groupDateFilter.Size = new System.Drawing.Size(300, 80);
            this.groupDateFilter.TabIndex = 1;
            this.groupDateFilter.TabStop = false;
            this.groupDateFilter.Text = "Filter by Date";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(10, 20);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(280, 22);
            this.dtpStart.TabIndex = 0;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(10, 50);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(280, 22);
            this.dtpEnd.TabIndex = 1;
            // 
            // groupFilters
            // 
            this.groupFilters.Controls.Add(this.cbxEvents);
            this.groupFilters.Controls.Add(this.cbxAuthors);
            this.groupFilters.Controls.Add(this.cbx_key_Reports);
            this.groupFilters.Location = new System.Drawing.Point(330, 12);
            this.groupFilters.Name = "groupFilters";
            this.groupFilters.Size = new System.Drawing.Size(300, 126);
            this.groupFilters.TabIndex = 2;
            this.groupFilters.TabStop = false;
            this.groupFilters.Text = "Filter Options";
            // 
            // cbxEvents
            // 
            this.cbxEvents.FormattingEnabled = true;
            this.cbxEvents.Location = new System.Drawing.Point(10, 20);
            this.cbxEvents.Name = "cbxEvents";
            this.cbxEvents.Size = new System.Drawing.Size(280, 24);
            this.cbxEvents.TabIndex = 0;
            this.cbxEvents.SelectedIndexChanged += new System.EventHandler(this.cbxEvents_SelectedIndexChanged);
            // 
            // cbxAuthors
            // 
            this.cbxAuthors.FormattingEnabled = true;
            this.cbxAuthors.Location = new System.Drawing.Point(10, 50);
            this.cbxAuthors.Name = "cbxAuthors";
            this.cbxAuthors.Size = new System.Drawing.Size(280, 24);
            this.cbxAuthors.TabIndex = 1;
            this.cbxAuthors.SelectedIndexChanged += new System.EventHandler(this.cbxAuthors_SelectedIndexChanged);
            // 
            // cbx_key_Reports
            // 
            this.cbx_key_Reports.FormattingEnabled = true;
            this.cbx_key_Reports.Location = new System.Drawing.Point(10, 80);
            this.cbx_key_Reports.Name = "cbx_key_Reports";
            this.cbx_key_Reports.Size = new System.Drawing.Size(280, 24);
            this.cbx_key_Reports.TabIndex = 2;
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(650, 20);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(150, 22);
            this.tbx_search.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(810, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DGVOutput
            // 
            this.DGVOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOutput.Location = new System.Drawing.Point(12, 220);
            this.DGVOutput.Name = "DGVOutput";
            this.DGVOutput.RowHeadersWidth = 51;
            this.DGVOutput.Size = new System.Drawing.Size(880, 300);
            this.DGVOutput.TabIndex = 5;
            this.DGVOutput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOutput_CellContentClick);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(12, 540);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(120, 30);
            this.btnOutput.TabIndex = 6;
            this.btnOutput.Text = "Generate Report";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(150, 540);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(270, 540);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 30);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Reports Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 591);
            this.Controls.Add(this.groupReportType);
            this.Controls.Add(this.groupDateFilter);
            this.Controls.Add(this.groupFilters);
            this.Controls.Add(this.tbx_search);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.DGVOutput);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExport);
            this.Name = "Reports";
            this.Text = "Report Generator";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.groupReportType.ResumeLayout(false);
            this.groupReportType.PerformLayout();
            this.groupDateFilter.ResumeLayout(false);
            this.groupFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupReportType;
        private System.Windows.Forms.RadioButton rbBooks;
        private System.Windows.Forms.RadioButton rbEvent;
        private System.Windows.Forms.RadioButton rbAuthors;
        private System.Windows.Forms.RadioButton rbReader;
        private System.Windows.Forms.GroupBox groupDateFilter;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox groupFilters;
        private System.Windows.Forms.ComboBox cbxEvents;
        private System.Windows.Forms.ComboBox cbxAuthors;
        private System.Windows.Forms.ComboBox cbx_key_Reports;
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView DGVOutput;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
    }
}
