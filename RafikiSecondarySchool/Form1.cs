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

        //private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //String username, password;
            //username = txtusername.Text;
            //password = txtpassword.Text;

            //try 
            //{
            //    String querry = "SELECT * FROM Login WHERE username = '"+txtusername.Text+"' AND password = '"+txtpassword.Text+"'";
            //    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            //    DataTable dtable = new DataTable();
            //    sda.Fill(dtable);

            //    if(dtable.Rows.Count > 0)
            //    {
            //        username = txtusername.Text;
            //        password = txtpassword.Text;

            //        //open dashboard
            //        DashboardForm d = new DashboardForm();
            //        d.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtusername.Clear();
            //        txtpassword.Clear();

            //        txtusername.Focus();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Error");
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

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
    }
}
