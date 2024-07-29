using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace RafikiSecondarySchool
{
    public partial class MarksSheetForm : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True";

        public MarksSheetForm()
        {
            InitializeComponent();
        }

        private void MarksSheetForm_Load_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM View1", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtMarksSheet.DataSource = dt;

                    CustomizeDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnselectdata_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM View1 WHERE StudentForm = @StudentForm", conn);
                    cmd.Parameters.AddWithValue("@StudentForm", cboform.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtMarksSheet.DataSource = dt;

                    CustomizeDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void CustomizeDataGridView()
        {
            dtMarksSheet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Navy,
                ForeColor = Color.White,
                Font = new Font("Verdana", 8, FontStyle.Bold)
            };
            dtMarksSheet.ColumnHeadersDefaultCellStyle = headerStyle;

            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.Black
            };
            dtMarksSheet.DefaultCellStyle = rowStyle;

            DataGridViewCellStyle alternateRowStyle = new DataGridViewCellStyle
            {
                BackColor = Color.LightGray
            };
            dtMarksSheet.AlternatingRowsDefaultCellStyle = alternateRowStyle;

            dtMarksSheet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtMarksSheet.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashboardForm d = new DashboardForm();
            d.Show();
            this.Hide();
        }

        private void label22_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label21_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
