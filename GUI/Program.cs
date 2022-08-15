﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin form = new FormLogin();
            form.Show();
            Application.Run();

            //Application.Run(new FormLogin());
            //Application.Run(new FormQLSanPham());
            //Application.Run(new FormBanHang("test"));
            //Application.Run(new FormQLNhanVien());
            //Application.Run(new FormAdmin());


        }
    }
}
