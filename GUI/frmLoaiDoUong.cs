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
    public partial class frmLoaiDoUong : Form
    {
        BLL_LoaiDoUong l = new BLL_LoaiDoUong();
        public frmLoaiDoUong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaLoai.Text !=""&& txtTenLoai.Text !="")
            {
                if(l.themLoaiDoUong(txtMaLoai.Text,txtTenLoai.Text)==1)
                {
                    MessageBox.Show("Thêm thành công");
                    dgvDSLoai.DataSource = l.loadData();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
                if (l.xoaLoaiDoUong(txtMaLoai.Text) == 1)
                {
                    MessageBox.Show("Xóa thành công");
                    dgvDSLoai.DataSource = l.loadData();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!");
                }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (l.suaLoaiDoUong(txtMaLoai.Text, txtTenLoai.Text) == 1)
            {
                MessageBox.Show("Sửa thành công");
                dgvDSLoai.DataSource = l.loadData();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!");
            }
        }

        private void dgvDSLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int li = e.RowIndex;
            txtMaLoai.Text = dgvDSLoai[0, li].Value.ToString();
            txtTenLoai.Text = dgvDSLoai[1, li].Value.ToString();
        }

        private void frmLoaiDoUong_Load(object sender, EventArgs e)
        {
            dgvDSLoai.DataSource = l.loadData();
            dgvDSLoai.Columns[0].HeaderText = "Mã loại";
            dgvDSLoai.Columns[0].Width = 150;
            dgvDSLoai.Columns[1].HeaderText = "Tên Loại";
            dgvDSLoai.Columns[1].Width = 150;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmDoUong frm = new frmDoUong();
            this.Hide();
            frm.Show();
        }
    }
}
