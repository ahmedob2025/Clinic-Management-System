namespace ClinicMangementSystem.PL
{
    partial class AppointmentEntryForm
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
            lblTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbPatients = new ComboBox();
            cmbDoctors = new ComboBox();
            dtpDate = new DateTimePicker();
            dtpTime = new DateTimePicker();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.WhiteSmoke;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Tahoma", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(26, 43, 76);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "اضافة موعد جديد ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(316, 68);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 1;
            label1.Text = " المريض";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(328, 113);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 2;
            label2.Text = "الطبيب";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(332, 155);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 3;
            label3.Text = "التاريخ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(336, 201);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 4;
            label4.Text = "الوقت";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(336, 248);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 5;
            label5.Text = "الحالة";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbPatients
            // 
            cmbPatients.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatients.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPatients.FormattingEnabled = true;
            cmbPatients.Location = new Point(12, 68);
            cmbPatients.Name = "cmbPatients";
            cmbPatients.Size = new Size(250, 29);
            cmbPatients.TabIndex = 6;
            // 
            // cmbDoctors
            // 
            cmbDoctors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctors.Font = new Font("Tahoma", 10.2F);
            cmbDoctors.FormattingEnabled = true;
            cmbDoctors.Location = new Point(12, 113);
            cmbDoctors.Name = "cmbDoctors";
            cmbDoctors.Size = new Size(250, 29);
            cmbDoctors.TabIndex = 7;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Tahoma", 10.2F);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(12, 151);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 28);
            dtpDate.TabIndex = 8;
            // 
            // dtpTime
            // 
            dtpTime.Font = new Font("Tahoma", 10.2F);
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(12, 201);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(250, 28);
            dtpTime.TabIndex = 9;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Tahoma", 10.2F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Scheduled", "Completed", "Cancelled" });
            cmbStatus.Location = new Point(12, 248);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(250, 29);
            cmbStatus.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(26, 43, 76);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(37, 308);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 12;
            btnSave.Text = "حفظ ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gainsboro;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(299, 309);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "الغاء";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AppointmentEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(462, 353);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(dtpTime);
            Controls.Add(dtpDate);
            Controls.Add(cmbDoctors);
            Controls.Add(cmbPatients);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppointmentEntryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "اضافة / تعديل موعد ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbPatients;
        private ComboBox cmbDoctors;
        private DateTimePicker dtpDate;
        private DateTimePicker dtpTime;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Button btnCancel;
    }
}