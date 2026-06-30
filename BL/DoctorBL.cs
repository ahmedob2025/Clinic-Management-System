
using ClinicMangementSystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using ClinicManagementSystem.DAL; // تأكد أن DAL موجودة بنفس الاسم
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicMangementSystem.BL
{
    public class DoctorBL
    {
        // دالة مساعدة لقراءة جملة الاتصال من App.config
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ClinicDBConnection"].ConnectionString;
        }

        // 1. جلب كل الأطباء
        public DataTable GetAllDoctors()
        {
            string query = "SELECT DoctorID, FullName, Specialization, Phone, ConsultationFee FROM Doctors ORDER BY DoctorID";
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

        // 2. إضافة طبيب جديد
        public bool AddDoctor(DoctorModel doctor)
        {
            if (doctor.ConsultationFee < 0)
            {
                MessageBox.Show("خطأ في الادخال ", "رسوم الكشف لا يمكن ان تكون سالبة",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                string query = @"
                    INSERT INTO Doctors (FullName, Specialization, Phone, ConsultationFee) 
                    VALUES (@FullName, @Specialization, @Phone, @ConsultationFee)
                ";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@FullName", doctor.FullName);
                        cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                        cmd.Parameters.AddWithValue("@Phone", doctor.phone);
                        cmd.Parameters.AddWithValue("@ConsultationFee", doctor.ConsultationFee);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ في الإضافة: " + ex.Message);
                return false;
            }
        }

        // 3. تعديل طبيب
        public bool UpdateDoctor(DoctorModel doctor)
        {
            if (doctor.ConsultationFee < 0)
            {
                MessageBox.Show("خطأ في الادخال ", "رسوم الكشف لا يمكن ان تكون سالبة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                string query = @"
                    UPDATE Doctors SET 
                        FullName = @FullName, 
                        Specialization = @Specialization, 
                        Phone = @Phone, 
                        ConsultationFee = @ConsultationFee 
                    WHERE DoctorID = @DoctorID
                ";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@DoctorID", doctor.DoctorID);
                        cmd.Parameters.AddWithValue("@FullName", doctor.FullName);
                        cmd.Parameters.AddWithValue("@Specialization", doctor.Specialization);
                        cmd.Parameters.AddWithValue("@Phone", doctor.phone);
                        cmd.Parameters.AddWithValue("@ConsultationFee", doctor.ConsultationFee);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ في التعديل: " + ex.Message);
                return false;
            }
        }

        // 4. حذف طبيب
        public bool DeleteDoctor(int doctorID)
        {
            try
            {
                string query = "DELETE FROM Doctors WHERE DoctorID = @DoctorID";
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@DoctorID", doctorID);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ في الحذف: " + ex.Message);
                return false;
            }
        }

        // 5. البحث عن طبيب
        public DataTable SearchDoctors(string keyword)
        {
            string query = @"
                SELECT DoctorID, FullName, Specialization, Phone, ConsultationFee 
                FROM Doctors 
                WHERE FullName LIKE @Keyword OR Specialization LIKE @Keyword OR Phone LIKE @Keyword
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

        // 6. جلب طبيب بواسطة ID (للتعديل)
        public DataTable GetDoctorById(int doctorID)
        {
            string query = "SELECT DoctorID, FullName, Specialization, Phone, ConsultationFee FROM Doctors WHERE DoctorID = @DoctorID";
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@DoctorID", doctorID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public int GetDoctorCount()
        {
            DataAccessLayer dal = new DataAccessLayer();
            string query = "SELECT COUNT(*) FROM Doctors";
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

        public string GetMostActiveDoctor()
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                string query = @"
            SELECT TOP 1 
                ISNULL(d.FullName, 'لا يوجد') AS FullName, 
                COUNT(a.AppointmentID) AS Count 
            FROM Doctors d
            LEFT JOIN Appointments a ON d.DoctorID = a.DoctorID
            GROUP BY d.FullName
            ORDER BY Count DESC
        ";
                DataTable dt = dal.SelectDataText(query, null);

                if (dt.Rows.Count > 0 && dt.Columns.Contains("FullName"))
                    return dt.Rows[0]["FullName"].ToString();

                return "لا يوجد مواعيد";
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ في جلب أكثر طبيب نشاطاً: " + ex.Message);
                return "خطأ";
            }
        }

    }
}