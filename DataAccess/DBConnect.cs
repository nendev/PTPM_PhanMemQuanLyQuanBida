using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ManageBIDA1.DataAccess
{
    public class DBConnect
    {
        private static string connec = @"Data Source=(local);Initial Catalog=QL_BIDA;User ID=sa;Password=123";

        private SqlConnection conn;

        public void CreateConnection()
        {
            try
            {
                // Initialize the connection with the static connection string
                conn = new SqlConnection(connec);
                Console.WriteLine("Connection object created successfully.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL error while creating connection: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General error while creating connection: " + ex.Message);
            }
        }
        public SqlConnection GetConnection()
        {
            return conn;
        }
        public bool TestConnection()
        {
            if (conn == null)
            {
                Console.WriteLine("Connection has not been initialized. Call CreateConnection first.");
                return false;
            }

            try
            {
                // Open the connection
                conn.Open();
                Console.WriteLine("Connection to database successful.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while connecting to database: " + ex.Message);
                return false;
            }
            finally
            {
                // Ensure the connection is closed after the test
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Connection closed.");
                }
            }
        }
        public DataTable ExcuteQuery(string pQuery)
        {
            DataTable dt = new DataTable();

            if (conn == null)
            {
                Console.WriteLine("Connection has not been initialized. Call CreateConnection first.");
                return dt;
            }

            try
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand(pQuery, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                Console.WriteLine("Query executed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while executing query: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Connection closed.");
                }
            }

            return dt;
        }
        private bool ExecuteNonQuery(string pQuery)
        {
            if (conn == null)
            {
                Console.WriteLine("Connection has not been initialized. Call CreateConnection first.");
                return false;
            }
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(pQuery, conn);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while executing query: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Connection closed.");
                }
            }
        }

        public bool Insert(string pQuery)
        {
            return ExecuteNonQuery(pQuery);
        }

        // Method to execute an UPDATE command
        public bool Update(string pQuery)
        {
            return ExecuteNonQuery(pQuery);
        }

        // Method to execute a DELETE command
        public bool Delete(string pQuery)
        {
            return ExecuteNonQuery(pQuery);
        }
        public int CountRows(string pQuery)
        {
            int rowCount = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(pQuery, conn);
                conn.Open();
                rowCount = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while counting rows: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Connection closed.");
                }
            }

            return rowCount;
        }
    }
    
}
