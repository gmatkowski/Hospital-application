using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Hospital.Abstracts;
using Hospital.DB;
using Hospital.Models;
using Hospital.Repositories;
using HospitalApp.Helpers;
using HospitalApp.Models;

namespace HospitalApp.Views
{
    public partial class Shifts : Form
    {
        FormHelper formHelper = new FormHelper();
        Employee employee;

        private ShiftRepository repository
        {
            get
            {
                return new ShiftRepository(new HospitalContext("HospitalDbContext"));
            }
        }

        public Shifts(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            this.StartForm();
            this.Activated += new EventHandler(FormActivated);
        }

        void FormActivated(object sender, EventArgs e)
        {
            this.RefreshTable();
        }

        private void StartForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(900, 600);
            this.MaximumSize = new Size(900, 600);

            this.shifts_for.Text = this.employee.full_name;

            this.datepicker.CustomFormat = "MMMM yyyy";
            this.datepicker.ShowUpDown = true;

            DateTime newDateValue = new DateTime(this.datepicker.Value.Year, this.datepicker.Value.Month, 1);
            this.datepicker.Value = newDateValue;
            this.datepicker.ValueChanged += new EventHandler(datepickerDateChanged);

            this.shifts_table.AllowUserToAddRows = false;
            this.shifts_table.RowHeadersVisible = false;
            this.shifts_table.CellContentClick += shifts_table_CellContentClick;

            this.create_shift.Visible = Program.AuthenticatedUser is Admin;        
        }

        protected override void OnLoad(EventArgs e)
        {
            this.shifts_table.SelectionChanged += new EventHandler(this.shifts_table_SelectionChanged);
        }

        private void shifts_table_SelectionChanged(object sender, EventArgs e)
        {
            this.shifts_table.ClearSelection();
        }

        private void shifts_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                var clickHandler = (Action<ShiftTable>)grid.Columns[e.ColumnIndex].Tag;
                var shift = (ShiftTable)grid.Rows[e.RowIndex].DataBoundItem;

                clickHandler(shift);
            }
        }

        private void datepickerDateChanged(object sender, System.EventArgs e)
        {
            this.RefreshTable();
        }

        private void RefreshTable()
        {
            this.shifts_table.Columns.Clear();
            this.shifts_table.DataSource = null;

            List<Shift> EmployeeShifts = this.repository.GetForEmployee(this.employee, this.datepicker.Value);
            BindingList<ShiftTable> shifts = new BindingList<ShiftTable>();

            EmployeeShifts.ForEach(shift =>
             {
                 ShiftTable shiftTable = new ShiftTable { id = shift.id, date = shift.date};
                 shiftTable.original_shift = shift;
                 shifts.Add(shiftTable);
             });

            this.shifts_table.DataSource = shifts;

            this.shifts_table.Update();
            this.shifts_table.Refresh();

            this.Createbuttons();
        }

        private void Createbuttons()
        {
            if(!(Program.AuthenticatedUser is Admin))
            {
                return;
            }

            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.DefaultCellStyle.BackColor = Color.Red;
            delete.DefaultCellStyle.ForeColor = Color.White;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Text = "Usuń";
            delete.Tag = (Action<ShiftTable>)DeleteButtonClicked;
            delete.UseColumnTextForButtonValue = true;
            this.shifts_table.Columns.Add(delete);
            this.shifts_table.Columns[this.shifts_table.Columns.Count - 1].HeaderText = "Usuwanie";
        }

        private void create_shift_Click(object sender, System.EventArgs e)
        {
            ShiftForm form = new ShiftForm(this.employee);
            form.ShowDialog();
        }

        public void DeleteButtonClicked(ShiftTable shift)
        {
            int index = this.formHelper.FindIndex(this.shifts_table, shift.id);
            if (index == -1)
            {
                MessageBox.Show(String.Format("Nie ma takiego dyżuru!"));
                return;
            }

            this.shifts_table.Rows.RemoveAt(index);
            this.repository.Delete(shift.original_shift);

            MessageBox.Show(String.Format("Usunięto dyżur z dnia {0}", shift.date.ToShortDateString()));
        }
    }
}
