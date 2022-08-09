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
    public partial class frmThongKe1 : Form
    {
        public frmThongKe1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmThongKe1_Load(object sender, EventArgs e)
        {
            XuatTK rpt = new XuatTK();
            rpt.SetDatabaseLogon("sa", "sa2012", @"DESKTOP-SOF5J9B\SQLEXPRESS", "QL_QUANCAPHE");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            rpt.SetParameterValue("NgayBD", Program.NgayBD);
            rpt.SetParameterValue("NgayKT", Program.NgayKT);
            rpt.SetParameterValue("TongTien"," VNĐ");
           
            
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongKeBanHang frm = new frmThongKeBanHang();
            frm.ShowDialog();
        }
    }
}
