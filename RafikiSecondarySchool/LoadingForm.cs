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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private int elapsedMilliseconds = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedMilliseconds += timer1.Interval;
            ProgressBar.Left += 4;

            if (ProgressBar.Left + ProgressBar.Width > CenterPanel.Width + 80)
            {
                ProgressBar.Left = 0;
            }

            if (elapsedMilliseconds >= 10000) // 10 seconds
            {
                timer1.Stop();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; // Set timer interval to 100 milliseconds
            timer1.Start(); // Start the timer when the form loads
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

