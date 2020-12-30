namespace HospitalApp.Views
{
    partial class UserForm
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
            this.password_confirmation_error = new System.Windows.Forms.Label();
            this.password_error = new System.Windows.Forms.Label();
            this.last_name_error = new System.Windows.Forms.Label();
            this.first_name_error = new System.Windows.Forms.Label();
            this.username_error = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.password_confirmation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pwz_label = new System.Windows.Forms.Label();
            this.pwz = new System.Windows.Forms.TextBox();
            this.pesel_label = new System.Windows.Forms.Label();
            this.pesel = new System.Windows.Forms.TextBox();
            this.specialization_label = new System.Windows.Forms.Label();
            this.specialization = new System.Windows.Forms.ComboBox();
            this.pesel_error = new System.Windows.Forms.Label();
            this.pwz_error = new System.Windows.Forms.Label();
            this.specialization_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password_confirmation_error
            // 
            this.password_confirmation_error.AutoSize = true;
            this.password_confirmation_error.ForeColor = System.Drawing.Color.Red;
            this.password_confirmation_error.Location = new System.Drawing.Point(535, 328);
            this.password_confirmation_error.Name = "password_confirmation_error";
            this.password_confirmation_error.Size = new System.Drawing.Size(0, 13);
            this.password_confirmation_error.TabIndex = 115;
            // 
            // password_error
            // 
            this.password_error.AutoSize = true;
            this.password_error.ForeColor = System.Drawing.Color.Red;
            this.password_error.Location = new System.Drawing.Point(535, 288);
            this.password_error.Name = "password_error";
            this.password_error.Size = new System.Drawing.Size(0, 13);
            this.password_error.TabIndex = 114;
            // 
            // last_name_error
            // 
            this.last_name_error.AutoSize = true;
            this.last_name_error.ForeColor = System.Drawing.Color.Red;
            this.last_name_error.Location = new System.Drawing.Point(535, 249);
            this.last_name_error.Name = "last_name_error";
            this.last_name_error.Size = new System.Drawing.Size(0, 13);
            this.last_name_error.TabIndex = 113;
            // 
            // first_name_error
            // 
            this.first_name_error.AutoSize = true;
            this.first_name_error.ForeColor = System.Drawing.Color.Red;
            this.first_name_error.Location = new System.Drawing.Point(535, 210);
            this.first_name_error.Name = "first_name_error";
            this.first_name_error.Size = new System.Drawing.Size(0, 13);
            this.first_name_error.TabIndex = 112;
            // 
            // username_error
            // 
            this.username_error.AutoSize = true;
            this.username_error.ForeColor = System.Drawing.Color.Red;
            this.username_error.Location = new System.Drawing.Point(535, 171);
            this.username_error.Name = "username_error";
            this.username_error.Size = new System.Drawing.Size(0, 13);
            this.username_error.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 120;
            this.label5.Text = "Powtórz hasło";
            // 
            // password_confirmation
            // 
            this.password_confirmation.Location = new System.Drawing.Point(265, 325);
            this.password_confirmation.Name = "password_confirmation";
            this.password_confirmation.PasswordChar = '*';
            this.password_confirmation.Size = new System.Drawing.Size(261, 20);
            this.password_confirmation.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 119;
            this.label6.Text = "Hasło";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(265, 285);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(261, 20);
            this.password.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 118;
            this.label4.Text = "Nazwisko";
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(265, 246);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(261, 20);
            this.last_name.TabIndex = 107;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Teal;
            this.submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(265, 474);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(263, 23);
            this.submit.TabIndex = 110;
            this.submit.Text = "Dodaj";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 116;
            this.label2.Text = "Nazwa użytkownika";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(265, 207);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(261, 20);
            this.first_name.TabIndex = 106;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(265, 168);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(261, 20);
            this.username.TabIndex = 105;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.header.Location = new System.Drawing.Point(290, 19);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(218, 26);
            this.header.TabIndex = 121;
            this.header.Text = "Dodanie użytkownika";
            // 
            // role
            // 
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "Admin",
            "Pielęgniarka",
            "Lekarz"});
            this.role.Location = new System.Drawing.Point(265, 125);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(261, 21);
            this.role.TabIndex = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 123;
            this.label1.Text = "Typ użytkownika (Rola)";
            // 
            // pwz_label
            // 
            this.pwz_label.AutoSize = true;
            this.pwz_label.Location = new System.Drawing.Point(263, 432);
            this.pwz_label.Name = "pwz_label";
            this.pwz_label.Size = new System.Drawing.Size(32, 13);
            this.pwz_label.TabIndex = 125;
            this.pwz_label.Text = "PWZ";
            // 
            // pwz
            // 
            this.pwz.Location = new System.Drawing.Point(265, 448);
            this.pwz.MaxLength = 7;
            this.pwz.Name = "pwz";
            this.pwz.Size = new System.Drawing.Size(261, 20);
            this.pwz.TabIndex = 124;
            // 
            // pesel_label
            // 
            this.pesel_label.AutoSize = true;
            this.pesel_label.Location = new System.Drawing.Point(263, 350);
            this.pesel_label.Name = "pesel_label";
            this.pesel_label.Size = new System.Drawing.Size(33, 13);
            this.pesel_label.TabIndex = 127;
            this.pesel_label.Text = "Pesel";
            // 
            // pesel
            // 
            this.pesel.Location = new System.Drawing.Point(266, 366);
            this.pesel.MaxLength = 11;
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(260, 20);
            this.pesel.TabIndex = 126;
            // 
            // specialization_label
            // 
            this.specialization_label.AutoSize = true;
            this.specialization_label.Location = new System.Drawing.Point(263, 392);
            this.specialization_label.Name = "specialization_label";
            this.specialization_label.Size = new System.Drawing.Size(69, 13);
            this.specialization_label.TabIndex = 129;
            this.specialization_label.Text = "Specjalizacja";
            // 
            // specialization
            // 
            this.specialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specialization.FormattingEnabled = true;
            this.specialization.Items.AddRange(new object[] {
            "Kardiolog",
            "Urolog ",
            "Neurolog",
            "Laryngolog"});
            this.specialization.Location = new System.Drawing.Point(265, 408);
            this.specialization.Name = "specialization";
            this.specialization.Size = new System.Drawing.Size(261, 21);
            this.specialization.TabIndex = 128;
            // 
            // pesel_error
            // 
            this.pesel_error.AutoSize = true;
            this.pesel_error.ForeColor = System.Drawing.Color.Red;
            this.pesel_error.Location = new System.Drawing.Point(533, 370);
            this.pesel_error.Name = "pesel_error";
            this.pesel_error.Size = new System.Drawing.Size(0, 13);
            this.pesel_error.TabIndex = 130;
            // 
            // pwz_error
            // 
            this.pwz_error.AutoSize = true;
            this.pwz_error.ForeColor = System.Drawing.Color.Red;
            this.pwz_error.Location = new System.Drawing.Point(534, 452);
            this.pwz_error.Name = "pwz_error";
            this.pwz_error.Size = new System.Drawing.Size(0, 13);
            this.pwz_error.TabIndex = 131;
            // 
            // specialization_error
            // 
            this.specialization_error.AutoSize = true;
            this.specialization_error.ForeColor = System.Drawing.Color.Red;
            this.specialization_error.Location = new System.Drawing.Point(534, 413);
            this.specialization_error.Name = "specialization_error";
            this.specialization_error.Size = new System.Drawing.Size(0, 13);
            this.specialization_error.TabIndex = 132;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.specialization_error);
            this.Controls.Add(this.pwz_error);
            this.Controls.Add(this.pesel_error);
            this.Controls.Add(this.specialization_label);
            this.Controls.Add(this.specialization);
            this.Controls.Add(this.pesel_label);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.pwz_label);
            this.Controls.Add(this.pwz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.role);
            this.Controls.Add(this.header);
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
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.username);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label password_confirmation_error;
        private System.Windows.Forms.Label password_error;
        private System.Windows.Forms.Label last_name_error;
        private System.Windows.Forms.Label first_name_error;
        private System.Windows.Forms.Label username_error;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password_confirmation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pwz_label;
        private System.Windows.Forms.TextBox pwz;
        private System.Windows.Forms.Label pesel_label;
        private System.Windows.Forms.TextBox pesel;
        private System.Windows.Forms.Label specialization_label;
        private System.Windows.Forms.ComboBox specialization;
        private System.Windows.Forms.Label pesel_error;
        private System.Windows.Forms.Label pwz_error;
        private System.Windows.Forms.Label specialization_error;
    }
}