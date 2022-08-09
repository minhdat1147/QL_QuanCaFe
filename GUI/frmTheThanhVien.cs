using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class frmTheThanhVien : Form
    {
        QLCaPheDataContext cafe = new QLCaPheDataContext();
        public static string mathe = "";
        public static int diemtl = 0;
        public static string makh = "";
        public frmTheThanhVien()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var khachhang = (from kh in cafe.KHACHHANGs
                            join lt in cafe.LOAITHEs on kh.MATHE equals lt.MATHE
                            where (kh.MAKH.Equals(txtGia.Text) || kh.SDT.Equals(txtGia.Text))
                            select new { kh, lt }
                               ).FirstOrDefault();

            if (khachhang != null)
            {
                label1.Text = "Họ Tên: "+khachhang.kh.TENKH + "  Mã thẻ:" + khachhang.lt.LOAITHE1;
                mathe = khachhang.lt.MATHE;
                diemtl = Convert.ToInt32(khachhang.kh.DIEMTL.ToString());
                makh= khachhang.kh.MAKH;
                Program.tenkh = khachhang.kh.TENKH;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại mã thẻ hoặc số điện thoại");
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.thetv = label1.Text;
            Program.mathetv = mathe;
            Program.diemtv = diemtl;
            Program.makh = makh;


        }

        private void frmTheThanhVien_Load(object sender, EventArgs e)
        {

        }
    }
}
