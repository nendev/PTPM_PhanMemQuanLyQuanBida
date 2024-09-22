namespace ManageBIDA1.Presentation
{
    partial class fThemSanPham
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            btn_AddMenu = new Guna.UI2.WinForms.Guna2Button();
            txt_gia = new Guna.UI2.WinForms.Guna2TextBox();
            txt_Tensp = new Guna.UI2.WinForms.Guna2TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(531, 284);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 3);
            tableLayoutPanel1.Controls.Add(btn_AddMenu, 1, 5);
            tableLayoutPanel1.Controls.Add(txt_gia, 1, 4);
            tableLayoutPanel1.Controls.Add(txt_Tensp, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 123F));
            tableLayoutPanel1.Size = new Size(531, 284);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 24);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên món:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 93);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "Giá:";
            // 
            // btn_AddMenu
            // 
            btn_AddMenu.BorderRadius = 10;
            btn_AddMenu.CustomizableEdges = customizableEdges7;
            btn_AddMenu.DisabledState.BorderColor = Color.DarkGray;
            btn_AddMenu.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_AddMenu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_AddMenu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_AddMenu.FillColor = Color.FromArgb(0, 192, 0);
            btn_AddMenu.Font = new Font("Segoe UI", 9F);
            btn_AddMenu.ForeColor = Color.White;
            btn_AddMenu.Location = new Point(91, 164);
            btn_AddMenu.Name = "btn_AddMenu";
            btn_AddMenu.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_AddMenu.Size = new Size(348, 52);
            btn_AddMenu.TabIndex = 4;
            btn_AddMenu.Text = "Thêm";
            btn_AddMenu.Click += btn_AddMenu_Click;
            // 
            // txt_gia
            // 
            txt_gia.CustomizableEdges = customizableEdges9;
            txt_gia.DefaultText = "";
            txt_gia.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_gia.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_gia.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_gia.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_gia.Dock = DockStyle.Fill;
            txt_gia.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_gia.Font = new Font("Segoe UI", 9F);
            txt_gia.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_gia.Location = new Point(91, 122);
            txt_gia.Margin = new Padding(3, 4, 3, 4);
            txt_gia.Name = "txt_gia";
            txt_gia.PasswordChar = '\0';
            txt_gia.PlaceholderText = "";
            txt_gia.SelectedText = "";
            txt_gia.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txt_gia.Size = new Size(348, 35);
            txt_gia.TabIndex = 5;
            txt_gia.KeyPress += txt_gia_KeyPress;
            // 
            // txt_Tensp
            // 
            txt_Tensp.CustomizableEdges = customizableEdges11;
            txt_Tensp.DefaultText = "";
            txt_Tensp.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Tensp.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Tensp.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Tensp.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Tensp.Dock = DockStyle.Fill;
            txt_Tensp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Tensp.Font = new Font("Segoe UI", 9F);
            txt_Tensp.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Tensp.Location = new Point(91, 53);
            txt_Tensp.Margin = new Padding(3, 4, 3, 4);
            txt_Tensp.Name = "txt_Tensp";
            txt_Tensp.PasswordChar = '\0';
            txt_Tensp.PlaceholderText = "";
            txt_Tensp.SelectedText = "";
            txt_Tensp.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txt_Tensp.Size = new Size(348, 36);
            txt_Tensp.TabIndex = 6;
            // 
            // fThemSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 284);
            Controls.Add(panel1);
            Name = "fThemSanPham";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm menu";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_AddMenu;
        private Guna.UI2.WinForms.Guna2TextBox txt_gia;
        private Guna.UI2.WinForms.Guna2TextBox txt_Tensp;
    }
}