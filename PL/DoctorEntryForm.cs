using ClinicMangementSystem.Models;
using System;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using ClinicMangementSystem.BL;
namespace ClinicMangementSystem.PL
{
    public partial class DoctorEntryForm : Form
    {
        private DoctorBL doctorBL = new DoctorBL();
        private DoctorModel currentDoctor = null;

        // منشئ الإضافة
        public DoctorEntryForm()
        {
            InitializeComponent();
            lblTitle.Text = "➕ إضافة طبيب جديد";
        }

        // منشئ التعديل
        public DoctorEntryForm(DoctorModel doctorToEdit)
        {
            InitializeComponent();
            if (doctorToEdit != null)
            {
                currentDoctor = doctorToEdit;
                txtFullName.Text = doctorToEdit.FullName;
                txtSpecialization.Text = doctorToEdit.Specialization;
                txtPhone.Text = doctorToEdit.phone;
                txtFee.Text = doctorToEdit.ConsultationFee.ToString();
            }
            else
            {
                lblTitle.Text = "➕ إضافة طبيب جديد";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtSpecialization.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtFee.Text))
            {
                MessageBox.Show("الرجاء ملء جميع الحقول.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // التحقق من أن رسوم الكشف رقم صحيح
            if (!decimal.TryParse(txtFee.Text, out decimal fee )|| fee <= 0)
            {
                MessageBox.Show("يرجى إدخال رسوم كشف صحيحة (رقم).", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DoctorModel doctor = new DoctorModel
            {
                FullName = txtFullName.Text.Trim(),
                Specialization = txtSpecialization.Text.Trim(),
                phone = txtPhone.Text.Trim(),
                ConsultationFee = fee
            };

            try
            {
                if (currentDoctor != null) // تعديل
                {
                    doctor.DoctorID = currentDoctor.DoctorID;
                    doctorBL.UpdateDoctor(doctor);
                    MessageBox.Show("تم التعديل بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // إضافة
                {
                    doctorBL.AddDoctor(doctor);
                    MessageBox.Show("تمت الإضافة بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtFee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}