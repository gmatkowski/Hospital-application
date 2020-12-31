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

            this.date.MinDate = DateTime.Now;

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddShift_Click(object sender, EventArgs e)
        {
            this.ClearErrors();

            DateTime date = this.date.Value;

            Console.WriteLine(date.ToShortDateString());

            Shift shift = new Shift();
            shift.user_id = this.employee.id;
            shift.date = date;

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
                Console.WriteLine(message);

                if (message.Contains("23505"))
                {
                    this.date_error.Text = "Wybrana data jest już zajęta";
                }
            }
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
