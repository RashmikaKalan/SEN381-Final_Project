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
        public void AddContract(string contractID, string clientID, int subID)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
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
