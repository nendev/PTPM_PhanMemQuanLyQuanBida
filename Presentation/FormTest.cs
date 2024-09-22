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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill; // Chiếm toàn bộ UserControl
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.RowCount = 2;

            // Đặt tỷ lệ phần trăm cho các cột và hàng
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            // Thêm các điều khiển vào các ô trong TableLayoutPanel
            Button btn1 = new Button { Text = "Button 1", Dock = DockStyle.Fill };
            Button btn2 = new Button { Text = "Button 2", Dock = DockStyle.Fill };
            Button btn3 = new Button { Text = "Button 3", Dock = DockStyle.Fill };
            Button btn4 = new Button { Text = "Button 4", Dock = DockStyle.Fill };

            tableLayoutPanel.Controls.Add(btn1, 0, 0);
            tableLayoutPanel.Controls.Add(btn2, 1, 0);
            tableLayoutPanel.Controls.Add(btn3, 0, 1);
            tableLayoutPanel.Controls.Add(btn4, 1, 1);

            // Thêm TableLayoutPanel vào UserControl
            this.Controls.Add(tableLayoutPanel);
        }
    }
}
