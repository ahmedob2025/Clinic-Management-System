using ClinicManagementSystem.DAL;
using ClinicMangementSystem.BL;
using ClinicMangementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using ClinicMangementSystem.PL;



namespace ClinicMangementSystem.PL
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {

            InitializeComponent();
            this.Text = "لوحة تحكم المدير , " + Program.CurrentUser.Username;
            LoadStatistics();
            LoadAppointmentsFromDatabase();

            lblWelcome.Text = $"مرحباَ, {Program.CurrentUser.Username} في نظام ادارة العيادات";
        }
        private void LoadStatistics()
        {
            try
            {
                PatientBL patientBL = new PatientBL();
                int patientCount = patientBL.GetPatientCount();
                lblPatientCount.Text = patientCount.ToString();
                DoctorBL doctorBL = new DoctorBL();
                int doctorCount = doctorBL.GetDoctorCount();
                lblDoctorCount.Text = doctorCount.ToString();
                AppointmentBL appointmentBL = new AppointmentBL();
                int appointmentCount = appointmentBL.GetAppointmentCount();
                lblAppointmentCount.Text = appointmentCount.ToString();
                UserBL userBL = new UserBL();
                int userCount = userBL.GetUserCount();
                lblUserCount.Text = userCount.ToString();

                BillBL billBL = new BillBL();
                int unpaidBills = billBL.GetUnpaidBillCount();
                lblUnpaidBills.Text = unpaidBills.ToString();

                int completionRate = appointmentBL.GetCompletedAppointmentsPercentage();
                lblCompletionRate.Text = completionRate + "%";

                string mostActiveDoctor = doctorBL.GetMostActiveDoctor();
                lblMostActiveDoctor.Text = mostActiveDoctor.ToString();

                int newPatients = patientBL.GetNewPatientsThisMonth();
                lblNewPatients.Text = newPatients.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل الإحصائيات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAppointmentsFromDatabase()
        {
            try
            {
                AppointmentBL appBL = new AppointmentBL();
                DataTable dt = appBL.GetAllAppointments(); // استدعاء الدالة من BLL

                dgvAppointments.DataSource = dt;

                if (dt.Rows.Count == 0)
                    dgvAppointments.DataSource = null;

                if (dgvAppointments.Columns.Count > 0)
                    dgvAppointments.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAppointments.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل المواعيد: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();

        }


        private void btnDoctor_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm();
            doctorsForm.ShowDialog();
            LoadStatistics();
            LoadAppointmentsFromDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }


        private void btnUser_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
            LoadStatistics();
            LoadAppointmentsFromDatabase();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            BillsForm billsForm = new BillsForm();
            billsForm.ShowDialog();
            LoadStatistics();
            LoadAppointmentsFromDatabase();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientsForm patientsForm = new PatientsForm();
            patientsForm.ShowDialog();
            LoadStatistics();
            LoadAppointmentsFromDatabase();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentsForm appointmentsForm = new AppointmentsForm();
            appointmentsForm.ShowDialog();
            LoadStatistics();
            LoadAppointmentsFromDatabase();

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            using (DoctorEntryForm entryForm = new DoctorEntryForm(null))
            {
                if (entryForm.ShowDialog() == DialogResult.OK)
                {
                    LoadStatistics();
                    LoadAppointmentsFromDatabase();
                }
            }

        }

        private void btnAddAppo_Click(object sender, EventArgs e)
        {
            using (AppointmentEntryForm entryForm = new AppointmentEntryForm(null))
            {
                if (entryForm.ShowDialog() == DialogResult.OK)
                {
                    LoadStatistics();
                    LoadAppointmentsFromDatabase();
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (UserEntryForm entryForm = new UserEntryForm(null))
            {
                if (entryForm.ShowDialog() == DialogResult.OK)
                {
                    LoadStatistics();
                    LoadAppointmentsFromDatabase();

                }
            }
        }

        private void lblUnpaidBills_Click(object sender, EventArgs e)
        {

        }
    }
}
