using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            LoginBLL login = new LoginBLL();
            string checkUser = login.checkAccount(txtBoxTaiKhoan.Text, TextBoxMatKhau.Text);
            if(checkUser == "Admin")
            {
                
                MessageBox.Show("Đăng nhập tài khoản " + txtBoxTaiKhoan.Text + " thành công", "Thông báo", MessageBoxButtons.OK);
                this.Hide();
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.ShowDialog();
                this.Show();

            }
            else if(checkUser == "User")
            {
                MessageBox.Show("Đăng nhập tài khoản " + txtBoxTaiKhoan.Text + " thành công", "Thông báo", MessageBoxButtons.OK);
                this.Hide();
                FormBanHang formBanHang = new FormBanHang(txtBoxTaiKhoan.Text);
                formBanHang.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtBoxTaiKhoan.Clear();
            TextBoxMatKhau.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
