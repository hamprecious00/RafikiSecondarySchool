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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True"))
                {
                    conn.Open();

                    // Retrieve hashed password from database
                    string query = "SELECT password FROM Login WHERE username = @username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    string hashedPassword = cmd.ExecuteScalar() as string;

                    // Check if username exists and verify password
                    if (!string.IsNullOrEmpty(hashedPassword) && BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                    {
                        // Login successful, open dashboard
                        DashboardForm d = new DashboardForm(username);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAdminForm add = new AddAdminForm();
            add.Show();
            this.Hide();
        }

        private void picte(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text;
            string pass = txtpassword.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True"))
                {
                    conn.Open();

                    // Retrieve hashed password from database
                    string query = "SELECT Password FROM Students WHERE Admno = @username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", user);

                    string hashedPassword = cmd.ExecuteScalar() as string;

                    if (!string.IsNullOrEmpty(hashedPassword) && BCrypt.Net.BCrypt.Verify(pass, hashedPassword))
                    {
                        // Login successful, open dashboard
                        Dashboard2Form d2 = new Dashboard2Form(user);
                        d2.Show();
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
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
