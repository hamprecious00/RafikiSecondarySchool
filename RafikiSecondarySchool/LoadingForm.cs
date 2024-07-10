﻿using System;
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

        int second = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            ProgressBar.Left += 2;
            if (ProgressBar.Left + ProgressBar.Width > CenterPanel.Width+80)
                ProgressBar.Left = 0;

            if(second == 300)
            {
                LoginForm l = new LoginForm();
                timer1.Stop();
                l.Show();
                this.Hide();
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
