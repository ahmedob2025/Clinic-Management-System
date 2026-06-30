namespace ClinicMangementSystem.PL
{
    partial class AdminDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            panel2 = new Panel();
            btnAppointments = new Button();
            btnPatients = new Button();
            btnBills = new Button();
            btnLogout = new Button();
            btnUser = new Button();
            btnDoctor = new Button();
            lblUser = new Label();
            pnlHeader = new Panel();
            CurrentUser = new Label();
            lblWelcome = new Label();
            pnlCountUser = new Panel();
            label3 = new Label();
            lblUserCount = new Label();
            label1 = new Label();
            pnlCountPatints = new Panel();
            label9 = new Label();
            lblPatientCount = new Label();
            label8 = new Label();
            pnlCountDoctors = new Panel();
            lblDoctorCount = new Label();
            label10 = new Label();
            lblCountDoctors = new Label();
            pnlCountAppoin = new Panel();
            lblAppointmentCount = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pnlCard = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblAppointmentsTitle = new Label();
            panel1 = new Panel();
            dgvAppointments = new DataGridView();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAddDoctor = new Button();
            btnAddAppo = new Button();
            btnAddUser = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel4 = new Panel();
            lblUnpaidBills = new Label();
            label = new Label();
            panel5 = new Panel();
            lblCompletionRate = new Label();
            lblCompletion = new Label();
            panel6 = new Panel();
            lblMostActiveDoctor = new Label();
            lblMostActive = new Label();
            panel7 = new Panel();
            lblNewPatients = new Label();
            lbl = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlCountUser.SuspendLayout();
            pnlCountPatints.SuspendLayout();
            pnlCountDoctors.SuspendLayout();
            pnlCountAppoin.SuspendLayout();
            pnlCard.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.Navy;
            pnlSidebar.Controls.Add(panel2);
            pnlSidebar.Controls.Add(btnAppointments);
            pnlSidebar.Controls.Add(btnPatients);
            pnlSidebar.Controls.Add(btnBills);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnUser);
            pnlSidebar.Controls.Add(btnDoctor);
            pnlSidebar.Controls.Add(lblUser);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(15);
            pnlSidebar.Size = new Size(200, 673);
            pnlSidebar.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(200, 587);
            panel2.Name = "panel2";
            panel2.Size = new Size(1059, 60);
            panel2.TabIndex = 10;
            // 
            // btnAppointments
            // 
            btnAppointments.Dock = DockStyle.Top;
            btnAppointments.FlatAppearance.BorderSize = 0;
            btnAppointments.FlatStyle = FlatStyle.Flat;
            btnAppointments.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            btnAppointments.ForeColor = Color.White;
            btnAppointments.Location = new Point(15, 175);
            btnAppointments.Margin = new Padding(5);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(170, 40);
            btnAppointments.TabIndex = 6;
            btnAppointments.Text = "المواعيد 📅";
            btnAppointments.TextAlign = ContentAlignment.MiddleRight;
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnPatients
            // 
            btnPatients.Dock = DockStyle.Top;
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.FlatStyle = FlatStyle.Flat;
            btnPatients.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            btnPatients.ForeColor = Color.White;
            btnPatients.Location = new Point(15, 135);
            btnPatients.Margin = new Padding(5);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(170, 40);
            btnPatients.TabIndex = 5;
            btnPatients.Text = "ادارة المرضى \U0001f9d1‍⚕️";
            btnPatients.TextAlign = ContentAlignment.MiddleRight;
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnBills
            // 
            btnBills.Dock = DockStyle.Top;
            btnBills.FlatAppearance.BorderSize = 0;
            btnBills.FlatStyle = FlatStyle.Flat;
            btnBills.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            btnBills.ForeColor = Color.White;
            btnBills.Location = new Point(15, 95);
            btnBills.Margin = new Padding(5);
            btnBills.Name = "btnBills";
            btnBills.Padding = new Padding(5);
            btnBills.Size = new Size(170, 40);
            btnBills.TabIndex = 4;
            btnBills.Text = "الفواتير 💰";
            btnBills.TextAlign = ContentAlignment.MiddleRight;
            btnBills.UseVisualStyleBackColor = true;
            btnBills.Click += btnBills_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            btnLogout.ForeColor = Color.LightCoral;
            btnLogout.Location = new Point(15, 629);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(170, 29);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "🔂 تسجيل الخروج";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += button1_Click;
            // 
            // btnUser
            // 
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderColor = Color.Navy;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(15, 55);
            btnUser.Margin = new Padding(5);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(170, 40);
            btnUser.TabIndex = 2;
            btnUser.Text = "ادارة المستخدمين 👥";
            btnUser.TextAlign = ContentAlignment.MiddleRight;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnDoctor
            // 
            btnDoctor.Dock = DockStyle.Top;
            btnDoctor.FlatAppearance.BorderSize = 0;
            btnDoctor.FlatStyle = FlatStyle.Flat;
            btnDoctor.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            btnDoctor.ForeColor = Color.White;
            btnDoctor.Location = new Point(15, 15);
            btnDoctor.Margin = new Padding(5);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(170, 40);
            btnDoctor.TabIndex = 1;
            btnDoctor.Text = "ادارة الاطباء \U0001f9d1‍⚕️";
            btnDoctor.TextAlign = ContentAlignment.MiddleRight;
            btnDoctor.UseVisualStyleBackColor = true;
            btnDoctor.Click += btnDoctor_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(18, 411);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 20);
            lblUser.TabIndex = 0;
            lblUser.Click += lblUser_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.LightGray;
            pnlHeader.Controls.Add(CurrentUser);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(200, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1398, 80);
            pnlHeader.TabIndex = 1;
            // 
            // CurrentUser
            // 
            CurrentUser.AutoSize = true;
            CurrentUser.Dock = DockStyle.Fill;
            CurrentUser.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CurrentUser.Location = new Point(0, 0);
            CurrentUser.Name = "CurrentUser";
            CurrentUser.Size = new Size(0, 31);
            CurrentUser.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(228, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.RightToLeft = RightToLeft.Yes;
            lblWelcome.Size = new Size(0, 31);
            lblWelcome.TabIndex = 0;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCountUser
            // 
            pnlCountUser.BackColor = Color.RoyalBlue;
            pnlCountUser.BackgroundImageLayout = ImageLayout.Center;
            pnlCountUser.BorderStyle = BorderStyle.FixedSingle;
            pnlCountUser.Controls.Add(label3);
            pnlCountUser.Controls.Add(lblUserCount);
            pnlCountUser.Controls.Add(label1);
            pnlCountUser.Dock = DockStyle.Fill;
            pnlCountUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlCountUser.ForeColor = Color.White;
            pnlCountUser.Location = new Point(11, 11);
            pnlCountUser.Margin = new Padding(10);
            pnlCountUser.Name = "pnlCountUser";
            pnlCountUser.Size = new Size(328, 108);
            pnlCountUser.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold);
            label3.ForeColor = Color.LightGray;
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label3.Location = new Point(-1, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 67);
            label3.TabIndex = 6;
            label3.Text = "👥";
            // 
            // lblUserCount
            // 
            lblUserCount.AutoSize = true;
            lblUserCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblUserCount.Location = new Point(104, 52);
            lblUserCount.Name = "lblUserCount";
            lblUserCount.Size = new Size(43, 50);
            lblUserCount.TabIndex = 5;
            lblUserCount.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(110, 13);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 4;
            label1.Text = "عدد المستخدمين";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlCountPatints
            // 
            pnlCountPatints.BackColor = Color.DarkOrange;
            pnlCountPatints.Controls.Add(label9);
            pnlCountPatints.Controls.Add(lblPatientCount);
            pnlCountPatints.Controls.Add(label8);
            pnlCountPatints.Dock = DockStyle.Fill;
            pnlCountPatints.ForeColor = Color.White;
            pnlCountPatints.Location = new Point(709, 11);
            pnlCountPatints.Margin = new Padding(10);
            pnlCountPatints.Name = "pnlCountPatints";
            pnlCountPatints.Size = new Size(328, 108);
            pnlCountPatints.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(99, 67);
            label9.TabIndex = 2;
            label9.Text = "\U0001f9d1‍⚕️";
            // 
            // lblPatientCount
            // 
            lblPatientCount.AutoSize = true;
            lblPatientCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPatientCount.Location = new Point(128, 59);
            lblPatientCount.Name = "lblPatientCount";
            lblPatientCount.Size = new Size(43, 50);
            lblPatientCount.TabIndex = 1;
            lblPatientCount.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(145, 14);
            label8.Name = "label8";
            label8.Size = new Size(96, 23);
            label8.TabIndex = 0;
            label8.Text = "عدد المرضى";
            // 
            // pnlCountDoctors
            // 
            pnlCountDoctors.BackColor = Color.MediumPurple;
            pnlCountDoctors.Controls.Add(lblDoctorCount);
            pnlCountDoctors.Controls.Add(label10);
            pnlCountDoctors.Controls.Add(lblCountDoctors);
            pnlCountDoctors.Dock = DockStyle.Fill;
            pnlCountDoctors.ForeColor = Color.White;
            pnlCountDoctors.Location = new Point(1058, 11);
            pnlCountDoctors.Margin = new Padding(10);
            pnlCountDoctors.Name = "pnlCountDoctors";
            pnlCountDoctors.Size = new Size(329, 108);
            pnlCountDoctors.TabIndex = 3;
            // 
            // lblDoctorCount
            // 
            lblDoctorCount.AutoSize = true;
            lblDoctorCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblDoctorCount.Location = new Point(152, 60);
            lblDoctorCount.Name = "lblDoctorCount";
            lblDoctorCount.Size = new Size(43, 50);
            lblDoctorCount.TabIndex = 2;
            lblDoctorCount.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold);
            label10.ForeColor = Color.LightGray;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(99, 67);
            label10.TabIndex = 1;
            label10.Text = "\U0001f9d1‍⚕️";
            // 
            // lblCountDoctors
            // 
            lblCountDoctors.AutoSize = true;
            lblCountDoctors.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCountDoctors.Location = new Point(152, 14);
            lblCountDoctors.Name = "lblCountDoctors";
            lblCountDoctors.Size = new Size(88, 23);
            lblCountDoctors.TabIndex = 0;
            lblCountDoctors.Text = "عدد الاطباء";
            // 
            // pnlCountAppoin
            // 
            pnlCountAppoin.BackColor = Color.SeaGreen;
            pnlCountAppoin.Controls.Add(lblAppointmentCount);
            pnlCountAppoin.Controls.Add(label6);
            pnlCountAppoin.Controls.Add(label5);
            pnlCountAppoin.Controls.Add(label4);
            pnlCountAppoin.Dock = DockStyle.Fill;
            pnlCountAppoin.ForeColor = Color.White;
            pnlCountAppoin.Location = new Point(360, 11);
            pnlCountAppoin.Margin = new Padding(10);
            pnlCountAppoin.Name = "pnlCountAppoin";
            pnlCountAppoin.Size = new Size(328, 108);
            pnlCountAppoin.TabIndex = 4;
            // 
            // lblAppointmentCount
            // 
            lblAppointmentCount.AutoSize = true;
            lblAppointmentCount.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblAppointmentCount.Location = new Point(119, 53);
            lblAppointmentCount.Name = "lblAppointmentCount";
            lblAppointmentCount.Size = new Size(43, 50);
            lblAppointmentCount.TabIndex = 6;
            lblAppointmentCount.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 67);
            label6.TabIndex = 2;
            label6.Text = "📅";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 127);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(135, 14);
            label4.Name = "label4";
            label4.Size = new Size(106, 23);
            label4.TabIndex = 0;
            label4.Text = "عدد المواعيد ";
            // 
            // pnlCard
            // 
            pnlCard.Controls.Add(tableLayoutPanel1);
            pnlCard.Dock = DockStyle.Top;
            pnlCard.Location = new Point(200, 80);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(1398, 135);
            pnlCard.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(pnlCountDoctors, 3, 0);
            tableLayoutPanel1.Controls.Add(pnlCountAppoin, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlCountUser, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlCountPatints, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1398, 130);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(200, 647);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1398, 26);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "© 2025 نظام إدارة العيادة - جميع الحقوق محفوظة.";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(330, 20);
            toolStripStatusLabel1.Text = "© 2026 نظام إدارة العيادة - جميع الحقوق محفوظة.";
            // 
            // lblAppointmentsTitle
            // 
            lblAppointmentsTitle.AutoSize = true;
            lblAppointmentsTitle.Dock = DockStyle.Top;
            lblAppointmentsTitle.Font = new Font("Goudy Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppointmentsTitle.ForeColor = Color.DarkBlue;
            lblAppointmentsTitle.Location = new Point(0, 0);
            lblAppointmentsTitle.Name = "lblAppointmentsTitle";
            lblAppointmentsTitle.Padding = new Padding(0, 0, 5, 20);
            lblAppointmentsTitle.Size = new Size(200, 47);
            lblAppointmentsTitle.TabIndex = 8;
            lblAppointmentsTitle.Text = "جدول المواعيد القادمة 📅";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvAppointments);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(lblAppointmentsTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 215);
            panel1.Name = "panel1";
            panel1.Size = new Size(1398, 432);
            panel1.TabIndex = 9;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToResizeColumns = false;
            dgvAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 244, 248);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAppointments.Dock = DockStyle.Left;
            dgvAppointments.GridColor = Color.Gainsboro;
            dgvAppointments.Location = new Point(0, 47);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.RowTemplate.Height = 35;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(1054, 325);
            dgvAppointments.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 372);
            panel3.Name = "panel3";
            panel3.Size = new Size(1054, 60);
            panel3.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(btnAddDoctor, 0, 0);
            tableLayoutPanel2.Controls.Add(btnAddAppo, 1, 0);
            tableLayoutPanel2.Controls.Add(btnAddUser, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1054, 60);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAddDoctor
            // 
            btnAddDoctor.BackColor = Color.FromArgb(40, 167, 69);
            btnAddDoctor.Dock = DockStyle.Fill;
            btnAddDoctor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddDoctor.ForeColor = Color.White;
            btnAddDoctor.Location = new Point(3, 3);
            btnAddDoctor.Name = "btnAddDoctor";
            btnAddDoctor.Size = new Size(345, 54);
            btnAddDoctor.TabIndex = 0;
            btnAddDoctor.Text = "اضافة طبيب جديد";
            btnAddDoctor.UseVisualStyleBackColor = false;
            btnAddDoctor.Click += btnAddDoctor_Click;
            // 
            // btnAddAppo
            // 
            btnAddAppo.BackColor = Color.FromArgb(40, 167, 69);
            btnAddAppo.Dock = DockStyle.Fill;
            btnAddAppo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddAppo.ForeColor = Color.White;
            btnAddAppo.Location = new Point(354, 3);
            btnAddAppo.Name = "btnAddAppo";
            btnAddAppo.Size = new Size(345, 54);
            btnAddAppo.TabIndex = 1;
            btnAddAppo.Text = "اضافة موعد جديد";
            btnAddAppo.UseVisualStyleBackColor = false;
            btnAddAppo.Click += btnAddAppo_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(40, 167, 69);
            btnAddUser.Dock = DockStyle.Fill;
            btnAddUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(705, 3);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(346, 54);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "اضافة مستخدم جديد";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel4, 0, 0);
            tableLayoutPanel3.Controls.Add(panel5, 0, 1);
            tableLayoutPanel3.Controls.Add(panel6, 0, 2);
            tableLayoutPanel3.Controls.Add(panel7, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Right;
            tableLayoutPanel3.Location = new Point(1054, 47);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(344, 385);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkOrange;
            panel4.Controls.Add(lblUnpaidBills);
            panel4.Controls.Add(label);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(338, 90);
            panel4.TabIndex = 4;
            // 
            // lblUnpaidBills
            // 
            lblUnpaidBills.AutoSize = true;
            lblUnpaidBills.Font = new Font("Tahoma", 22F, FontStyle.Bold);
            lblUnpaidBills.ForeColor = Color.Transparent;
            lblUnpaidBills.Location = new Point(132, 42);
            lblUnpaidBills.Name = "lblUnpaidBills";
            lblUnpaidBills.Size = new Size(44, 45);
            lblUnpaidBills.TabIndex = 1;
            lblUnpaidBills.Text = "0";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.DarkOrange;
            label.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.ImageAlign = ContentAlignment.BottomCenter;
            label.Location = new Point(71, 2);
            label.Margin = new Padding(2);
            label.Name = "label";
            label.Size = new Size(170, 25);
            label.TabIndex = 0;
            label.Text = "الفواتير الغير مدفوعة";
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Click += lblUnpaidBills_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MediumPurple;
            panel5.Controls.Add(lblCompletionRate);
            panel5.Controls.Add(lblCompletion);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 99);
            panel5.Name = "panel5";
            panel5.Size = new Size(338, 90);
            panel5.TabIndex = 5;
            // 
            // lblCompletionRate
            // 
            lblCompletionRate.AutoSize = true;
            lblCompletionRate.Font = new Font("Tahoma", 22F, FontStyle.Bold);
            lblCompletionRate.ForeColor = Color.Transparent;
            lblCompletionRate.Location = new Point(132, 42);
            lblCompletionRate.Name = "lblCompletionRate";
            lblCompletionRate.Size = new Size(44, 45);
            lblCompletionRate.TabIndex = 2;
            lblCompletionRate.Text = "0";
            // 
            // lblCompletion
            // 
            lblCompletion.AutoSize = true;
            lblCompletion.BackColor = Color.MediumPurple;
            lblCompletion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompletion.ForeColor = Color.White;
            lblCompletion.Location = new Point(120, 0);
            lblCompletion.Name = "lblCompletion";
            lblCompletion.Size = new Size(99, 25);
            lblCompletion.TabIndex = 1;
            lblCompletion.Text = "نسبة الانجاز";
            lblCompletion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.Controls.Add(lblMostActiveDoctor);
            panel6.Controls.Add(lblMostActive);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 195);
            panel6.Name = "panel6";
            panel6.Size = new Size(338, 90);
            panel6.TabIndex = 6;
            // 
            // lblMostActiveDoctor
            // 
            lblMostActiveDoctor.AutoSize = true;
            lblMostActiveDoctor.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            lblMostActiveDoctor.ForeColor = Color.Transparent;
            lblMostActiveDoctor.Location = new Point(120, 52);
            lblMostActiveDoctor.Name = "lblMostActiveDoctor";
            lblMostActiveDoctor.Size = new Size(66, 24);
            lblMostActiveDoctor.TabIndex = 3;
            lblMostActiveDoctor.Text = "name";
            // 
            // lblMostActive
            // 
            lblMostActive.AutoSize = true;
            lblMostActive.BackColor = Color.Teal;
            lblMostActive.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMostActive.ForeColor = Color.White;
            lblMostActive.Location = new Point(101, 0);
            lblMostActive.Name = "lblMostActive";
            lblMostActive.Size = new Size(140, 25);
            lblMostActive.TabIndex = 2;
            lblMostActive.Text = "اكثر طبيب نشاطاَ";
            lblMostActive.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Crimson;
            panel7.Controls.Add(lblNewPatients);
            panel7.Controls.Add(lbl);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 291);
            panel7.Name = "panel7";
            panel7.Size = new Size(338, 91);
            panel7.TabIndex = 7;
            // 
            // lblNewPatients
            // 
            lblNewPatients.AutoSize = true;
            lblNewPatients.Font = new Font("Tahoma", 22F, FontStyle.Bold);
            lblNewPatients.ForeColor = Color.Transparent;
            lblNewPatients.Location = new Point(132, 43);
            lblNewPatients.Name = "lblNewPatients";
            lblNewPatients.Size = new Size(44, 45);
            lblNewPatients.TabIndex = 4;
            lblNewPatients.Text = "0";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Crimson;
            lbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(80, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(183, 25);
            lbl.TabIndex = 3;
            lbl.Text = "مرضى جدد هدا الشهر ";
            lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlConnection1
            // 
            sqlConnection1.AccessTokenCallback = null;
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            sqlConnection1.SspiContextProvider = null;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1598, 673);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(pnlCard);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مرحبا بك في لوحة تحكم المدير ";
            WindowState = FormWindowState.Maximized;
            Load += AdminDashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlCountUser.ResumeLayout(false);
            pnlCountUser.PerformLayout();
            pnlCountPatints.ResumeLayout(false);
            pnlCountPatints.PerformLayout();
            pnlCountDoctors.ResumeLayout(false);
            pnlCountDoctors.PerformLayout();
            pnlCountAppoin.ResumeLayout(false);
            pnlCountAppoin.PerformLayout();
            pnlCard.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnLogout;
        private Button btnUser;
        private Button btnDoctor;
        private Label lblUser;
        private Panel pnlHeader;
        private Label lblWelcome;
        private Panel pnlCountUser;
        private Panel pnlCountPatints;
        private Panel pnlCountDoctors;
        private Panel pnlCountAppoin;
        private Label label1;
        private Label lblUserCount;
        private Button btnAppointments;
        private Button btnPatients;
        private Button btnBills;
        private Panel pnlCard;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblAppointmentCount;
        private Label label8;
        private Label lblPatientCount;
        private Label label9;
        private Label lblCountDoctors;
        private Label label10;
        private Label lblDoctorCount;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Label CurrentUser;
        private Label lblAppointmentsTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgvAppointments;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAddDoctor;
        private Button btnAddAppo;
        private Button btnAddUser;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label;
        private Label lblCompletion;
        private Label lblMostActive;
        private Label lbl;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label lblUnpaidBills;
        private Label lblCompletionRate;
        private Label lblMostActiveDoctor;
        private Label lblNewPatients;
    }
}