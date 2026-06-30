namespace ClinicMangementSystem.PL
{
    partial class UsersForm
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
            panelSearch = new Panel();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            panelGrid = new Panel();
            dgvUsers = new DataGridView();
            panelActions = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            panelSearch.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panelActions.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.WhiteSmoke;
            panelSearch.Controls.Add(btnRefresh);
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(label1);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1262, 60);
            panelSearch.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(253, 126, 20);
            btnRefresh.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1158, 19);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 38);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "تحديث ";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(88, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "اكتب اسم المستخدم";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(23, 162, 184);
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 25);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Padding = new Padding(4);
            label1.Size = new Size(76, 29);
            label1.TabIndex = 0;
            label1.Text = "بحث 🔍";
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dgvUsers);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 60);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1262, 613);
            panelGrid.TabIndex = 2;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(242, 244, 248);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle8.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle9;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.GridColor = Color.Gainsboro;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 35;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1262, 613);
            dgvUsers.TabIndex = 9;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
            // 
            // panelActions
            // 
            panelActions.BackColor = SystemColors.ControlLight;
            panelActions.Controls.Add(tableLayoutPanel1);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(0, 553);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(1262, 120);
            panelActions.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.5974655F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.96355F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDelete, 1, 0);
            tableLayoutPanel1.Controls.Add(btnEdit, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
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
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(5, 5);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(414, 110);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "اضافة ➕";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(428, 4);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(408, 112);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "حذف 🗑️";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 123, 239);
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(844, 4);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(414, 112);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "تعديل ✏️";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelActions);
            Controls.Add(panelGrid);
            Controls.Add(panelSearch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ادارة المستخدمين";
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panelActions.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelSearch;
        private Panel panelGrid;
        private Panel panelActions;
        private Label label1;
        private TextBox txtSearch;
        private Button btnRefresh;
        private DataGridView dgvUsers;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
    }
}