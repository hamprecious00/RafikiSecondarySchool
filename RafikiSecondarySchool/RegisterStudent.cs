﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Media;

namespace RafikiSecondarySchool
{
    public partial class RegisterStudentForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");

        public RegisterStudentForm()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DashboardForm d = new DashboardForm();
            d.Show();
            this.Hide();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the image is loaded
                // if (studentpic.Image == null)
                //{
                //  MessageBox.Show("Please upload an image.");
                //return;
                //}

                // Open the connection
                conn.Open();

                // Create the SQL command with parameters
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Students]
                ([Admno]
                ,[StudentName]
                ,[Gender]
                ,[StudentForm]
                ,[StudentClass]
                ,[DateofBirth]
                
                ,[CurrentYear]
                ,[Semester])
                VALUES
                (@Admno, @StudentName, @Gender, @StudentForm, @StudentClass, @DateofBirth, @CurrentYear, @Semester)", conn);

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@Admno", txtadm.Text);
                cmd.Parameters.AddWithValue("@StudentName", txtstudentname.Text);
                cmd.Parameters.AddWithValue("@Gender", cmbgender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@StudentForm", cbostudentform.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@StudentClass", cbostudentclass.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DateofBirth", DateTime.Parse(this.dateofbirth.Text));
                //  cmd.Parameters.AddWithValue("@Photo", studentpic.Image);
                cmd.Parameters.AddWithValue("@CurrentYear", txtcurrentyear.Text);
                cmd.Parameters.AddWithValue("@Semester", cbosemester.SelectedItem.ToString());

                // Execute the command
                cmd.ExecuteNonQuery();

                // Close the connection
                conn.Close();

                MessageBox.Show("Registration Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtadm.Text = string.Empty;
            txtstudentname.Text = string.Empty;
            cbostudentclass.SelectedIndex = -1;
            cbostudentform.SelectedIndex = -1;
            cbosemester.SelectedIndex = -1;
            txtcurrentyear.Text = String.Empty;
            cmbgender.SelectedIndex = -1;

            // Clear the checkboxes
            //sub4.Checked = false;
            //sub7.Checked = false;
            //sub8.Checked = false;
            //sub9.Checked = false;
            //sub11.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
