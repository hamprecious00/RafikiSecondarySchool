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
using Microsoft.Reporting.WinForms;
using System.ComponentModel.Design;


namespace RafikiSecondarySchool
{
    public partial class ReportForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");


        public ReportForm()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * From View1 where Admno = '"+txtadm.Text+"'", conn);
                //cmd.Parameters.AddWithValue("@Admno", txtadm.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer2.LocalReport.ReportPath = @"C:\Users\NURA\source\repos\RafikiSecondarySchool\RafikiSecondarySchool\Report1.rdlc";
                reportViewer2.LocalReport.DataSources.Clear();
                reportViewer2.LocalReport.DataSources.Add(rds);
                reportViewer2.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DashboardForm d = new DashboardForm();
            d.Show();
            this.Hide();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }
    }
}
