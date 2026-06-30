using ClinicMangementSystem.Models;
using ClinicMangementSystem.PL;
using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using ClinicMangementSystem.BL;

namespace ClinicMangementSystem.PL
{
    public partial class DoctorsForm : Form
    {
        private DoctorBL doctorBL = new DoctorBL();
        private int currentDoctorID = 0;

        public DoctorsForm()
        {

            InitializeComponent();
            LoadAllDoctors();
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        public void LoadAllDoctors()
        {
            DataTable dt = doctorBL.GetAllDoctors();
            dgvDoctors.DataSource = dt;
            dgvDoctors.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvDoctors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count > 0)
            {
                currentDoctorID = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells["DoctorID"].Value);
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (DoctorEntryForm entryForm = new DoctorEntryForm(null))
            {
                if (entryForm.ShowDialog() == DialogResult.OK)
                    LoadAllDoctors();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentDoctorID == 0)
            {
                MessageBox.Show("الرجاء تحديد طبيب.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = doctorBL.GetDoctorById(currentDoctorID);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                DoctorModel doctor = new DoctorModel
                {
                    DoctorID = Convert.ToInt32(row["DoctorID"]),
                    FullName = row["FullName"].ToString(),
                    Specialization = row["Specialization"].ToString(),
                    phone = row["Phone"].ToString(),
                    ConsultationFee = Convert.ToDecimal(row["ConsultationFee"])
                };

                using (DoctorEntryForm entryForm = new DoctorEntryForm(doctor))
                {
                    if (entryForm.ShowDialog() == DialogResult.OK)
                        LoadAllDoctors();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentDoctorID == 0)
            {
                MessageBox.Show("الرجاء تحديد طبيب.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("هل أنت متأكد من الحذف؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                doctorBL.DeleteDoctor(currentDoctorID);
                MessageBox.Show("تم الحذف.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllDoctors();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
                LoadAllDoctors();
            else
            {
                DataTable dt = doctorBL.SearchDoctors(keyword);
                dgvDoctors.DataSource = dt;
                if (dt.Rows.Count == 0)
                    MessageBox.Show("لا توجد نتائج.", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllDoctors();
            txtSearch.Clear();
        }
    }
}