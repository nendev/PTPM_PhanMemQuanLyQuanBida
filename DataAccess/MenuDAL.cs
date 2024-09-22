using ManageBIDA1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBIDA1.DataAccess
{
    internal class MenuDAL
    {
        private DBConnect dbConnection;

        public MenuDAL()
        {
            dbConnection = new DBConnect();
            dbConnection.CreateConnection();
        }
        public bool Insert(string tenSanPham, float donGia)
        {
            string query = $"INSERT INTO [Menu] (TenSanPham, DonGia) VALUES (N'{tenSanPham}', {donGia})";
            return dbConnection.Insert(query);

        }
        public void Delete(int id)
        {
            // Tạo câu truy vấn để xóa mục có ID tương ứng
            string query = "DELETE FROM [Menu] WHERE id = " + id;

            // Thực hiện câu lệnh xóa
            dbConnection.ExcuteQuery(query);
        }
        public List<MenuDTO> GetMenu(string tukhoa)
        {

            List<MenuDTO> menu = new List<MenuDTO>();
            string query;

            // Kiểm tra từ khóa, nếu từ khóa là null hoặc rỗng thì lấy tất cả sản phẩm
            if (string.IsNullOrEmpty(tukhoa))
            {
                query = "SELECT * FROM [Menu]";
            }
            else
            {
                // Nếu từ khóa không rỗng, sử dụng LIKE để tìm kiếm
                query = "SELECT * FROM [Menu] WHERE TenSanPham LIKE '%" + tukhoa + "%'";
            }

            // Thực hiện truy vấn
            DataTable dt = dbConnection.ExcuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                MenuDTO item = new MenuDTO
                {
                    id = Convert.ToInt32(row["id"]),
                    TenSanPham = row["TenSanPham"].ToString(),
                    DonGia = Convert.ToSingle(row["DonGia"])
                };
                menu.Add(item);
            }

            return menu;
        }
    }
}
