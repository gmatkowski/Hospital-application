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
using Hospital.DB;
using Hospital.Abstracts;
using HospitalApp.Models;
using Hospital.Models;

namespace HospitalApp.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.logged_as.Text = Program.AuthenticatedUser.full_name;

            this.SetTableProperties();
            this.Activated += new EventHandler(FormActivated);
        }

        void FormActivated(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void RefreshData()
        {
            this.FillTable();
            this.CreateButtons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Logout();
            Redirect.GoToLogin(this);
        }

        private void SetTableProperties()
        {
            this.users_table.AllowUserToAddRows = false;
            this.users_table.RowHeadersVisible = false;
            this.users_table.CellContentClick += users_table_CellContentClick;

            if (!String.Equals(Program.AuthenticatedUser.role, "Admin"))
            {
                this.adduser.Visible = false;
            }
        }

        private UserRepository GetRepository()
        {
            return new UserRepository(new HospitalContext("HospitalDbContext"));
        }

        private void FillTable()
        {
            this.users_table.Columns.Clear();
            this.users_table.DataSource = null;

            List<User> users = this.GetRepository().GetListingForUser(Program.AuthenticatedUser);

            BindingList<UserTable> people = new BindingList<UserTable>();
            users.ForEach(user =>
            {
                UserTable userTable = new UserTable { id = user.id, first_name = user.first_name, last_name = user.last_name, role = user.GetRoleName() };
                if(user is Doctor)
                {
                    Doctor doctor = (Doctor)user;
                    userTable.specialization = doctor.specialization;
                }

                userTable.original_user = user;

                people.Add(userTable);
            });

            this.users_table.DataSource = people;

            this.users_table.Update();
            this.users_table.Refresh();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.users_table.SelectionChanged += new EventHandler(this.users_table_SelectionChanged);
        }

        private void users_table_SelectionChanged(object sender, EventArgs e)
        {
            this.users_table.ClearSelection();
        }

        private void CreateButtons()
        {
            // Shifts
            DataGridViewButtonColumn shifts = new DataGridViewButtonColumn();
            shifts.DefaultCellStyle.BackColor = Color.LightBlue;
            shifts.DefaultCellStyle.ForeColor = Color.Black;
            shifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            shifts.Name = "shifts";
            shifts.ReadOnly = true;
            shifts.Text = "Zobacz";
            shifts.Tag = (Action<UserTable>)ShiftButtonClicked;
            shifts.UseColumnTextForButtonValue = true;
            this.users_table.Columns.Add(shifts);
            this.users_table.Columns[this.users_table.Columns.Count - 1].HeaderText = "Dyżury";

            if (String.Equals(Program.AuthenticatedUser.role, "Admin"))
            {
                // Edit
                DataGridViewButtonColumn edit = new DataGridViewButtonColumn();
                edit.DefaultCellStyle.BackColor = Color.LightGreen;
                edit.DefaultCellStyle.ForeColor = Color.Black;
                edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                edit.Name = "edit";
                edit.ReadOnly = true;
                edit.Text = "Edytuj";
                edit.Tag = (Action<UserTable>)EditButtonClicked;
                edit.UseColumnTextForButtonValue = true;
                this.users_table.Columns.Add(edit);
                this.users_table.Columns[this.users_table.Columns.Count - 1].HeaderText = "Edycja";

                // Delete
                DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                delete.DefaultCellStyle.BackColor = Color.Red;
                delete.DefaultCellStyle.ForeColor = Color.White;
                delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                delete.Name = "delete";
                delete.ReadOnly = true;
                delete.Text = "Usuń";
                delete.Tag = (Action<UserTable>)DeleteButtonClicked;
                delete.UseColumnTextForButtonValue = true;
                this.users_table.Columns.Add(delete);
                this.users_table.Columns[this.users_table.Columns.Count - 1].HeaderText = "Usuwanie";
            }
        }

        private void users_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                var clickHandler = (Action<UserTable>)grid.Columns[e.ColumnIndex].Tag;
                var person = (UserTable)grid.Rows[e.RowIndex].DataBoundItem;

                clickHandler(person);
            }
        }

        public void ShiftButtonClicked(UserTable user)
        {
            if(user.original_user is Admin)
            {
                MessageBox.Show(String.Format("Tylko lekarze oraz pielęgniarki mają dyżury."));
                return;
            }

            MessageBox.Show(String.Format("Clicked shift button for {0}", user.fullname));
        }

        public void EditButtonClicked(UserTable user)
        {
            if (!String.Equals(Program.AuthenticatedUser.role, "Admin"))
            {
                MessageBox.Show(String.Format("Nie masz prawa do edytowania użytkowników"));
                return;
            }

            UserForm form = new UserForm(user.original_user);
            form.ShowDialog();
        }

        public void DeleteButtonClicked(UserTable user)
        {
            if(user.id == Program.AuthenticatedUser.id)
            {
                MessageBox.Show(String.Format("Nie możesz usunąć samego siebie!"));
                return;
            }

            if (!String.Equals(Program.AuthenticatedUser.role, "Admin"))
            {
                MessageBox.Show(String.Format("Nie masz prawa do usuwania użytkowników"));
                return;
            }

            int index = this.FindIndex(user);
            if(index == -1)
            {
                MessageBox.Show(String.Format("Nie ma takiego użytkownika"));
                return;
            }

            this.users_table.Rows.RemoveAt(index);
            this.GetRepository().Delete(user.original_user);

            MessageBox.Show(String.Format("Usunięto użytkownika {0}", user.fullname));
        }

        private int FindColumnIndex(string name)
        {
            int index = -1;
            foreach (DataGridViewColumn column in this.users_table.Columns)
            {
                if (String.Equals(column.Name, name))
                {
                    index = column.Index;
                    break;
                }
            }
            return index;
        }

        private int FindIndex(UserTable user)
        {
            int rowIndex = -1;
            int columnIndex = this.FindColumnIndex("id");
            if(columnIndex == -1)
            {
                return rowIndex;
            }

            foreach (DataGridViewRow row in this.users_table.Rows)
            {
                if (String.Equals(user.id.ToString(), row.Cells[columnIndex].Value.ToString()))
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            return rowIndex;
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            if (!String.Equals(Program.AuthenticatedUser.role, "Admin"))
            {
                MessageBox.Show(String.Format("Nie masz prawa do dodawania użytkowników"));
                return;
            }

            UserForm form = new UserForm();
            form.ShowDialog();
        }
    }
}
