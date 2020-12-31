using Hospital.Repositories;
using System;
using System.Windows.Forms;
using Hospital.DB;
using Hospital.Abstracts;
using System.Data.Entity.Validation;
using HospitalApp.Helpers;
using System.Collections.Generic;
using Hospital.Models;
using System.Data.Entity.Infrastructure;
using System.Configuration;
using System.Drawing;

namespace HospitalApp.Views
{
    public partial class ShiftForm : Form
    {
        Employee employee;

        FormHelper formHelper = new FormHelper();
        Dictionary<string, string> replacers = new Dictionary<string, string>()
        {
            { "date", "Data dyżuru"},
        };

        private ShiftRepository repository
        {
            get
            {
                return new ShiftRepository(new HospitalContext("HospitalDbContext"));
            }
        }

        public ShiftForm(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            this.MinimumSize = new Size(330, 240);
            this.MaximumSize = new Size(330, 240);

            this.date.MinDate = DateTime.Now;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddShift_Click(object sender, EventArgs e)
        {
            this.ClearErrors();

            DateTime date = this.date.Value;

            Shift shift = new Shift();
            shift.user_id = this.employee.id;
            shift.date = date;

            if (!this.ValidateForm())
            {
                return;
            }

            try
            {
                this.repository.Insert(shift);

                MessageBox.Show("Dyżur został dodany.");
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
            catch(DbUpdateException ex)
            {
                string message = ex.GetBaseException().Message;

                if (message.Contains("23505"))
                {
                    this.date_error.Text = "Wybrana data jest już zajęta";
                    return;
                }

                this.date_error.Text = "Wystąpił niezamierzony błąd, skontaktuj się z twórcą oprogramowania!";
            }
        }

        private bool ValidateForm()
        {
            int max = int.Parse(ConfigurationManager.AppSettings.Get("max_shifts"));

            if (!this.repository.CanHaveAtPointedDateExact(this.employee, this.date.Value))
            {
                this.date_error.Text = "Pracownik ma już dyżur tego dnia.";
                return false;
            }

            if (!this.repository.CanHaveAnotherInThisMont(this.employee, this.date.Value, max))
            {
                this.date_error.Text = String.Format("Wykorzystano {0} dyżurów.", max);
                return false;
            }

            if (!this.repository.CanHaveAtPointedDate(this.employee, this.date.Value))
            {
                this.date_error.Text = "Dyżyry nie mogą występować dzień po dniu.";
                return false;
            }

            if(this.employee is Doctor) { 
                if (!this.repository.CanHaveAtPointedDateDoctorLookup((Doctor)this.employee, this.date.Value))
                {
                    this.date_error.Text = "W tym dniu inny lekarz o tej samej specjalizacji ma już dyżur.";
                    return false;
                }
            }

            //CanHaveAtPointedDateDoctorLookup

            return true;
        }

        private void ClearErrors()
        {
            string[] fields = { "date"};
            foreach (string field in fields)
            {
                Control ctn = this.Controls[String.Format("{0}_error", field)];
                ctn.Text = "";
            }
        }
    }
}
