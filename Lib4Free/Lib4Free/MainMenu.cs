using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib4Free
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnBookManager_Click(object sender, EventArgs e)
        {
            BookManagement bookForm = new BookManagement();
            bookForm.Show();
            this.Hide(); // keeps app running, just hides MainForm
        }

        private void btn_Click(object sender, EventArgs e)
        {
            BookDonation donationForm = new BookDonation();
            donationForm.Show();
            this.Hide(); // keeps app running, just hides MainForm
        }

        private void btnEventManager_Click(object sender, EventArgs e)
        {
            EventManagement eventForm = new EventManagement();
            eventForm.Show();
            this.Hide(); // keeps app running, just hides MainForm
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports();
            reportsForm.Show();
            this.Hide(); // keeps app running, just hides MainForm
        }
    }
}
