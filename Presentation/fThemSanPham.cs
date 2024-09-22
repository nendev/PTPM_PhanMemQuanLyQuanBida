using ManageBIDA1.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageBIDA1.Presentation
{
    public partial class fThemSanPham : Form
    {
        private MenuDLL MenuDLL;
        public fThemSanPham()
        {
            InitializeComponent();
            MenuDLL = new MenuDLL();
        }

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }

            // Kiểm tra nếu đã có một dấu chấm thập phân thì không cho phép nhập thêm
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Loại bỏ ký tự không hợp lệ
            }
        }

        private void btn_AddMenu_Click(object sender, EventArgs e)
        {
            string tenSanPham = txt_Tensp.Text;
            float donGia;
            if (string.IsNullOrWhiteSpace(tenSanPham) || !float.TryParse(txt_gia.Text, out donGia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool result = MenuDLL.Insert(tenSanPham, donGia);
            if (result)
            {
                MessageBox.Show("Sản phẩm đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // đã xong kiểm tra lỗi
        }
    }
}
