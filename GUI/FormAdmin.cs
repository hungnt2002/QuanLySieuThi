using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormAdmin : Form
    {
        bool isExit = true;
        public FormAdmin()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();

            }
            currentFormChild = childForm;
            childForm.TopLevel = false; // Show form con có thể thực hiện tiếp trên form cha
            childForm.FormBorderStyle = FormBorderStyle.None;//đóng hộp thoại  - o x
            childForm.Dock = DockStyle.Fill; //Lấp đầy panel
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm; //truyền dữ liệu qua panel
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();

            }
            label1.Text = "Home";

        }

        private void btnFormSP_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQLSanPham());
            label1.Text = btnFormSP.Text;
        }

        private void btnFormNV_Click(object sender, EventArgs e)
        {
            openChildForm(new FormQLNhanVien());
            label1.Text = btnFormNV.Text;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            isExit = false;
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit == true)
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
    }
}
