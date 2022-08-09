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
using DTO;
namespace GUI
{
    public partial class frmKhachHang : Form
    {
        BLL_KhachHang kh = new BLL_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text !=""&&txtTen.Text!=""&& comboBox1.Text!=""&&txtSDT.Text!="")
            {
                if (kh.themKH(txtMaKH.Text, txtTen.Text, comboBox1.Text, txtSDT.Text) == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = kh.loadData();
                }
                else
                {
                    MessageBox.Show("Trùng mã khách hàng!!!");
                }
            }   
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(kh.xoaKH(txtMaKH.Text)==1)
            {
                MessageBox.Show("Xóa thành công");
                dataGridView1.DataSource = kh.loadData();
            }
            else
            {
                MessageBox.Show("Xóa khách hàng không thành công!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(kh.suaKH(txtMaKH.Text, txtTen.Text, comboBox1.Text, txtSDT.Text) == 1)
            {
                MessageBox.Show("Sửa thành công");
                dataGridView1.DataSource = kh.loadData();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int li = e.RowIndex;
            txtMaKH.Text = dataGridView1[0, li].Value.ToString();
            txtTen.Text = dataGridView1[1, li].Value.ToString();
            comboBox1.Text = dataGridView1[2, li].Value.ToString();
            txtSDT.Text = dataGridView1[3, li].Value.ToString();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kh.loadData();
            dataGridView1.Columns[0].HeaderText = "Mã Khách Hàng";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].HeaderText = "Tên Khách Hàng";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "Số điện Thoại";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.Show();
        }

        private void btnDSHoaDon_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text=="")
            {
                MessageBox.Show("Vui lòng chọn một khách hàng bất kỳ", "Thông báo");
                return;
            }
            else
            {
                Program.makhHD = txtMaKH.Text.Trim();
                frmDSHDKhachHang dsHDKH = new frmDSHDKhachHang();
                dsHDKH.ShowDialog();
            }    
        }
    }
}
