namespace ClinicMangementSystem.PL
{
    partial class UserEntryForm
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
            txtUsername = new TextBox();
            txtPassowrd = new TextBox();
            txtFullName = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblFullName = new Label();
            cmbRole = new ComboBox();
            lblRole = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(26, 43, 76);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(217, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "اضافة مستخدم جديد ➕";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(65, 81);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(186, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassowrd
            // 
            txtPassowrd.BackColor = Color.White;
            txtPassowrd.BorderStyle = BorderStyle.FixedSingle;
            txtPassowrd.Location = new Point(65, 140);
            txtPassowrd.Name = "txtPassowrd";
            txtPassowrd.Size = new Size(186, 27);
            txtPassowrd.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(65, 199);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(186, 27);
            txtFullName.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsername.Location = new Point(310, 85);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(112, 23);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "اسم المستخدم";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(331, 144);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(91, 23);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "كلمة المرور";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(325, 203);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(97, 23);
            lblFullName.TabIndex = 6;
            lblFullName.Text = "الاسم الكامل";
            // 
            // cmbRole
            // 
            cmbRole.BackColor = Color.White;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Reception" });
            cmbRole.Location = new Point(65, 251);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(186, 28);
            cmbRole.TabIndex = 7;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(350, 256);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(72, 23);
            lblRole.TabIndex = 8;
            lblRole.Text = "الصلاحية";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(26, 43, 76);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(65, 309);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 9;
            btnSave.Text = "حفظ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(322, 309);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "الغاء";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // UserEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(462, 353);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            Controls.Add(lblFullName);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtFullName);
            Controls.Add(txtPassowrd);
            Controls.Add(txtUsername);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserEntryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "اضافة مستخدم جديد";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtUsername;
        private TextBox txtPassowrd;
        private TextBox txtFullName;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblFullName;
        private ComboBox cmbRole;
        private Label lblRole;
        private Button btnSave;
        private Button btnCancel;
    }
}