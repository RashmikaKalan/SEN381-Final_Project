using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DBAccess
{
    public class TechSupportDataHandler
    {
        public void AddEmployee(string fname, string lname, string phn, string email, int level, string user, string pass)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procAddEmployee", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FIRST", fname);
                cmd.Parameters.AddWithValue("@LAST", lname);
                cmd.Parameters.AddWithValue("@PHN", phn);
                cmd.Parameters.AddWithValue("@EMAIL", email);
                cmd.Parameters.AddWithValue("@EMPL", level);
                cmd.Parameters.AddWithValue("@USER", user);
                cmd.Parameters.AddWithValue("@PASS", pass);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                throw new Exception(string.Format("Database Error: {0} Has Occurred.", sqlex));
            }
            finally
            {
                if (connection.State==ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        } 

        public void AddAppointment(int bookID, int empID, string clientID, string desc, DateTime date, int priority)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procAddAppointement", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CID", clientID);
                cmd.Parameters.AddWithValue("@EID", empID);
                cmd.Parameters.AddWithValue("@DESC", desc);
                cmd.Parameters.AddWithValue("@DATE", date);
                cmd.Parameters.AddWithValue("@PRI", priority);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                throw new Exception(string.Format("Database Error: {0} Has Occurred.", sqlex));
            }
            finally
            {
                if (connection.State==ConnectionState.Open)
                {
                    connection.Close();
                }
            }           
        } 

        public void UpdateAppointment(int bookID, int empID, string clientID, string desc, DateTime date, int priority)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procUpdateAppointment", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BID", bookID);
                cmd.Parameters.AddWithValue("@EID", empID);
                cmd.Parameters.AddWithValue("@DATE", date);
                cmd.Parameters.AddWithValue("@DESC", desc);
                cmd.Parameters.AddWithValue("@PRI", priority);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                throw new Exception(string.Format("Database Error: {0} Has Occurred.", sqlex));
            }
            finally
            {
                if (connection.State==ConnectionState.Open)
                {
                    connection.Close();
                }
            }            
        } 

        public void DeleteAppointment(int bookID)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procDeleteAppointment", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("BID", bookID);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                throw new Exception(string.Format("Database Error: {0} Has Occurred.", sqlex));
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public DataTable GetClientApps(string ID)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                DataTable dataTable = new DataTable();
                connection.Open();
                SqlCommand cmd = new SqlCommand("procClientApps", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                dataTable.Load(cmd.ExecuteReader());
                return dataTable;
            }
            catch (SqlException sqlex)
            {
                throw new Exception(string.Format("Database Error: {0} Has Occurred.", sqlex));
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }           
        }

        public DataTable GetAppsID(int ID)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                DataTable dataTable = new DataTable();
                connection.Open();
                SqlCommand cmd = new SqlCommand("procAppID", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                dataTable.Load(cmd.ExecuteReader());
                return dataTable;
            }
            catch (SqlException sqlex)
            {
                throw new Exception(string.Format("Database Error: {0} Has Occurred.", sqlex));
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }           
        }

        public DataTable GetAppsDate(DateTime date)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                DataTable dataTable = new DataTable();
                connection.Open();
                SqlCommand cmd = new SqlCommand("procAppDate", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DATE", date);
                dataTable.Load(cmd.ExecuteReader());
                return dataTable;
            }
            catch (SqlException sqlex)
            {
                throw new Exception(string.Format("Database Error: {0} Has Occurred.", sqlex));
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public DataTable EmployeeSchedule(int EID)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                DataTable data = new DataTable();
                connection.Open();
                SqlCommand cmd = new SqlCommand("procEmployeeSchedule", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EMPID", EID);
                data.Load(cmd.ExecuteReader());
                return data;
            }
            catch (SqlException sqlex)
            {
                throw new Exception(string.Format("Database Error: {0} Has Occurred.", sqlex));
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public DataTable GetCalls()
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                DataTable dt = new DataTable();
                connection.Open();
                SqlCommand cmd = new SqlCommand("procAllCalls", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (SqlException sqlex)
            {
                throw new Exception(string.Format("Database Error: {0} Has Occurred.", sqlex));
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void RecordCall(int empid, DateTime date, double duration)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procAddCall", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DATE", date);
                cmd.Parameters.AddWithValue("@DUR", duration);
                cmd.Parameters.AddWithValue("@EMP", empid);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                throw new Exception(string.Format("Database Error: {0} Has Occurred.", sqlex));
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
