using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RafikiSecondarySchool
{
    public partial class AddAdminForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");

        public AddAdminForm()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string email = textBox.Text;
                if (IsValidEmail(email))
                {
                    // Email format is valid
                    textBox.BackColor = Color.White; // or any other indication of valid input
                }
                else
                {
                    // Email format is invalid
                    textBox.BackColor = Color.Pink; // or any other indication of invalid input
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtusr.Text;
                string password = txtpass.Text;
                string email = txtemail.Text;

                // Validate email format
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Invalid email format. Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit method if email is invalid
                }

                // Open the connection
                conn.Open();

                // Hash the password
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(txtpass.Text);

                // Create the SQL command with parameters
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Login]
                ([username]
                ,[password]
                ,[email])
                VALUES
                (@username, @password, @email)", conn);

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@username", txtusr.Text);
                cmd.Parameters.AddWithValue("@password", hashedPassword); // Store hashed password
                cmd.Parameters.AddWithValue("@email", txtemail.Text);

                // Execute the command
                cmd.ExecuteNonQuery();

                // Close the connection
                conn.Close();

                MessageBox.Show("Registered Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
