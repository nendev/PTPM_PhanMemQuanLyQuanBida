using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageBIDA1.DataAccess;
using ManageBIDA1.DTO;
namespace ManageBIDA1.BusinessLogic
{
    internal class MenuDLL
    {
        private MenuDAL MenuDAL;
        // khai báo r khởi tạo
        public MenuDLL()
        {
            MenuDAL = new MenuDAL();
        }
        public List<MenuDTO> getMenu(string tukhoa)
        {
            return MenuDAL.GetMenu(tukhoa);
        }
        public bool Insert(string tenSanPham, float donGia)
        {
            return MenuDAL.Insert(tenSanPham.ToString(), donGia);
        }
        public void Delete(int id)
        {
            MenuDAL.Delete(id);
        }

    }
}
