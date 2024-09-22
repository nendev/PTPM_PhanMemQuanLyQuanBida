namespace ManageBIDA1.Presentation.UserControls
{
    partial class UCQuanLyMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            splitContainer = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel_timkiem = new Panel();
            txt_timkiem = new Guna.UI2.WinForms.Guna2TextBox();
            lb_timkiem = new Label();
            panel_btnmenu = new Panel();
            btnmenu_themsp = new Guna.UI2.WinForms.Guna2Button();
            btnmenu_themban = new Guna.UI2.WinForms.Guna2Button();
            btnmenu_xoa = new Guna.UI2.WinForms.Guna2Button();
            list_menu = new Guna.UI2.WinForms.Guna2DataGridView();
            id = new DataGridViewTextBoxColumn();
            tensanpham = new DataGridViewTextBoxColumn();
            dongia = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel_timkiem.SuspendLayout();
            panel_btnmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)list_menu).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = SystemColors.AppWorkspace;
            splitContainer.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer.Panel1.Paint += splitContainer_Panel1_Paint;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = SystemColors.ControlDarkDark;
            splitContainer.Panel2.Controls.Add(list_menu);
            splitContainer.Size = new Size(819, 462);
            splitContainer.SplitterDistance = 76;
            splitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.93895F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.06105F));
            tableLayoutPanel1.Controls.Add(panel_timkiem, 0, 0);
            tableLayoutPanel1.Controls.Add(panel_btnmenu, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(819, 76);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_timkiem
            // 
            panel_timkiem.Controls.Add(txt_timkiem);
            panel_timkiem.Controls.Add(lb_timkiem);
            panel_timkiem.Dock = DockStyle.Fill;
            panel_timkiem.Location = new Point(3, 3);
            panel_timkiem.Name = "panel_timkiem";
            panel_timkiem.Padding = new Padding(10);
            panel_timkiem.Size = new Size(403, 70);
            panel_timkiem.TabIndex = 0;
            // 
            // txt_timkiem
            // 
            txt_timkiem.CustomizableEdges = customizableEdges1;
            txt_timkiem.DefaultText = "";
            txt_timkiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_timkiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_timkiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_timkiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_timkiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_timkiem.Font = new Font("Segoe UI", 9F);
            txt_timkiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_timkiem.Location = new Point(84, 1);
            txt_timkiem.Margin = new Padding(3, 4, 3, 4);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.PasswordChar = '\0';
            txt_timkiem.PlaceholderText = "";
            txt_timkiem.SelectedText = "";
            txt_timkiem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_timkiem.Size = new Size(316, 46);
            txt_timkiem.TabIndex = 1;
            txt_timkiem.TextChanged += Txt_timkiem_TextChanged;
            // 
            // lb_timkiem
            // 
            lb_timkiem.AutoSize = true;
            lb_timkiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_timkiem.Location = new Point(13, 10);
            lb_timkiem.Name = "lb_timkiem";
            lb_timkiem.Size = new Size(75, 20);
            lb_timkiem.TabIndex = 0;
            lb_timkiem.Text = "Tìm kiếm:";
            // 
            // panel_btnmenu
            // 
            panel_btnmenu.Controls.Add(btnmenu_themsp);
            panel_btnmenu.Controls.Add(btnmenu_themban);
            panel_btnmenu.Controls.Add(btnmenu_xoa);
            panel_btnmenu.Dock = DockStyle.Fill;
            panel_btnmenu.Location = new Point(412, 3);
            panel_btnmenu.Name = "panel_btnmenu";
            panel_btnmenu.Size = new Size(404, 70);
            panel_btnmenu.TabIndex = 1;
            // 
            // btnmenu_themsp
            // 
            btnmenu_themsp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnmenu_themsp.CustomizableEdges = customizableEdges3;
            btnmenu_themsp.DisabledState.BorderColor = Color.DarkGray;
            btnmenu_themsp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnmenu_themsp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnmenu_themsp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnmenu_themsp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmenu_themsp.ForeColor = Color.White;
            btnmenu_themsp.Location = new Point(3, 4);
            btnmenu_themsp.Name = "btnmenu_themsp";
            btnmenu_themsp.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnmenu_themsp.Size = new Size(153, 43);
            btnmenu_themsp.TabIndex = 2;
            btnmenu_themsp.Text = "Thêm sản phẩm";
            btnmenu_themsp.Click += btnmenu_themsp_Click;
            // 
            // btnmenu_themban
            // 
            btnmenu_themban.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnmenu_themban.CustomizableEdges = customizableEdges5;
            btnmenu_themban.DisabledState.BorderColor = Color.DarkGray;
            btnmenu_themban.DisabledState.CustomBorderColor = Color.DarkGray;
            btnmenu_themban.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnmenu_themban.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnmenu_themban.Enabled = false;
            btnmenu_themban.FillColor = Color.LimeGreen;
            btnmenu_themban.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmenu_themban.ForeColor = Color.White;
            btnmenu_themban.Location = new Point(162, 4);
            btnmenu_themban.Name = "btnmenu_themban";
            btnmenu_themban.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnmenu_themban.Size = new Size(127, 43);
            btnmenu_themban.TabIndex = 1;
            btnmenu_themban.Text = "Thêm vào bàn";
            // 
            // btnmenu_xoa
            // 
            btnmenu_xoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnmenu_xoa.CustomizableEdges = customizableEdges7;
            btnmenu_xoa.DisabledState.BorderColor = Color.DarkGray;
            btnmenu_xoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnmenu_xoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnmenu_xoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnmenu_xoa.Enabled = false;
            btnmenu_xoa.FillColor = Color.OrangeRed;
            btnmenu_xoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmenu_xoa.ForeColor = Color.White;
            btnmenu_xoa.Location = new Point(295, 4);
            btnmenu_xoa.Name = "btnmenu_xoa";
            btnmenu_xoa.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnmenu_xoa.Size = new Size(106, 43);
            btnmenu_xoa.TabIndex = 0;
            btnmenu_xoa.Text = "Xóa";
            btnmenu_xoa.Click += btnmenu_xoa_Click;
            // 
            // list_menu
            // 
            list_menu.AllowUserToAddRows = false;
            list_menu.AllowUserToDeleteRows = false;
            list_menu.AllowUserToOrderColumns = true;
            list_menu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            list_menu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            list_menu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            list_menu.ColumnHeadersHeight = 42;
            list_menu.Columns.AddRange(new DataGridViewColumn[] { id, tensanpham, dongia });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            list_menu.DefaultCellStyle = dataGridViewCellStyle3;
            list_menu.Dock = DockStyle.Fill;
            list_menu.GridColor = Color.FromArgb(231, 229, 255);
            list_menu.Location = new Point(0, 0);
            list_menu.MultiSelect = false;
            list_menu.Name = "list_menu";
            list_menu.ReadOnly = true;
            list_menu.RowHeadersVisible = false;
            list_menu.RowHeadersWidth = 51;
            list_menu.Size = new Size(819, 382);
            list_menu.TabIndex = 0;
            list_menu.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            list_menu.ThemeStyle.AlternatingRowsStyle.Font = null;
            list_menu.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            list_menu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            list_menu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            list_menu.ThemeStyle.BackColor = Color.White;
            list_menu.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            list_menu.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            list_menu.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            list_menu.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            list_menu.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            list_menu.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            list_menu.ThemeStyle.HeaderStyle.Height = 42;
            list_menu.ThemeStyle.ReadOnly = true;
            list_menu.ThemeStyle.RowsStyle.BackColor = Color.White;
            list_menu.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            list_menu.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            list_menu.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            list_menu.ThemeStyle.RowsStyle.Height = 29;
            list_menu.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            list_menu.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            list_menu.CellContentClick += list_menu_CellContentClick;
            list_menu.SelectionChanged += List_menu_SelectionChanged;
            // 
            // id
            // 
            id.HeaderText = "#";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // tensanpham
            // 
            tensanpham.HeaderText = "Tên sản phẩm";
            tensanpham.MinimumWidth = 6;
            tensanpham.Name = "tensanpham";
            tensanpham.ReadOnly = true;
            // 
            // dongia
            // 
            dongia.HeaderText = "Đơn giá";
            dongia.MinimumWidth = 6;
            dongia.Name = "dongia";
            dongia.ReadOnly = true;
            // 
            // UCQuanLyMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer);
            Name = "UCQuanLyMenu";
            Size = new Size(819, 462);
            Load += UCQuanLyMenu_Load;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel_timkiem.ResumeLayout(false);
            panel_timkiem.PerformLayout();
            panel_btnmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)list_menu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_timkiem;
        private Label lb_timkiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_timkiem;
        private Panel panel_btnmenu;
        private Guna.UI2.WinForms.Guna2Button btnmenu_xoa;
        private Guna.UI2.WinForms.Guna2Button btnmenu_themban;
        private Guna.UI2.WinForms.Guna2Button btnmenu_themsp;
        private Guna.UI2.WinForms.Guna2DataGridView list_menu;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn tensanpham;
        private DataGridViewTextBoxColumn dongia;
    }
}
