using ClinicMangementSystem.BL;
using ClinicMangementSystem.Models;
using ClinicMangementSystem.BL;
using ClinicMangementSystem.Models;
using System;
using System.Windows.Forms;

namespace ClinicMangementSystem.PL
{
    public partial class PatientEntryForm : Form
    {
        private PatientBL patientBL = new PatientBL();
        private PatientModel currentPatient = null;

        // منشئ الإضافة
        public PatientEntryForm()
        {
            InitializeComponent();
            lblTitle.Text = "➕ إضافة مريض جديد";
        }

        // منشئ التعديل
        public PatientEntryForm(PatientModel patientToEdit) : this()
        {
            if (patientToEdit != null)
            {
                currentPatient = patientToEdit;
                lblTitle.Text = "✏️ تعديل مريض";
                txtFullName.Text = patientToEdit.FullName;
                txtPhone.Text = patientToEdit.Phone;
                cmbGender.Text = patientToEdit.Gender;
                dtpBirthDate.Value = patientToEdit.BirthDate;
                txtAddress.Text = patientToEdit.Address;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // التحقق من الحقول الأساسية
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(cmbGender.Text))
            {
                MessageBox.Show("الرجاء ملء الحقول الأساسية (الاسم، الهاتف، الجنس).", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PatientModel patient = new PatientModel
            {
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Gender = cmbGender.Text,
                BirthDate = dtpBirthDate.Value,
                Address = txtAddress.Text.Trim()
            };

            try
            {
                if (currentPatient != null) // تعديل
                {
                    patient.PatientID = currentPatient.PatientID;
                    patientBL.UpdatePatient(patient);
                    MessageBox.Show("تم التعديل بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // إضافة
                {
                    patientBL.AddPatient(patient);
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
    }
}