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
            this.users_table = new System.Windows.Forms.DataGridView();
            this.adduser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.users_table)).BeginInit();
            this.SuspendLayout();
            // 
            // users_table
            // 
            this.users_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.users_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_table.Location = new System.Drawing.Point(12, 83);
            this.users_table.MultiSelect = false;
            this.users_table.Name = "users_table";
            this.users_table.ReadOnly = true;
            this.users_table.Size = new System.Drawing.Size(860, 466);
            this.users_table.TabIndex = 3;
            // 
            // adduser
            // 
            this.adduser.BackColor = System.Drawing.Color.Teal;
            this.adduser.FlatAppearance.BorderSize = 0;
            this.adduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adduser.ForeColor = System.Drawing.Color.White;
            this.adduser.Location = new System.Drawing.Point(12, 38);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(108, 23);
            this.adduser.TabIndex = 4;
            this.adduser.Text = "Dodaj użytkownika";
            this.adduser.UseVisualStyleBackColor = false;
            this.adduser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.adduser);
            this.Controls.Add(this.users_table);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.users_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView users_table;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn specialization;
        private DataGridViewButtonColumn shifts;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
        private Button adduser;
    }
}