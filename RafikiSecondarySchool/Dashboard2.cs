using System;
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
    public partial class Dashboard2Form : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");


        public Dashboard2Form(string username)
        {
            InitializeComponent();
            //this.username = username;
            lblAdmno.Text = username;
            //LoadStudentDetails();
        }

        private void Dashboard2Form_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE Admno = @Admno", conn);
                cmd.Parameters.AddWithValue("@Admno", lblAdmno.Text);

                // Execute the command and retrieve the name
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblName.Text = reader["StudentName"].ToString();
                    lblClass.Text = reader["StudentForm"].ToString();
                    lblstream.Text = reader["StudentClass"].ToString();
                    //txtterm.Text = reader["Semester"].ToString();
                }
                else
                {
                    lblName.Text = "Record not found";
                    lblClass.Text = "0";
                    //txtterm.Text = "0";
                }

                // Close the reader and the connection
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcomplain.Text = string.Empty;
        }

        private void lblmath_Click(object sender, EventArgs e){ }

        private void btnterm1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True")
)
                {
                    // Open the connection
                    conn.Open();

                    // Create the SQL command
                    SqlCommand cmd = new SqlCommand(
                       "SELECT Admno, StudentName, StudentForm, StudentClass, Math, Eng, Kis, Bio, Chem, Phy, Geo, Cre, Hist, Agrics, Business, Ict, Total, Average, Grade, Term, Compliment " +
                       "FROM View1 WHERE Admno = @Admno AND Term = @Term1", conn);

                    // Add the parameters to the command
                    cmd.Parameters.AddWithValue("@Admno", lblAdmno.Text);
                    cmd.Parameters.AddWithValue("@Term1", "Term1"); 

                    // Execute the command and retrieve the data
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblmath.Text = reader["Math"].ToString();
                        lbleng.Text = reader["Eng"].ToString();
                        lblkis.Text = reader["Kis"].ToString();
                        lblchem.Text = reader["Chem"].ToString();
                        lblbio.Text = reader["Bio"].ToString();
                        lblphy.Text = reader["Phy"].ToString();
                        lblcre.Text = reader["Cre"].ToString();
                        lblgeo.Text = reader["Geo"].ToString();
                        lblhist.Text = reader["Hist"].ToString();
                        lblagrics.Text = reader["Agrics"].ToString();
                        lblbusiness.Text = reader["Business"].ToString();
                        lblict.Text = reader["Ict"].ToString();
                        lbltotal.Text = reader["Total"].ToString();
                        lblaverage.Text = reader["Average"].ToString();
                        lblgrade.Text = reader["Grade"].ToString();
                        lblcompliment.Text = reader["Compliment"].ToString();

                    }
                    else
                    {
                        lblnotfound.Text = "Records not found!!!";
                        lblmath.Text = string.Empty;
                        lbleng.Text = string.Empty;
                        lblkis.Text = string.Empty;
                        lblchem.Text = string.Empty;
                        lblbio.Text = string.Empty;
                        lblphy.Text = string.Empty;
                        lblcre.Text = string.Empty;
                        lblgeo.Text = string.Empty;
                        lblhist.Text = string.Empty;
                        lblagrics.Text = string.Empty;
                        lblbusiness.Text = string.Empty;
                        lblict.Text = string.Empty;
                        lbltotal.Text = string.Empty;
                        lblaverage.Text = string.Empty;
                        lblgrade.Text = string.Empty;
                        lblcompliment.Text = string.Empty;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void btnterm2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True")
)
                {
                    // Open the connection
                    conn.Open();

                    // Create the SQL command
                    SqlCommand cmd = new SqlCommand(
                       "SELECT Admno, StudentName, StudentForm, StudentClass, Math, Eng, Kis, Bio, Chem, Phy, Geo, Cre, Hist, Agrics, Business, Ict, Total, Average, Grade, Term, Compliment " +
                       "FROM View1 WHERE Admno = @Admno AND Term = @Term2", conn);

                    // Add the parameters to the command
                    cmd.Parameters.AddWithValue("@Admno", lblAdmno.Text);
                    cmd.Parameters.AddWithValue("@Term2", "Term2"); 

                    // Execute the command and retrieve the data
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblmath.Text = reader["Math"].ToString();
                        lbleng.Text = reader["Eng"].ToString();
                        lblkis.Text = reader["Kis"].ToString();
                        lblchem.Text = reader["Chem"].ToString();
                        lblbio.Text = reader["Bio"].ToString();
                        lblphy.Text = reader["Phy"].ToString();
                        lblcre.Text = reader["Cre"].ToString();
                        lblgeo.Text = reader["Geo"].ToString();
                        lblhist.Text = reader["Hist"].ToString();
                        lblagrics.Text = reader["Agrics"].ToString();
                        lblbusiness.Text = reader["Business"].ToString();
                        lblict.Text = reader["Ict"].ToString();
                        lbltotal.Text = reader["Total"].ToString();
                        lblaverage.Text = reader["Average"].ToString();
                        lblgrade.Text = reader["Grade"].ToString();
                        lblcompliment.Text = reader["Compliment"].ToString();

                        
                    }
                    else
                    {
                        lblnotfound.Text = "Records not found!!!";
                        lblmath.Text = string.Empty;
                        lbleng.Text = string.Empty;
                        lblkis.Text = string.Empty;
                        lblchem.Text = string.Empty;
                        lblbio.Text = string.Empty;
                        lblphy.Text = string.Empty;
                        lblcre.Text = string.Empty;
                        lblgeo.Text = string.Empty;
                        lblhist.Text = string.Empty;
                        lblagrics.Text = string.Empty;
                        lblbusiness.Text = string.Empty;
                        lblict.Text = string.Empty;
                        lbltotal.Text = string.Empty;
                        lblaverage.Text = string.Empty;
                        lblgrade.Text = string.Empty;
                        lblcompliment.Text = string.Empty;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnterm3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True")
)
                {
                    // Open the connection
                    conn.Open();

                    // Create the SQL command
                    SqlCommand cmd = new SqlCommand(
                       "SELECT Admno, StudentName, StudentForm, StudentClass, Math, Eng, Kis, Bio, Chem, Phy, Geo, Cre, Hist, Agrics, Business, Ict, Total, Average, Grade, Term, Compliment " +
                       "FROM View1 WHERE Admno = @Admno AND Term = @Term3", conn);

                    // Add the parameters to the command
                    cmd.Parameters.AddWithValue("@Admno", lblAdmno.Text);
                    cmd.Parameters.AddWithValue("@Term3", "Term3"); // Ensure this matches the term you want to filter by

                    // Execute the command and retrieve the data
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblmath.Text = reader["Math"].ToString();
                        lbleng.Text = reader["Eng"].ToString();
                        lblkis.Text = reader["Kis"].ToString();
                        lblchem.Text = reader["Chem"].ToString();
                        lblbio.Text = reader["Bio"].ToString();
                        lblphy.Text = reader["Phy"].ToString();
                        lblcre.Text = reader["Cre"].ToString();
                        lblgeo.Text = reader["Geo"].ToString();
                        lblhist.Text = reader["Hist"].ToString();
                        lblagrics.Text = reader["Agrics"].ToString();
                        lblbusiness.Text = reader["Business"].ToString();
                        lblict.Text = reader["Ict"].ToString();
                        lbltotal.Text = reader["Total"].ToString();
                        lblaverage.Text = reader["Average"].ToString();
                        lblgrade.Text = reader["Grade"].ToString();
                        lblcompliment.Text = reader["Compliment"].ToString();

                    }
                    else
                    {
                        lblnotfound.Text = "Records not found!!!";
                        lblmath.Text = string.Empty;
                        lbleng.Text = string.Empty;
                        lblkis.Text = string.Empty;
                        lblchem.Text = string.Empty;
                        lblbio.Text = string.Empty;
                        lblphy.Text = string.Empty;
                        lblcre.Text = string.Empty;
                        lblgeo.Text = string.Empty;
                        lblhist.Text = string.Empty;
                        lblagrics.Text = string.Empty;
                        lblbusiness.Text = string.Empty;
                        lblict.Text = string.Empty;
                        lbltotal.Text = string.Empty;
                        lblaverage.Text = string.Empty;
                        lblgrade.Text = string.Empty;
                        lblcompliment.Text = string.Empty;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {

                // Open the connection
                conn.Open();

                // Create the SQL command with parameters
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Complains]
                ([Date]
                ,[Complaint]
                ,[Name])
                VALUES
                (@Date, @Complaint, @Name)", conn);

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@Date", date.Text);
                cmd.Parameters.AddWithValue("@Complaint", txtcomplain.Text);
                cmd.Parameters.AddWithValue("@Name", lblName.Text);


                // Execute the command
                cmd.ExecuteNonQuery();

                // Close the connection
                conn.Close();

                MessageBox.Show("Complaint Submited Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
