using ClinicMangementSystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using ClinicMangementSystem.DAL; 
using System.Configuration;
#nullable disable

namespace ClinicMangementSystem.BL
{
    public class UserBL
    {
        DataAccessLayer dal = new DataAccessLayer();

        // 1. التحقق من الدخول (يستخدم إجراء مخزن - صح)
        public DataTable VerifyUser(string username, string password)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 50) { Value = username };
            param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50) { Value = password };

            dal.Open();
            DataTable dt = dal.SelectData("VerifyUser", param); // هذا يستخدم الإجراء المخزن
            dal.Close();
            return dt;
        }

        // 2. جلب دور المستخدم (يستخدم إجراء مخزن - صح)
        public string GetUserRole(string username)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Username", SqlDbType.NVarChar, 50) { Value = username };

            dal.Open();
            DataTable dt = dal.SelectData("GetUserRole", param);
            dal.Close();

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["Role"].ToString();
            return null;
        }

        // 3. جلب كل المستخدمين (استعلام عادي - يستخدم SelectDataText)
        public DataTable GetAllUsers()
        {
            string query = @"SELECT UserID, Username, FullName, Role, IsActive, CreatedDate FROM Users ORDER BY UserID";
            return dal.SelectDataText(query, null); // صح
        }

        // 4. إضافة مستخدم (تم تعديلها لاستخدام dal.ExecuteCommand مباشرة)

        public bool AddUser(UserModel user)
        {
            try
            {
                string query = @"
            INSERT INTO Users (Username, Password, Role, FullName, IsActive) 
            VALUES (@Username, @Password, @Role, @FullName, 1)
        ";

                // اقرأ جملة الاتصال مباشرة من App.config (بدون الاعتماد على DAL)
                string connectionString = ConfigurationManager.ConnectionStrings["ClinicDBConnection"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.Parameters.AddWithValue("@Role", user.Role);
                        cmd.Parameters.AddWithValue("@FullName", user.FullName);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ أثناء الإضافة: " + ex.Message);
                return false;
            }
        }

        // 5. تعديل مستخدم
        public bool UpdateUser(UserModel user)
        {
            try
            {
                string query = @"
            UPDATE Users SET 
                Username = @Username, 
                Password = @Password, 
                Role = @Role, 
                FullName = @FullName, 
                IsActive = @IsActive 
            WHERE UserID = @UserID
        ";

                string connectionString = ConfigurationManager.ConnectionStrings["ClinicDBConnection"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@UserID", user.UserID);
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.Parameters.AddWithValue("@Role", user.Role);
                        cmd.Parameters.AddWithValue("@FullName", user.FullName);
                        cmd.Parameters.AddWithValue("@IsActive", user.IsActive);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ أثناء التعديل: " + ex.Message);
                return false;
            }
        }

        // 6. حذف مستخدم
        public bool DeleteUser(int userId)
        {
            try
            {
                string query = "DELETE FROM Users WHERE UserID = @UserID";
                string connectionString = ConfigurationManager.ConnectionStrings["ClinicDBConnection"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("خطأ أثناء الحذف: " + ex.Message);
                return false;
            }
        }

        // 7.البحث  
        public DataTable SearchUsers(string keyword)
        {
            try
            {
                string query = @"
            SELECT UserID, Username, FullName, Role, IsActive, CreatedDate 
            FROM Users 
            WHERE Username LIKE @Keyword OR FullName LIKE @Keyword OR Role LIKE @Keyword
        ";
                string connectionString = ConfigurationManager.ConnectionStrings["ClinicDBConnection"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
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
                System.Windows.Forms.MessageBox.Show("خطأ أثناء البحث: " + ex.Message);
                return new DataTable(); // إرجاع جدول فارغ في حالة الخطأ
            }
        }

        // 8. جلب مستخدم بواسطة ID (تم التعديل لاستخدام SelectDataText)
        public DataTable GetUserById(int userId)
        {
            string query = @"SELECT UserID, Username, Password, FullName, Role, IsActive, CreatedDate 
                             FROM Users WHERE UserID = @UserID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserID", userId)
            };
            return dal.SelectDataText(query, parameters);
        }
        public int GetUserCount()
        {
            DataAccessLayer dal = new DataAccessLayer();
            string query = "SELECT COUNT(*) FROM Users";
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
        
    }
}