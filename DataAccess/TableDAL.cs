using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageBIDA1.DTO;

namespace ManageBIDA1.DataAccess
{
    public class TableDAL
    {
        private DBConnect dbConnection;
        public TableDAL()
        {
            dbConnection = new DBConnect();
            dbConnection.CreateConnection();
        }
        public List<TableDTO> GetTables()
        {
            List<TableDTO> tables = new List<TableDTO>();
            string query = "SELECT * FROM [table]";

            DataTable dt = dbConnection.ExcuteQuery(query);

            //MessageBox.Show("Number of rows retrieved: " + dt.Rows.Count);

            foreach (DataRow row in dt.Rows)
            {
                TableDTO table = new TableDTO
                {
                    id = Convert.ToInt32(row["id"]),
                    maban = row["maban"].ToString(),
                    loaiban = row["loaiban"].ToString(),
                    dongia = Convert.ToSingle(row["dongia"])
                };
                tables.Add(table);
            }

            return tables;
        }
    }
}
