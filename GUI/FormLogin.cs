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
        bool isExit = true;
        public FormLogin()
        {
            InitializeComponent();
        }


        public bool checkInput()
        {
            if (txtBoxTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                return false;
            }
            else if(TxtBoxMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                return false;
            }
            return true;
        }


        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isExit == true)
            {
                if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                } 
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                return;
            }

            LoginBLL login = new LoginBLL();
            string checkUser = login.checkAccount(txtBoxTaiKhoan.Text, TxtBoxMatKhau.Text);
            if (checkUser == "Admin")
            {

                MessageBox.Show("Đăng nhập tài khoản " + txtBoxTaiKhoan.Text + " thành công", "Thông báo", MessageBoxButtons.OK);
                this.Hide();
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                isExit = false;
                this.Close();

            }
            else if (checkUser == "User")
            {
                MessageBox.Show("Đăng nhập tài khoản " + txtBoxTaiKhoan.Text + " thành công", "Thông báo", MessageBoxButtons.OK);
                this.Hide();
                FormBanHang formBanHang = new FormBanHang(txtBoxTaiKhoan.Text);
                formBanHang.Show();
                isExit = false;
                this.Close();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo");
            }
        }

        private void lblHoanTac_Click(object sender, EventArgs e)
        {
            txtBoxTaiKhoan.Text = "";
            TxtBoxMatKhau.Text = "";
            txtBoxTaiKhoan.Focus();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtBoxTaiKhoan.Focus();
        }

       
    }
}
