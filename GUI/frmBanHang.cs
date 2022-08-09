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
    public partial class frmBanHang : Form
    {
        BLL_BanHang bh = new BLL_BanHang();
        QLCaPheDataContext cafe = new QLCaPheDataContext();
        string masp = "";
        int gia = 0;
        double thanhtien = 0;
        string tongtien = "";
        string khuyenmai = "";
        string dvt = "";
        double tt = 0;
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTheThanhVien the = new frmTheThanhVien(); 
            the.ShowDialog();
            label2.Text = Program.thetv;
            load_TTKH();
        }
        public void load_TTKH()
        {
            dgvBH.DataSource = bh.loadData(Convert.ToInt32(txtMaCTHD.Text)); 
            double sum = 0;
            for (int i = 0; i < dgvBH.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvBH.Rows[i].Cells[6].Value);
            }
            if (Program.mathetv == "COP")
            {
                lblGiamgia.Text = "Giảm giá: " + string.Format("{0:#,##}", (sum * 0.1)).ToString() + " VNĐ";
                lblTongTien.Text = "Tổng tiền: " + string.Format("{0:#,##}", (sum * 0.9)).ToString() + " VNĐ";
                tongtien = string.Format("{0:#,##}", (sum * 0.9)).ToString() + " VNĐ";
                khuyenmai = string.Format("{0:#,##}", (sum * 0.1)).ToString() + " VNĐ";
                tt = sum * 0.9;
            }
            else if (Program.mathetv == "SLV")
            {
                lblGiamgia.Text = "Giảm giá: " + string.Format("{0:#,##}", (sum * 0.15)).ToString() + " VNĐ";
                lblTongTien.Text = "Tổng tiền: " + string.Format("{0:#,##}", (sum * 0.85)).ToString() + " VNĐ";
                tongtien = string.Format("{0:#,##}", (sum * 0.85)).ToString() + " VNĐ";
                khuyenmai = string.Format("{0:#,##}", (sum * 0.15)).ToString() + " VNĐ";
                tt = sum * 0.85;
            }
            else if (Program.mathetv == "GOLD")
            {
                lblGiamgia.Text = "Giảm giá: " + string.Format("{0:#,##}", (sum * 0.2)).ToString() + " VNĐ";
                lblTongTien.Text = "Tổng tiền: " + string.Format("{0:#,##}", (sum * 0.8)).ToString() + " VNĐ";
                tongtien = string.Format("{0:#,##}", (sum * 0.8)).ToString() + " VNĐ";
                khuyenmai = string.Format("{0:#,##}", (sum * 0.2)).ToString() + " VNĐ";
                tt = sum * 0.8;
            }
        }
        public void frmBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_QUANCAPHEDataSet3.LOAIDOUONG' table. You can move, or remove it, as needed.
            this.lOAIDOUONGTableAdapter.Fill(this.qL_QUANCAPHEDataSet3.LOAIDOUONG);
            cboTenLoai.Text = "Hãy chọn loại sản phẩm";
            cboTenSP.Text = "Hãy chọn sản phẩm";
            txtMaCTHD.Enabled = false;
            txtGia.Enabled = false;
            textBox1.Enabled = false;
           
            txtTT.Enabled = false;
            cboTenLoai.Enabled=false;
            cboTenSP.Enabled = false;
            numericUpDown1.Enabled = false;
            lblGiamgia.Text = "Giảm giá: 0 VNĐ ";
            lblTongTien.Text = "Tổng tiền: 0 VNĐ " ;
            if(dgvBH.Rows.Count==0)
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnThanhToan.Enabled = false;
                btnTheTV.Enabled = false;
               
            }    
           
        }
        public void loadCbo()
        {
            
            List<DOUONG> lstSP = new List<DOUONG>();


            lstSP = bh.layCombobox(cboTenLoai.SelectedValue.ToString());
            foreach (var a in lstSP)
            {
                cboTenSP.Items.Add(a.TENSP);

            }
           

        }
        public void reset()
        {
            cboTenLoai.Text = "Hãy chọn loại đồ uống";
            cboTenSP.Text = "Hãy chọn đồ uống";
            textBox1.Text = "";
            txtGia.Text = "0";
            txtTT.Text = "0";
            numericUpDown1.Value = 1;
        }
        public void LoadDaTa()
        {
            dgvBH.DataSource = bh.loadData(int.Parse(txtMaCTHD.Text));

            dgvBH.Columns[0].HeaderText = "Mã hóa đơn";
            dgvBH.Columns[1].HeaderText = "Tên loại đồ uống";
            dgvBH.Columns[2].HeaderText = "Tên đồ uống";
            dgvBH.Columns[3].HeaderText = "Số lượng";
            dgvBH.Columns[4].HeaderText = "DVT";
            dgvBH.Columns[5].HeaderText = "Đơn giá";
            dgvBH.Columns[6].HeaderText = "Thành tiền";

            dgvBH.Columns[0].Width = 150;
            dgvBH.Columns[1].Width = 150;
            dgvBH.Columns[2].Width = 150;
            dgvBH.Columns[3].Width = 150;
            dgvBH.Columns[4].Width = 150;
            dgvBH.Columns[5].Width = 150;
            dgvBH.Columns[6].Width = 150;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaCTHD.Text != "" && cboTenLoai.Text != "" && cboTenSP.Text != "" && Convert.ToInt32(numericUpDown1.Text) != 0)
            {
                int mahd = Convert.ToInt32(txtMaCTHD.Text);
                string maloai = cboTenLoai.SelectedValue.ToString();
                string tenloai = cboTenLoai.Text.ToString();
                string tensp = cboTenSP.Text.ToString();
                int sl = Convert.ToInt32(numericUpDown1.Text);
                int gia = Convert.ToInt32(txtGia.Text);
                int thanhtien = Convert.ToInt32(txtTT.Text);
                if (bh.them(mahd, maloai, masp, sl, textBox1.Text, gia, thanhtien) == 1)
                {
                    if (bh.themTam(mahd, tenloai, tensp, sl, textBox1.Text, gia, thanhtien) == 1)
                    {
                        MessageBox.Show("Thêm thành công");
                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                        btnThanhToan.Enabled = true;
                        btnTheTV.Enabled = true;
                        dgvBH.DataSource = bh.loadData(mahd);
                        double sum = 0;
                        for (int i = 0; i < dgvBH.Rows.Count; ++i)
                        {
                            sum += Convert.ToInt32(dgvBH.Rows[i].Cells[6].Value);
                        }

                        lblGiamgia.Text = "Giảm giá: 0 VNĐ";
                        lblTongTien.Text = "Tổng tiền: " + string.Format("{0:#,##}", (sum)).ToString() + " VNĐ";
                        tongtien = string.Format("{0:#,##}", (sum)).ToString() + " VNĐ";
                        khuyenmai = "0 VNĐ";
                        tt = sum;
                    }
                }
            }
            else
            {    
                    MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
                
            }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            if (bh.taoHD(Program.manv) == 1)
            {
                int mahd = 0;
                var lstHD = bh.laymaHD();
                foreach (var a in lstHD)
                {
                    mahd = a.MAHD;
                }
                txtMaCTHD.Text = mahd.ToString();
            }
            btnTaoHD.Enabled = false;
            cboTenLoai.Enabled = true;
        }

        private void cboTenLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTenSP.Items.Clear();
            cboTenSP.Text = "Hãy chọn sản phẩm";
            loadCbo();
            cboTenSP.Enabled = true;

        }

        private void cboTenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = (from s in cafe.DOUONGs where s.TENSP.Equals(cboTenSP.SelectedItem.ToString()) select s);


            foreach (var a in q)
            {
                masp = a.MASP;
                gia = Convert.ToInt32(a.DONGIA);
                dvt = a.DVT;
            }
            int sl = int.Parse(numericUpDown1.Value.ToString());         
            txtGia.Text = gia.ToString();
            textBox1.Text = dvt;
            numericUpDown1.Enabled = true;
            btnThem.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int sl = int.Parse(numericUpDown1.Value.ToString());
            txtGia.Text = gia.ToString();
            thanhtien = sl * gia;
            txtTT.Text = thanhtien.ToString();

            //if (Program.mathetv.Equals("COP"))
            //{
            //    txtGia.Text = gia.ToString();

            //    thanhtien = sl * (gia * 0.9);

            //    txtTT.Text = thanhtien.ToString();
            //}
            //else
            //{
            //    txtGia.Text = gia.ToString();
            //    thanhtien = sl * gia;
            //    txtTT.Text = thanhtien.ToString();
            //}
        }

        private void dgvBH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int li = e.RowIndex;
            txtMaCTHD.Text = dgvBH[0, li].Value.ToString();
            cboTenLoai.Text = dgvBH[1, li].Value.ToString();
            cboTenSP.Text = dgvBH[2, li].Value.ToString();
            numericUpDown1.Text = dgvBH[3, li].Value.ToString();
            textBox1.Text = dgvBH[4, li].Value.ToString();
            txtGia.Text = dgvBH[5, li].Value.ToString();
            txtTT.Text = dgvBH[6, li].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(txtMaCTHD.Text!="")
            {
                List<CHITIETHD> lsthd = new List<CHITIETHD>();
                bh.xoaHDTam(Convert.ToInt32(txtMaCTHD.Text));
                Program.mahd = int.Parse(txtMaCTHD.Text);
                Program.tongtien = tongtien;
                Program.giamgia = khuyenmai;
                if (Program.thetv != "")
                {
                    bh.UpdateHD(Convert.ToInt32(txtMaCTHD.Text), Program.makh, Convert.ToInt32(tt));
                    int diemtl = 0;
                    diemtl = Program.diemtv + Convert.ToInt32(tt / 1000);
                    if (diemtl >= 0 && diemtl < 2000)
                    {
                        bh.UpdateDiemKH(Program.makh, diemtl, "COP");
                    }
                    else if (diemtl >= 2000 && diemtl < 5000)
                    {
                        bh.UpdateDiemKH(Program.makh, diemtl, "SLV");
                    }
                    else if (diemtl >= 5000)
                    {
                        bh.UpdateDiemKH(Program.makh, diemtl, "GOLD");
                    }
                }
                bh.UpdateHD(Convert.ToInt32(txtMaCTHD.Text), Program.makh, Convert.ToInt32(tt));
                BienLaiHD bl = new BienLaiHD();
                this.Hide();
                bl.ShowDialog();
            }   
           else
            {
                MessageBox.Show("Không có món để thanh toán", "Thông báo");
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaCTHD.Text==""&&cboTenLoai.Text==""&&cboTenSP.Text=="")
            {
                MessageBox.Show("Vui lòng nhập thông tin món cần xóa", "Thông báo");
                return;
            }    
            int mahd = Convert.ToInt32(txtMaCTHD.Text);
            string maloai = cboTenLoai.SelectedValue.ToString();
            string tenloai = cboTenLoai.Text.ToString();
            string tensp = cboTenSP.Text.ToString();
            if (bh.xoaHD(mahd, maloai, masp) == 1)
            {
                MessageBox.Show("Xóa Thành công");
                bh.xoaHDTam1(mahd, tenloai, tensp);
                LoadDaTa();
                reset();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmMain main = new frmMain();
            main.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaCTHD.Text == "" && cboTenLoai.Text == "" && cboTenSP.Text == "")
            {
                MessageBox.Show("Vui lòng Nhập thông tin món cần sửa", "Thông báo");
                return;
            }
            if (bh.UpdateHD1(Convert.ToInt32(txtMaCTHD.Text), cboTenLoai.SelectedValue.ToString(), masp, Convert.ToInt32(numericUpDown1.Text), Convert.ToInt32(thanhtien)) == 1)
            {
                bh.UpdateHDTam(Convert.ToInt32(txtMaCTHD.Text), cboTenLoai.Text, cboTenSP.Text, Convert.ToInt32(numericUpDown1.Text), Convert.ToInt32(thanhtien));
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                LoadDaTa();
            }

        }
    }
}
