using System.Drawing;
using System.Windows.Forms;

namespace HospitalApp.Views
{
    partial class Login
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.username_error = new System.Windows.Forms.Label();
            this.password_error = new System.Windows.Forms.Label();
            this.failed_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(335, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logowanie do systemu";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(340, 196);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(230, 20);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(340, 239);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(230, 20);
            this.password.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwa użytkownika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasło";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Teal;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(340, 266);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(230, 24);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Zaloguj się";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // username_error
            // 
            this.username_error.AutoSize = true;
            this.username_error.ForeColor = System.Drawing.Color.Red;
            this.username_error.Location = new System.Drawing.Point(577, 200);
            this.username_error.Name = "username_error";
            this.username_error.Size = new System.Drawing.Size(0, 13);
            this.username_error.TabIndex = 6;
            // 
            // password_error
            // 
            this.password_error.AutoSize = true;
            this.password_error.ForeColor = System.Drawing.Color.Red;
            this.password_error.Location = new System.Drawing.Point(576, 242);
            this.password_error.Name = "password_error";
            this.password_error.Size = new System.Drawing.Size(0, 13);
            this.password_error.TabIndex = 7;
            // 
            // failed_error
            // 
            this.failed_error.AutoSize = true;
            this.failed_error.ForeColor = System.Drawing.Color.Red;
            this.failed_error.Location = new System.Drawing.Point(341, 293);
            this.failed_error.Name = "failed_error";
            this.failed_error.Size = new System.Drawing.Size(0, 13);
            this.failed_error.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.failed_error);
            this.Controls.Add(this.password_error);
            this.Controls.Add(this.username_error);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label username_error;
        private System.Windows.Forms.Label password_error;
        private System.Windows.Forms.Label failed_error;
    }
}

