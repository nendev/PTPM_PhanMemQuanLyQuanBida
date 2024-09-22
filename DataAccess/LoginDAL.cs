using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBIDA1.DataAccess
{
    public class LoginDAL
    {
        private DBConnect dbConnection;

        public LoginDAL()
        {
            dbConnection = new DBConnect();
            dbConnection.CreateConnection();
        }

        // Phương thức kiểm tra đăng nhập
        public bool CheckLogin(string username, string password)
        {
            // Tạo chuỗi truy vấn SQL với tham số
            string query = $"SELECT COUNT(*) FROM [user] WHERE username = '{username}' AND password = '{password}'";

            // Sử dụng phương thức CountRows từ DBConnect để đếm số dòng
            int rowCount = dbConnection.CountRows(query);

            // Nếu rowCount > 0, nghĩa là đã tìm thấy user và password khớp trong bảng user
            return rowCount > 0;
        }

    }
}
