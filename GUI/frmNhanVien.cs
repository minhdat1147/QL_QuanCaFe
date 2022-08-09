using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class frmNhanVien : Form
    {
        BLL_NhanVien nv = new BLL_NhanVien();
        QLCaPheDataContext nv1 = new QLCaPheDataContext();
        
        string taikhoan = "";
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTenNV.Text != "" && cboGT.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtCMND.Text != "" && cboCV.Text != "")
            {
                if(nv.themNV(txtMaNV.Text, txtTenNV.Text, dtNS.Value, cboGT.Text, txtDiaChi.Text, txtSDT.Text, txtCMND.Text, cboCV.Text)==1)
                {
                    dataGridView1.DataSource = nv.loadData();
                    biendoichuoi();
                    if(nv.themTK(taikhoan,txtMaNV.Text)==1)
                    {
                        
                        MessageBox.Show("Thêm Thành công");
                        
                    }    
                    
                }
                else
                {
                    MessageBox.Show("trùng mã nhân viên!!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
        }
        public void biendoichuoi()
        {
            string swap = txtTenNV.Text;
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = swap.Normalize(NormalizationForm.FormD);
            swap = regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
            var chuoi = swap.Split(' ');
            string manv = txtMaNV.Text;

            taikhoan = chuoi[2] + "-" + chuoi[0].Substring(0, 1) + chuoi[1].Substring(0, 1)+manv.Substring(manv.Length-2,2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int li = e.RowIndex;
            txtMaNV.Text = dataGridView1[0, li].Value.ToString();
            txtTenNV.Text = dataGridView1[1, li].Value.ToString();
            dtNS.Text = dataGridView1[2, li].Value.ToString();
            cboGT.Text = dataGridView1[3, li].Value.ToString();
            txtDiaChi.Text = dataGridView1[4, li].Value.ToString();
            txtSDT.Text = dataGridView1[5, li].Value.ToString();
            txtCMND.Text = dataGridView1[6, li].Value.ToString();
            cboCV.Text = dataGridView1[7, li].Value.ToString();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nv.loadData();
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].HeaderText = "Tên Nhân viên";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].HeaderText = "Giới tính";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].HeaderText = "Địa chỉ";
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].HeaderText = "Số điện Thoại";
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].HeaderText = "Chứng minh nhân dân";
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].HeaderText = "Chức Vụ";
            dataGridView1.Columns[7].Width = 150;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nv.suaNV(txtMaNV.Text, txtTenNV.Text, dtNS.Value, cboGT.Text, txtDiaChi.Text, txtSDT.Text, txtCMND.Text, cboCV.Text) == 1)
            {
                MessageBox.Show("Sửa Thành công");
                dataGridView1.DataSource = nv.loadData();
            }
            else
            {
                MessageBox.Show("sửa không thành công!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nv.xoaTKNV(txtMaNV.Text);
            if(nv.xoaNV(txtMaNV.Text)==1)
            {
                MessageBox.Show("Xoá thành công");
                dataGridView1.DataSource = nv.loadData();
            }
            else
            {
                MessageBox.Show("Xóa không thành công!!!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           

        }
    }
}
