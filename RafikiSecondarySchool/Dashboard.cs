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
        public DashboardForm()
        {
            InitializeComponent();
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
            this.Hide();
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
            SheetDetailsForm sheet = new SheetDetailsForm();
            sheet.Show();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            StudentlistForm student = new StudentlistForm();
            student.Show();
            this.Hide();
        }
    }
}
