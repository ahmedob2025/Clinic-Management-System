namespace ClinicMangementSystem.PL
{
    partial class BillsForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            dgvBills = new DataGridView();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnUpdatePayment = new Button();
            btnPrint = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 60);
            panel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(253, 126, 20);
            btnRefresh.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(820, 16);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 38);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "تحديث";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(23, 162, 184);
            btnSearch.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(12, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 38);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(118, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "بحث ";
            txtSearch.Size = new Size(154, 27);
            txtSearch.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvBills);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 443);
            panel2.TabIndex = 1;
            // 
            // dgvBills
            // 
            dgvBills.AllowUserToAddRows = false;
            dgvBills.AllowUserToResizeColumns = false;
            dgvBills.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(242, 244, 248);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dgvBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBills.BackgroundColor = Color.White;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle8.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvBills.DefaultCellStyle = dataGridViewCellStyle9;
            dgvBills.Dock = DockStyle.Fill;
            dgvBills.GridColor = Color.Gainsboro;
            dgvBills.Location = new Point(0, 0);
            dgvBills.Name = "dgvBills";
            dgvBills.ReadOnly = true;
            dgvBills.RowHeadersVisible = false;
            dgvBills.RowHeadersWidth = 51;
            dgvBills.RowTemplate.Height = 35;
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.Size = new Size(932, 443);
            dgvBills.TabIndex = 9;
            dgvBills.SelectionChanged += dgvBills_SelectionChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 383);
            panel3.Name = "panel3";
            panel3.Size = new Size(932, 120);
            panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnUpdatePayment, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPrint, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(932, 120);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnUpdatePayment
            // 
            btnUpdatePayment.BackColor = Color.FromArgb(253, 126, 20);
            btnUpdatePayment.Dock = DockStyle.Fill;
            btnUpdatePayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdatePayment.ForeColor = Color.White;
            btnUpdatePayment.Location = new Point(3, 3);
            btnUpdatePayment.Name = "btnUpdatePayment";
            btnUpdatePayment.Size = new Size(304, 114);
            btnUpdatePayment.TabIndex = 0;
            btnUpdatePayment.Text = "تحديث حالة الدفع ";
            btnUpdatePayment.UseVisualStyleBackColor = false;
            btnUpdatePayment.Click += btnUpdatePayment_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(111, 66, 193);
            btnPrint.Dock = DockStyle.Fill;
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(623, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(306, 114);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "طباعة 🖨️";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // BillsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 503);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BillsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ادارة الفواتير ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvBills;
        private Button btnUpdatePayment;
        private Button btnPrint;
    }
}