using ManageBIDA1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBIDA1.BusinessLogic
{
    internal class SettingDLL
    {
        private SettingDAL settingDAO;

        public SettingDLL()
        {
            settingDAO = new SettingDAL();
        }
        public (string TenQuan, string DiaChi) GetSettings()
        {
            return settingDAO.GetSettings();
        }
        public bool UpdateSetting(string tenQuan, string diaChi)
        {
            return settingDAO.UpdateSetting(tenQuan, diaChi);
        }
    }
}
