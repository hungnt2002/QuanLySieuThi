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
namespace GUI
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            if (TextBoxMatKhau.Text.Equals(textBoxNhapLaiMatKhau.Text))
            {
                RegisterBLL register = new RegisterBLL();
                bool checkUser = register.checkAccount(txtBoxTaiKhoan.Text, TextBoxMatKhau.Text);
                if (checkUser == true)
                {

                    MessageBox.Show("Đăng kí tài khoản " + txtBoxTaiKhoan.Text + " thành công", "Thông báo");
                }
                else if (checkUser == false)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu đã có người sử dụng ", "Thông báo");

                }
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp ", "Thông báo");
            }
        }
    }
}
