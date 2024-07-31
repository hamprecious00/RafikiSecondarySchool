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
    public partial class DashboardForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");


        public DashboardForm(string username)
        {
            InitializeComponent();
            lbluser.Text = username;
        }
        public DashboardForm() : this("Guest"){ }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            RegisterStudentForm r = new RegisterStudentForm();
            r.Show();
            this.Hide();
        }

        private void txtuser_TextChanged(object sender, EventArgs e){ }

        private void btnmarksentry_Click(object sender, EventArgs e)
        {
            EnterMarksForm enter = new EnterMarksForm();
            enter.Show();
            this.Hide();
        }

        private void btnmarkssheet_Click(object sender, EventArgs e)
        {
            MarksSheetForm sheet = new MarksSheetForm();
            sheet.Show();
            this.Hide();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            StudentlistForm student = new StudentlistForm();
            student.Show();
            this.Hide();
        }

        private void btnreportcard_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.Show();
            this.Hide();
        }

        private void lbluser_Click(object sender, EventArgs e){ }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = "SELECT * FROM Complains";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblName.Text = reader["Name"].ToString();
                    lblDate.Text = reader["Date"].ToString();
                    txtComplains.Text = reader["Complaint"].ToString();
                }
                else
                {
                    lblName.Text = "Record not found"; 
                }

                // Close the reader and the connection
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e){ }

        private void button1_Click(object sender, EventArgs e) { }

        private void button4_Click(object sender, EventArgs e)
        {
            AddAdminForm add = new AddAdminForm();
            add.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComplainForm complain = new ComplainForm();
            complain.Show();
            this.Hide();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            ComplainForm complain = new ComplainForm();
            complain.Show();
            this.Hide();
        }
    }
}
