using Guna.UI2.WinForms;
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
    public partial class fLogin : Form
    {

        public fLogin()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            LoginDLL loginService = new LoginDLL();
            bool isValidLogin = loginService.KiemTra(username, password);
            if (isValidLogin)
            {

                //MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void lb_username_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                // Hiển thị mật khẩu
                txt_password.PasswordChar = '\0'; // '\0' là ký tự null, nó sẽ hiển thị nội dung gốc
            }
            else
            {
                // Ẩn mật khẩu
                txt_password.PasswordChar = '*'; // Dấu '*' sẽ ẩn nội dung mật khẩu
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
