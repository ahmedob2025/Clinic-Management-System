namespace ClinicMangementSystem.PL
{
    partial class DoctorEntryForm
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
            txtFullName = new TextBox();
            txtSpecialization = new TextBox();
            txtPhone = new TextBox();
            txtFee = new TextBox();
            lblFullName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(31, 51);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(228, 28);
            txtFullName.TabIndex = 0;
            // 
            // txtSpecialization
            // 
            txtSpecialization.BackColor = Color.White;
            txtSpecialization.BorderStyle = BorderStyle.FixedSingle;
            txtSpecialization.Font = new Font("Tahoma", 10.2F);
            txtSpecialization.Location = new Point(31, 119);
            txtSpecialization.Name = "txtSpecialization";
            txtSpecialization.Size = new Size(228, 28);
            txtSpecialization.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Tahoma", 10.2F);
            txtPhone.Location = new Point(31, 186);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(228, 28);
            txtPhone.TabIndex = 2;
            // 
            // txtFee
            // 
            txtFee.BackColor = Color.White;
            txtFee.BorderStyle = BorderStyle.FixedSingle;
            txtFee.Font = new Font("Tahoma", 10.2F);
            txtFee.Location = new Point(31, 251);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(228, 28);
            txtFee.TabIndex = 3;
            txtFee.TextChanged += txtFee_TextChanged;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.DimGray;
            lblFullName.Location = new Point(283, 51);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(114, 21);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "اسم الطبيب ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(314, 126);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 5;
            label2.Text = "التخصص";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(336, 193);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 6;
            label3.Text = "الهاتف";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(275, 251);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 7;
            label4.Text = "رسوم الكشف";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(26, 43, 76);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(31, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 8;
            btnSave.Text = "حفظ ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(297, 306);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "الغاء";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.WhiteSmoke;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(26, 43, 76);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(72, 24);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "اضافة ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DoctorEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(462, 353);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblFullName);
            Controls.Add(txtFee);
            Controls.Add(txtPhone);
            Controls.Add(txtSpecialization);
            Controls.Add(txtFullName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DoctorEntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة / تعديل طبيب";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtSpecialization;
        private TextBox txtPhone;
        private TextBox txtFee;
        private Label lblFullName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSave;
        private Button btnCancel;
        private Label lblTitle;
    }
}