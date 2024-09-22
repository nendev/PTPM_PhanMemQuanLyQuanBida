using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBIDA1.DataAccess
{
    
    public class SettingDAL
    {
        private DBConnect dbConnection;
        public SettingDAL()
        {
            dbConnection = new DBConnect();
            dbConnection.CreateConnection();
        }
        public (string TenQuan, string DiaChi) GetSettings()
        {
            string query = "SELECT TenQuan, DiaChi FROM Setting";
            using (SqlCommand cmd = new SqlCommand(query, dbConnection.GetConnection()))
            {
                try
                {
                    dbConnection.GetConnection().Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tenQuan = reader["TenQuan"].ToString();
                            string diaChi = reader["DiaChi"].ToString();
                            return (tenQuan, diaChi);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while fetching settings: " + ex.Message);
                }
                finally
                {
                    dbConnection.GetConnection().Close();
                }
            }
            return (string.Empty, string.Empty);
        }

        public bool UpdateSetting(string tenQuan, string diaChi)
        {
            // Tạo truy vấn UPDATE để cập nhật bảng Setting
            string query = $"UPDATE Setting SET TenQuan = N'{tenQuan}', DiaChi = N'{diaChi}' WHERE 1=1";

            // Sử dụng phương thức Update của dbConnection để thực hiện truy vấn
            return dbConnection.Update(query);
        }
    }
}
