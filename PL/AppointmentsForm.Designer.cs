namespace ClinicMangementSystem.PL
{
    partial class AppointmentsForm
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
            panel1 = new Panel();
            button2 = new Button();
            btnRefrech = new Button();
            txtSearch = new TextBox();
            panel2 = new Panel();
            dgvAppointments = new DataGridView();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnRefrech);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 80);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(23, 162, 184);
            button2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 22);
            button2.Name = "button2";
            button2.Size = new Size(100, 38);
            button2.TabIndex = 2;
            button2.Text = "بحث 🔍";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSearch_Click;
            // 
            // btnRefrech
            // 
            btnRefrech.BackColor = Color.FromArgb(253, 126, 20);
            btnRefrech.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefrech.ForeColor = Color.White;
            btnRefrech.Location = new Point(870, 22);
            btnRefrech.Name = "btnRefrech";
            btnRefrech.Size = new Size(100, 38);
            btnRefrech.TabIndex = 1;
            btnRefrech.Text = "تحديث ♻️";
            btnRefrech.UseVisualStyleBackColor = false;
            btnRefrech.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(100, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "ابحث عن مريض / طبيب ";
            txtSearch.Size = new Size(172, 27);
            txtSearch.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvAppointments);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 473);
            panel2.TabIndex = 1;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToResizeColumns = false;
            dgvAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(242, 244, 248);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle5.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(26, 43, 76);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvAppointments.DefaultCellStyle = dataGridViewCellStyle6;
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.GridColor = Color.Gainsboro;
            dgvAppointments.Location = new Point(0, 0);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersVisible = false;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.RowTemplate.Height = 35;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(982, 473);
            dgvAppointments.TabIndex = 9;
            dgvAppointments.SelectionChanged += dgvAppointments_SelectionChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 433);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 120);
            panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDelete, 1, 0);
            tableLayoutPanel1.Controls.Add(btnEdit, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(982, 120);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(40, 167, 69);
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(321, 114);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "اضافة ➕";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(220, 53, 69);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(330, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(321, 114);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "حذف 🗑️";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(0, 123, 239);
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(657, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(322, 114);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "تعديل ✏️";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // AppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AppointmentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ادارة المواعيد ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button btnRefrech;
        private TextBox txtSearch;
        private Panel panel2;
        private DataGridView dgvAppointments;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
    }
}