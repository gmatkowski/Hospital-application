using Hospital.DB;
using Hospital.Models;
using Hospital.Repositories;
using HospitalApp.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalApp.Views
{
    public partial class AdminRegister : Form
    {
        FormHelper formHelper = new FormHelper();
        Dictionary<string, string> replacers = new Dictionary<string, string>()
        {
            { "username", "Nazwa użytkownika"},
            { "first_name", "Imię"},
            { "last_name", "Naziwsko"},
            { "password", "Hasło"},
            { "password_confirmation", "Powtórz hasło"},
        };
        UserRepository repository  {
            get
            {
                return new UserRepository(new HospitalContext("HospitalDbContext"));
            }
        }
        public AdminRegister()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(900, 600);
            this.MaximumSize = new Size(900, 600);
        }

        private void RegisterAdminButton_Click(object sender, EventArgs e)
        {
            this.ClearErrors();

            string username = this.username.Text.Trim();
            string first_name = this.first_name.Text.Trim();
            string last_name = this.last_name.Text.Trim();
            string password = this.password.Text.Trim();
            string password_confirmation = this.password_confirmation.Text.Trim();

            if (!String.Equals(password, password_confirmation))
            {
                this.password_error.Text = "Hasła nie są jednakowe";
                this.password_confirmation_error.Text = "Hasła nie są jednakowe";
                return;
            }

            try
            {
                Admin admin = new Admin();
                admin.username = username;
                admin.first_name = first_name;
                admin.last_name = last_name;
                admin.password = password.Length > 0 ? BCrypt.Net.BCrypt.HashPassword(password): password;

                this.repository.Insert(admin);
                Redirect.GoToLogin(this);
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var errors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in errors.ValidationErrors)
                    {
                        string field = validationError.PropertyName;
                        string message = this.formHelper.ReplaceFieldnames(validationError.ErrorMessage, this.replacers);

                        Control ctn = this.Controls[String.Format("{0}_error", field)];
                        ctn.Text = message;
                    }

                    
                }
            }
        }

        private void ClearErrors()
        {
            this.repository.Clear();

            string[] fields = { "username", "first_name", "last_name", "password", "password_confirmation" };
            foreach (string field in fields)
            {
                Control ctn = this.Controls[String.Format("{0}_error", field)];
                ctn.Text = "";
            }
        }
    }
}
