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
        SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder();
        public ProductDataHandler()
        {
            conn.DataSource = @"LAPTOP-J27F0985";
            conn.InitialCatalog = "Kalan_Rashmika_SEN381_Project";
            conn.IntegratedSecurity = true;
        }

        public void AddProduct(string prodID, string name, string desc, double amount, string version , DateTime date, int man)
        {
            SqlConnection connection = new SqlConnection(conn.ToString());
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("procInsertProduct", connection);
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
                if (connection.State==ConnectionState.Open)
                {
                    connection.Close();
                }
            }           
        } //inserts a new product into the database

        public void UpdateProduct(string prodID, string name, string desc, double amount, string version, DateTime date, int man)
        {
            SqlConnection connection = new SqlConnection(conn.ToString());
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
            SqlConnection connection = new SqlConnection(conn.ToString());
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
