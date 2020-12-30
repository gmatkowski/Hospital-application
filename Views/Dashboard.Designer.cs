using System.Drawing;
using System.Windows.Forms;

namespace HospitalApp.Views
{
    partial class Dashboard
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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(900, 600);
            this.MaximumSize = new Size(900, 600);

            this.logout = new System.Windows.Forms.Button();
            this.logged_as = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Teal;
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(797, 38);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 0;
            this.logout.Text = "Wyloguj się";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // logged_as
            // 
            this.logged_as.AutoSize = true;
            this.logged_as.Dock = System.Windows.Forms.DockStyle.Right;
            this.logged_as.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logged_as.ForeColor = System.Drawing.Color.DimGray;
            this.logged_as.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logged_as.Location = new System.Drawing.Point(799, 0);
            this.logged_as.Margin = new System.Windows.Forms.Padding(0);
            this.logged_as.Name = "logged_as";
            this.logged_as.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.logged_as.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logged_as.Size = new System.Drawing.Size(85, 27);
            this.logged_as.TabIndex = 1;
            this.logged_as.Text = "gmatkowski";
            this.logged_as.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(680, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(119, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = ":Zalogowano jako";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logged_as);
            this.Controls.Add(this.logout);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label logged_as;
        private System.Windows.Forms.Label label1;
    }
}