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
    public partial class frmNhapHang : Form
    {
        BLL_NhapHang pn = new BLL_NhapHang();
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            //dgvPN.Columns[0].HeaderText = "Mã Phiếu nhập";
            //dgvPN.Columns[0].Width = 150;
            //dgvPN.Columns[1].HeaderText = "Tên Loại";
            //dgvPN.Columns[1].Width = 150;
            //dgvPN.Columns[2].HeaderText = "Tên Món";
            //dgvPN.Columns[2].Width = 150;
            //dgvPN.Columns[3].HeaderText = "Số Lượng";
            //dgvPN.Columns[3].Width = 150;
            //dgvPN.Columns[4].HeaderText = "Đơn Vị tính";
            //dgvPN.Columns[4].Width = 150;
            //dgvPN.Columns[5].HeaderText = "Đơn Giá";
            //dgvPN.Columns[5].Width = 150;
            //dgvPN.Columns[6].HeaderText = "Thành Tiền";
            //dgvPN.Columns[6].Width = 150;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            if (pn.taoPN(Program.manv) == 1)
            {
                int mapn = 0;
                var lstPN = pn.layMaPN();
                foreach (var a in lstPN)
                {
                    mapn = a.MAPN;
                }
                txtMaCTPN.Text = mapn.ToString();
            }
            btnTaoPN.Enabled = false;
            cboTenLoai.Enabled = true;
        }
    }
}
