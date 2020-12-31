namespace HospitalApp.Views
{
    partial class ShiftForm
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
            this.AddShift = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddShift
            // 
            this.AddShift.BackColor = System.Drawing.Color.Teal;
            this.AddShift.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddShift.FlatAppearance.BorderSize = 0;
            this.AddShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddShift.ForeColor = System.Drawing.Color.White;
            this.AddShift.Location = new System.Drawing.Point(41, 152);
            this.AddShift.Name = "AddShift";
            this.AddShift.Size = new System.Drawing.Size(230, 24);
            this.AddShift.TabIndex = 4;
            this.AddShift.Text = "Dodaj dyżur";
            this.AddShift.UseVisualStyleBackColor = false;
            this.AddShift.Click += new System.EventHandler(this.AddShift_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(41, 94);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(230, 20);
            this.date.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(92, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dodanie dyżury";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wybierz datę";
            // 
            // date_error
            // 
            this.date_error.AutoSize = true;
            this.date_error.ForeColor = System.Drawing.Color.Red;
            this.date_error.Location = new System.Drawing.Point(38, 127);
            this.date_error.Name = "date_error";
            this.date_error.Size = new System.Drawing.Size(0, 13);
            this.date_error.TabIndex = 8;
            // 
            // ShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 245);
            this.Controls.Add(this.date_error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.AddShift);
            this.Name = "ShiftForm";
            this.Text = "Dodaj dyżur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddShift;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label date_error;
    }
}