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
    public partial class frmNhaCungCap : Form
    {
        BLL_NhaCungCap ncc = new BLL_NhaCungCap();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ncc.loadData();
            dataGridView1.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Địa Chỉ";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "Số điện thoại";
            dataGridView1.Columns[3].Width = 150;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaNCC.Text !=""&& txtTen.Text !="" &&txtDiachi.Text !=""&& txtSDt.Text !="")
            {
                if(ncc.themNCC(txtMaNCC.Text,txtTen.Text,txtDiachi.Text,txtSDt.Text)==1)
                {
                    MessageBox.Show("Thêm Thành công");
                    dataGridView1.DataSource = ncc.loadData();

                }
                else
                {
                    MessageBox.Show("Trùng mã nhà cung cấp!!!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(ncc.suaNCC(txtMaNCC.Text, txtTen.Text, txtDiachi.Text, txtSDt.Text)==1)
            {
                MessageBox.Show("Sửa thành công");
                dataGridView1.DataSource = ncc.loadData();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int li = e.RowIndex;
            txtMaNCC.Text = dataGridView1[0, li].Value.ToString();
            txtTen.Text = dataGridView1[1, li].Value.ToString();
            txtDiachi.Text = dataGridView1[2, li].Value.ToString();
            txtSDt.Text = dataGridView1[3, li].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(ncc.xoaNCC(txtMaNCC.Text)==1)
            {
                MessageBox.Show("Xóa thành công");
                dataGridView1.DataSource = ncc.loadData();
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.Show();
        }

        private void btnDSPN_Click(object sender, EventArgs e)
        {
            frmNhapHang frm = new frmNhapHang();
            this.Hide();
            frm.Show();
        }
    }
}
