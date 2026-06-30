using System.Data;
using Microsoft.Data.SqlClient;

namespace ClinicMangementSystem.DAL
{
    internal class DataAccessLayer
    {
        private String connectionString = "ClinicDBConnection";
        //private String connectionString = @"Server=.\myser; DataBase=Shahba Rose; Integrated Security = true";
        private SqlConnection sqlConnection;
        public DataAccessLayer()
        {
            String ServerName = @"AhmedObaidat\SQLEXPRESS";
            String dataBase = "ClinicDB";
            connectionString = @"Server=" + ServerName + "; DataBase=" + dataBase + "; Integrated Security = true; Encrypt = False ; TrustServerCertificate = True";
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

        public SqlDataAdapter SelectDataGetAdpat(String storedProcedure, SqlParameter[] param)
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

            return da;
        }

        internal int SelectDataInt(String storedProcedure)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;

            Open();
            int id = Convert.ToInt16(sqlCommand.ExecuteScalar());
            Close();
            return id;
        }



        public String SelectDataString(String storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }

            return sqlCommand.ExecuteScalar().ToString();
        }

        public void ExecuteCommand(String storedProcedure, SqlParameter[] param)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = storedProcedure;
            if (param != null)
            {
                sqlCommand.Parameters.AddRange(param);
            }
            Open();
            sqlCommand.ExecuteNonQuery();
            Close();
        }
        public DataTable SelectDataText(string query, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                if (param != null)
                    cmd.Parameters.AddRange(param);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

            }
            return dt;
        }
        }
}