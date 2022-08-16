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
    public partial class FormBanHang : Form
    {
        bool isExit = true;
        String tenNV;

        DataTable dt;

        int tongTienOrder = 0;
        int tienTraLai = 0;
        int tienKhachDua = 0;
        ProductBLL productBLL = new ProductBLL();
        public FormBanHang(string tenNV)
        {

            InitializeComponent();
            this.tenNV = tenNV;
        }

        public void GetHeaderText()
        {
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView2.Columns[2].HeaderText = "Số lượng";
            dataGridView2.Columns[3].HeaderText = "Giá";
            dataGridView2.Columns[4].HeaderText = "Phân loại";
            dataGridView2.Columns[5].HeaderText = "Nhà sản xuất";
            GetSizeColumn2();
        }

        public void GetSizeColumn()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 100;
        }
        public void GetSizeColumn2()
        {
            dataGridView2.Columns[0].Width = 50;
            dataGridView2.Columns[1].Width = 180;
            dataGridView2.Columns[2].Width = 70;
            dataGridView2.Columns[3].Width = 80;
            dataGridView2.Columns[4].Width = 100;
            dataGridView2.Columns[5].Width = 90;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            cBoxTimKiem.Text = "Tất cả";
            ProductBLL productBLL = new ProductBLL();
            lblTenNV.Text = tenNV;
            dataGridView2.DataSource = productBLL.loadAll();
            GetHeaderText();

            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dt = new DataTable();

            dt.Columns.Add("STT");
            dt.Columns.Add("Tên Sản phẩm");
            dt.Columns.Add("Giá");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Tổng tiền");
            dataGridView1.DataSource = dt;
            lblTongTien.Text = tongTienOrder.ToString();
            GetSizeColumn();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtBoxTenSP.Text = dataGridView2.SelectedCells[1].Value.ToString();
            txtBoxGia.Text = dataGridView2.SelectedCells[3].Value.ToString();
            txtBoxSoLuong.Text = "1";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxTimKiem.Text == "Tất cả")
            {
                FormBanHang_Load(sender, e);
                return;
            }

            dataGridView2.DataSource = productBLL.selectLoai(cBoxTimKiem.Text);
        }
        int idSP = 0;
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void tinhTienOder()
        {
            tongTienOrder = 0;

            foreach (DataRow dataRow in dt.Rows)
            {
                tongTienOrder += int.Parse(dataRow[4].ToString());
            }
            lblTongTien.Text = tongTienOrder.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            txtBoxTienTra.Text = "";
            int tongSL;
            int tongTien;

            if (txtBoxTenSP.Text == "" || txtBoxSoLuong.Text == "")
            {
                return;
            }
            foreach (DataRow dataRow in dt.Rows)
            {

                if (txtBoxTenSP.Text == dataRow[1].ToString())
                {
                    tongSL = int.Parse(txtBoxSoLuong.Text) + int.Parse(dataRow[3].ToString());
                    dataRow[3] = tongSL.ToString();
                    tongTien = int.Parse(dataRow[2].ToString()) * int.Parse(dataRow[3].ToString());
                    dataRow[4] = tongTien.ToString();
                    tongTienOrder = productBLL.tinhTienOder(dt);

                    lblTongTien.Text = tongTienOrder.ToString();
                    return;
                }
            }

            idSP++;
            DataRow row = dt.NewRow();

            row[0] = idSP.ToString();
            row[1] = txtBoxTenSP.Text;
            row[2] = txtBoxGia.Text;
            row[3] = txtBoxSoLuong.Text;

            tongTien = int.Parse(row[2].ToString()) * int.Parse(row[3].ToString());

            row[4] = tongTien.ToString();

            dt.Rows.Add(row);



            tongTienOrder = productBLL.tinhTienOder(dt);
            lblTongTien.Text = tongTienOrder.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBoxTienTra.Text = "";
            txtBoxTienKhach.Text = "";
            txtBoxTenSP.Text = "";
            txtBoxGia.Text = "";
            txtBoxSoLuong.Text = "";
            lblTongTien.Text = "0";
            dt.Clear();
        }

        private void btnTienTra_Click(object sender, EventArgs e)
        {
            if (txtBoxTienKhach.Text == "")
            {
                MessageBox.Show("Chưa nhập tiền khách đưa !!!", "Thông báo");
                return;
            }
            if (int.Parse(txtBoxTienKhach.Text) < tongTienOrder)
            {
                MessageBox.Show("Tiền khách đưa không đủ!!!", "Thông báo");
                return;
            }
            tienKhachDua = int.Parse(txtBoxTienKhach.Text);
            tienTraLai = tienKhachDua - tongTienOrder;
            txtBoxTienTra.Text = tienTraLai.ToString();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            StaffBLL staffBLL = new StaffBLL();
            DataTable dtTen = staffBLL.selectTenNV(lblTenNV.Text);
            tenNV = dtTen.Rows[0][0].ToString();
            if (dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("Hóa đơn phải có ít nhất 1 sản phẩm");
                return;
            }

            ExportBill.ExportFile(dt, tenNV, tongTienOrder, tienKhachDua, tienTraLai);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            isExit = false;
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected)
                {
                    if (dt.Rows.Count < 1)
                    {
                        return;
                    }
                    tongTienOrder -= int.Parse(dt.Rows[i][4].ToString());
                    lblTongTien.Text = tongTienOrder.ToString();
                    dataGridView1.Rows.RemoveAt(i);
                }

            }
        }

        private void txtBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            string name = txtBoxTimKiem.Text;

            if (name == "")
            {
                if (cBoxTimKiem.Text == "Tất cả")
                {
                    ProductBLL productBLL = new ProductBLL();
                    dataGridView2.DataSource = productBLL.loadAll();

                }
                else
                {
                    dataGridView2.DataSource = productBLL.selectLoai(cBoxTimKiem.Text);
                }
            }
            else
            {
                ProductBLL productBLL = new ProductBLL();
                dataGridView2.DataSource = productBLL.selectTenSanPhamTheoLoai(name, cBoxTimKiem.Text);
            }
        }

        private void cBoxTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormBanHang_FormClosing(object sender, FormClosingEventArgs e)
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