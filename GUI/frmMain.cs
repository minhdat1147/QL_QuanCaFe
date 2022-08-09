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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            this.Hide();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Program.chucvu == "Nhân Viên")
            {
                btnNhaCungCap.Visible = false;
                btnNhapHang.Visible = false;
                btnNhanVien.Visible = false;
                btnThongKe.Visible = false;
                btnQLDoUong.Visible = false;
            }
            label1.Text = "Xin chào: " + Program.tennv;
            label3.Text = "Ngày: " + System.DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            this.Hide();
            frm.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            this.Hide();
            frm.Show();
        }

        private void btnQLDoUong_Click(object sender, EventArgs e)
        {
            frmDoUong frm = new frmDoUong();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTTNhanVien a = new frmTTNhanVien();
            a.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            this.Hide();
            frm.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            frmBanHang a = new frmBanHang();
            this.Hide();
            a.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frmThongKeBanHang frm = new frmThongKeBanHang();
            this.Hide();
            frm.Show();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frm = new frmNhapHang();
            this.Hide();
            frm.Show();
        }
    }
}
