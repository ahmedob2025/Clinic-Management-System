using ClinicMangementSystem.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicMangementSystem.PL
{
    public partial class ReceptionDashboard : Form
    {
        public ReceptionDashboard()
        {
            InitializeComponent();
            if (Program.CurrentUser != null)
            {
                lblWelcome.Text = "مرحبا " + Program.CurrentUser.UserName + "(موظف الاستقبال)";
            }
            else
                lblWelcome.Text = "مرحبا موظف الاستقبال";
            LoadTodayAppointments();
            LoadStatistics();

        }
        private void LoadStatistics()
        {
            try
            {
                PatientBL patientBL = new PatientBL();
                int totalePatients = patientBL.GetPatientCount();
                lblTotalePatients.Text = totalePatients.ToString();

                AppointmentBL appointmentBL = new AppointmentBL();
                int totaleAppointment = appointmentBL.GetAllAppointments().Rows.Count;
                lblTodayAppointments.Text = totaleAppointment.ToString();

                BillBL billBL = new BillBL();
                int totaleBills = billBL.GetBillCount();
                lblTotaleBills.Text = totaleBills.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل الإحصائيات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTodayAppointments()
        {
            try
            {
                AppointmentBL appointmentBL = new AppointmentBL();
                DataTable todayAppointments = appointmentBL.GetAllAppointments();
                dgvTodayAppointments.DataSource = todayAppointments;
                if (todayAppointments.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد مواعيد اليوم.", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvTodayAppointments.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل مواعيد اليوم: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cardPatients_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalePatients_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientsForm f = new PatientsForm();
            f.ShowDialog();
            LoadStatistics();
            LoadTodayAppointments();

        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentsForm f = new AppointmentsForm();
            f.ShowDialog();
            LoadStatistics();
            LoadTodayAppointments();

        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            BillsForm f = new BillsForm();
            f.ShowDialog();
            LoadStatistics();
            LoadTodayAppointments();

        }
    }
}
