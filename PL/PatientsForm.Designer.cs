namespace ClinicMangementSystem.PL
{
    partial class PatientsForm
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
            panel1 = new Panel();
            btnRefresh = new Button();
            button1 = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            dgvPatients = new DataGridView();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(button1);
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
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(829, 16);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 38);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "تحديث ♻️";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 162, 184);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 19);
            button1.Name = "button1";
            button1.Size = new Size(100, 38);
            button1.TabIndex = 1;
            button1.Text = "بحث 🔍";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(109, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "ابحث عن مريض ";
            txtSearch.Size = new Size(167, 27);
            txtSearch.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvPatients);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 443);
            panel2.TabIndex = 1;
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToResizeColumns = false;
            dgvPatients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(242, 244, 248);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPatients.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPatients.Dock = DockStyle.Fill;
            dgvPatients.GridColor = Color.Gainsboro;
            dgvPatients.Location = new Point(0, 0);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.RowTemplate.Height = 35;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(932, 443);
            dgvPatients.TabIndex = 9;
            dgvPatients.SelectionChanged += dgvPatients_SelectionChanged;
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
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanel1.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(932, 120);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(3);
            btnAdd.Size = new Size(310, 120);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "اضافة ➕";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 123, 255);
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(313, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(304, 114);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "تعديل ✏️";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(623, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(306, 114);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "حذف 🗑️";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // PatientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 503);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PatientsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ادارة المرضى";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtSearch;
        private Button btnRefresh;
        private Button button1;
        private DataGridView dgvPatients;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}