using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class frmThongKeBanHang : Form
    {
        BLL_BanHang bh = new BLL_BanHang();
        double sum = 0;
        public frmThongKeBanHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv1.DataSource=bh.loadData1(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());
            dgv1.Columns[2].Visible = false;
            dgv1.Columns[5].Visible = false;
            dgv1.Columns[6].Visible = false;
            lblSL.Text = "Số lượng: "+Convert.ToInt32(dgv1.Rows.Count).ToString();
            int count = Convert.ToInt32(dgv1.Rows.Count);
            
            for(int i=0;i< count; i++)
            {
                sum += Convert.ToInt32(dgv1.Rows[i].Cells[4].Value);
            }
            label2.Text = "Tổng tiền: "+string.Format("{0:#,##}", (sum)).ToString() + " VNĐ";
            btnXuatEX.Enabled = true;
        }

        private void frmThongKeBanHang_Load(object sender, EventArgs e)
        {
            btnXuatEX.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }

        private void btnXuatEX_Click(object sender, EventArgs e)
        {
            Program.NgayBD = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Program.NgayKT = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            Program.TongTienTK = sum.ToString();
            frmThongKe1 frm = new frmThongKe1();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
