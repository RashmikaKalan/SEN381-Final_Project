using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DBAccess
{
    public class ProductDataHandler
    {
        public void AddProduct(string prodID, string name, string desc, double amount, string version , DateTime date, int man)
        {
            SqlConnection sql = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand("procInsertProduct", sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", prodID);
                cmd.Parameters.AddWithValue("@NAME", name);
                cmd.Parameters.AddWithValue("@DESC", desc);
                cmd.Parameters.AddWithValue("@AMNT", amount);
                cmd.Parameters.AddWithValue("@VERS", version);
                cmd.Parameters.AddWithValue("@DATE", date);
                cmd.Parameters.AddWithValue("@MAN", man);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                throw new Exception(string.Format("Database Error: {0} Has Occurred.", sqlex));
            }
            finally
            {
                if (sql.State==ConnectionState.Open)
                {
                    sql.Close();
                }
            }           
        } //inserts a new product into the database

        public void UpdateProduct(string prodID, string name, string desc, double amount, string version, DateTime date, int man)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procUpdateProduct", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", prodID);
                cmd.Parameters.AddWithValue("@DESC", desc);
                cmd.Parameters.AddWithValue("@COST", amount);
                cmd.Parameters.AddWithValue("@VERSION", version);
                cmd.Parameters.AddWithValue("@DATE", date);
                cmd.Parameters.AddWithValue("@MAN", man);
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
        } //updates an existing products details in the database using a stored procedure

        public void DeleteProduct(string ID)
        {
            SqlConnection connection = SingletonConnection.Singleton.SqlConnectionFactory;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procDeleteProduct", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
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
        } //removes a product from the database
    }
}
