using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RafikiSecondarySchool
{
    public partial class DashboardForm : Form
    {
        public DashboardForm(string username)
        {
            InitializeComponent();
            lbluser.Text = username;
        }
        public DashboardForm() : this("Guest")
        {
        }

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
            //this.Hide();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

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

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
