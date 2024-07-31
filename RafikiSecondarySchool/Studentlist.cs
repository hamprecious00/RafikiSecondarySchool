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
    public partial class StudentlistForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4ROF1AO\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");

        public StudentlistForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){ }

        private void btnback_Click(object sender, EventArgs e)
        {
            DashboardForm d = new DashboardForm();
            d.Show();
            this.Hide();
        }

        private void StudentlistForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"Select * From View2", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                CustomizeDataGridView();


                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void CustomizeDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Navy,
                ForeColor = Color.White,
                Font = new Font("Verdana", 12, FontStyle.Bold)
            };
            dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;

            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.Black
            };
            dataGridView1.DefaultCellStyle = rowStyle;

            DataGridViewCellStyle alternateRowStyle = new DataGridViewCellStyle
            {
                BackColor = Color.LightGray
            };
            dataGridView1.AlternatingRowsDefaultCellStyle = alternateRowStyle;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void label4_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e){ }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){ }
    }
}
