using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QAWebsite
{
    public partial class DashboardPage : Form
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void QAReportPage_Click(object sender, EventArgs e)
        {
            // Create an instance of the target form
            int rat = 0;
            //if(employee.userType == 'Geek')
            if(rat != 1)
            {
                DetailedReportPage Detail = new DetailedReportPage();

                // Display the target form
                Detail.Show();

                // Optionally, hide the current form
                this.Hide();
            }
            else
            {
                Form1 Detail = new Form1();

                // Display the target form
                Detail.Show();

                // Optionally, hide the current form
                this.Hide();
            }
        }

        private void QADesPage_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
