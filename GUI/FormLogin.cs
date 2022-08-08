using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            bool check = login.checkAccount(txtBoxTaiKhoan.Text, TextBoxMatKhau.Text);
            if(check == true)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo");
            }
        }

        
    }
}
