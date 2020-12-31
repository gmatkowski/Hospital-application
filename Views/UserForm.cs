using Hospital.Abstracts;
using Hospital.DB;
using Hospital.Models;
using Hospital.Repositories;
using HospitalApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Views
{
    public partial class UserForm : Form
    {
        User user;
        FormHelper formHelper = new FormHelper();

        Dictionary<string, string> replacers = new Dictionary<string, string>()
        {
            { "username", "Nazwa użytkownika"},
            { "first_name", "Imię"},
            { "last_name", "Naziwsko"},
            { "password", "Hasło"},
            { "password_confirmation", "Powtórz hasło"},
            { "specialization", "Specjalizacja"}
        };

        public UserForm()
        {
            this.Prepare();
        }

        public UserForm(User user)
        {
            this.user = user;
            this.Prepare();
        }
        private bool IsUpdatingMode()
        {
            return this.user != null;
        }

        protected void Prepare()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(900, 600);
            this.MaximumSize = new Size(900, 600);

            this.HideAllNotCommonFields();

            this.role.SelectedItem = "Admin";

            if (this.IsUpdatingMode())
            {
                this.submit.Text = "Zapisz";
                this.header.Text = String.Format("Zmiana danych użytkownika {0}", this.user.full_name);

                this.username.Text = this.user.username;
                this.first_name.Text = this.user.first_name;
                this.last_name.Text = this.user.last_name;
                this.pesel.Text = this.user.first_name;

                if (this.user is Admin)
                {
                    this.ShowDoctorFields();
                    this.role.SelectedItem = "Admin";
                }

                if (this.user is Nurse)
                {
                    Nurse nurse = (Nurse)this.user;
                    this.role.SelectedItem = "Pielęgniarka";
                    this.pesel.Text = nurse.pesel;

                    this.ShowNurseFields();
                }

                if (this.user is Doctor)
                {
                    Doctor doctor = (Doctor)this.user;
                    this.role.SelectedItem = "Lekarz";
                    this.pesel.Text = doctor.pesel;
                    this.pwz.Text = doctor.pwz;
                    this.specialization.Text = doctor.specialization;

                    this.ShowDoctorFields();
                }
            }

            this.role.SelectedIndexChanged += new EventHandler(role_SelectedIndexChanged);
            this.pesel.KeyPress += new KeyPressEventHandler(onlyNumbersKeyPress);
            this.pwz.KeyPress += new KeyPressEventHandler(onlyNumbersKeyPress);
        }

        private void role_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string role = (string)this.role.SelectedItem;

            this.HideAllNotCommonFields();

            switch (role)
            {
                case "Lekarz":
                    this.ShowDoctorFields();
                    break;
                case "Pielęgniarka":
                    this.ShowNurseFields();
                    break;
            }
        }

        private void HideAllNotCommonFields()
        {
            this.pwz.Visible = false;
            this.pwz_label.Visible = false;
            this.specialization.Visible = false;
            this.specialization_label.Visible = false;
            this.pesel.Visible = false;
            this.pesel_label.Visible = false;
        }

        private void ShowNurseFields()
        {
            this.pesel.Visible = true;
            this.pesel_label.Visible = true;
        }
        private void ShowDoctorFields()
        {
            this.ShowNurseFields();

            this.pwz.Visible = true;
            this.pwz_label.Visible = true;
            this.specialization.Visible = true;
            this.specialization_label.Visible = true;
        }

        private void onlyNumbersKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+")) { 
                e.Handled = true;
            }
        }

        private User RetriveParsedUser(User user)
        {
            string username = this.username.Text.Trim();
            string first_name = this.first_name.Text.Trim();
            string last_name = this.last_name.Text.Trim();
            string password = this.password.Text.Trim();

            if (this.IsUpdatingMode())
            {
                user.id = this.user.id;
            }

            user.username = username;
            user.first_name = first_name;
            user.last_name = last_name;
            user.password = password;

            return user;
        }

        private bool PasswordValidation()
        {
            string password = this.password.Text.Trim();
            string password_confirmation = this.password_confirmation.Text.Trim();

            if(this.IsUpdatingMode() && password.Length == 0)
            {
                return true;
            }
            
            if(!String.Equals(password, password_confirmation)) { 
                this.password_error.Text = "Hasła nie są jednakowe";
                this.password_confirmation_error.Text = "Hasła nie są jednakowe";
                return false;
            }

            return true;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.ClearErrors();

            UserRepository repository = new UserRepository(new HospitalContext("HospitalDbContext"));

            User user;

            switch (this.role.SelectedItem)
            {
                case "Lekarz":
                    Doctor doctor = new Doctor();
                    doctor.pesel = this.pesel.Text;
                    doctor.pwz = this.pwz.Text;
                    doctor.specialization = this.specialization.Text;
                    user = this.RetriveParsedUser(doctor);
                    break;
                case "Pielęgniarka":
                    Nurse nurse = new Nurse();
                    nurse.pesel = this.pesel.Text;
                    user = this.RetriveParsedUser(nurse);
                    break;
                default:
                    user = this.RetriveParsedUser(new Admin());
                    break;
            }

            if (!this.PasswordValidation())
            {
                return;
            }

            bool hashPassword = true;

            string password = this.password.Text.Trim();
            if (this.IsUpdatingMode())
            {
                if (password.Length == 0)
                {
                    user.password = this.user.password;
                    hashPassword = false;
                }
            }

            if (hashPassword)
            {
                user.password = BCrypt.Net.BCrypt.HashPassword(password);
            }
            try
            {
                if (this.IsUpdatingMode())
                {
                    repository.Update(user);
                }
                else
                {
                    repository.Insert(user);
                }

                MessageBox.Show(String.Format("Użytkownik został {0}", this.IsUpdatingMode() ? "zapisany" : "dodany"));
                this.Close();
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
            string[] fields = { "username", "first_name", "last_name", "password", "password_confirmation", "pwz", "specialization", "pesel" };
            foreach (string field in fields)
            {
                Control ctn = this.Controls[String.Format("{0}_error", field)];
                ctn.Text = "";
            }
        }
    }
}
