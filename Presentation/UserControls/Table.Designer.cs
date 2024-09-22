namespace ManageBIDA1.Presentation.UserControls
{
    partial class Table
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
            tableLayoutPanel1 = new TableLayoutPanel();
            name = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbTrangThai = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(name, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(174, 30);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Click += Table_Click;
            tableLayoutPanel1.DoubleClick += Table_Click;
            tableLayoutPanel1.MouseClick += tableLayoutPanel1_MouseClick;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(62, 0);
            name.Name = "name";
            name.Size = new Size(50, 20);
            name.TabIndex = 0;
            name.Text = "label1";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lbTrangThai, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 90);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(174, 26);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lbTrangThai
            // 
            lbTrangThai.AutoSize = true;
            lbTrangThai.Location = new Point(3, 0);
            lbTrangThai.Name = "lbTrangThai";
            lbTrangThai.Size = new Size(74, 20);
            lbTrangThai.TabIndex = 0;
            lbTrangThai.Text = "Bàn trống";
            // 
            // Table
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Table";
            Size = new Size(180, 119);
            Load += Table_Load;
            MouseDown += Table_MouseDown;
            MouseEnter += Table_MouseEnter;
            MouseLeave += Table_MouseLeave;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label name;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbTrangThai;
    }
}
