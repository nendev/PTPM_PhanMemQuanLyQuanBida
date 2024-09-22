using ManageBIDA1.BusinessLogic;
using ManageBIDA1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageBIDA1.Presentation.UserControls
{
    public partial class UCSetting : UserControl
    {
        private SettingDLL settingService;
        private TableDLL tableService;
        public UCSetting()

        {
            InitializeComponent();
            btn_delTable.Height = 200;
            settingService = new SettingDLL();
            tableService = new TableDLL();
            LoadSettings();
            LoadTableList();
        }
        private void LoadTableList()
        {
            // Lấy danh sách các TableDTO từ TableService
            List<TableDTO> tables = tableService.GetTables();
            //MessageBox.Show(table.row)
            // Xóa tất cả các hàng trong DataGridView trước khi thêm dữ liệu mới
            list_table.Rows.Clear();
            // Duyệt qua danh sách tables và thêm từng item vào DataGridView
            foreach (var table in tables)
            {
                list_table.Rows.Add(table.id, table.maban, table.loaiban, table.dongia.ToString("N0"));
            }
        }
        private void LoadSettings()
        {
            var settings = settingService.GetSettings();
            txt_TenQuan.Text = settings.TenQuan;
            txt_DiaChi.Text = settings.DiaChi;
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCSetting_Load(object sender, EventArgs e)
        {

        }

        private void btn_UpdateSetting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenQuan.Text))
            {
                MessageBox.Show("Tên quán không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = settingService.UpdateSetting(txt_TenQuan.Text, txt_DiaChi.Text);
            if (result)
            {
                MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSettings();
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_UpdateSetting_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_addTable_Click(object sender, EventArgs e)
        {

        }
    }
}
