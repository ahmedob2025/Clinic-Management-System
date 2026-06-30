#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicMangementSystem.DAL;
using System.Data;
using System.Configuration;
using Microsoft.Data.SqlClient;
using ClinicMangementSystem.Models;
namespace ClinicMangementSystem.BL
{
    public class AppointmentBL
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ClinicDBConnection"].ConnectionString;
        }

        public int GetAppointmentCount()
        {
            DataAccessLayer dal = new DataAccessLayer();
            string query = "SELECT COUNT(*) FROM Appointments";
            DataTable dt = dal.SelectDataText(query, null);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            else
            {
                return 0;
            }
        }
        public bool CheckAvailability(int doctorID, DateTime date, TimeSpan time)
        {
            try
            {
                // استخرج الساعة من الوقت المدخل
                int hour = time.Hours;

                string query = @"
            SELECT COUNT(*) 
            FROM Appointments 
            WHERE DoctorID = @DoctorID 
              AND AppointmentDate = @Date 
              AND DATEPART(HOUR, AppointmentTime) = @Hour
        ";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@DoctorID", doctorID);
                        cmd.Parameters.AddWithValue("@Date", date.Date);
                        cmd.Parameters.AddWithValue("@Hour", hour);

                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count == 0; // True إذا كانت الساعة فارغة، False إذا كان هناك موعد
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في التحقق من التوفر: " + ex.Message);
                return false;
            }
        }
        public bool AddAppointment(AppointmentModel appointment)
        {

            try
            {
                if (appointment.AppointmentDate.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("خطأ في الادخال ", "لا يمكن حجز موعد في تاريخ ماضي ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (appointment.AppointmentDate.Date == DateTime.Now.Date && appointment.AppointmentTime < DateTime.Now.TimeOfDay)
                {
                    MessageBox.Show("خطأ في الادخال ", "لا يمكن حجز موعد في وقت مضى من اليوم!م", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                // 1. تحقق من الساعة 
                if (!CheckAvailability(appointment.DoctorID, appointment.AppointmentDate, appointment.AppointmentTime))
                {
                    MessageBox.Show("يوجد موعد آخر لهذا الطبيب في نفس الساعة!", "تعارض", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // 2. إدراج الموعد
                string query = @"
            INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, AppointmentTime, Status) 
            OUTPUT INSERTED.AppointmentID
            VALUES (@PatientID, @DoctorID, @Date, @Time, @Status)
        ";

                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                        cmd.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                        cmd.Parameters.AddWithValue("@Date", appointment.AppointmentDate.Date);
                        cmd.Parameters.AddWithValue("@Time", appointment.AppointmentTime);
                        cmd.Parameters.AddWithValue("@Status", appointment.Status ?? "Scheduled");

                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int newAppointmentID = Convert.ToInt32(result);
                            decimal fee = GetDoctorFee(appointment.DoctorID);
                            BillBL billBL = new BillBL();
                            billBL.CreateBill(newAppointmentID, fee);
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في إضافة الموعد: " + ex.Message);
                return false;
            }
        }
        public bool UpdateAppointment(AppointmentModel appointment)
        {
            try
            {
                if (appointment.AppointmentDate.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("خطأ في الادخال ", "لا يمكن حجز موعد في تاريخ ماضي ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (appointment.AppointmentDate.Date == DateTime.Now.Date && appointment.AppointmentTime < DateTime.Now.TimeOfDay)
                {
                    MessageBox.Show("خطأ في الادخال ", "لا يمكن حجز موعد في وقت مضى من اليوم!م", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                int hour = appointment.AppointmentTime.Hours;

                // التحقق من التعارض (مع استثناء هذا الموعد نفسه)
                string checkQuery = @"
            SELECT COUNT(*) 
            FROM Appointments 
            WHERE DoctorID = @DoctorID 
              AND AppointmentDate = @Date 
              AND DATEPART(HOUR, AppointmentTime) = @Hour 
              AND AppointmentID != @AppointmentID
        ";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                        cmd.Parameters.AddWithValue("@Date", appointment.AppointmentDate.Date);
                        cmd.Parameters.AddWithValue("@Hour", hour);
                        cmd.Parameters.AddWithValue("@AppointmentID", appointment.AppointmentID);
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("يوجد موعد آخر لهذا الطبيب في نفس الساعة!", "تعارض", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }

                // تنفيذ التحديث (يبقى كما هو)
                string updateQuery = @"
            UPDATE Appointments SET 
                PatientID = @PatientID, 
                DoctorID = @DoctorID, 
                AppointmentDate = @Date, 
                AppointmentTime = @Time, 
                Status = @Status 
            WHERE AppointmentID = @AppointmentID
        ";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@AppointmentID", appointment.AppointmentID);
                        cmd.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                        cmd.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                        cmd.Parameters.AddWithValue("@Date", appointment.AppointmentDate.Date);
                        cmd.Parameters.AddWithValue("@Time", appointment.AppointmentTime);
                        cmd.Parameters.AddWithValue("@Status", appointment.Status);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في التعديل: " + ex.Message);
                return false;
            }
        }
        public bool DeleteAppointment(int appointmentId)
        {
            try
            {
                string query = "DELETE FROM Appointments WHERE AppointmentID = @AppointmentID";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء حذف الموعد: " + ex.Message);
                return false;
            }
        }

        public DataTable SearchAppointments(string Keyword)
        {
            try
            {
                string query = @"
                    SELECT 
                        a.AppointmentDate AS 'التاريخ',
                        a.AppointmentTime AS 'الوقت',
                        d.FullName AS 'الطبيب',
                        p.FullName AS 'المريض',
                        a.Status AS 'الحالة'
                    FROM Appointments a
                    INNER JOIN Doctors d ON a.DoctorID = d.DoctorID
                    INNER JOIN Patients p ON a.PatientID = p.PatientID
                    WHERE 
                        d.FullName LIKE @Keyword OR 
                        p.FullName LIKE @Keyword OR 
                        a.Status LIKE @Keyword
                    ORDER BY a.AppointmentDate, a.AppointmentTime";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Keyword", "%" + Keyword + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء البحث عن المواعيد: " + ex.Message);
                return null;
            }
        }
        public DataTable GetAppointmentById(int appointmentId)
        {
            try
            {
                string query = @"
                       SELECT
                            AppointmentID, PatientID, DoctorID, AppointmentDate, AppointmentTime, Status
                        FROM Appointments
                        WHERE AppointmentID = @AppointmentID";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء جلب بيانات الموعد: " + ex.Message);
                return null;
            }
        }
            // 1. دالة جلب كل المواعيد مع أسماء الأطباء والمرض
        public DataTable GetAllAppointments()
        {
            try
            {
                string query = @"
                    SELECT 
                         a.AppointmentID,
                        a.AppointmentDate AS 'التاريخ',
                        a.AppointmentTime AS 'الوقت',
                        d.FullName AS 'الطبيب',
                        p.FullName AS 'المريض',
                        a.Status AS 'الحالة'
                    FROM Appointments a
                    INNER JOIN Doctors d ON a.DoctorID = d.DoctorID
                    INNER JOIN Patients p ON a.PatientID = p.PatientID
                    ORDER BY a.AppointmentDate, a.AppointmentTime";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ أثناء جلب كل المواعيد: " + ex.Message);
                return null;

            }
        }

        private decimal GetDoctorFee(int doctorID)
        {
            try
            {
                string query = "SELECT ConsultationFee FROM Doctors WHERE DoctorID = @DoctorID";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@DoctorID", doctorID);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result == null || result == DBNull.Value)
                            return 0;
                        return Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في جلب رسوم الطبيب: " + ex.Message);
                return 0;
            }
        }
        public int GetCompletedAppointmentsPercentage()
        {
            DataAccessLayer dal = new DataAccessLayer();
            string query = @"
        SELECT 
            CASE 
                WHEN COUNT(*) = 0 THEN 0
                ELSE CAST(COUNT(CASE WHEN Status = 'Completed' THEN 1 END) AS FLOAT) / COUNT(*) * 100 
            END
        FROM Appointments
    ";
            DataTable dt = dal.SelectDataText(query, null);
            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(Math.Round(Convert.ToDecimal(dt.Rows[0][0])));
            return 0;
        }


    }
}

