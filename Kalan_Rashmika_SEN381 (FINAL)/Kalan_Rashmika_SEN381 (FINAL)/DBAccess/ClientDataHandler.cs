using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DBAccess
{
    public class ClientDataHandler
    {
        public void AddClient(string id, string fname, string lname, string IDNum, string phn, string email, string location, string import)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procInsertClient", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@FirstName", fname);
                cmd.Parameters.AddWithValue("@LastName", lname);
                cmd.Parameters.AddWithValue("@IDNum", IDNum);
                cmd.Parameters.AddWithValue("@Phone", phn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Location", location);
                cmd.Parameters.AddWithValue("@IMPORT", import);
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
        } //makes use of a stored procedure to insert a new client to the database

        public void UpdateClient(string id, string fname, string lname, string IDNum, string phn, string email, string location, string import)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procUpdateClient", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDN", IDNum);
                cmd.Parameters.AddWithValue("@PHN", phn);
                cmd.Parameters.AddWithValue("@EM", email);
                cmd.Parameters.AddWithValue("@LOC", location);
                cmd.Parameters.AddWithValue("@IMPORT", import);
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
        } //updates an existing clients details in the database

        public void DeleteClient(string IDNum, string clientID)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {               
                connection.Open();

                SqlCommand cmm = new SqlCommand("procRemoveBill", connection);
                cmm.CommandType = CommandType.StoredProcedure;
                cmm.Parameters.AddWithValue("@ID", clientID);
                cmm.ExecuteNonQuery();

                SqlCommand cmr = new SqlCommand("procRemoveSub", connection);
                cmr.CommandType = CommandType.StoredProcedure;
                cmr.Parameters.AddWithValue("@ID", clientID);
                cmr.ExecuteNonQuery();                

                SqlCommand cmd = new SqlCommand("procDeleteClient", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDNum", IDNum); 
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

        public void GenerateNewBill(string clientID, DateTime date, string month, double amnt, int subid)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procGenerateBill", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CID", clientID);
                cmd.Parameters.AddWithValue("@DATE", date);
                cmd.Parameters.AddWithValue("@MONTH", month);
                cmd.Parameters.AddWithValue("@AMNT", amnt);
                cmd.Parameters.AddWithValue("@SID", subid);
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

        public DataTable GetClientBills(string ID)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                DataTable dataTable = new DataTable();
                connection.Open();
                SqlCommand cmd = new SqlCommand("procClientBill", connection);
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

        public void AddSubscription(string clientID, string prodID, DateTime purchase, double cost, string version, string serial)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {                
                connection.Open();
                SqlCommand cmd = new SqlCommand("procSubscription", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CID", clientID);
                cmd.Parameters.AddWithValue("DATE", purchase);
                cmd.Parameters.AddWithValue("@COST", cost);
                cmd.Parameters.AddWithValue("@PID", prodID);
                cmd.Parameters.AddWithValue("@VER", version);
                cmd.Parameters.AddWithValue("@SER", serial);
                cmd.ExecuteNonQuery();
            }
            catch(Exception sqlex)
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

        public DataTable GetSubs()
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                DataTable dataTable = new DataTable();
                connection.Open();
                SqlCommand cmd = new SqlCommand("procGetSubs", connection);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public void DeleteSub(string ID, string prodID, int subID)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procRemoveSubscriptions", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@PRODID", prodID);
                cmd.Parameters.AddWithValue("@SUB", subID);
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

        public void InsertAddOns(int addid, int subid, int quantity)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procInsertAddOn", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AID", addid);
                cmd.Parameters.AddWithValue("@SID", subid);
                cmd.Parameters.AddWithValue("@QUAN", quantity);
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

        public DataTable GetSubAddOns(int subID)
        { 
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                DataTable dataTable = new DataTable();
                connection.Open();
                SqlCommand cmd = new SqlCommand("procGetClientAddOns", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SUB", subID);
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
    }
}
