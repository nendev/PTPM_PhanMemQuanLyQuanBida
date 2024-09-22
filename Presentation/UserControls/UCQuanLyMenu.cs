using ManageBIDA1.BusinessLogic;
using ManageBIDA1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageBIDA1.Presentation.UserControls
{
    public partial class UCQuanLyMenu : UserControl
    {
        private MenuDLL menuDLL;
        public UCQuanLyMenu()
        {
            InitializeComponent();
            menuDLL = new MenuDLL();
            LoadMenuList(null);
        }
        private void LoadMenuList(string tukhoa)
        {
            List<MenuDTO> Menu = menuDLL.getMenu(tukhoa);
            // clear dữ liệu trên bảng menu
            list_menu.Rows.Clear();
            //thêm dữ liệu vào
            int stt = 1;

            // Thêm dữ liệu vào DataGridView
            foreach (var item in Menu)
            {
                list_menu.Rows.Add(item.id, item.TenSanPham, item.DonGia.ToString("N0"));
                stt++; // Tăng số thứ tự cho dòng tiếp theo
            }

        }

        private void Txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            // Gọi hàm TimKiem với từ khóa hiện tại
            LoadMenuList(txt_timkiem.Text);
        }
        private void btnmenu_xoa_Click(object sender, EventArgs e)
        {
            if (list_menu.SelectedRows.Count > 0)
            {
                // Lấy ID của mục được chọn
                int id = Convert.ToInt32(list_menu.SelectedRows[0].Cells["id"].Value);

                // Hỏi xác nhận trước khi xóa
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Gọi hàm để xóa mục từ bảng Menu
                    menuDLL.Delete(id);

                    // Cập nhật lại danh sách sau khi xóa
                    LoadMenuList(null);
                    txt_timkiem.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.");
            }
        }

        // ở giới là giao diện thui
        private void UCQuanLyMenu_Load(object sender, EventArgs e)
        {
            splitContainer.SplitterDistance = (int)(this.Height * 0.1);
            lb_timkiem.Location = new Point(0, 10);
            txt_timkiem.Location = new Point(lb_timkiem.Right + 5, 10);
            txt_timkiem.Width = splitContainer.Panel1.Width - lb_timkiem.Width - 20;
            txt_timkiem.Height = (int)(splitContainer.Panel1.Height * 0.8);
        }
        private void List_menu_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn hay không
            if (list_menu.SelectedRows.Count > 0)
            {
                // Nếu có dòng được chọn, cho phép các nút được nhấn
                btnmenu_themban.Enabled = true;
                btnmenu_xoa.Enabled = true;
            }
            else
            {
                // Nếu không có dòng nào được chọn, vô hiệu hóa các nút
                btnmenu_themban.Enabled = false;
                btnmenu_xoa.Enabled = false;
            }
        }
        private void splitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void list_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnmenu_themsp_Click(object sender, EventArgs e)
        {
            fThemSanPham formThemSanPham = new fThemSanPham();
            formThemSanPham.ShowDialog();
            LoadMenuList(null);
        }
    }
}
