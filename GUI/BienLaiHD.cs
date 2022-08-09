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
    public partial class BienLaiHD : Form
    {
        public BienLaiHD()
        {
            InitializeComponent();
        }

        private void BienLaiHD_Load(object sender, EventArgs e)
        {
            XuatHD rpt = new XuatHD();
            rpt.SetDatabaseLogon("sa", "sa2012", @"DESKTOP-SOF5J9B\SQLEXPRESS", "QL_QUANCAPHE");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            rpt.SetParameterValue("NgayLap", System.DateTime.Now);
            rpt.SetParameterValue("HoTen", Program.tennv);
            rpt.SetParameterValue("TongTien", Program.tongtien);
            rpt.SetParameterValue("GiamGia", Program.giamgia);
            rpt.SetParameterValue("TenKH", Program.tenkh);
        }

       

        private void btnXuat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmBanHang frm = new frmBanHang();
            frm.Show();
        }
    }
}
