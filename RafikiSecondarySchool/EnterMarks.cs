using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RafikiSecondarySchool
{
    public partial class EnterMarksForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");

        public EnterMarksForm()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            DashboardForm d = new DashboardForm();
            d.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnentermarks_Click(object sender, EventArgs e)
        {
            try
            {

                // Open the connection
                conn.Open();

                // Create the SQL command with parameters
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Exam]
                ([Adm]
                ,[Indexno]
                ,[Math]
                ,[Eng]
                ,[Kis]
                ,[Bio]
                ,[Chem]
                ,[Phy]
                ,[Geo]
                ,[Cre]
                ,[Hist]
                ,[Agrics]
                ,[Business]
                ,[Ict])
                VALUES
                (@Adm, @Indexno, @Math, @Eng, @Kis, @Bio, @Chem, @Phy, @Geo, @Cre, @Hist, @Agrics, @Business, @Ict)", conn);

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@Adm", txtadm.Text);
                cmd.Parameters.AddWithValue("@Indexno", txtindexno.Text);
                cmd.Parameters.AddWithValue("@Math", txtmath.Text);
                cmd.Parameters.AddWithValue("@Eng", txteng.Text);
                cmd.Parameters.AddWithValue("@Kis", txtkis.Text);
                cmd.Parameters.AddWithValue("@Bio", txtbio.Text);
                cmd.Parameters.AddWithValue("@Chem", txtchem.Text);
                cmd.Parameters.AddWithValue("@Phy", txtphy.Text);
                cmd.Parameters.AddWithValue("@Geo", txtgeo.Text);
                cmd.Parameters.AddWithValue("@Cre", txtcre.Text);
                cmd.Parameters.AddWithValue("@Hist", txthist.Text);
                cmd.Parameters.AddWithValue("@Agrics", txtagrics.Text);
                cmd.Parameters.AddWithValue("@Business", txtbs.Text);
                cmd.Parameters.AddWithValue("@Ict", txtict.Text);



           
                // Execute the command
                cmd.ExecuteNonQuery();

                // Close the connection
                conn.Close();

                MessageBox.Show("Marks Entered Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtadm.Text = string.Empty;
            txtindexno.Text = string.Empty;
            txtmath.Text = string.Empty;
            txtict.Text = string.Empty;
            txtbs.Text = string.Empty;
            txtagrics.Text = string.Empty;
            txthist.Text = string.Empty;
            txtcre.Text = string.Empty;
            txtgeo.Text = string.Empty;
            txtphy.Text = string.Empty;
            txtchem.Text = string.Empty;
            txtbio.Text = string.Empty;
            txtkis.Text = string.Empty;
            txteng.Text = string.Empty;
        }
    }
}
