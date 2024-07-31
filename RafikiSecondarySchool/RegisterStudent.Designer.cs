
namespace RafikiSecondarySchool
{
    partial class RegisterStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtadm = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.txtcurrentyear = new System.Windows.Forms.TextBox();
            this.cbostudentclass = new System.Windows.Forms.ComboBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbostudentform = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADM Number";
            // 
            // txtadm
            // 
            this.txtadm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtadm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtadm.Location = new System.Drawing.Point(149, 6);
            this.txtadm.Multiline = true;
            this.txtadm.Name = "txtadm";
            this.txtadm.Size = new System.Drawing.Size(336, 32);
            this.txtadm.TabIndex = 1;
            this.txtadm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnregister.FlatAppearance.BorderSize = 0;
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnregister.Location = new System.Drawing.Point(12, 84);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(247, 58);
            this.btnregister.TabIndex = 2;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(32, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(32, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(35, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Student Class";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(26, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Student Name";
            // 
            // txtstudentname
            // 
            this.txtstudentname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstudentname.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtstudentname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtstudentname.Location = new System.Drawing.Point(149, 3);
            this.txtstudentname.Multiline = true;
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(336, 32);
            this.txtstudentname.TabIndex = 12;
            // 
            // btnback
            // 
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(738, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(67, 55);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "🔙";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnclear.Location = new System.Drawing.Point(12, 235);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(246, 58);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnnew.FlatAppearance.BorderSize = 0;
            this.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnnew.Location = new System.Drawing.Point(12, 157);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(247, 58);
            this.btnnew.TabIndex = 17;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // dateofbirth
            // 
            this.dateofbirth.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dateofbirth.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dateofbirth.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dateofbirth.CustomFormat = "dd-MM-yyyy";
            this.dateofbirth.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateofbirth.Location = new System.Drawing.Point(149, 11);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(336, 27);
            this.dateofbirth.TabIndex = 18;
            // 
            // txtcurrentyear
            // 
            this.txtcurrentyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcurrentyear.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtcurrentyear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtcurrentyear.Location = new System.Drawing.Point(149, 8);
            this.txtcurrentyear.Multiline = true;
            this.txtcurrentyear.Name = "txtcurrentyear";
            this.txtcurrentyear.Size = new System.Drawing.Size(336, 32);
            this.txtcurrentyear.TabIndex = 19;
            this.txtcurrentyear.TextChanged += new System.EventHandler(this.txtcurrentyear_TextChanged);
            // 
            // cbostudentclass
            // 
            this.cbostudentclass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbostudentclass.FormattingEnabled = true;
            this.cbostudentclass.Items.AddRange(new object[] {
            "E",
            "W",
            "N",
            "S"});
            this.cbostudentclass.Location = new System.Drawing.Point(149, 9);
            this.cbostudentclass.Name = "cbostudentclass";
            this.cbostudentclass.Size = new System.Drawing.Size(336, 29);
            this.cbostudentclass.TabIndex = 23;
            // 
            // cmbgender
            // 
            this.cmbgender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(149, 10);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(336, 29);
            this.cmbgender.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Location = new System.Drawing.Point(73, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Gender";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.btnregister);
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 531);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtadm);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(279, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 49);
            this.panel2.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.txtstudentname);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(279, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 49);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.cmbgender);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(279, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(507, 49);
            this.panel4.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(466, 49);
            this.panel5.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.Controls.Add(this.cbostudentclass);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(279, 294);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(507, 49);
            this.panel7.TabIndex = 30;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel8.Controls.Add(this.dateofbirth);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(279, 349);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(507, 49);
            this.panel8.TabIndex = 31;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.txtcurrentyear);
            this.panel9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(279, 400);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(507, 49);
            this.panel9.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(275, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Register New Student";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel10.Controls.Add(this.cbostudentform);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(279, 239);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(507, 49);
            this.panel10.TabIndex = 34;
            // 
            // cbostudentform
            // 
            this.cbostudentform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cbostudentform.FormattingEnabled = true;
            this.cbostudentform.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbostudentform.Location = new System.Drawing.Point(149, 7);
            this.cbostudentform.Name = "cbostudentform";
            this.cbostudentform.Size = new System.Drawing.Size(336, 29);
            this.cbostudentform.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(95, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Form";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtpassword);
            this.panel6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(279, 455);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(507, 49);
            this.panel6.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(61, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.txtpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtpassword.Location = new System.Drawing.Point(149, 8);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(336, 32);
            this.txtpassword.TabIndex = 19;
            // 
            // RegisterStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(817, 531);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnback);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterStudent";
            this.Load += new System.EventHandler(this.RegisterStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadm;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.DateTimePicker dateofbirth;
        private System.Windows.Forms.TextBox txtcurrentyear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.ComboBox cbostudentclass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cbostudentform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpassword;
    }
}