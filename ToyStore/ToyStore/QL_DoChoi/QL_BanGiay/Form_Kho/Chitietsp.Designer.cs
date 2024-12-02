namespace QL_BanGiay
{
    partial class FrmChiTietSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietSanPham));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMoanh = new System.Windows.Forms.Button();
            this.cbChatLieu = new System.Windows.Forms.ComboBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.lbSoluong = new System.Windows.Forms.Label();
            this.txtKichthuoc = new System.Windows.Forms.TextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.lbAnh = new System.Windows.Forms.Label();
            this.cbKieuDoChoi = new System.Windows.Forms.ComboBox();
            this.txtTrongluong = new System.Windows.Forms.TextBox();
            this.txtMausac = new System.Windows.Forms.TextBox();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.lbKieudochoi = new System.Windows.Forms.Label();
            this.lbChatlieu = new System.Windows.Forms.Label();
            this.lbTrongluong = new System.Windows.Forms.Label();
            this.lbMausac = new System.Windows.Forms.Label();
            this.lbGioitinh = new System.Windows.Forms.Label();
            this.lbKichthuoc = new System.Windows.Forms.Label();
            this.cbThuonghieu = new System.Windows.Forms.ComboBox();
            this.lbMasp = new System.Windows.Forms.Label();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.lbTensp = new System.Windows.Forms.Label();
            this.txtDongianhap = new System.Windows.Forms.TextBox();
            this.lbDongianhap = new System.Windows.Forms.Label();
            this.txtDongiaban = new System.Windows.Forms.TextBox();
            this.lbDongiaban = new System.Windows.Forms.Label();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.lbThuonghieu = new System.Windows.Forms.Label();
            this.errSanpham = new System.Windows.Forms.ErrorProvider(this.components);
            this.ptbAnhsp = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhsp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(640, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.Location = new System.Drawing.Point(2, 15);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(267, 48);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoa.Location = new System.Drawing.Point(269, 15);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(206, 48);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLuu.Location = new System.Drawing.Point(475, 15);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 48);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.Location = new System.Drawing.Point(562, 15);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(76, 48);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMoanh);
            this.groupBox2.Controls.Add(this.ptbAnhsp);
            this.groupBox2.Controls.Add(this.cbChatLieu);
            this.groupBox2.Controls.Add(this.txtSoluong);
            this.groupBox2.Controls.Add(this.lbSoluong);
            this.groupBox2.Controls.Add(this.txtKichthuoc);
            this.groupBox2.Controls.Add(this.txtAnh);
            this.groupBox2.Controls.Add(this.lbAnh);
            this.groupBox2.Controls.Add(this.cbKieuDoChoi);
            this.groupBox2.Controls.Add(this.txtTrongluong);
            this.groupBox2.Controls.Add(this.txtMausac);
            this.groupBox2.Controls.Add(this.cbGioitinh);
            this.groupBox2.Controls.Add(this.lbKieudochoi);
            this.groupBox2.Controls.Add(this.lbChatlieu);
            this.groupBox2.Controls.Add(this.lbTrongluong);
            this.groupBox2.Controls.Add(this.lbMausac);
            this.groupBox2.Controls.Add(this.lbGioitinh);
            this.groupBox2.Controls.Add(this.lbKichthuoc);
            this.groupBox2.Controls.Add(this.cbThuonghieu);
            this.groupBox2.Controls.Add(this.lbMasp);
            this.groupBox2.Controls.Add(this.txtTensp);
            this.groupBox2.Controls.Add(this.lbTensp);
            this.groupBox2.Controls.Add(this.txtDongianhap);
            this.groupBox2.Controls.Add(this.lbDongianhap);
            this.groupBox2.Controls.Add(this.txtDongiaban);
            this.groupBox2.Controls.Add(this.lbDongiaban);
            this.groupBox2.Controls.Add(this.txtMasp);
            this.groupBox2.Controls.Add(this.lbThuonghieu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(640, 346);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // btnMoanh
            // 
            this.btnMoanh.Location = new System.Drawing.Point(157, 229);
            this.btnMoanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoanh.Name = "btnMoanh";
            this.btnMoanh.Size = new System.Drawing.Size(84, 41);
            this.btnMoanh.TabIndex = 19;
            this.btnMoanh.Text = "Mở ảnh";
            this.btnMoanh.UseVisualStyleBackColor = true;
            this.btnMoanh.Click += new System.EventHandler(this.btnMoanh_Click);
            // 
            // cbChatLieu
            // 
            this.cbChatLieu.ForeColor = System.Drawing.Color.Black;
            this.cbChatLieu.FormattingEnabled = true;
            this.cbChatLieu.Location = new System.Drawing.Point(275, 144);
            this.cbChatLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbChatLieu.Name = "cbChatLieu";
            this.cbChatLieu.Size = new System.Drawing.Size(82, 21);
            this.cbChatLieu.TabIndex = 15;
            // 
            // txtSoluong
            // 
            this.txtSoluong.ForeColor = System.Drawing.Color.Black;
            this.txtSoluong.Location = new System.Drawing.Point(438, 50);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(68, 20);
            this.txtSoluong.TabIndex = 17;
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongianhap_KeyPress);
            // 
            // lbSoluong
            // 
            this.lbSoluong.AutoSize = true;
            this.lbSoluong.ForeColor = System.Drawing.Color.Black;
            this.lbSoluong.Location = new System.Drawing.Point(383, 56);
            this.lbSoluong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSoluong.Name = "lbSoluong";
            this.lbSoluong.Size = new System.Drawing.Size(52, 13);
            this.lbSoluong.TabIndex = 52;
            this.lbSoluong.Text = "Số lượng:";
            // 
            // txtKichthuoc
            // 
            this.txtKichthuoc.ForeColor = System.Drawing.Color.Black;
            this.txtKichthuoc.Location = new System.Drawing.Point(265, 16);
            this.txtKichthuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKichthuoc.Name = "txtKichthuoc";
            this.txtKichthuoc.Size = new System.Drawing.Size(106, 20);
            this.txtKichthuoc.TabIndex = 11;
            this.txtKichthuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongianhap_KeyPress);
            // 
            // txtAnh
            // 
            this.txtAnh.ForeColor = System.Drawing.Color.Black;
            this.txtAnh.Location = new System.Drawing.Point(423, 79);
            this.txtAnh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(121, 59);
            this.txtAnh.TabIndex = 18;
            // 
            // lbAnh
            // 
            this.lbAnh.AutoSize = true;
            this.lbAnh.ForeColor = System.Drawing.Color.Black;
            this.lbAnh.Location = new System.Drawing.Point(383, 83);
            this.lbAnh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAnh.Name = "lbAnh";
            this.lbAnh.Size = new System.Drawing.Size(29, 13);
            this.lbAnh.TabIndex = 49;
            this.lbAnh.Text = "Ảnh:";
            // 
            // cbKieuDoChoi
            // 
            this.cbKieuDoChoi.ForeColor = System.Drawing.Color.Black;
            this.cbKieuDoChoi.FormattingEnabled = true;
            this.cbKieuDoChoi.Location = new System.Drawing.Point(448, 18);
            this.cbKieuDoChoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbKieuDoChoi.Name = "cbKieuDoChoi";
            this.cbKieuDoChoi.Size = new System.Drawing.Size(120, 21);
            this.cbKieuDoChoi.TabIndex = 16;
            // 
            // txtTrongluong
            // 
            this.txtTrongluong.ForeColor = System.Drawing.Color.Black;
            this.txtTrongluong.Location = new System.Drawing.Point(275, 113);
            this.txtTrongluong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTrongluong.Name = "txtTrongluong";
            this.txtTrongluong.Size = new System.Drawing.Size(96, 20);
            this.txtTrongluong.TabIndex = 14;
            // 
            // txtMausac
            // 
            this.txtMausac.ForeColor = System.Drawing.Color.Black;
            this.txtMausac.Location = new System.Drawing.Point(265, 78);
            this.txtMausac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMausac.Name = "txtMausac";
            this.txtMausac.Size = new System.Drawing.Size(106, 20);
            this.txtMausac.TabIndex = 13;
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.ForeColor = System.Drawing.Color.Black;
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Unisex"});
            this.cbGioitinh.Location = new System.Drawing.Point(265, 50);
            this.cbGioitinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(106, 21);
            this.cbGioitinh.TabIndex = 12;
            // 
            // lbKieudochoi
            // 
            this.lbKieudochoi.AutoSize = true;
            this.lbKieudochoi.ForeColor = System.Drawing.Color.Black;
            this.lbKieudochoi.Location = new System.Drawing.Point(374, 22);
            this.lbKieudochoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKieudochoi.Name = "lbKieudochoi";
            this.lbKieudochoi.Size = new System.Drawing.Size(70, 13);
            this.lbKieudochoi.TabIndex = 44;
            this.lbKieudochoi.Text = "Kiểu đồ chơi:";
            // 
            // lbChatlieu
            // 
            this.lbChatlieu.AutoSize = true;
            this.lbChatlieu.ForeColor = System.Drawing.Color.Black;
            this.lbChatlieu.Location = new System.Drawing.Point(208, 150);
            this.lbChatlieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbChatlieu.Name = "lbChatlieu";
            this.lbChatlieu.Size = new System.Drawing.Size(51, 13);
            this.lbChatlieu.TabIndex = 43;
            this.lbChatlieu.Text = "Chất liệu:";
            // 
            // lbTrongluong
            // 
            this.lbTrongluong.AutoSize = true;
            this.lbTrongluong.ForeColor = System.Drawing.Color.Black;
            this.lbTrongluong.Location = new System.Drawing.Point(206, 115);
            this.lbTrongluong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTrongluong.Name = "lbTrongluong";
            this.lbTrongluong.Size = new System.Drawing.Size(67, 13);
            this.lbTrongluong.TabIndex = 42;
            this.lbTrongluong.Text = "Trọng lượng:";
            // 
            // lbMausac
            // 
            this.lbMausac.AutoSize = true;
            this.lbMausac.ForeColor = System.Drawing.Color.Black;
            this.lbMausac.Location = new System.Drawing.Point(206, 83);
            this.lbMausac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMausac.Name = "lbMausac";
            this.lbMausac.Size = new System.Drawing.Size(51, 13);
            this.lbMausac.TabIndex = 41;
            this.lbMausac.Text = "Màu sắc:";
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.AutoSize = true;
            this.lbGioitinh.ForeColor = System.Drawing.Color.Black;
            this.lbGioitinh.Location = new System.Drawing.Point(206, 50);
            this.lbGioitinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(50, 13);
            this.lbGioitinh.TabIndex = 40;
            this.lbGioitinh.Text = "Giới tính:";
            // 
            // lbKichthuoc
            // 
            this.lbKichthuoc.AutoSize = true;
            this.lbKichthuoc.ForeColor = System.Drawing.Color.Black;
            this.lbKichthuoc.Location = new System.Drawing.Point(206, 20);
            this.lbKichthuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKichthuoc.Name = "lbKichthuoc";
            this.lbKichthuoc.Size = new System.Drawing.Size(63, 13);
            this.lbKichthuoc.TabIndex = 39;
            this.lbKichthuoc.Text = "Kích thước:";
            // 
            // cbThuonghieu
            // 
            this.cbThuonghieu.ForeColor = System.Drawing.Color.Black;
            this.cbThuonghieu.FormattingEnabled = true;
            this.cbThuonghieu.Location = new System.Drawing.Point(82, 142);
            this.cbThuonghieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbThuonghieu.Name = "cbThuonghieu";
            this.cbThuonghieu.Size = new System.Drawing.Size(108, 21);
            this.cbThuonghieu.TabIndex = 10;
            // 
            // lbMasp
            // 
            this.lbMasp.AutoSize = true;
            this.lbMasp.ForeColor = System.Drawing.Color.Black;
            this.lbMasp.Location = new System.Drawing.Point(16, 23);
            this.lbMasp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMasp.Name = "lbMasp";
            this.lbMasp.Size = new System.Drawing.Size(74, 13);
            this.lbMasp.TabIndex = 29;
            this.lbMasp.Text = "Mã sản phẩm:";
            // 
            // txtTensp
            // 
            this.txtTensp.ForeColor = System.Drawing.Color.Black;
            this.txtTensp.Location = new System.Drawing.Point(93, 47);
            this.txtTensp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(98, 20);
            this.txtTensp.TabIndex = 7;
            // 
            // lbTensp
            // 
            this.lbTensp.AutoSize = true;
            this.lbTensp.ForeColor = System.Drawing.Color.Black;
            this.lbTensp.Location = new System.Drawing.Point(16, 50);
            this.lbTensp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTensp.Name = "lbTensp";
            this.lbTensp.Size = new System.Drawing.Size(78, 13);
            this.lbTensp.TabIndex = 30;
            this.lbTensp.Text = "Tên sản phẩm:";
            // 
            // txtDongianhap
            // 
            this.txtDongianhap.ForeColor = System.Drawing.Color.Black;
            this.txtDongianhap.Location = new System.Drawing.Point(93, 79);
            this.txtDongianhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDongianhap.Name = "txtDongianhap";
            this.txtDongianhap.Size = new System.Drawing.Size(98, 20);
            this.txtDongianhap.TabIndex = 8;
            this.txtDongianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongianhap_KeyPress);
            // 
            // lbDongianhap
            // 
            this.lbDongianhap.AutoSize = true;
            this.lbDongianhap.ForeColor = System.Drawing.Color.Black;
            this.lbDongianhap.Location = new System.Drawing.Point(16, 83);
            this.lbDongianhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDongianhap.Name = "lbDongianhap";
            this.lbDongianhap.Size = new System.Drawing.Size(74, 13);
            this.lbDongianhap.TabIndex = 31;
            this.lbDongianhap.Text = "Đơn giá nhập:";
            // 
            // txtDongiaban
            // 
            this.txtDongiaban.ForeColor = System.Drawing.Color.Black;
            this.txtDongiaban.Location = new System.Drawing.Point(93, 113);
            this.txtDongiaban.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDongiaban.Name = "txtDongiaban";
            this.txtDongiaban.Size = new System.Drawing.Size(98, 20);
            this.txtDongiaban.TabIndex = 9;
            this.txtDongiaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongianhap_KeyPress);
            // 
            // lbDongiaban
            // 
            this.lbDongiaban.AutoSize = true;
            this.lbDongiaban.ForeColor = System.Drawing.Color.Black;
            this.lbDongiaban.Location = new System.Drawing.Point(16, 113);
            this.lbDongiaban.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDongiaban.Name = "lbDongiaban";
            this.lbDongiaban.Size = new System.Drawing.Size(68, 13);
            this.lbDongiaban.TabIndex = 32;
            this.lbDongiaban.Text = "Đơn giá bán:";
            // 
            // txtMasp
            // 
            this.txtMasp.ForeColor = System.Drawing.Color.Black;
            this.txtMasp.Location = new System.Drawing.Point(93, 18);
            this.txtMasp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(98, 20);
            this.txtMasp.TabIndex = 6;
            // 
            // lbThuonghieu
            // 
            this.lbThuonghieu.AutoSize = true;
            this.lbThuonghieu.ForeColor = System.Drawing.Color.Black;
            this.lbThuonghieu.Location = new System.Drawing.Point(16, 145);
            this.lbThuonghieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThuonghieu.Name = "lbThuonghieu";
            this.lbThuonghieu.Size = new System.Drawing.Size(70, 13);
            this.lbThuonghieu.TabIndex = 33;
            this.lbThuonghieu.Text = "Thương hiệu:";
            // 
            // errSanpham
            // 
            this.errSanpham.ContainerControl = this;
            // 
            // ptbAnhsp
            // 
            this.ptbAnhsp.Location = new System.Drawing.Point(290, 175);
            this.ptbAnhsp.Margin = new System.Windows.Forms.Padding(2);
            this.ptbAnhsp.Name = "ptbAnhsp";
            this.ptbAnhsp.Size = new System.Drawing.Size(343, 164);
            this.ptbAnhsp.TabIndex = 55;
            this.ptbAnhsp.TabStop = false;
            // 
            // FrmChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(640, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChiTietSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết sản phẩm";
            this.Load += new System.EventHandler(this.Chitietsp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhsp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbThuonghieu;
        private System.Windows.Forms.Label lbMasp;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.Label lbTensp;
        private System.Windows.Forms.TextBox txtDongianhap;
        private System.Windows.Forms.Label lbDongianhap;
        private System.Windows.Forms.TextBox txtDongiaban;
        private System.Windows.Forms.Label lbDongiaban;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.Label lbThuonghieu;
        private System.Windows.Forms.ComboBox cbChatLieu;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label lbSoluong;
        private System.Windows.Forms.TextBox txtKichthuoc;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Label lbAnh;
        private System.Windows.Forms.ComboBox cbKieuDoChoi;
        private System.Windows.Forms.TextBox txtTrongluong;
        private System.Windows.Forms.TextBox txtMausac;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.Label lbKieudochoi;
        private System.Windows.Forms.Label lbChatlieu;
        private System.Windows.Forms.Label lbTrongluong;
        private System.Windows.Forms.Label lbMausac;
        private System.Windows.Forms.Label lbGioitinh;
        private System.Windows.Forms.Label lbKichthuoc;
        private System.Windows.Forms.PictureBox ptbAnhsp;
        private System.Windows.Forms.Button btnMoanh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ErrorProvider errSanpham;
    }
}