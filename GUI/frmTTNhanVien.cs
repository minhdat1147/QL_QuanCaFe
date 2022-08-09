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
namespace GUI
{
    public partial class frmTTNhanVien : Form
    {
        string hinh = "";
        QLCaPheDataContext caphe = new QLCaPheDataContext();
        public frmTTNhanVien()
        {
            InitializeComponent();
        }

        private void frmTTNhanVien_Load(object sender, EventArgs e)
        {
            var dangNhap = (from dn in caphe.DANGNHAPs
                            join nv in caphe.NHANVIENs on dn.MANV equals nv.MANV
                            where (dn.TAIKHOAN.Equals(Program.TK) && dn.MATKHAU.Equals(Program.MK))
                            select new { nv, dn }
                               ).FirstOrDefault();
            if (dangNhap != null)
            {
                txtCMND.Text = dangNhap.nv.CMND;
                txtDiaChi.Text = dangNhap.nv.DIACHI;
                txtSDT.Text = dangNhap.nv.SDT;
                dtNS.Text = dangNhap.nv.NGAYSINH.ToString();
                hinh = dangNhap.nv.HINHANH;
                txtTenNV.Text = dangNhap.nv.TENNV;
                if (dangNhap.nv.GTINH == "Nam")
                {
                    cboGT.SelectedIndex = 1;
                }
                else
                {
                    cboGT.SelectedIndex = 0;
                }
                //pictureBox1.Image = Image.FromFile(@"D:\Apps\HTTT_Nhom4_QL_QuanCaPhe\HTTT_Nhom4_QL_QuanCaPhe\HinhNV\" + hinh);
                pictureBox1.Image = Image.FromFile(@"C:\Users\WIN 10\Desktop\PTPM_UDTM_Nhom10_QL_QuanCaPhe\PTPM_UDTM_Nhom10_QL_QuanCaPhe\HinhNV\" + hinh);
            }      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            PictureBox objpt = new PictureBox();
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
            }           
            pictureBox1.Image= Image.FromFile(filepath.ToString());
            var Imagee = filepath.Split('\\');
            hinh = Imagee[7].ToString() ;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var q = from l in caphe.NHANVIENs
                    where l.MANV.Equals(Program.manv)
                    select l;
            if(q.Count()!=0)
            {
                q.First().TENNV = txtTenNV.Text;
                q.First().GTINH = cboGT.Text;
                q.First().CMND = txtCMND.Text;
                q.First().DIACHI = txtDiaChi.Text;
                q.First().SDT = txtSDT.Text;
                q.First().NGAYSINH = Convert.ToDateTime(dtNS.Text);
                if(hinh!="")
                {
                    q.First().HINHANH = hinh;
                }    
                caphe.SubmitChanges();
                this.Hide();
            }    
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            this.Hide();
            frmDoiMatKHau dmk = new frmDoiMatKHau();
            dmk.ShowDialog();
        }

        private void cboGT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
