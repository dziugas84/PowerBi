using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PowerBi
{
    public partial class ConnectionForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=PowerBi;Integrated Security=True");
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username;
            string password;

            username = txt_username.Text;
            password = txt_password.Text;

            try
            {
                String querry = "SELECT * FROM Principal WHERE AccountName = '" + txt_username.Text + "' AND AccountPassword = '" + txt_password.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    password = txt_password.Text;
                    MenuForm menuform = new MenuForm();
                    menuform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bad username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
            MessageBox.Show("Fields clean", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
