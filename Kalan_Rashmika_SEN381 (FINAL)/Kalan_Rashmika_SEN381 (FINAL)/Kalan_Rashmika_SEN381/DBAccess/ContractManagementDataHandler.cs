using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DBAccess
{
    public class ContractManagementDataHandler
    {
        SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
        public ContractManagementDataHandler()
        {
            conn.DataSource = @"LAPTOP-J27F0985";
            conn.InitialCatalog = "Kalan_Rashmika_SEN381_Project";
            conn.IntegratedSecurity = true;
        }

        public void AddContract(string contractID, string clientID, int subID)
        {
            SqlConnection connection = new SqlConnection(conn.ToString());
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procAddContract", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CON", contractID);
                cmd.Parameters.AddWithValue("@CID", clientID);
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
    }
}
