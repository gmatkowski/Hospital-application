using HospitalApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Controls
{
    class LoggedControl : UserControl
    {
        private Form form;
        private Button logout;
        private Label logged_as;
        private Label logged_as_label;

        public LoggedControl(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        // Initialize the control elements.
        public void InitializeComponent()
        {
            this.logout = new System.Windows.Forms.Button();
            this.logged_as = new System.Windows.Forms.Label();
            this.logged_as_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Gray;
            this.logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(365, 30);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 0;
            this.logout.Text = "Wyloguj się";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // logged_as
            // 
            this.logged_as.AutoSize = true;
            this.logged_as.Dock = System.Windows.Forms.DockStyle.Right;
            this.logged_as.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logged_as.ForeColor = System.Drawing.Color.DimGray;
            this.logged_as.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logged_as.Location = new System.Drawing.Point(358, 0);
            this.logged_as.Margin = new System.Windows.Forms.Padding(0);
            this.logged_as.Name = "logged_as";
            this.logged_as.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.logged_as.Size = new System.Drawing.Size(85, 27);
            this.logged_as.TabIndex = 1;
            this.logged_as.Text = Program.AuthenticatedUser.full_name;
            this.logged_as.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logged_as_label
            // 
            this.logged_as_label.AutoSize = true;
            this.logged_as_label.Dock = System.Windows.Forms.DockStyle.Right;
            this.logged_as_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logged_as_label.Location = new System.Drawing.Point(239, 0);
            this.logged_as_label.Margin = new System.Windows.Forms.Padding(0);
            this.logged_as_label.Name = "logged_as_label";
            this.logged_as_label.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.logged_as_label.Size = new System.Drawing.Size(119, 27);
            this.logged_as_label.TabIndex = 2;
            this.logged_as_label.Text = "Zalogowano jako:";
            // 
            // LoggedControl
            // 
            this.AutoSize = true;
            this.Controls.Add(this.logout);
            this.Controls.Add(this.logged_as_label);
            this.Controls.Add(this.logged_as);
            this.Name = "LoggedControl";
            this.Size = new System.Drawing.Size(443, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Program.Logout();
            Redirect.GoToLogin(this.form);
        }
    }
}
