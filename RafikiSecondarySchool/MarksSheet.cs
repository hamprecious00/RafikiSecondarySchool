﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RafikiSecondarySchool
{
    public partial class MarksSheetForm : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");

        public MarksSheetForm()
        {
            InitializeComponent();
        }

        private void MarksSheetForm_load(object sender, EventArgs e)
        {
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Select * From Views1", conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm d = new DashboardForm();
            d.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnselectdata_Click(object sender, EventArgs e)
        {
            try
            {
                //StudentForm = '" + cboform.Text + "'
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"Select * From View1 where StudentForm = '" + cboform.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void MarksSheetForm_Load_1(object sender, EventArgs e)
        {
           try
            {
                // TODO: This line of code loads data into the 'schoolDataSet2.View1' table. You can move, or remove it, as needed.
                //this.view1TableAdapter.Fill(this.schoolDataSet2.View1);
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"Select * From View1", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
