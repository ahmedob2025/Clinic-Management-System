using ClinicMangementSystem.BL;
using ClinicMangementSystem.Models;

using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClinicMangementSystem.PL
{
    public partial class AppointmentEntryForm : Form
    {
        private AppointmentBL appBL = new AppointmentBL();
        private PatientBL patientBL = new PatientBL();
        private DoctorBL doctorBL = new DoctorBL();
        private AppointmentModel currentAppointment = null;

         // constractore
        public AppointmentEntryForm()
        {
            InitializeComponent();
            lblTitle.Text = "📅 إضافة موعد جديد";
            LoadComboBoxes();
        }

        // منشئ التعديل
        public AppointmentEntryForm(AppointmentModel appointmentToEdit) : this()
        {
            if (appointmentToEdit != null)
            {
                currentAppointment = appointmentToEdit;
                lblTitle.Text = "✏️ تعديل موعد";
                cmbPatients.SelectedValue = appointmentToEdit.PatientID;
                cmbDoctors.SelectedValue = appointmentToEdit.DoctorID;
                dtpDate.Value = appointmentToEdit.AppointmentDate;
                dtpTime.Value = DateTime.Today.Add(appointmentToEdit.AppointmentTime);
                cmbStatus.Text = appointmentToEdit.Status;
            }
        }

        // دالة لملء ComboBoxes بالمرضى والأطباء
        private void LoadComboBoxes()
        {
            // 1. ملء المرضى (DisplayMember = FullName, ValueMember = PatientID)
            DataTable patients = patientBL.GetAllPatients();
            cmbPatients.DataSource = patients;
            cmbPatients.DisplayMember = "FullName";
            cmbPatients.ValueMember = "PatientID";

            // 2. ملء الأطباء (DisplayMember = FullName, ValueMember = DoctorID)
            DataTable doctors = doctorBL.GetAllDoctors();
            cmbDoctors.DataSource = doctors;
            cmbDoctors.DisplayMember = "FullName";
            cmbDoctors.ValueMember = "DoctorID";

            // 3. تعيين الحالة الافتراضية للإضافة
            if (currentAppointment == null)
                cmbStatus.SelectedIndex = 0; // Scheduled
        }

        // زر الحفظ
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. التحقق من اختيار مريض وطبيب
            if (cmbPatients.SelectedIndex == -1 || cmbDoctors.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء اختيار المريض والطبيب.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. التحقق من اختيار الحالة (الأهم)
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء اختيار الحالة (Scheduled, Completed, Cancelled).", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return;
            }

            if (dtpDate.Value.Date < DateTime.Now.Date) {
                MessageBox.Show("خطأ", "لا يمكن حجز موعد في الماضي ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return;
            }
            if (dtpDate.Value.Date < DateTime.Now.Date && dtpDate.Value.TimeOfDay < DateTime.Now.TimeOfDay) {
                MessageBox.Show("خطأ", "لا يمكن حجز موعد في وقت مضى من اليوم  ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return;
            }

            // 3. بناء الكائن (مع التأكد من أن القيمة صحيحة)
            AppointmentModel appointment = new AppointmentModel
            {
                PatientID = (int)cmbPatients.SelectedValue,
                DoctorID = (int)cmbDoctors.SelectedValue,
                AppointmentDate = dtpDate.Value.Date,
                AppointmentTime = dtpTime.Value.TimeOfDay,
                Status = cmbStatus.Text.Trim() // <-- إزالة أي مسافات إضافية
            };

            try
            {
                bool success = false;
                if (currentAppointment != null) // تعديل
                {
                    appointment.AppointmentID = currentAppointment.AppointmentID;
                    success = appBL.UpdateAppointment(appointment);
                }
                else // إضافة
                {
                    success = appBL.AddAppointment(appointment);
                }

                if (success)
                {
                    MessageBox.Show("تمت العملية بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
        }

        // زر الإلغاء
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}