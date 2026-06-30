namespace ClinicMangementSystem.PL
{
    partial class LoginForm
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
            label1 = new Label();
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            btnCancel = new Button();
            chkRemember = new CheckBox();
            lblError = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 21);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(26, 43, 76);
            lblTitle.Location = new Point(64, 11);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(594, 36);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "نظام ادارة العيادات الطبية تسجيل الدخول";
            lblTitle.Click += label2_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(495, 148);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(143, 24);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "اسم المستخدم";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(221, 150);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 27);
            txtUsername.TabIndex = 3;
            txtUsername.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(221, 218);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(244, 27);
            txtPassword.TabIndex = 4;
            txtPassword.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Tahoma", 10.8F);
            lblPassword.Location = new Point(543, 223);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(95, 22);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "كلمة المرور";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(26, 43, 76);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(221, 313);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "دخول ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(538, 313);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "الغاء";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button2_Click;
            // 
            // chkRemember
            // 
            chkRemember.AutoSize = true;
            chkRemember.Location = new Point(231, 267);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(75, 24);
            chkRemember.TabIndex = 8;
            chkRemember.Text = "تذكرني";
            chkRemember.UseVisualStyleBackColor = true;
            chkRemember.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(473, 290);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(chkRemember);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(33, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 360);
            panel1.TabIndex = 10;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسحيل الدخول";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnCancel;
        private CheckBox chkRemember;
        private Label lblError;
        private Panel panel1;
    }
}