using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; 
using Microsoft.Data.SqlClient;
namespace ClinicManagementSystem.DAL
{
    internal class DataAccessLayer
    {
        private SqlConnection sqlConnection;

        // الـ Constructor بيقرأ من App.config بدل ما يكتب البيانات قاسية
        public DataAccessLayer()
        {
         
            string connectionString = ConfigurationManager.ConnectionStrings["ClinicDBConnection"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }

        public void Open()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }

        public void Close()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        // دالة لجلب البيانات (للاستعلامات اللي بترجع جدول)
        public DataTable SelectData(String storedProcedure, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            return dt;
        }

        // دالة لتنفيذ الأوامر (إضافة، تعديل، حذف)
        public void ExecuteCommand(String storedProcedure, SqlParameter[] param)
        {
        SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandType = CommandType.Text; // استعلام نصي عادي
            cmd.CommandText = storedProcedure;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            Open();
            cmd.ExecuteNonQuery();
            Close();
        }

        // (اختياري) دالة إضافية للاستعلامات النصية البسيطة إذا حبيت تستخدمها مع VerifyUser
        public DataTable SelectDataText(string query, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text; // استعلام نصي عادي
            sqlCommand.CommandText = query;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            return dt;
        }
    }
}