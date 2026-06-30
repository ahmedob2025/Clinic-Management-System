using ClinicMangementSystem.BL;
using ClinicMangementSystem.Models;
using ClinicMangementSystem.PL;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClinicMangementSystem.PL
{
    public partial class AppointmentsForm : Form
    {
        private AppointmentBL appBL = new AppointmentBL();
        private int currentAppointmentID = 0;

        public AppointmentsForm()
        {
            InitializeComponent();
            LoadAllAppointments();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadAllAppointments()
        {
            DataTable dt = appBL.GetAllAppointments();
            dgvAppointments.DataSource = dt;
            FormatAppointmentGrid(dgvAppointments); // تنسيق الجدول
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        // دالة تنسيق الجدول (تظهر الأسماء بدلاً من الأرقام)
        private void FormatAppointmentGrid(DataGridView dgv)
        {
            if (dgv.Columns["AppointmentID"] != null)
                dgv.Columns["AppointmentID"].Visible = false;

            if (dgv.Columns["PatientName"] != null)
            {
                dgv.Columns["PatientName"].HeaderText = "المريض";
                dgv.Columns["PatientName"].FillWeight = 25;
            }
            if (dgv.Columns["DoctorName"] != null)
            {
                dgv.Columns["DoctorName"].HeaderText = "الطبيب";
                dgv.Columns["DoctorName"].FillWeight = 25;
            }
            if (dgv.Columns["AppointmentDate"] != null)
            {
                dgv.Columns["AppointmentDate"].HeaderText = "التاريخ";
                dgv.Columns["AppointmentDate"].FillWeight = 15;
                dgv.Columns["AppointmentDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
            if (dgv.Columns["AppointmentTime"] != null)
            {
                dgv.Columns["AppointmentTime"].HeaderText = "الوقت";
                dgv.Columns["AppointmentTime"].FillWeight = 15;
                dgv.Columns["AppointmentTime"].DefaultCellStyle.Format = "hh\\:mm";
            }
            if (dgv.Columns["Status"] != null)
            {
                dgv.Columns["Status"].HeaderText = "الحالة";
                dgv.Columns["Status"].FillWeight = 20;
            }

            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dgv.RowTemplate.Height = 35;
            dgv.AllowUserToAddRows = false;
        }

        // حدث تحديد الصف
        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                currentAppointmentID = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["AppointmentID"].Value);
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        // زر الإضافة
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AppointmentEntryForm entryForm = new AppointmentEntryForm(null))
            {
                if (entryForm.ShowDialog() == DialogResult.OK)
                    LoadAllAppointments();
            }
        }

        // زر التعديل
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentAppointmentID == 0)
            {
                MessageBox.Show("الرجاء تحديد موعد.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = appBL.GetAppointmentById(currentAppointmentID);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                AppointmentModel app = new AppointmentModel
                {
                    AppointmentID = Convert.ToInt32(row["AppointmentID"]),
                    PatientID = Convert.ToInt32(row["PatientID"]),
                    DoctorID = Convert.ToInt32(row["DoctorID"]),
                    AppointmentDate = Convert.ToDateTime(row["AppointmentDate"]),
                    AppointmentTime = TimeSpan.Parse(row["AppointmentTime"].ToString()),
                    Status = row["Status"].ToString()
                };

                using (AppointmentEntryForm entryForm = new AppointmentEntryForm(app))
                {
                    if (entryForm.ShowDialog() == DialogResult.OK)
                        LoadAllAppointments();
                }
            }
        }

        // زر الحذف
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentAppointmentID == 0)
            {
                MessageBox.Show("الرجاء تحديد موعد.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                appBL.DeleteAppointment(currentAppointmentID);
                MessageBox.Show("تم الحذف.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllAppointments();
            }
        }

        // زر البحث
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
                LoadAllAppointments();
            else
            {
                DataTable dt = appBL.SearchAppointments(keyword);
                dgvAppointments.DataSource = dt;
                FormatAppointmentGrid(dgvAppointments);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("لا توجد نتائج.", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // زر التحديث
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllAppointments();
            txtSearch.Clear();
        }
    }
}