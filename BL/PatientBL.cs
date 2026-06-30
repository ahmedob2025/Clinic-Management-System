#nullable disable
using ClinicManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using ClinicMangementSystem.Models;

namespace ClinicMangementSystem.BL
{
    public class PatientBL
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ClinicDBConnection"].ConnectionString;
        }
        public DataTable GetAllPatients()
        {
            try
            {
                string query = "SELECT PatientID, FullName, Phone, Address, BirthDate,Gender FROM Patients ORDER BY PatientID";
                string connectionString = ConfigurationManager.ConnectionStrings["ClinicDBConnection"].ConnectionString; // Read connection string from App.config
                System.Windows.Forms.MessageBox.Show("Connection String: " + connectionString); // Debugging line
                using (SqlConnection conn = new SqlConnection(connectionString))
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
                System.Windows.Forms.MessageBox.Show("Error fetching patients: " + ex.Message);
                return new DataTable(); // Return an empty DataTable in case of error
            }
        }

        public bool AddPatient(PatientModel patient)
        {
            string query = "INSERT INTO Patients (FullName, Phone, Address, BirthDate) VALUES (@FullName, @Phone, @Address, @BirthDate)";
            if (patient.BirthDate > DateTime.Now.Date)
            {
                MessageBox.Show("خطأ في الادخال ", "تاريخ الميلاد لا يجب ان يكون في المستقبل ,",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@FullName", patient.FullName);
                        cmd.Parameters.AddWithValue("@Phone", patient.Phone);
                        cmd.Parameters.AddWithValue("@Address", patient.Address);
                        cmd.Parameters.AddWithValue("@BirthDate", patient.BirthDate);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error adding patient: " + ex.Message);
                return false;
            }
        }
        public bool UpdatePatient(PatientModel patient)
        {
            string query = "UPDATE Patients SET FullName = @FullName, Phone = @Phone, Address = @Address, BirthDate = @BirthDate WHERE PatientID = @PatientID";
            if (patient.BirthDate > DateTime.Now.Date)
            {
                MessageBox.Show("خطأ في الادخال ", "تاريخ الميلاد لا يجب ان يكون في المستقبل ,", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@FullName", patient.FullName);
                        cmd.Parameters.AddWithValue("@Phone", patient.Phone);
                        cmd.Parameters.AddWithValue("@Address", patient.Address);
                        cmd.Parameters.AddWithValue("@BirthDate", patient.BirthDate);
                        cmd.Parameters.AddWithValue("@PatientID", patient.PatientID);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error updating patient: " + ex.Message);
                return false;
            }
        }
        public bool DeletePatient(int patientID)
        {
            string query = "DELETE FROM Patients WHERE PatientID = @PatientID";
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@PatientID", patientID);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error deleting patient: " + ex.Message);
                return false;
            }
        }
        public DataTable SearchPatients(string searchTerm)
        {
            string query = "SELECT PatientID, FullName, Phone, Address, BirthDate , Gender FROM Patients WHERE FullName LIKE @SearchTerm OR Phone LIKE @SearchTerm OR Address LIKE @SearchTerm ORDER BY PatientID";
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable GetPatientById(int patient)
        {             string query = "SELECT PatientID, FullName, Phone,Gender, Address, BirthDate FROM Patients WHERE PatientID = @PatientID";
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@PatientID", patient);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public int GetPatientCount()
        {
        DataAccessLayer dal = new DataAccessLayer();
            string query = "SELECT COUNT(*) FROM Patients";
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
        public int GetNewPatientsThisMonth()
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();

                string checkColumnQuery = @"
            SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_NAME = 'Patients' AND COLUMN_NAME = 'CreatedDate'
        ";
                DataTable checkDt = dal.SelectDataText(checkColumnQuery, null);
                bool columnExists = checkDt.Rows.Count > 0 && Convert.ToInt32(checkDt.Rows[0][0]) > 0;

                string query;
                if (columnExists)
                {
                
                    query = @"
                SELECT COUNT(*) FROM Patients 
                WHERE MONTH(CreatedDate) = MONTH(GETDATE()) 
                  AND YEAR(CreatedDate) = YEAR(GETDATE())
            ";
                }
                else
                {
                    query = @"
                SELECT COUNT(*) FROM Patients 
                WHERE PatientID > (SELECT ISNULL(MAX(PatientID) - 30, 0) FROM Patients)
            ";
                }

                DataTable dt = dal.SelectDataText(query, null);
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                    return Convert.ToInt32(dt.Rows[0][0]);
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في جلب مرضى جدد: " + ex.Message);
                return 0;
            }
        }
    }
}
