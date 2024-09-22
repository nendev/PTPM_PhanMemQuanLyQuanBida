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
    public partial class UCTable : UserControl
    {

        public UCTable()
        {
            InitializeComponent();
            LoadUCTable();
        }

        private void LoadUCTable()
        {
            flowLayoutPanel.Controls.Clear();

            // Vòng lặp để tạo và thêm các instance của Table
            for (int i = 1; i <= 15; i++)
            {
                string tenBan = $"Bàn {i:D2}";
                string loaiBan = $"Loại bàn {i}";
                decimal donGia = 40000;

                var table = new Table(tenBan, loaiBan, donGia)
                {
                    Width = 200, // Kích thước phù hợp với FlowLayoutPanel
                    Height = 100
                };

                flowLayoutPanel.Controls.Add(table);
            }
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
