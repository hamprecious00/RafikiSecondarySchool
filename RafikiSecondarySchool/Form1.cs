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

namespace RafikiSecondarySchool
{
    public partial class LoginForm : Form

    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, password;
            username = txtusername.Text;
            password = txtpassword.Text;

            try 
            {
                String querry = "SELECT * FROM Login WHERE username = '"+txtusername.Text+"' AND password = '"+txtpassword.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = txtusername.Text;
                    password = txtpassword.Text;

                    //open dashboard
                    DashboardForm d = new DashboardForm();
                    d.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtpassword.Clear();

                    txtusername.Focus();
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
