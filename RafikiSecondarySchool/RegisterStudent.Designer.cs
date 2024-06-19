
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstudentform = new System.Windows.Forms.TextBox();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtstudentclass = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.txtcurrentyear = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADM Number";
            // 
            // txtadm
            // 
            this.txtadm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadm.Location = new System.Drawing.Point(124, 21);
            this.txtadm.Multiline = true;
            this.txtadm.Name = "txtadm";
            this.txtadm.Size = new System.Drawing.Size(248, 32);
            this.txtadm.TabIndex = 1;
            this.txtadm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(500, 59);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(147, 55);
            this.btnregister.TabIndex = 2;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Student Class";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = " Student Form";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Student Name";
            // 
            // txtstudentform
            // 
            this.txtstudentform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstudentform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentform.Location = new System.Drawing.Point(124, 150);
            this.txtstudentform.Multiline = true;
            this.txtstudentform.Name = "txtstudentform";
            this.txtstudentform.Size = new System.Drawing.Size(248, 32);
            this.txtstudentform.TabIndex = 11;
            // 
            // txtstudentname
            // 
            this.txtstudentname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentname.Location = new System.Drawing.Point(124, 59);
            this.txtstudentname.Multiline = true;
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(248, 32);
            this.txtstudentname.TabIndex = 12;
            // 
            // txtstudentclass
            // 
            this.txtstudentclass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstudentclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentclass.Location = new System.Drawing.Point(124, 188);
            this.txtstudentclass.Multiline = true;
            this.txtstudentclass.Name = "txtstudentclass";
            this.txtstudentclass.Size = new System.Drawing.Size(248, 32);
            this.txtstudentclass.TabIndex = 13;
            // 
            // txtsemester
            // 
            this.txtsemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsemester.Location = new System.Drawing.Point(124, 306);
            this.txtsemester.Multiline = true;
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(248, 32);
            this.txtsemester.TabIndex = 14;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(572, 401);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(500, 209);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(147, 55);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(500, 133);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(147, 55);
            this.btnnew.TabIndex = 17;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            // 
            // dateofbirth
            // 
            this.dateofbirth.CustomFormat = "dd-MM-yyyy";
            this.dateofbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateofbirth.Location = new System.Drawing.Point(124, 229);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(248, 20);
            this.dateofbirth.TabIndex = 18;
            // 
            // txtcurrentyear
            // 
            this.txtcurrentyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcurrentyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurrentyear.Location = new System.Drawing.Point(124, 268);
            this.txtcurrentyear.Multiline = true;
            this.txtcurrentyear.Name = "txtcurrentyear";
            this.txtcurrentyear.Size = new System.Drawing.Size(248, 32);
            this.txtcurrentyear.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.cmbgender);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtadm);
            this.groupBox1.Controls.Add(this.txtstudentname);
            this.groupBox1.Controls.Add(this.txtcurrentyear);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateofbirth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtstudentform);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsemester);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtstudentclass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 352);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(124, 108);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(248, 24);
            this.cmbgender.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Gender";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // RegisterStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterStudent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadm;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtstudentform;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtstudentclass;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.DateTimePicker dateofbirth;
        private System.Windows.Forms.TextBox txtcurrentyear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbgender;
    }
}