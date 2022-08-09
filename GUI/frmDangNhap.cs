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
    public partial class frmDangNhap : Form
    {
        QLCaPheDataContext cafe = new QLCaPheDataContext();
        BLL_NhanVien dn = new BLL_NhanVien();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text !="" && txtMatKhau.Text !="")
            {
                var dangNhap = (from dn in cafe.DANGNHAPs join nv in cafe.NHANVIENs on dn.MANV equals nv.MANV
                                where (dn.TAIKHOAN.Equals(txtTaiKhoan.Text) && dn.MATKHAU.Equals(txtMatKhau.Text))
                                select new { nv,dn }
                               ).FirstOrDefault();
                if (dangNhap != null)
                {
                    MessageBox.Show("Đăng nhập thành công!!", "Thông báo");
                    Program.TK = dangNhap.dn.TAIKHOAN;
                    Program.MK = dangNhap.dn.MATKHAU;
                    Program.tennv = dangNhap.nv.TENNV;
                    Program.manv = dangNhap.nv.MANV;
                    Program.chucvu = dangNhap.nv.CHUCVU;
                    Program.sdt = dangNhap.nv.SDT;
                    Program.cmnd = dangNhap.nv.CMND;
                    Program.gtinh = dangNhap.nv.GTINH;
                    Program.diachi = dangNhap.nv.DIACHI;
                    Program.ngaysinh = dangNhap.nv.NGAYSINH.ToString();
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!");
                    reset();
                    txtTaiKhoan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tài khoản hoặc mật khẩu!!!");
                reset();
                txtTaiKhoan.Focus();
            }
            
        }
        public void reset()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }

        private void ckb_HienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_HienThi.Checked)
            {
                txtMatKhau.PasswordChar = (char)0;
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongBao = MessageBox.Show("Bạn có muốn thoát!!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(thongBao == DialogResult.Yes)
            {
                Application.Exit();
            }    
        }
    }
}
