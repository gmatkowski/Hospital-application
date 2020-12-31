using Hospital.Abstracts;
using Hospital.DB;
using Hospital.Exceptions;
using Hospital.Repositories;
using HospitalApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalApp.Views
{
    public partial class Login : Form
    {
        FormHelper formHelper = new FormHelper();
        UserRepository repository
        {
            get
            {
                return new UserRepository(new HospitalContext("HospitalDbContext"));
            }
        }

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(900, 600);
            this.MaximumSize = new Size(900, 600);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.ClearErrors();

            string username = this.username.Text.Trim();
            string password = this.password.Text.Trim();

            try
            {
                User user = this.repository.GetByUsername(username);
                if (!BCrypt.Net.BCrypt.Verify(password, user.password))
                {
                    throw new UserNotFoundException();
                }

                Program.AuthenticatedUser = user;
                Redirect.GoToDashboard(this);
            }
            catch (UserNotFoundException ex)
            {
                this.failed_error.Text = "Logowanie niepoprawne!";
            }
        }

        private void ClearErrors()
        {
            this.repository.Clear();

            string[] fields = { "username", "password", "failed" };
            foreach (string field in fields)
            {
                Control ctn = this.Controls[String.Format("{0}_error", field)];
                ctn.Text = "";
            }
        }
    }
}
