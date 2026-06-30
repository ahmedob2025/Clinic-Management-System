namespace ClinicMangementSystem.PL
{
    partial class DoctorsForm
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
            pnlHeader = new Panel();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            dgvDoctors = new DataGridView();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            pnlHeader.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnRefresh);
            pnlHeader.Controls.Add(btnSearch);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1262, 60);
            pnlHeader.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(253, 126, 20);
            btnRefresh.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1150, 16);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 38);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "تحديث ♻️";
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
            btnSearch.Text = "بحث 🔍";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(107, 23);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "ابحث عن طبيب ...";
            txtSearch.Size = new Size(184, 27);
            txtSearch.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDoctors);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(1262, 613);
            panel2.TabIndex = 1;
            // 
            // dgvDoctors
            // 
            dgvDoctors.AllowUserToAddRows = false;
            dgvDoctors.AllowUserToResizeColumns = false;
            dgvDoctors.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(242, 244, 248);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dgvDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctors.BackgroundColor = Color.White;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle8.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvDoctors.DefaultCellStyle = dataGridViewCellStyle9;
            dgvDoctors.Dock = DockStyle.Fill;
            dgvDoctors.GridColor = Color.Gainsboro;
            dgvDoctors.Location = new Point(0, 0);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.RowHeadersVisible = false;
            dgvDoctors.RowHeadersWidth = 51;
            dgvDoctors.RowTemplate.Height = 35;
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.Size = new Size(1262, 613);
            dgvDoctors.TabIndex = 9;
            dgvDoctors.SelectionChanged += dgvDoctors_SelectionChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 553);
            panel3.Name = "panel3";
            panel3.Size = new Size(1262, 120);
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
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1262, 120);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(2);
            btnAdd.Size = new Size(420, 120);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "اضافة ➕";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 123, 239);
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(420, 0);
            btnEdit.Margin = new Padding(0);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(2);
            btnEdit.Size = new Size(420, 120);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "تعديل ✏️";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(840, 0);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(2);
            btnDelete.Size = new Size(422, 120);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "حذف 🗑️";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // DoctorsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "DoctorsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorsForm";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtSearch;
        private Button btnRefresh;
        private Button btnSearch;
        private DataGridView dgvDoctors;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}