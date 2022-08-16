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
    public partial class FormQLNhanVien : Form
    {
        public FormQLNhanVien()
        {
            InitializeComponent();
        }

        private void FormQLNhanVien_Load(object sender, EventArgs e)
        {
            StaffBLL staffBLL = new StaffBLL();
            dataGridView1.DataSource = staffBLL.loadAll();

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxID.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtBoxTenNV.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtBoxTuoi.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtBoxSDT.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtBoxTaiKhoan.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txtBoxMatKhau.Text = dataGridView1.SelectedCells[5].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQLSanPham formQLSanPham = new FormQLSanPham();
            formQLSanPham.ShowDialog();
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool check;
            try
            {
                StaffBLL staffBLL = new StaffBLL();
                check = staffBLL.insert(txtBoxTenNV.Text, txtBoxTuoi.Text, txtBoxSDT.Text, txtBoxTaiKhoan.Text, txtBoxMatKhau.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message, "Thông báo");
                return;
            }

            if (check == true)
            {
                MessageBox.Show("Thêm thành công!!!", "Thông báo");
                FormQLNhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Trùng username!!!", "Thông báo");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool check;
            StaffBLL staffBLL = new StaffBLL();
            try
            {
                check = staffBLL.update(txtBoxID.Text, txtBoxTenNV.Text, txtBoxTuoi.Text, txtBoxSDT.Text, txtBoxTaiKhoan.Text, txtBoxMatKhau.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message, "Thông báo");
                return;
            }

            if (check == true)
            {
                MessageBox.Show("Sửa thành công!!!", "Thông báo");
                FormQLNhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không tìm thấy username để sửa!!!", "Thông báo");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check;
            StaffBLL staffBLL = new StaffBLL();
            try
            {
                check = staffBLL.delete(txtBoxID.Text, txtBoxMatKhau.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message, "Thông báo");
                return;
            }

            if (check == true)
            {
                MessageBox.Show("Xóa thành công!!!", "Thông báo");
                FormQLNhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên đăng nhập để xóa!!!", "Thông báo");

            }
        }
    }
}
