using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBi
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Performance_Click(object sender, EventArgs e)
        {
            PerformanceForm performance = new PerformanceForm();
            performance.Show();
            this.Hide();
        }

        private void SLA_Click(object sender, EventArgs e)
        {
            SLAForm sla = new SLAForm();
            sla.Show();
            this.Hide();
        }

        private void Outstanding_Click(object sender, EventArgs e)
        {
            OutstandingForm outstanding = new OutstandingForm();
            outstanding.Show();
            this.Hide();
        }

        private void Outstanding2_Click(object sender, EventArgs e)
        {
            OutstandingForm2 outstanding2 = new OutstandingForm2();
            outstanding2.Show();
            this.Hide();
        }

        private void Top_Click(object sender, EventArgs e)
        {
            TopForm top = new TopForm();
            top.Show();
            this.Hide();
        }

        private void CreatedClosed_Click(object sender, EventArgs e)
        {
            CreatedClosedForm created = new CreatedClosedForm();
            created.Show();
            this.Hide();
        }

        private void CreatedClosed2_Click(object sender, EventArgs e)
        {
            CreatedClosed2Form created2 = new CreatedClosed2Form();
            created2.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
