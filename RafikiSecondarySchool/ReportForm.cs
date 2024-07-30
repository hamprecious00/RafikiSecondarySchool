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

                // Use parameterized query to prevent SQL injection
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM View1 WHERE Admno = @Admno AND Term = @Term", conn);
                cmd.Parameters.AddWithValue("@Admno", txtadm.Text);
                cmd.Parameters.AddWithValue("@Term", cboterm.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer2.LocalReport.ReportPath = @"C:\Users\NURA\source\repos\RafikiSecondarySchool\RafikiSecondarySchool\Report1.rdlc";
                reportViewer2.LocalReport.DataSources.Clear();
                reportViewer2.LocalReport.DataSources.Add(rds);
                reportViewer2.RefreshReport();

                MessageBox.Show("Report Generated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed in the finally block
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
