using ManageBIDA1.DataAccess;
using ManageBIDA1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageBIDA1.BusinessLogic
{
    internal class TableDLL
    {
        private TableDAL tableDAO;

        public TableDLL()
        {
            tableDAO = new TableDAL();
        }
        public List<TableDTO> GetTables()
        {
            // Bạn có thể thêm các logic nghiệp vụ tại đây nếu cần
            return tableDAO.GetTables();
        }
    }
}
