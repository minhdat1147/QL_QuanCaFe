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
    public partial class frmDoUong : Form
    {
        BLL_DoUong sp = new BLL_DoUong();
        public frmDoUong()
        {
            InitializeComponent();
        }

        private void frmDoUong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_QUANCAPHEDataSet2.LOAIDOUONG' table. You can move, or remove it, as needed.
            this.lOAIDOUONGTableAdapter1.Fill(this.qL_QUANCAPHEDataSet2.LOAIDOUONG);
            // TODO: This line of code loads data into the 'qL_QUANCAPHEDataSet.DOUONG' table. You can move, or remove it, as needed.
            this.dOUONGTableAdapter.Fill(this.qL_QUANCAPHEDataSet.DOUONG);
            // TODO: This line of code loads data into the 'qL_QUANCAPHEDataSet1.LOAIDOUONG' table. You can move, or remove it, as needed.
            this.lOAIDOUONGTableAdapter.Fill(this.qL_QUANCAPHEDataSet1.LOAIDOUONG);
            dataGridView1.DataSource = sp.loadData();
            dataGridView1.Columns[5].Visible = false;
            cboMaLoai.Text = "Tất cả";

            dataGridView1.Columns[0].HeaderText = "Mã đồ uống";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].HeaderText = "Tên đồ uống";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Đơn Vị tính";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "Đơn Giá";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].HeaderText = "Mã Loại";
            dataGridView1.Columns[4].Width = 150;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "" && txtTenSP.Text != "" && cboMaLoai.Text != "" && txtGia.Text != "" && cboDVT.Text != "")
            {
                if (sp.themSP(txtMaSP.Text, txtTenSP.Text, cboDVT.Text, Convert.ToInt32(txtGia.Text), cboMaLoai.Text) == 1)
                {
                    MessageBox.Show("Thêm Thành công");
                    dataGridView1.DataSource = sp.loadData();
                }

                else
                {
                    MessageBox.Show("Thêm không thành công!!!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (sp.xoa(txtMaSP.Text) == 1)
            {
                MessageBox.Show("Xóa Thành công"); 
                dataGridView1.DataSource = sp.loadData();

            }
            else
            {
                MessageBox.Show("Xóa không thành công!!");
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (sp.suaSP(txtMaSP.Text, txtTenSP.Text, cboDVT.Text, Convert.ToInt32(txtGia.Text), cboMaLoai.Text) == 1)
            {
                MessageBox.Show("Sửa Thành công");
                dataGridView1.DataSource = sp.loadData();
            }

            else
            {
                MessageBox.Show("Sửa không thành công!!!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int li = e.RowIndex;
            txtMaSP.Text = dataGridView1[0, li].Value.ToString();
            txtTenSP.Text = dataGridView1[1, li].Value.ToString();
            cboDVT.Text = dataGridView1[2, li].Value.ToString();
            txtGia.Text = dataGridView1[3, li].Value.ToString();
            cboMaLoai.Text = dataGridView1[4, li].Value.ToString();
        }

        private void btnQLLoaiDoUong_Click(object sender, EventArgs e)
        {
            frmLoaiDoUong frm = new frmLoaiDoUong();
            this.Hide();
            frm.Show();

        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a=sp.timkiem(cboLoai.SelectedValue.ToString());
            dataGridView1.DataSource = a;
            return;
        }
    }
}
