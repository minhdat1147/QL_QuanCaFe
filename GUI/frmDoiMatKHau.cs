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
    public partial class frmDoiMatKHau : Form
    {
        BLL_NhanVien nv = new BLL_NhanVien();
        public frmDoiMatKHau()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPassCu.Text==""|| txtPassMoi.Text == ""|| txtNhapLai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
                return;
            }
            else
            {
                if (txtPassMoi.Text.Length < 6 && txtNhapLai.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải dài hơn 6 ký tự", "Thông báo");
                    return;
                }
                else
                {
                    if (txtPassCu.Text == Program.MK)
                    {
                        if (txtNhapLai.Text == txtPassMoi.Text)
                        {
                            if (nv.doiPass(Program.manv, txtPassMoi.Text.Trim()) == 1)
                            {
                                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                                this.Hide();
                                frmDangNhap a = new frmDangNhap();
                                a.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Đổi mật khẩu không thành công", "Thông báo");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu mới không khớp ", "Thông báo");
                            txtNhapLai.Text = "";
                            txtNhapLai.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo");
                    }
                }
                
            }
             
        }

        private void frmDoiMatKHau_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTTNhanVien frm = new frmTTNhanVien();
            frm.ShowDialog();
        }
    }
}
