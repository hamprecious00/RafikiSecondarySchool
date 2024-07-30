
namespace RafikiSecondarySchool
{
    partial class MarksSheetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarksSheetForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnselectdata = new System.Windows.Forms.Button();
            this.cboform = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtMarksSheet = new System.Windows.Forms.DataGridView();
            this.admnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.histDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agricsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ictDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet3 = new RafikiSecondarySchool.SchoolDataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.view1TableAdapter = new RafikiSecondarySchool.SchoolDataSet3TableAdapters.View1TableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMarksSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnselectdata);
            this.panel1.Controls.Add(this.cboform);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 182);
            this.panel1.TabIndex = 0;
            // 
            // btnselectdata
            // 
            this.btnselectdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnselectdata.FlatAppearance.BorderSize = 0;
            this.btnselectdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselectdata.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselectdata.ForeColor = System.Drawing.Color.White;
            this.btnselectdata.Location = new System.Drawing.Point(214, 134);
            this.btnselectdata.Name = "btnselectdata";
            this.btnselectdata.Size = new System.Drawing.Size(118, 30);
            this.btnselectdata.TabIndex = 19;
            this.btnselectdata.Text = "SELECT DATA";
            this.btnselectdata.UseVisualStyleBackColor = false;
            this.btnselectdata.Click += new System.EventHandler(this.btnselectdata_Click);
            // 
            // cboform
            // 
            this.cboform.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.cboform.FormattingEnabled = true;
            this.cboform.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboform.Location = new System.Drawing.Point(87, 134);
            this.cboform.Name = "cboform";
            this.cboform.Size = new System.Drawing.Size(121, 29);
            this.cboform.TabIndex = 14;
            this.cboform.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "FORM";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(3, 169);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1258, 10);
            this.panel4.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1058, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Gabriola", 18.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label19.Location = new System.Drawing.Point(543, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(194, 46);
            this.label19.TabIndex = 11;
            this.label19.Text = "Motto: Hadi Kileleni";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 18.25F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(483, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(325, 35);
            this.label21.TabIndex = 10;
            this.label21.Text = "P.O.BOX 581-30200 KITALE";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(431, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(430, 41);
            this.label22.TabIndex = 9;
            this.label22.Text = "RAFIKI SECONDARY SCHOOL";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.dtMarksSheet);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 458);
            this.panel2.TabIndex = 1;
            // 
            // dtMarksSheet
            // 
            this.dtMarksSheet.AutoGenerateColumns = false;
            this.dtMarksSheet.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtMarksSheet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtMarksSheet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtMarksSheet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtMarksSheet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtMarksSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMarksSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admnoDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentFormDataGridViewTextBoxColumn,
            this.studentClassDataGridViewTextBoxColumn,
            this.indexnoDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.mathDataGridViewTextBoxColumn,
            this.engDataGridViewTextBoxColumn,
            this.kisDataGridViewTextBoxColumn,
            this.bioDataGridViewTextBoxColumn,
            this.chemDataGridViewTextBoxColumn,
            this.phyDataGridViewTextBoxColumn,
            this.geoDataGridViewTextBoxColumn,
            this.creDataGridViewTextBoxColumn,
            this.histDataGridViewTextBoxColumn,
            this.agricsDataGridViewTextBoxColumn,
            this.businessDataGridViewTextBoxColumn,
            this.ictDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.averageDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.complimentDataGridViewTextBoxColumn});
            this.dtMarksSheet.DataSource = this.view1BindingSource;
            this.dtMarksSheet.Location = new System.Drawing.Point(3, 3);
            this.dtMarksSheet.Name = "dtMarksSheet";
            this.dtMarksSheet.RowHeadersVisible = false;
            this.dtMarksSheet.Size = new System.Drawing.Size(1255, 412);
            this.dtMarksSheet.TabIndex = 6;
            // 
            // admnoDataGridViewTextBoxColumn
            // 
            this.admnoDataGridViewTextBoxColumn.DataPropertyName = "Admno";
            this.admnoDataGridViewTextBoxColumn.HeaderText = "Adm";
            this.admnoDataGridViewTextBoxColumn.Name = "admnoDataGridViewTextBoxColumn";
            this.admnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.admnoDataGridViewTextBoxColumn.Width = 50;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // studentFormDataGridViewTextBoxColumn
            // 
            this.studentFormDataGridViewTextBoxColumn.DataPropertyName = "StudentForm";
            this.studentFormDataGridViewTextBoxColumn.HeaderText = "Form";
            this.studentFormDataGridViewTextBoxColumn.Name = "studentFormDataGridViewTextBoxColumn";
            this.studentFormDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentFormDataGridViewTextBoxColumn.Width = 50;
            // 
            // studentClassDataGridViewTextBoxColumn
            // 
            this.studentClassDataGridViewTextBoxColumn.DataPropertyName = "StudentClass";
            this.studentClassDataGridViewTextBoxColumn.HeaderText = "Class";
            this.studentClassDataGridViewTextBoxColumn.Name = "studentClassDataGridViewTextBoxColumn";
            this.studentClassDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentClassDataGridViewTextBoxColumn.Width = 50;
            // 
            // indexnoDataGridViewTextBoxColumn
            // 
            this.indexnoDataGridViewTextBoxColumn.DataPropertyName = "Indexno";
            this.indexnoDataGridViewTextBoxColumn.HeaderText = "Index";
            this.indexnoDataGridViewTextBoxColumn.Name = "indexnoDataGridViewTextBoxColumn";
            this.indexnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.indexnoDataGridViewTextBoxColumn.Width = 50;
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "Term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Term";
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.ReadOnly = true;
            this.termDataGridViewTextBoxColumn.Width = 45;
            // 
            // mathDataGridViewTextBoxColumn
            // 
            this.mathDataGridViewTextBoxColumn.DataPropertyName = "Math";
            this.mathDataGridViewTextBoxColumn.HeaderText = "Math";
            this.mathDataGridViewTextBoxColumn.Name = "mathDataGridViewTextBoxColumn";
            this.mathDataGridViewTextBoxColumn.ReadOnly = true;
            this.mathDataGridViewTextBoxColumn.Width = 50;
            // 
            // engDataGridViewTextBoxColumn
            // 
            this.engDataGridViewTextBoxColumn.DataPropertyName = "Eng";
            this.engDataGridViewTextBoxColumn.HeaderText = "Eng";
            this.engDataGridViewTextBoxColumn.Name = "engDataGridViewTextBoxColumn";
            this.engDataGridViewTextBoxColumn.ReadOnly = true;
            this.engDataGridViewTextBoxColumn.Width = 45;
            // 
            // kisDataGridViewTextBoxColumn
            // 
            this.kisDataGridViewTextBoxColumn.DataPropertyName = "Kis";
            this.kisDataGridViewTextBoxColumn.HeaderText = "Kis";
            this.kisDataGridViewTextBoxColumn.Name = "kisDataGridViewTextBoxColumn";
            this.kisDataGridViewTextBoxColumn.ReadOnly = true;
            this.kisDataGridViewTextBoxColumn.Width = 45;
            // 
            // bioDataGridViewTextBoxColumn
            // 
            this.bioDataGridViewTextBoxColumn.DataPropertyName = "Bio";
            this.bioDataGridViewTextBoxColumn.HeaderText = "Bio";
            this.bioDataGridViewTextBoxColumn.Name = "bioDataGridViewTextBoxColumn";
            this.bioDataGridViewTextBoxColumn.ReadOnly = true;
            this.bioDataGridViewTextBoxColumn.Width = 40;
            // 
            // chemDataGridViewTextBoxColumn
            // 
            this.chemDataGridViewTextBoxColumn.DataPropertyName = "Chem";
            this.chemDataGridViewTextBoxColumn.HeaderText = "Chem";
            this.chemDataGridViewTextBoxColumn.Name = "chemDataGridViewTextBoxColumn";
            this.chemDataGridViewTextBoxColumn.ReadOnly = true;
            this.chemDataGridViewTextBoxColumn.Width = 50;
            // 
            // phyDataGridViewTextBoxColumn
            // 
            this.phyDataGridViewTextBoxColumn.DataPropertyName = "Phy";
            this.phyDataGridViewTextBoxColumn.HeaderText = "Phy";
            this.phyDataGridViewTextBoxColumn.Name = "phyDataGridViewTextBoxColumn";
            this.phyDataGridViewTextBoxColumn.ReadOnly = true;
            this.phyDataGridViewTextBoxColumn.Width = 45;
            // 
            // geoDataGridViewTextBoxColumn
            // 
            this.geoDataGridViewTextBoxColumn.DataPropertyName = "Geo";
            this.geoDataGridViewTextBoxColumn.HeaderText = "Geo";
            this.geoDataGridViewTextBoxColumn.Name = "geoDataGridViewTextBoxColumn";
            this.geoDataGridViewTextBoxColumn.ReadOnly = true;
            this.geoDataGridViewTextBoxColumn.Width = 40;
            // 
            // creDataGridViewTextBoxColumn
            // 
            this.creDataGridViewTextBoxColumn.DataPropertyName = "Cre";
            this.creDataGridViewTextBoxColumn.HeaderText = "Cre";
            this.creDataGridViewTextBoxColumn.Name = "creDataGridViewTextBoxColumn";
            this.creDataGridViewTextBoxColumn.ReadOnly = true;
            this.creDataGridViewTextBoxColumn.Width = 40;
            // 
            // histDataGridViewTextBoxColumn
            // 
            this.histDataGridViewTextBoxColumn.DataPropertyName = "Hist";
            this.histDataGridViewTextBoxColumn.HeaderText = "Hist";
            this.histDataGridViewTextBoxColumn.Name = "histDataGridViewTextBoxColumn";
            this.histDataGridViewTextBoxColumn.ReadOnly = true;
            this.histDataGridViewTextBoxColumn.Width = 45;
            // 
            // agricsDataGridViewTextBoxColumn
            // 
            this.agricsDataGridViewTextBoxColumn.DataPropertyName = "Agrics";
            this.agricsDataGridViewTextBoxColumn.HeaderText = "Agrics";
            this.agricsDataGridViewTextBoxColumn.Name = "agricsDataGridViewTextBoxColumn";
            this.agricsDataGridViewTextBoxColumn.ReadOnly = true;
            this.agricsDataGridViewTextBoxColumn.Width = 50;
            // 
            // businessDataGridViewTextBoxColumn
            // 
            this.businessDataGridViewTextBoxColumn.DataPropertyName = "Business";
            this.businessDataGridViewTextBoxColumn.HeaderText = "B/S";
            this.businessDataGridViewTextBoxColumn.Name = "businessDataGridViewTextBoxColumn";
            this.businessDataGridViewTextBoxColumn.ReadOnly = true;
            this.businessDataGridViewTextBoxColumn.Width = 40;
            // 
            // ictDataGridViewTextBoxColumn
            // 
            this.ictDataGridViewTextBoxColumn.DataPropertyName = "Ict";
            this.ictDataGridViewTextBoxColumn.HeaderText = "Ict";
            this.ictDataGridViewTextBoxColumn.Name = "ictDataGridViewTextBoxColumn";
            this.ictDataGridViewTextBoxColumn.ReadOnly = true;
            this.ictDataGridViewTextBoxColumn.Width = 40;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 50;
            // 
            // averageDataGridViewTextBoxColumn
            // 
            this.averageDataGridViewTextBoxColumn.DataPropertyName = "Average";
            this.averageDataGridViewTextBoxColumn.HeaderText = "Avg";
            this.averageDataGridViewTextBoxColumn.Name = "averageDataGridViewTextBoxColumn";
            this.averageDataGridViewTextBoxColumn.ReadOnly = true;
            this.averageDataGridViewTextBoxColumn.Width = 45;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            this.gradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradeDataGridViewTextBoxColumn.Width = 50;
            // 
            // complimentDataGridViewTextBoxColumn
            // 
            this.complimentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.complimentDataGridViewTextBoxColumn.DataPropertyName = "Compliment";
            this.complimentDataGridViewTextBoxColumn.HeaderText = "Compliment";
            this.complimentDataGridViewTextBoxColumn.Name = "complimentDataGridViewTextBoxColumn";
            this.complimentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View1";
            this.view1BindingSource.DataSource = this.schoolDataSet3;
            // 
            // schoolDataSet3
            // 
            this.schoolDataSet3.DataSetName = "SchoolDataSet3";
            this.schoolDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1183, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view1TableAdapter
            // 
            this.view1TableAdapter.ClearBeforeFill = true;
            // 
            // MarksSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1261, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MarksSheetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarksSheet";
            this.Load += new System.EventHandler(this.MarksSheetForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtMarksSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnselectdata;
        private SchoolDataSet3 schoolDataSet3;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private SchoolDataSet3TableAdapters.View1TableAdapter view1TableAdapter;
        private System.Windows.Forms.DataGridView dtMarksSheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn admnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFormDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn histDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agricsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ictDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complimentDataGridViewTextBoxColumn;
    }
}