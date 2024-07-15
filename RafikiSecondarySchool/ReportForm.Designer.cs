

namespace RafikiSecondarySchool
{
    partial class ReportForm
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
            this.label21 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtadm = new System.Windows.Forms.TextBox();
            this.btngenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            //this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 18.25F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(251, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(211, 35);
            this.label21.TabIndex = 11;
            this.label21.Text = "Generate Report";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.txtadm);
            this.panel1.Controls.Add(this.btngenerate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 99);
            this.panel1.TabIndex = 12;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Gray;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(644, 62);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(89, 29);
            this.btnexit.TabIndex = 16;
            this.btnexit.Text = "Exit";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtadm
            // 
            this.txtadm.Location = new System.Drawing.Point(125, 64);
            this.txtadm.Multiline = true;
            this.txtadm.Name = "txtadm";
            this.txtadm.Size = new System.Drawing.Size(100, 27);
            this.txtadm.TabIndex = 15;
            // 
            // btngenerate
            // 
            this.btngenerate.BackColor = System.Drawing.Color.Gray;
            this.btngenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngenerate.Location = new System.Drawing.Point(272, 62);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(89, 29);
            this.btngenerate.TabIndex = 14;
            this.btngenerate.Text = "Generate";
            this.btngenerate.UseVisualStyleBackColor = false;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(68, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "ADM:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportViewer1
            // 
            //this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            //this.reportViewer1.Name = "reportViewer1";
            //this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            //this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(12, 105);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(721, 551);
            this.reportViewer2.TabIndex = 13;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 705);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtadm;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.Label label1;
        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnexit;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}