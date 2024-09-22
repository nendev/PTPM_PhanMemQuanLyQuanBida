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
    public partial class Table : UserControl
    {
        // Các thuộc tính để lưu trữ giá trị truyền vào
        public string TenBan { get; set; }
        public string LoaiBan { get; set; }
        public decimal DonGia { get; set; }
        private Color originalBackColor;

        private ContextMenuStrip contextMenuStrip;
        // Khởi tạo với các tham số
        public Table(string tenban, string loaiban, decimal dongia)
        {
            InitializeComponent();

            // Gán các giá trị cho các thuộc tính
            TenBan = tenban;
            LoaiBan = loaiban;
            DonGia = dongia;
            originalBackColor = this.BackColor;
            // Cập nhật giao diện
            UpdateUI();
            InitializeContextMenu();
        }

        // Phương thức để cập nhật giao diện
        private void UpdateUI()
        {
            // Đặt giá trị cho label "ten"
            if (name != null)
            {
                name.Text = TenBan;
            }

            // Bạn có thể cập nhật thêm các phần tử giao diện khác nếu cần
        }
        private void Table_Click(object sender, EventArgs e)
        {
            // Hiển thị thông báo khi nhấp chuột vào UserControl
            MessageBox.Show($"Bàn: {TenBan}\nLoại bàn: {LoaiBan}\nĐơn giá: {DonGia}", "Thông tin bàn");
        }
        private void InitializeContextMenu()
        {
            contextMenuStrip = new ContextMenuStrip();

            // Tạo các mục menu
            var openTableMenuItem = new ToolStripMenuItem("Mở bàn");
            var addDishMenuItem = new ToolStripMenuItem("Thêm món");
            var moveTableMenuItem = new ToolStripMenuItem("Chuyển bàn");

            // Thêm các mục menu vào ContextMenuStrip
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { openTableMenuItem, addDishMenuItem, moveTableMenuItem });

            // Đăng ký sự kiện cho các mục menu
            openTableMenuItem.Click += (s, e) => OpenTable();
            addDishMenuItem.Click += (s, e) => AddDish();
            moveTableMenuItem.Click += (s, e) => MoveTable();
        }
        private void OpenTable()
        {
            MessageBox.Show($"Mở bàn: {TenBan}", "Mở bàn");
        }

        // Phương thức để thêm món (tùy chỉnh theo yêu cầu của bạn)
        private void AddDish()
        {
            MessageBox.Show($"Thêm món cho bàn: {TenBan}", "Thêm món");
        }

        // Phương thức để chuyển bàn (tùy chỉnh theo yêu cầu của bạn)
        private void MoveTable()
        {
            MessageBox.Show($"Chuyển bàn: {TenBan}", "Chuyển bàn");
        }
        private void Table_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Hiển thị thông báo khi nhấp chuột trái vào UserControl
                MessageBox.Show($"Bàn: {TenBan}\nLoại bàn: {LoaiBan}\nĐơn giá: {DonGia}", "Thông tin bàn");
            }
            else if (e.Button == MouseButtons.Right)
            {
                // Kiểm tra và hiển thị menu popup khi nhấp chuột phải vào UserControl
                if (contextMenuStrip != null)
                {
                    contextMenuStrip.Show(this, e.Location);
                }
                else
                {
                    MessageBox.Show("ContextMenuStrip is not initialized.");
                }
            }
        }

        private void Table_Load(object sender, EventArgs e)
        {
            // Đảm bảo rằng giao diện được cập nhật khi UserControl được tải
            UpdateUI();
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show($"Bàn: {TenBan}\nLoại bàn: {LoaiBan}\nĐơn giá: {DonGia}", "Thông tin bàn");
        }
        private void Table_MouseEnter(object sender, EventArgs e)
        {
            // Làm nhạt màu nền của UserControl
            this.BackColor = ChangeColorBrightness(originalBackColor, -0.4f);
        }

        // Phương thức xử lý sự kiện MouseLeave
        private void Table_MouseLeave(object sender, EventArgs e)
        {
            // Khôi phục màu nền gốc của UserControl
            this.BackColor = originalBackColor;
        }

        // Phương thức để thay đổi độ sáng của màu
        private Color ChangeColorBrightness(Color color, float correctionFactor)
        {
            float red = color.R / 255f;
            float green = color.G / 255f;
            float blue = color.B / 255f;

            red = Clamp(red + correctionFactor);
            green = Clamp(green + correctionFactor);
            blue = Clamp(blue + correctionFactor);

            return Color.FromArgb(color.A, (int)(red * 255), (int)(green * 255), (int)(blue * 255));
        }

        // Phương thức để đảm bảo giá trị màu nằm trong khoảng từ 0 đến 1
        private float Clamp(float value)
        {
            if (value < 0)
                return 0;
            if (value > 1)
                return 1;
            return value;
        }
    }
}
