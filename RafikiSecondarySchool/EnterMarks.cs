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
                ([Admno]
                ,[Indexno]
                ,[Form]
                ,[Term]
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
                ,[Ict]
                ,[Total]
                ,[Average]
                ,[Grade]
                ,[Compliment])
                VALUES
                (@Admno, @Indexno, @Form, @Term, @Math, @Eng, @Kis, @Bio, @Chem, @Phy, @Geo, @Cre, @Hist, @Agrics, @Business, @Ict, @Total, @average, @Grade, @Compliment)", conn);

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@Admno", txtadm.Text);
                cmd.Parameters.AddWithValue("@Indexno", txtindexno.Text);
                cmd.Parameters.AddWithValue("@Form", cboform.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Term", cboterm.SelectedItem.ToString());
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
                cmd.Parameters.AddWithValue("@Total", lbltotal.Text);
                cmd.Parameters.AddWithValue("@Average", lblavg.Text);
                cmd.Parameters.AddWithValue("@Grade", lblgrade.Text);
                cmd.Parameters.AddWithValue("@Compliment", lblcompliment.Text);


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
            cboform.SelectedIndex = -1;
            cboterm.SelectedIndex = -1;
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
            lblavg.Text = "0";
            lbltotal.Text = "0";
            lblgrade.Text = "...";
            lblcompliment.Text = "...";
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Double[] R = new Double[20];
                R[0] = Convert.ToDouble(txtmath.Text);
                R[1] = Convert.ToDouble(txtcre.Text);
                R[2] = Convert.ToDouble(txtbio.Text);
                R[3] = Convert.ToDouble(txtchem.Text);
                R[4] = Convert.ToDouble(txtphy.Text);
                R[5] = Convert.ToDouble(txtgeo.Text);
                R[6] = Convert.ToDouble(txthist.Text);
                R[7] = Convert.ToDouble(txtagrics.Text);
                R[8] = Convert.ToDouble(txtict.Text);
                R[9] = Convert.ToDouble(txtbs.Text);
                R[10] = Convert.ToDouble(txtkis.Text);
                R[11] = Convert.ToDouble(txteng.Text);

                R[12] = (int)((R[0] + R[1] + R[2] + R[3] + R[4] + R[5] + R[6] + R[7] + R[8] + R[9] + R[10] + R[11]) / 12);
                R[13] = R[0] + R[1] + R[2] + R[3] + R[4] + R[5] + R[6] + R[7] + R[8] + R[9] + R[10] + R[11];

                String average = Convert.ToString(R[12]);
                String total = Convert.ToString(R[13]);

                lblavg.Text = average;
                lbltotal.Text = total;

                if (R[12] >= 80)
                {
                    lblgrade.Text = "A";
                    lblcompliment.Text = "Excellent";
                }
                else if (R[12] >= 60 && R[12] < 80)
                {
                    lblgrade.Text = "B";
                    lblcompliment.Text = "Very Good";
                }
                else if (R[12] >= 50 && R[12] < 60)
                {
                    lblgrade.Text = "C";
                    lblcompliment.Text = "Good";
                }
                else if (R[12] >= 40 && R[12] < 50)
                {
                    lblgrade.Text = "D";
                    lblcompliment.Text = "Fair";
                }
                else if (R[12] < 40)
                {
                    lblgrade.Text = "E";
                    lblcompliment.Text = "Fail";
                }
                else
                {
                    //else statement
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
