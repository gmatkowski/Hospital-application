namespace HospitalApp.Views
{
    partial class Shifts
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
            this.shifts_for_label = new System.Windows.Forms.Label();
            this.shifts_for = new System.Windows.Forms.Label();
            this.shifts_table = new System.Windows.Forms.DataGridView();
            this.create_shift = new System.Windows.Forms.Button();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.shifts_table)).BeginInit();
            this.SuspendLayout();
            // 
            // shifts_for_label
            // 
            this.shifts_for_label.AutoSize = true;
            this.shifts_for_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shifts_for_label.Location = new System.Drawing.Point(12, 29);
            this.shifts_for_label.Name = "shifts_for_label";
            this.shifts_for_label.Size = new System.Drawing.Size(86, 20);
            this.shifts_for_label.TabIndex = 1;
            this.shifts_for_label.Text = "Dyżury dla:";
            // 
            // shifts_for
            // 
            this.shifts_for.AutoSize = true;
            this.shifts_for.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shifts_for.Location = new System.Drawing.Point(104, 29);
            this.shifts_for.Name = "shifts_for";
            this.shifts_for.Size = new System.Drawing.Size(167, 20);
            this.shifts_for.TabIndex = 2;
            this.shifts_for.Text = "Nazwa Użytkownika";
            // 
            // shifts_table
            // 
            this.shifts_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shifts_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shifts_table.Location = new System.Drawing.Point(12, 69);
            this.shifts_table.Name = "shifts_table";
            this.shifts_table.Size = new System.Drawing.Size(860, 480);
            this.shifts_table.TabIndex = 0;
            // 
            // create_shift
            // 
            this.create_shift.BackColor = System.Drawing.Color.Teal;
            this.create_shift.FlatAppearance.BorderSize = 0;
            this.create_shift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_shift.ForeColor = System.Drawing.Color.White;
            this.create_shift.Location = new System.Drawing.Point(764, 26);
            this.create_shift.Name = "create_shift";
            this.create_shift.Size = new System.Drawing.Size(108, 23);
            this.create_shift.TabIndex = 5;
            this.create_shift.Text = "Dodaj dyżur";
            this.create_shift.UseVisualStyleBackColor = false;
            this.create_shift.Click += new System.EventHandler(this.create_shift_Click);
            // 
            // datepicker
            // 
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker.Location = new System.Drawing.Point(335, 29);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(200, 20);
            this.datepicker.TabIndex = 6;
            // 
            // Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.create_shift);
            this.Controls.Add(this.shifts_for);
            this.Controls.Add(this.shifts_for_label);
            this.Controls.Add(this.shifts_table);
            this.Name = "Shifts";
            this.Text = "Dyżury";
            ((System.ComponentModel.ISupportInitialize)(this.shifts_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label shifts_for_label;
        private System.Windows.Forms.Label shifts_for;
        private System.Windows.Forms.DataGridView shifts_table;
        private System.Windows.Forms.Button create_shift;
        private System.Windows.Forms.DateTimePicker datepicker;
    }
}