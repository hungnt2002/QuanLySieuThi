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
    public partial class FormQLSanPham : Form
    {
        public FormQLSanPham()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQLNhanVien formQLNhanVien = new FormQLNhanVien();
            formQLNhanVien.Show();
            this.Close();
        }


        private void FormQLSanPham_Load(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            dataGridView1.DataSource = productBLL.loadAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[3].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedCells[4].Value.ToString(); 
            textBox5.Text = dataGridView1.SelectedCells[5].Value.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool check;
            ProductBLL productBLL = new ProductBLL();
            try
            {
                check = productBLL.insert(textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text), comboBox2.Text, textBox5.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message, "Thông báo");
                return;
            }

            if(check == true)
            {
                MessageBox.Show("Thêm thành công!!!", "Thông báo");
                FormQLSanPham_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Trùng tên sản phẩm!!!", "Thông báo");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool check;
            ProductBLL productBLL = new ProductBLL();
            try
            {
                check = productBLL.delete(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message, "Thông báo");
                return;
            }

            if (check == true)
            {
                MessageBox.Show("Xóa thành công!!!", "Thông báo");
                FormQLSanPham_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên sản phẩm để xóa!!!", "Thông báo");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool check;
            ProductBLL productBLL = new ProductBLL();
            try
            {
                check = productBLL.update(textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text), comboBox2.Text, textBox5.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message, "Thông báo");
                return;
            }

            if (check == true)
            {
                MessageBox.Show("Sửa thành công!!!", "Thông báo");
                FormQLSanPham_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên sản phẩm để sửa!!!", "Thông báo");

            }


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string name = textBox7.Text;

            if(name == "")
            {
                FormQLSanPham_Load(sender, e);
            }
            else
            {
                ProductBLL productBLL = new ProductBLL();
                dataGridView1.DataSource = productBLL.selectCondition(name);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
