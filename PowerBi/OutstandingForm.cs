using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBi
{
    public partial class OutstandingForm : Form
    {            
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=PowerBi2;Integrated Security=True");
        public string from;
        public string to;
        public OutstandingForm()
        {
            InitializeComponent();
        }

        private void Export_Click(object sender, EventArgs e)
        {

        from = txt_from.Text;
            to = txt_to.Text;

            if (txt_from.Text == "" || txt_to.Text == "")
            {
                MessageBox.Show("Please fill textbox From and To", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand command = new SqlCommand("select COUNT(RequestNo) AS Amount, p.Title FROM Workplace " +
                    "AS W INNER JOIN Principal as P ON P.ID =W.SupportPerson" +
                    "WHERE Closed >= '" + txt_from.Text + "' AND Closed <= '" + txt_to.Text + "' GROUP BY p.Title", conn);
}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_to_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_from_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }
    }
}
