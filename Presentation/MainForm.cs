using ManageBIDA1.Presentation.UserControls;

namespace ManageBIDA1
{
    public partial class MainForm : Form
    {
        public int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
        public int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        private UCSetting uCSetting;
        private UCQuanLyMenu uCQuanLyMenu;
        private UCTable uCTable;
        public MainForm()
        {

            InitializeComponent();
            btnQuanLyBan.Checked = true;
            btn_right.Checked = true;

            uCTable = new UCTable
            {
                Dock = DockStyle.Fill
            };
            PanelLeft_Content.Controls.Add(uCTable);
            uCSetting = new UCSetting
            {
                Dock = DockStyle.Fill // Đảm bảo UserControl chiếm toàn bộ diện tích của PanelLeft_Content
            };

            uCQuanLyMenu = new UCQuanLyMenu
            {
                Dock = DockStyle.Fill
            };
            
            this.Resize += new EventHandler(Form1_Resize);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = ColorTranslator.FromHtml("#00408c");
            SetKichThuoc();
            KhoiTaoFooter();
            KhoiTaoPanel();
            ViTriFooter();
            
        }
        private void KhoiTaoPanel()
        {
            int panelHeight = (int)(this.ClientSize.Height * 0.95);
            int leftPanelWidth = (int)(this.ClientSize.Width * 0.7);
            int rightPanelWidth = (int)(this.ClientSize.Width * 0.3);

            // Cấu hình leftPanel
            leftPanel.Width = leftPanelWidth;
            leftPanel.Height = panelHeight;
            leftPanel.Location = new Point(0, 0);
            leftPanel.BackColor = ColorTranslator.FromHtml("#00408c"); // Màu nền để dễ dàng nhận biết (có thể tùy chỉnh)
            KhoiTaoLeftPanel();
            // Cấu hình rightPanel
            rightPanel.Width = rightPanelWidth;
            rightPanel.Height = panelHeight;
            rightPanel.Location = new Point(leftPanelWidth, 0);
            rightPanel.BackColor = ColorTranslator.FromHtml("#00408c");
            KhoiTaoRightPanel();
        }
        private void KhoiTaoLeftPanel()
        {
            int panelButtonHeight = (int)(this.ClientSize.Height * 0.05);

            panelButton.Width = leftPanel.Width;
            panelButton.Height = panelButtonHeight;
            panelButton.Location = new Point(0, 20); // Đặt ở trên cùng của leftPanel

            // chỉnh chiều cao cho 2 button
            btnQuanLyBan.Height = panelButton.Height;
            btnQuanLyMenu.Height = panelButton.Height;
            btnSetting.Height = panelButton.Height;
            // Thêm panelButton vào leftPanel
            leftPanel.Controls.Add(panelButton);
            int panelContentY = panelButton.Location.Y + panelButton.Height - 8;

            // Tính toán chiều cao của PanelLeft_Content
            int panelContentHeight = leftPanel.Height - panelContentY - 10; // Trừ đi 10 để dành cho padding

            PanelLeft_Content.Width = leftPanel.Width - 20; // Trừ đi padding trái và phải (10 + 10)
            PanelLeft_Content.Height = panelContentHeight;
            PanelLeft_Content.Location = new Point(10, panelContentY); // Padding trái là 10, Y là ngay dưới btnQuanLyBan

            // Đặt padding cho PanelLeft_Content
            PanelLeft_Content.Padding = new Padding(10);
            // Tạo hai button và thêm chúng vào panelButton


        }
        private void KhoiTaoRightPanel()
        {
            int panelButtonHeight = (int)(this.ClientSize.Height * 0.05);
            panelButtonRight.Width = rightPanel.Width;
            panelButtonRight.Height = panelButtonHeight;
            panelButtonRight.Location = new Point(0, 20);

            btn_right.Height = panelButtonHeight;
            int panelContentY = panelButtonRight.Location.Y + panelButtonRight.Height - 8;
            int panelContentHeight = rightPanel.Height - panelContentY - 10;

            PanelRight_Content.Width = rightPanel.Width - 20; // Trừ đi padding trái và phải (10 + 10)
            PanelRight_Content.Height = panelContentHeight;
            PanelRight_Content.Location = new Point(10, panelContentY); // Padding trái là 10, Y là ngay dưới btnQuanLyBan

            // Đặt padding cho PanelLeft_Content
            PanelRight_Content.Padding = new Padding(10);

        }
        private void KhoiTaoTabControl()
        {
            //tabControl.Width = (int)(this.Width * 0.5);
            //tabControl.Location = new Point(0, 0);
            //// Đặt chiều cao của TabControl bằng 90% chiều cao của form
            //tabControl.Height = (int)(this.ClientSize.Height * 0.95);

            // Đặt vị trí của TabControl bắt đầu từ phía trên cùng bên trái

        }
        private void KhoiTaoFooter()
        {
            // đã kéo thả footer, thêm label vào
            lb_name.Text = "Phần Mềm Quản Lý CLB Bida v1.0";

            lb_sobansudung.ForeColor = ColorTranslator.FromHtml("#28b44f");
            lb_sobansudung_number.ForeColor = ColorTranslator.FromHtml("#28b44f");

            lb_bantrong_number.ForeColor = ColorTranslator.FromHtml("#0066cc");
            lb_bantrong.ForeColor = ColorTranslator.FromHtml("#0066cc");

            // Đặt lb_bantrong_number luôn nằm sát phía bên phải của PanelFooter
            int panelWidth = PanelFooter.Width;
            int panelHeight = PanelFooter.Height;

            int numberLabelWidth = lb_bantrong_number.Width;
            int bantrongLabelWidth = lb_bantrong.Width;
            int sobansudungNumberWidth = lb_sobansudung_number.Width;
            int sobansudungWidth = lb_sobansudung.Width;

            // Tính toán vị trí để lb_bantrong_number nằm sát bên phải
            int rightPosition = panelWidth - numberLabelWidth - 10;

            // Tính toán vị trí Top để các Label nằm giữa theo chiều dọc
            int middlePosition = (panelHeight - lb_bantrong_number.Height) / 2;

            // Cập nhật vị trí cho lb_bantrong_number
            lb_bantrong_number.Location = new Point(rightPosition, middlePosition);

            // Đặt lb_bantrong ở phía bên trái của lb_bantrong_number
            int bantrongPosition = rightPosition - bantrongLabelWidth;

            // Cập nhật vị trí cho lb_bantrong
            lb_bantrong.Location = new Point(bantrongPosition, middlePosition);

            // Cập nhật vị trí cho lb_sobansudung_number
            lb_sobansudung_number.Location = new Point(bantrongPosition - sobansudungNumberWidth - 10, middlePosition);

            // Cập nhật vị trí cho lb_sobansudung
            lb_sobansudung.Location = new Point(bantrongPosition - sobansudungNumberWidth - sobansudungWidth - 10, middlePosition);
        }
        private void ViTriFooter()
        {
            PanelFooter.Height = (int)(this.ClientSize.Height * 0.05);
            PanelFooter.Location = new Point(0, this.ClientSize.Height - PanelFooter.Height);
            KhoiTaoFooter();
        }
        private void SetKichThuoc()
        {


            // Đặt kích thước form bằng 95% kích thước màn hình
            this.Width = (int)(screenWidth * 0.9);
            this.Height = (int)(screenHeight * 0.95);

            // Đặt vị trí của form ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.WindowState = FormWindowState.Maximized;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            ViTriFooter();
            KhoiTaoFooter();
            KhoiTaoPanel();
            

        }

        private void btnQuanLyMenu_Click(object sender, EventArgs e)
        {
            PanelLeft_Content.Controls.Clear();
            
            PanelLeft_Content.Controls.Add(uCQuanLyMenu);

        }

        private void btnQuanLyBan_Click(object sender, EventArgs e)
        {
            PanelLeft_Content.Controls.Clear();
            
            PanelLeft_Content.Controls.Add(uCTable);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            PanelLeft_Content.Controls.Clear();
            
            PanelLeft_Content.Controls.Add(uCSetting);
        }

    }
}
