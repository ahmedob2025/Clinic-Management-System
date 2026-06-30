namespace ClinicMangementSystem.PL
{
    partial class PatientEntryForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            cmbGender = new ComboBox();
            dtpBirthDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.WhiteSmoke;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(26, 43, 76);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(114, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "اضافة مريض";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(305, 50);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 1;
            label2.Text = "اسم المريض";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(323, 98);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 2;
            label3.Text = "رقم الهاتف";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(353, 144);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 3;
            label4.Text = "الجنس";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(315, 197);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 4;
            label5.Text = "تاريخ الميلاد";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(353, 244);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 5;
            label6.Text = "العنوان";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(43, 48);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(242, 27);
            txtFullName.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Location = new Point(43, 92);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(242, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(43, 238);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(242, 27);
            txtAddress.TabIndex = 10;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FlatStyle = FlatStyle.System;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(43, 137);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(242, 28);
            cmbGender.TabIndex = 12;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(43, 191);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(242, 27);
            dtpBirthDate.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(26, 43, 76);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(43, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 14;
            btnSave.Text = "حفظ ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(319, 306);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "الغاء";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // PatientEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(462, 353);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpBirthDate);
            Controls.Add(cmbGender);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PatientEntryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "اضافة / تعديل مريض";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private ComboBox cmbGender;
        private DateTimePicker dtpBirthDate;
        private Button btnSave;
        private Button btnCancel;
    }
}