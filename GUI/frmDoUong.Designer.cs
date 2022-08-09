
namespace GUI
{
    partial class frmDoUong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.btnQLLoaiDoUong = new System.Windows.Forms.Button();
            this.cboMaLoai = new System.Windows.Forms.ComboBox();
            this.lOAIDOUONGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_QUANCAPHEDataSet2 = new GUI.QL_QUANCAPHEDataSet2();
            this.lOAIDOUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLQUANCAPHEDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_QUANCAPHEDataSet1 = new GUI.QL_QUANCAPHEDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.TG = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lOAIDOUONGTableAdapter = new GUI.QL_QUANCAPHEDataSet1TableAdapters.LOAIDOUONGTableAdapter();
            this.qL_QUANCAPHEDataSet = new GUI.QL_QUANCAPHEDataSet();
            this.dOUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOUONGTableAdapter = new GUI.QL_QUANCAPHEDataSetTableAdapters.DOUONGTableAdapter();
            this.lOAIDOUONGTableAdapter1 = new GUI.QL_QUANCAPHEDataSet2TableAdapters.LOAIDOUONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOUONGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_QUANCAPHEDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQUANCAPHEDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_QUANCAPHEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_QUANCAPHEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOUONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDVT
            // 
            this.cboDVT.FormattingEnabled = true;
            this.cboDVT.Items.AddRange(new object[] {
            "Lon",
            "Chai",
            "Ly",
            "Bịch"});
            this.cboDVT.Location = new System.Drawing.Point(757, 324);
            this.cboDVT.Margin = new System.Windows.Forms.Padding(4);
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.Size = new System.Drawing.Size(132, 24);
            this.cboDVT.TabIndex = 94;
            // 
            // btnQLLoaiDoUong
            // 
            this.btnQLLoaiDoUong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnQLLoaiDoUong.Location = new System.Drawing.Point(517, 2);
            this.btnQLLoaiDoUong.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLLoaiDoUong.Name = "btnQLLoaiDoUong";
            this.btnQLLoaiDoUong.Size = new System.Drawing.Size(185, 28);
            this.btnQLLoaiDoUong.TabIndex = 91;
            this.btnQLLoaiDoUong.Text = "Quản lý loại đồ uống";
            this.btnQLLoaiDoUong.UseVisualStyleBackColor = false;
            this.btnQLLoaiDoUong.Click += new System.EventHandler(this.btnQLLoaiDoUong_Click);
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.DataSource = this.lOAIDOUONGBindingSource1;
            this.cboMaLoai.DisplayMember = "MALOAI";
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.Location = new System.Drawing.Point(460, 324);
            this.cboMaLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(132, 24);
            this.cboMaLoai.TabIndex = 90;
            this.cboMaLoai.ValueMember = "MALOAI";
            // 
            // lOAIDOUONGBindingSource1
            // 
            this.lOAIDOUONGBindingSource1.DataMember = "LOAIDOUONG";
            this.lOAIDOUONGBindingSource1.DataSource = this.qL_QUANCAPHEDataSet2;
            // 
            // qL_QUANCAPHEDataSet2
            // 
            this.qL_QUANCAPHEDataSet2.DataSetName = "QL_QUANCAPHEDataSet2";
            this.qL_QUANCAPHEDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAIDOUONGBindingSource
            // 
            this.lOAIDOUONGBindingSource.DataMember = "LOAIDOUONG";
            this.lOAIDOUONGBindingSource.DataSource = this.qLQUANCAPHEDataSet1BindingSource;
            // 
            // qLQUANCAPHEDataSet1BindingSource
            // 
            this.qLQUANCAPHEDataSet1BindingSource.DataSource = this.qL_QUANCAPHEDataSet1;
            this.qLQUANCAPHEDataSet1BindingSource.Position = 0;
            // 
            // qL_QUANCAPHEDataSet1
            // 
            this.qL_QUANCAPHEDataSet1.DataSetName = "QL_QUANCAPHEDataSet1";
            this.qL_QUANCAPHEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "Loại sản phẩm";
            // 
            // cboLoai
            // 
            this.cboLoai.DataSource = this.lOAIDOUONGBindingSource;
            this.cboLoai.DisplayMember = "TENLOAI";
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(308, 7);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(159, 24);
            this.cboLoai.TabIndex = 88;
            this.cboLoai.ValueMember = "MALOAI";
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThoat.Location = new System.Drawing.Point(711, 218);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 28);
            this.btnThoat.TabIndex = 87;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(699, 207);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(460, 383);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(132, 22);
            this.txtGia.TabIndex = 85;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(373, 392);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(30, 17);
            this.label.TabIndex = 84;
            this.label.Text = "GIá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 328);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 83;
            this.label7.Text = "Mã loại";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(164, 383);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(132, 22);
            this.txtTenSP.TabIndex = 82;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(164, 328);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(132, 22);
            this.txtMaSP.TabIndex = 81;
            // 
            // TG
            // 
            this.TG.AutoSize = true;
            this.TG.Location = new System.Drawing.Point(640, 334);
            this.TG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TG.Name = "TG";
            this.TG.Size = new System.Drawing.Size(75, 17);
            this.TG.TabIndex = 80;
            this.TG.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 392);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Tên đồ uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 328);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Mã đồ uống";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(711, 151);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 60);
            this.btnSua.TabIndex = 77;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(711, 79);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 64);
            this.btnXoa.TabIndex = 76;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(711, 4);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 68);
            this.btnThem.TabIndex = 75;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(227, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 34);
            this.label1.TabIndex = 74;
            this.label1.Text = "Thông tin đồ uống";
            // 
            // lOAIDOUONGTableAdapter
            // 
            this.lOAIDOUONGTableAdapter.ClearBeforeFill = true;
            // 
            // qL_QUANCAPHEDataSet
            // 
            this.qL_QUANCAPHEDataSet.DataSetName = "QL_QUANCAPHEDataSet";
            this.qL_QUANCAPHEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOUONGBindingSource
            // 
            this.dOUONGBindingSource.DataMember = "DOUONG";
            this.dOUONGBindingSource.DataSource = this.qL_QUANCAPHEDataSet;
            // 
            // dOUONGTableAdapter
            // 
            this.dOUONGTableAdapter.ClearBeforeFill = true;
            // 
            // lOAIDOUONGTableAdapter1
            // 
            this.lOAIDOUONGTableAdapter1.ClearBeforeFill = true;
            // 
            // frmDoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(912, 445);
            this.Controls.Add(this.cboDVT);
            this.Controls.Add(this.btnQLLoaiDoUong);
            this.Controls.Add(this.cboMaLoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.TG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "frmDoUong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoUong";
            this.Load += new System.EventHandler(this.frmDoUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOUONGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_QUANCAPHEDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDOUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQUANCAPHEDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_QUANCAPHEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_QUANCAPHEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOUONGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDVT;
        private System.Windows.Forms.Button btnQLLoaiDoUong;
        private System.Windows.Forms.ComboBox cboMaLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.BindingSource qLQUANCAPHEDataSet1BindingSource;
        private QL_QUANCAPHEDataSet1 qL_QUANCAPHEDataSet1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label TG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource lOAIDOUONGBindingSource;
        private QL_QUANCAPHEDataSet1TableAdapters.LOAIDOUONGTableAdapter lOAIDOUONGTableAdapter;
        private QL_QUANCAPHEDataSet qL_QUANCAPHEDataSet;
        private System.Windows.Forms.BindingSource dOUONGBindingSource;
        private QL_QUANCAPHEDataSetTableAdapters.DOUONGTableAdapter dOUONGTableAdapter;
        private QL_QUANCAPHEDataSet2 qL_QUANCAPHEDataSet2;
        private System.Windows.Forms.BindingSource lOAIDOUONGBindingSource1;
        private QL_QUANCAPHEDataSet2TableAdapters.LOAIDOUONGTableAdapter lOAIDOUONGTableAdapter1;
    }
}