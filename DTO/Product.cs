using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        private string tenSanPham;
        private int soLuong;
        private int gia;
        private string phanLoai;
        private string nhaSanXuat;

        public Product() { }

        public Product(string tenSanPham, int soLuong, int gia, string phanLoai, string nhaSanXuat)
        {
            this.tenSanPham = tenSanPham;
            this.soLuong = soLuong;
            this.gia = gia;
            this.phanLoai = phanLoai;
            this.nhaSanXuat = nhaSanXuat;
        }

        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int Gia { get => gia; set => gia = value; }
        public string PhanLoai { get => phanLoai; set => phanLoai = value; }
        public string NhaSanXuat { get => nhaSanXuat; set => nhaSanXuat = value; }

    }
}
