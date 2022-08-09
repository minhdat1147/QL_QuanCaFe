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
    public partial class frmDSHDKhachHang : Form
    {
        QLCaPheDataContext cafe = new QLCaPheDataContext();
        BLL_DSHDKH dshd = new BLL_DSHDKH();
        public frmDSHDKhachHang()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmDSHDKhachHang_Load(object sender, EventArgs e)
        {
            var dangNhap = (from kh in cafe.KHACHHANGs
                            join the in cafe.LOAITHEs on kh.MATHE equals the.MATHE
                            where (kh.MAKH.Equals(Program.makhHD))
                            select new { kh, the }
                               ).FirstOrDefault();
            if (dangNhap != null)
            {
                lblmaKH.Text = "Mã khách hàng: " + dangNhap.kh.MAKH;
                lblTenKH.Text = "Tên khách hàng: " + dangNhap.kh.TENKH;
                lblSDT.Text = "Số điện thoại: " + dangNhap.kh.SDT;
                lblDiem.Text = "Điểm hiện tại: " + dangNhap.kh.DIEMTL;
                lblLoaiThe.Text = "Loại thẻ: " + dangNhap.the.LOAITHE1;
            }
            dgvDSHDKH.DataSource = dshd.loadData(Program.makhHD);
            dgvDSHDKH.Columns[0].HeaderText = "Mã hóa đơn";
            dgvDSHDKH.Columns[0].Width = 150;
            dgvDSHDKH.Columns[2].Visible = false;
            dgvDSHDKH.Columns[3].HeaderText = "Ngày lập";
            dgvDSHDKH.Columns[3].Width = 150;
            dgvDSHDKH.Columns[4].HeaderText = "Tổng tiền";
            dgvDSHDKH.Columns[3].Width = 150;
            dgvDSHDKH.Columns[1].Visible = false;
            dgvDSHDKH.Columns[5].Visible = false;
            dgvDSHDKH.Columns[6].Visible = false;
            label1.Text = "Tổng số hóa đơn: " + dgvDSHDKH.Rows.Count.ToString();
            int tongtien = 0;
            for(int i=0;i<dgvDSHDKH.Rows.Count;i++)
            {
                tongtien = tongtien + Convert.ToInt32(dgvDSHDKH.Rows[i].Cells[4].Value);
                
            }
            label2.Text = "Tổng tiền là: " + string.Format("{0:#,##}", tongtien) + " VNĐ";
        }

        private void dgvDSHDKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
