using ClinicMangementSystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Configuration;
using ClinicManagementSystem.DAL;

namespace ClinicMangementSystem.BL
{
    public class BillBL
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ClinicDBConnection"].ConnectionString;
        }

        // 1. جلب جميع الفواتير مع أسماء المرضى والأطباء
        public DataTable GetAllBills()
        {
            try
            {
                string query = @"
                    SELECT 
                        b.BillID,
                        p.FullName AS PatientName,
                        d.FullName AS DoctorName,
                        b.Amount,
                        b.PaymentStatus,
                        b.PaymentDate,
                        a.AppointmentDate
                    FROM Bills b
                    INNER JOIN Appointments a ON b.AppointmentID = a.AppointmentID
                    INNER JOIN Patients p ON a.PatientID = p.PatientID
                    INNER JOIN Doctors d ON a.DoctorID = d.DoctorID
                    ORDER BY b.BillID DESC
                ";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ في جلب الفواتير: " + ex.Message);
                return new DataTable();
            }
        }

        // 2. إنشاء فاتورة جديدة (تُستدعى من AppointmentBL عند الحجز)
        public bool CreateBill(int appointmentID, decimal amount)
        {
            if (amount <= 0) {
                MessageBox.Show("خطأ في الادخال ", "المبلغ لا يمكن ان يكون سالب ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                string query = @"
                    INSERT INTO Bills (AppointmentID, Amount, PaymentStatus) 
                    VALUES (@AppointmentID, @Amount, 'Unpaid')
                ";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ في إنشاء الفاتورة: " + ex.Message);
                return false;
            }
        }

        // 3. تحديث حالة الدفع (تحويلها إلى مدفوعة)
        public bool UpdatePaymentStatus(int billID)
        {
            
            try
            {
                string query = @"
                    UPDATE Bills 
                    SET PaymentStatus = 'Paid', 
                        PaymentDate = @PaymentDate 
                    WHERE BillID = @BillID
                ";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@BillID", billID);
                        cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now.Date);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ في تحديث الدفع: " + ex.Message);
                return false;
            }
        }

        // 4. البحث عن فاتورة (حسب المريض أو الطبيب)
        public DataTable SearchBills(string keyword)
        {
            try
            {
                string query = @"
                    SELECT 
                        b.BillID,
                        p.FullName AS PatientName,
                        d.FullName AS DoctorName,
                        b.Amount,
                        b.PaymentStatus,
                        b.PaymentDate,
                        a.AppointmentDate
                    FROM Bills b
                    INNER JOIN Appointments a ON b.AppointmentID = a.AppointmentID
                    INNER JOIN Patients p ON a.PatientID = p.PatientID
                    INNER JOIN Doctors d ON a.DoctorID = d.DoctorID
                    WHERE p.FullName LIKE @Keyword OR d.FullName LIKE @Keyword
                    ORDER BY b.BillID DESC
                ";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ في البحث: " + ex.Message);
                return new DataTable();
            }
        }

        // 5. جلب فاتورة بواسطة ID (للتحديث أو الطباعة)
        public DataTable GetBillById(int billID)
        {
            try
            {
                string query = @"
                    SELECT 
                        b.BillID,
                        p.FullName AS PatientName,
                        d.FullName AS DoctorName,
                        b.Amount,
                        b.PaymentStatus,
                        b.PaymentDate,
                        a.AppointmentDate
                    FROM Bills b
                    INNER JOIN Appointments a ON b.AppointmentID = a.AppointmentID
                    INNER JOIN Patients p ON a.PatientID = p.PatientID
                    INNER JOIN Doctors d ON a.DoctorID = d.DoctorID
                    WHERE b.BillID = @BillID
                ";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@BillID", billID);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ في جلب الفاتورة: " + ex.Message);
                return new DataTable();
            }
        }
        public int GetBillCount()
        {
            DataAccessLayer dal = new DataAccessLayer();
            string query = "SELECT COUNT(*) FROM Bills";
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

        public int GetUnpaidBillCount()
        {
            DataAccessLayer dal = new DataAccessLayer();
            string query = "SELECT COUNT(*) FROM Bills WHERE paymentStatus = 'Unpaid'";
            DataTable dt = dal.SelectDataText(query, null);
            if (dt.Rows.Count > 0)
                return Convert.ToInt32(dt.Rows[0][0]);
            return 0;
        }

    }
}






















