﻿namespace PatientManagement.Forms.DoctorForm
{
    partial class CheckUpList
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
            this.lsvCheckup = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvCheckup
            // 
            this.lsvCheckup.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCheckup.HideSelection = false;
            this.lsvCheckup.Location = new System.Drawing.Point(22, 97);
            this.lsvCheckup.Name = "lsvCheckup";
            this.lsvCheckup.Size = new System.Drawing.Size(1025, 486);
            this.lsvCheckup.TabIndex = 0;
            this.lsvCheckup.UseCompatibleStateImageBehavior = false;
            this.lsvCheckup.DoubleClick += new System.EventHandler(this.lsvCheckup_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient Check-up List";
            // 
            // CheckUpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvCheckup);
            this.Name = "CheckUpList";
            this.Text = "CheckUpList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvCheckup;
        private System.Windows.Forms.Label label1;
    }
}