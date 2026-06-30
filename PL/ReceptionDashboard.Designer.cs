namespace ClinicMangementSystem.PL
{
    partial class ReceptionDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelSidebar = new Panel();
            btnLogout = new Button();
            btnBills = new Button();
            btnAppointments = new Button();
            btnPatients = new Button();
            panelHeader = new Panel();
            lblWelcome = new Label();
            panelCards = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            cardPatients = new Panel();
            lblPatientsTitle = new Label();
            lblTotalePatients = new Label();
            cardBills = new Panel();
            lblBillsTotale = new Label();
            lblTotaleBills = new Label();
            label2 = new Label();
            cardAppointments = new Panel();
            lblTodayAppointments = new Label();
            lblAppointsTotale = new Label();
            panelGrid = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            dgvTodayAppointments = new DataGridView();
            lblGridTitle = new Label();
            panelSidebar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelCards.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            cardPatients.SuspendLayout();
            cardBills.SuspendLayout();
            cardAppointments.SuspendLayout();
            panelGrid.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodayAppointments).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.Navy;
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnBills);
            panelSidebar.Controls.Add(btnAppointments);
            panelSidebar.Controls.Add(btnPatients);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.ForeColor = SystemColors.Menu;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(256, 673);
            panelSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            btnLogout.ForeColor = Color.LightCoral;
            btnLogout.Location = new Point(0, 623);
            btnLogout.Margin = new Padding(10, 50, 0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(256, 50);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "تسجيل الخروج 🚪";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBills
            // 
            btnBills.Dock = DockStyle.Top;
            btnBills.FlatAppearance.BorderSize = 0;
            btnBills.FlatStyle = FlatStyle.Flat;
            btnBills.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            btnBills.Location = new Point(0, 120);
            btnBills.Name = "btnBills";
            btnBills.Padding = new Padding(65, 0, 0, 0);
            btnBills.Size = new Size(256, 50);
            btnBills.TabIndex = 2;
            btnBills.Text = "الفواتير 💰";
            btnBills.TextAlign = ContentAlignment.MiddleLeft;
            btnBills.UseVisualStyleBackColor = true;
            btnBills.Click += btnBills_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.Dock = DockStyle.Top;
            btnAppointments.FlatAppearance.BorderSize = 0;
            btnAppointments.FlatStyle = FlatStyle.Flat;
            btnAppointments.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold);
            btnAppointments.ForeColor = Color.White;
            btnAppointments.Location = new Point(0, 70);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Padding = new Padding(20, 0, 0, 0);
            btnAppointments.Size = new Size(256, 50);
            btnAppointments.TabIndex = 1;
            btnAppointments.Text = "ادارة المواعيد 📅";
            btnAppointments.TextAlign = ContentAlignment.MiddleLeft;
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnPatients
            // 
            btnPatients.Dock = DockStyle.Top;
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.FlatStyle = FlatStyle.Flat;
            btnPatients.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPatients.ForeColor = Color.White;
            btnPatients.Location = new Point(0, 0);
            btnPatients.Name = "btnPatients";
            btnPatients.Padding = new Padding(20, 0, 0, 0);
            btnPatients.Size = new Size(256, 70);
            btnPatients.TabIndex = 0;
            btnPatients.Text = "ادارة المرضى \U0001f9d1‍⚕️";
            btnPatients.TextAlign = ContentAlignment.MiddleLeft;
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.WhiteSmoke;
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(256, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(987, 70);
            panelHeader.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Simple Bold Jut Out", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            lblWelcome.ForeColor = Color.FromArgb(26, 43, 76);
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Padding = new Padding(30, 0, 0, 0);
            lblWelcome.Size = new Size(987, 70);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCards
            // 
            panelCards.BackColor = Color.White;
            panelCards.Controls.Add(tableLayoutPanel1);
            panelCards.Dock = DockStyle.Top;
            panelCards.Location = new Point(256, 70);
            panelCards.Name = "panelCards";
            panelCards.Size = new Size(987, 230);
            panelCards.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(cardPatients, 0, 0);
            tableLayoutPanel1.Controls.Add(cardBills, 1, 0);
            tableLayoutPanel1.Controls.Add(cardAppointments, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(987, 230);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cardPatients
            // 
            cardPatients.BackColor = Color.FromArgb(227, 242, 253);
            cardPatients.BorderStyle = BorderStyle.FixedSingle;
            cardPatients.Controls.Add(lblPatientsTitle);
            cardPatients.Controls.Add(lblTotalePatients);
            cardPatients.Dock = DockStyle.Fill;
            cardPatients.Location = new Point(11, 11);
            cardPatients.Margin = new Padding(10);
            cardPatients.Name = "cardPatients";
            cardPatients.Size = new Size(307, 208);
            cardPatients.TabIndex = 0;
            cardPatients.Paint += cardPatients_Paint;
            // 
            // lblPatientsTitle
            // 
            lblPatientsTitle.AutoSize = true;
            lblPatientsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPatientsTitle.ForeColor = Color.Gray;
            lblPatientsTitle.Location = new Point(56, 51);
            lblPatientsTitle.Name = "lblPatientsTitle";
            lblPatientsTitle.Size = new Size(232, 37);
            lblPatientsTitle.TabIndex = 1;
            lblPatientsTitle.Text = "اجمالي مرضى اليوم";
            lblPatientsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalePatients
            // 
            lblTotalePatients.AutoSize = true;
            lblTotalePatients.Dock = DockStyle.Bottom;
            lblTotalePatients.Font = new Font("Cooper Black", 19.8000011F);
            lblTotalePatients.ForeColor = Color.FromArgb(26, 43, 76);
            lblTotalePatients.Location = new Point(0, 167);
            lblTotalePatients.Name = "lblTotalePatients";
            lblTotalePatients.Size = new Size(37, 39);
            lblTotalePatients.TabIndex = 0;
            lblTotalePatients.Text = "0";
            lblTotalePatients.TextAlign = ContentAlignment.MiddleCenter;
            lblTotalePatients.Click += lblTotalePatients_Click;
            // 
            // cardBills
            // 
            cardBills.BackColor = Color.FromArgb(255, 248, 225);
            cardBills.BorderStyle = BorderStyle.FixedSingle;
            cardBills.Controls.Add(lblBillsTotale);
            cardBills.Controls.Add(lblTotaleBills);
            cardBills.Controls.Add(label2);
            cardBills.Dock = DockStyle.Fill;
            cardBills.Location = new Point(339, 11);
            cardBills.Margin = new Padding(10);
            cardBills.Name = "cardBills";
            cardBills.Size = new Size(307, 208);
            cardBills.TabIndex = 3;
            // 
            // lblBillsTotale
            // 
            lblBillsTotale.AutoSize = true;
            lblBillsTotale.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBillsTotale.ForeColor = Color.Gray;
            lblBillsTotale.Location = new Point(185, 50);
            lblBillsTotale.Name = "lblBillsTotale";
            lblBillsTotale.Size = new Size(106, 38);
            lblBillsTotale.TabIndex = 4;
            lblBillsTotale.Text = "الفواتير ";
            // 
            // lblTotaleBills
            // 
            lblTotaleBills.AutoSize = true;
            lblTotaleBills.Dock = DockStyle.Bottom;
            lblTotaleBills.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotaleBills.ForeColor = Color.FromArgb(26, 43, 76);
            lblTotaleBills.Location = new Point(0, 167);
            lblTotaleBills.Name = "lblTotaleBills";
            lblTotaleBills.Size = new Size(37, 39);
            lblTotaleBills.TabIndex = 3;
            lblTotaleBills.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 39);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            // 
            // cardAppointments
            // 
            cardAppointments.BackColor = Color.FromArgb(232, 245, 233);
            cardAppointments.BorderStyle = BorderStyle.FixedSingle;
            cardAppointments.Controls.Add(lblTodayAppointments);
            cardAppointments.Controls.Add(lblAppointsTotale);
            cardAppointments.Dock = DockStyle.Fill;
            cardAppointments.Location = new Point(667, 11);
            cardAppointments.Margin = new Padding(10);
            cardAppointments.Name = "cardAppointments";
            cardAppointments.Size = new Size(309, 208);
            cardAppointments.TabIndex = 4;
            // 
            // lblTodayAppointments
            // 
            lblTodayAppointments.AutoSize = true;
            lblTodayAppointments.Dock = DockStyle.Bottom;
            lblTodayAppointments.Font = new Font("Cooper Black", 19.8000011F);
            lblTodayAppointments.Location = new Point(0, 167);
            lblTodayAppointments.Name = "lblTodayAppointments";
            lblTodayAppointments.Size = new Size(37, 39);
            lblTodayAppointments.TabIndex = 1;
            lblTodayAppointments.Text = "0";
            // 
            // lblAppointsTotale
            // 
            lblAppointsTotale.AutoSize = true;
            lblAppointsTotale.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppointsTotale.ForeColor = Color.Gray;
            lblAppointsTotale.Location = new Point(134, 51);
            lblAppointsTotale.Name = "lblAppointsTotale";
            lblAppointsTotale.Size = new Size(156, 38);
            lblAppointsTotale.TabIndex = 0;
            lblAppointsTotale.Text = "مواعيد اليوم";
            lblAppointsTotale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.White;
            panelGrid.Controls.Add(statusStrip1);
            panelGrid.Controls.Add(dgvTodayAppointments);
            panelGrid.Controls.Add(lblGridTitle);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(256, 300);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(987, 373);
            panelGrid.TabIndex = 3;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 347);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(987, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "© 2025 نظام إدارة العيادة - جميع الحقوق محفوظة.";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(972, 20);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "© 2025 نظام إدارة العيادة - جميع الحقوق محفوظة.";
            // 
            // dgvTodayAppointments
            // 
            dgvTodayAppointments.AllowUserToAddRows = false;
            dgvTodayAppointments.AllowUserToResizeColumns = false;
            dgvTodayAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(242, 244, 248);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvTodayAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTodayAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodayAppointments.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvTodayAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTodayAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvTodayAppointments.DefaultCellStyle = dataGridViewCellStyle6;
            dgvTodayAppointments.Dock = DockStyle.Fill;
            dgvTodayAppointments.GridColor = Color.Gainsboro;
            dgvTodayAppointments.Location = new Point(0, 48);
            dgvTodayAppointments.Name = "dgvTodayAppointments";
            dgvTodayAppointments.ReadOnly = true;
            dgvTodayAppointments.RowHeadersVisible = false;
            dgvTodayAppointments.RowHeadersWidth = 51;
            dgvTodayAppointments.RowTemplate.Height = 35;
            dgvTodayAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTodayAppointments.Size = new Size(987, 325);
            dgvTodayAppointments.TabIndex = 9;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGridTitle.ForeColor = Color.FromArgb(26, 43, 76);
            lblGridTitle.Location = new Point(0, 0);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Padding = new Padding(0, 0, 5, 20);
            lblGridTitle.Size = new Size(120, 48);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "مواعيد اليوم";
            lblGridTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReceptionDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 673);
            Controls.Add(panelGrid);
            Controls.Add(panelCards);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ReceptionDashboard";
            Text = "لوحة تحكم الاستقبال";
            panelSidebar.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelCards.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            cardPatients.ResumeLayout(false);
            cardPatients.PerformLayout();
            cardBills.ResumeLayout(false);
            cardBills.PerformLayout();
            cardAppointments.ResumeLayout(false);
            cardAppointments.PerformLayout();
            panelGrid.ResumeLayout(false);
            panelGrid.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodayAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelHeader;
        private Panel panelCards;
        private Button btnPatients;
        private Button btnBills;
        private Button btnAppointments;
        private Button btnLogout;
        private Label lblWelcome;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel cardPatients;
        private Panel cardBills;
        private Panel cardAppointments;
        private Label lblTotalePatients;
        private Label label2;
        private Label lblAppointsTotale;
        private Label lblPatientsTitle;
        private Label lblBillsTotale;
        private Label lblTotaleBills;
        private Label lblTodayAppointments;
        private Panel panelGrid;
        private Label lblGridTitle;
        private StatusStrip statusStrip1;
        private DataGridView dgvTodayAppointments;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}