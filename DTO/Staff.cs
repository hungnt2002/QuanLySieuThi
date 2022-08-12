﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Staff
    {
        private string id;
        private string tenNhanVien;
        private string tuoi;
        private string sodt;
        

        public Staff()
        { }
        public Staff(string id, string tenNhanVien, String tuoi, string sodt)
        {
            this.id = id;
            this.TenNhanVien = tenNhanVien;
            this.Tuoi = tuoi;
            this.Sodt = sodt;
        }

        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public String Tuoi { get => tuoi; set => tuoi = value; }
        public string Sodt { get => sodt; set => sodt = value; }
        public string Id { get => id; }
    }
}
