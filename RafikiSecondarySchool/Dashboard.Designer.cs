
namespace RafikiSecondarySchool
{
    partial class DashboardForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnview = new System.Windows.Forms.Button();
            this.btnreportcard = new System.Windows.Forms.Button();
            this.btnmarkssheet = new System.Windows.Forms.Button();
            this.btnmarksentry = new System.Windows.Forms.Button();
            this.btnaddstudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(938, 528);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 30);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.btnview);
            this.groupBox1.Controls.Add(this.btnreportcard);
            this.groupBox1.Controls.Add(this.btnmarkssheet);
            this.groupBox1.Controls.Add(this.btnmarksentry);
            this.groupBox1.Controls.Add(this.btnaddstudent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 409);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(29, 330);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(223, 49);
            this.btnview.TabIndex = 6;
            this.btnview.Text = "View Students";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnreportcard
            // 
            this.btnreportcard.Location = new System.Drawing.Point(29, 260);
            this.btnreportcard.Name = "btnreportcard";
            this.btnreportcard.Size = new System.Drawing.Size(223, 49);
            this.btnreportcard.TabIndex = 2;
            this.btnreportcard.Text = "Report Cards";
            this.btnreportcard.UseVisualStyleBackColor = true;
            this.btnreportcard.Click += new System.EventHandler(this.btnreportcard_Click);
            // 
            // btnmarkssheet
            // 
            this.btnmarkssheet.AutoSize = true;
            this.btnmarkssheet.Location = new System.Drawing.Point(29, 192);
            this.btnmarkssheet.Name = "btnmarkssheet";
            this.btnmarkssheet.Size = new System.Drawing.Size(223, 49);
            this.btnmarkssheet.TabIndex = 3;
            this.btnmarkssheet.Text = "Marks Sheet";
            this.btnmarkssheet.UseVisualStyleBackColor = true;
            this.btnmarkssheet.Click += new System.EventHandler(this.btnmarkssheet_Click);
            // 
            // btnmarksentry
            // 
            this.btnmarksentry.Location = new System.Drawing.Point(29, 122);
            this.btnmarksentry.Name = "btnmarksentry";
            this.btnmarksentry.Size = new System.Drawing.Size(223, 49);
            this.btnmarksentry.TabIndex = 4;
            this.btnmarksentry.Text = "Marks Entry";
            this.btnmarksentry.UseVisualStyleBackColor = true;
            this.btnmarksentry.Click += new System.EventHandler(this.btnmarksentry_Click);
            // 
            // btnaddstudent
            // 
            this.btnaddstudent.Location = new System.Drawing.Point(29, 58);
            this.btnaddstudent.Name = "btnaddstudent";
            this.btnaddstudent.Size = new System.Drawing.Size(223, 49);
            this.btnaddstudent.TabIndex = 5;
            this.btnaddstudent.Text = "Register Students";
            this.btnaddstudent.UseVisualStyleBackColor = true;
            this.btnaddstudent.Click += new System.EventHandler(this.btnaddstudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "User";
            // 
            // txtuser
            // 
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(202, 496);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(80, 29);
            this.txtuser.TabIndex = 4;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 570);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnreportcard;
        private System.Windows.Forms.Button btnmarkssheet;
        private System.Windows.Forms.Button btnmarksentry;
        private System.Windows.Forms.Button btnaddstudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btnview;
    }
}