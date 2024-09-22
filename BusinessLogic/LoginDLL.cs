using ManageBIDA1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBIDA1.BusinessLogic
{
    class LoginDLL
    {
        private readonly LoginDAL loginDAO;

        public LoginDLL()
        {
            loginDAO = new LoginDAL();
        }

        public bool KiemTra(string Tendangnhap, string matKhau)
        {
            return loginDAO.CheckLogin(Tendangnhap, matKhau);
        }
    }
}
