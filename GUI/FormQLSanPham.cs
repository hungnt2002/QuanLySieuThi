using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using OfficeOpenXml;

namespace GUI
{

    public partial class FormQLSanPham : Form
    {
        DataTable dt;
        public FormQLSanPham()
        {
            InitializeComponent();
        }

        public void Header()
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQLNhanVien formQLNhanVien = new FormQLNhanVien();
            formQLNhanVien.Show();
            this.Close();
        }

        public void GetHeaderText()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Giá";
            dataGridView1.Columns[4].HeaderText = "Phân loại";
            dataGridView1.Columns[5].HeaderText = "Nhà sản xuất";
            GetSizeColumn();
        }

        public void GetSizeColumn()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 100;
        }

        private void FormQLSanPham_Load(object sender, EventArgs e)
        {
            ProductBLL productBLL = new ProductBLL();
            dataGridView1.DataSource = productBLL.loadAll();
            GetHeaderText();
            
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message, "Thông báo");
                return;
            }

            if (check == true)
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

            if (name == "")
            {
                FormQLSanPham_Load(sender, e);
            }
            else
            {
                ProductBLL productBLL = new ProductBLL();
                dataGridView1.DataSource = productBLL.selectTenSanPhamTheoLoai(name, comboBox1.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Tất cả")
            {
                FormQLSanPham_Load(sender, e);
                return;
            }
            ProductBLL productBLL = new ProductBLL();
            dataGridView1.DataSource = productBLL.selectLoai(comboBox1.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Tất cả";
            FormQLSanPham_Load(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox2.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("Phải có ít nhất 1 sản phẩm");
                return;
            }
            FormQLSanPham_Load(sender, e);
            dt = new DataTable();
            dt = (DataTable)dataGridView1.DataSource;

            ExcelProduct.ExportFile(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)| *.xlsx | Excel (*.xlsx) |*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetHeaderText();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập file thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }
        private void ImportExcel(string path)
        {

            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();

                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[2, i].Value.ToString());
                }

                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRows.ToArray());
                }
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
