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
    public partial class FormBanHang : Form
    {
        String tenNV;
        public FormBanHang(string tenNV)
        {
            this.tenNV = tenNV; 
            InitializeComponent();
            this.tenNV = tenNV;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool check = TestAccountDAL.insert();

            MessageBox.Show(check.ToString());
            

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            label1.Text = tenNV;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
