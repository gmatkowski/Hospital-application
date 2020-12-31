using System.Drawing;
using System.Windows.Forms;

namespace HospitalApp.Views
{
    partial class AdminRegister
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
            this.username = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterAdminButton = new System.Windows.Forms.Button();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password_confirmation = new System.Windows.Forms.TextBox();
            this.username_error = new System.Windows.Forms.Label();
            this.first_name_error = new System.Windows.Forms.Label();
            this.last_name_error = new System.Windows.Forms.Label();
            this.password_error = new System.Windows.Forms.Label();
            this.password_confirmation_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(303, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 26);
            this.label1.TabIndex = 105;
            this.label1.Text = "Rejestracja administratora";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(307, 193);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(261, 20);
            this.username.TabIndex = 1;
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(307, 232);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(261, 20);
            this.first_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Nazwa użytkownika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Imię";
            // 
            // RegisterAdminButton
            // 
            this.RegisterAdminButton.BackColor = System.Drawing.Color.Teal;
            this.RegisterAdminButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RegisterAdminButton.FlatAppearance.BorderSize = 0;
            this.RegisterAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterAdminButton.ForeColor = System.Drawing.Color.White;
            this.RegisterAdminButton.Location = new System.Drawing.Point(307, 383);
            this.RegisterAdminButton.Name = "RegisterAdminButton";
            this.RegisterAdminButton.Size = new System.Drawing.Size(261, 23);
            this.RegisterAdminButton.TabIndex = 6;
            this.RegisterAdminButton.Text = "Zarejestruj";
            this.RegisterAdminButton.UseVisualStyleBackColor = true;
            this.RegisterAdminButton.Click += new System.EventHandler(this.RegisterAdminButton_Click);
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(307, 271);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(261, 20);
            this.last_name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Nazwisko";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Hasło";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(308, 310);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(261, 20);
            this.password.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 104;
            this.label5.Text = "Powtórz hasło";
            // 
            // password_confirmation
            // 
            this.password_confirmation.Location = new System.Drawing.Point(309, 350);
            this.password_confirmation.Name = "password_confirmation";
            this.password_confirmation.PasswordChar = '*';
            this.password_confirmation.Size = new System.Drawing.Size(261, 20);
            this.password_confirmation.TabIndex = 5;
            // 
            // username_error
            // 
            this.username_error.AutoSize = true;
            this.username_error.ForeColor = System.Drawing.Color.Red;
            this.username_error.Location = new System.Drawing.Point(575, 196);
            this.username_error.Name = "username_error";
            this.username_error.Size = new System.Drawing.Size(0, 13);
            this.username_error.TabIndex = 12;
            // 
            // first_name_error
            // 
            this.first_name_error.AutoSize = true;
            this.first_name_error.ForeColor = System.Drawing.Color.Red;
            this.first_name_error.Location = new System.Drawing.Point(575, 235);
            this.first_name_error.Name = "first_name_error";
            this.first_name_error.Size = new System.Drawing.Size(0, 13);
            this.first_name_error.TabIndex = 13;
            // 
            // last_name_error
            // 
            this.last_name_error.AutoSize = true;
            this.last_name_error.ForeColor = System.Drawing.Color.Red;
            this.last_name_error.Location = new System.Drawing.Point(575, 274);
            this.last_name_error.Name = "last_name_error";
            this.last_name_error.Size = new System.Drawing.Size(0, 13);
            this.last_name_error.TabIndex = 14;
            // 
            // password_error
            // 
            this.password_error.AutoSize = true;
            this.password_error.ForeColor = System.Drawing.Color.Red;
            this.password_error.Location = new System.Drawing.Point(575, 313);
            this.password_error.Name = "password_error";
            this.password_error.Size = new System.Drawing.Size(0, 13);
            this.password_error.TabIndex = 15;
            // 
            // password_confirmation_error
            // 
            this.password_confirmation_error.AutoSize = true;
            this.password_confirmation_error.ForeColor = System.Drawing.Color.Red;
            this.password_confirmation_error.Location = new System.Drawing.Point(575, 353);
            this.password_confirmation_error.Name = "password_confirmation_error";
            this.password_confirmation_error.Size = new System.Drawing.Size(0, 13);
            this.password_confirmation_error.TabIndex = 16;
            // 
            // AdminRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.password_confirmation_error);
            this.Controls.Add(this.password_error);
            this.Controls.Add(this.last_name_error);
            this.Controls.Add(this.first_name_error);
            this.Controls.Add(this.username_error);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password_confirmation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.RegisterAdminButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Name = "AdminRegister";
            this.Text = "Rejestracja administratora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RegisterAdminButton;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password_confirmation;
        private System.Windows.Forms.Label username_error;
        private System.Windows.Forms.Label first_name_error;
        private System.Windows.Forms.Label last_name_error;
        private System.Windows.Forms.Label password_error;
        private System.Windows.Forms.Label password_confirmation_error;
    }
}