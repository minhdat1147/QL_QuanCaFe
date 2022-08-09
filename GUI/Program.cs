using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    static class Program
    {
        public static String tennv = "";

        public static String manv = "";
        public static String sdt = "";
        public static String Image = "";
        public static String cmnd = "";

        public static String diachi = "";
        public static String ngaysinh = "";
        public static String tenncc = "";

        public static String makh = "";
        public static String makhHD = "";
        public static String tenkh = "";
        public static String gtinh = "";
        public static String chucvu = "";
        public static String thetv = "";
        public static String mathetv = "";
        public static int diemtv = 0;
        public static int mahd = 0;
        public static int mapn = 0;
        public static String tongtien = ""; 
        public static String giamgia = "";
        public static String TK = "";
        public static String MK = "";
        public static String NgayBD = "";
        public static String NgayKT = "";
        public static String TongTienTK = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
        }
    }
}
