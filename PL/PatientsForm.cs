using ClinicMangementSystem.BL;   // لأن اسم المجلد BL
using ClinicMangementSystem.Models;
using ClinicMangementSystem.BL;
using ClinicMangementSystem.Models;
using ClinicMangementSystem.PL;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClinicMangementSystem.PL
{
    public partial class PatientsForm : Form
    {
        private PatientBL patientBL = new PatientBL();
        private int currentPatientID = 0;

        public PatientsForm()
        {
            InitializeComponent();
            LoadAllPatients();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void LoadAllPatients()
        {
            DataTable dt = patientBL.GetAllPatients();
            dgvPatients.DataSource = dt;
            dgvPatients.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        // حدث تحديد صف في الجدول
        private void dgvPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                currentPatientID = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["PatientID"].Value);
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
            using (PatientEntryForm entryForm = new PatientEntryForm(null))
            {
                if (entryForm.ShowDialog() == DialogResult.OK)
                    LoadAllPatients();
            }
        }

        // زر التعديل
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentPatientID == 0)
            {
                MessageBox.Show("الرجاء تحديد مريض.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = patientBL.GetPatientById(currentPatientID);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                PatientModel patient = new PatientModel
                {
                    PatientID = Convert.ToInt32(row["PatientID"]),
                    FullName = row["FullName"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Gender = row["Gender"].ToString(),
                    BirthDate = Convert.ToDateTime(row["BirthDate"]),
                    Address = row["Address"].ToString()
                };

                using (PatientEntryForm entryForm = new PatientEntryForm(patient))
                {
                    if (entryForm.ShowDialog() == DialogResult.OK)
                        LoadAllPatients();
                }
            }
        }

        // زر الحذف
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentPatientID == 0)
            {
                MessageBox.Show("الرجاء تحديد مريض.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                patientBL.DeletePatient(currentPatientID);
                MessageBox.Show("تم الحذف.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllPatients();
            }
        }

        // زر البحث
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
                LoadAllPatients();
            else
            {
                DataTable dt = patientBL.SearchPatients(keyword);
                dgvPatients.DataSource = dt;
                if (dt.Rows.Count == 0)
                    MessageBox.Show("لا توجد نتائج.", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // زر التحديث
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllPatients();
            txtSearch.Clear();
        }
    }
}