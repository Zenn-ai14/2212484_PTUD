namespace QL_BanGiay
{
    partial class FrmHoaDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDonBan));
            this.label8 = new System.Windows.Forms.Label();
            this.danhSachBan = new System.Windows.Forms.DataGridView();
            this.timKiem = new System.Windows.Forms.Button();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.reset = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.themChiTiet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dateNgayBan = new System.Windows.Forms.DateTimePicker();
            this.cbomaNV = new System.Windows.Forms.ComboBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Mã hóa đơn";
            // 
            // danhSachBan
            // 
            this.danhSachBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachBan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.danhSachBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.danhSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachBan.Location = new System.Drawing.Point(17, 73);
            this.danhSachBan.Name = "danhSachBan";
            this.danhSachBan.RowHeadersWidth = 51;
            this.danhSachBan.RowTemplate.Height = 24;
            this.danhSachBan.Size = new System.Drawing.Size(1137, 223);
            this.danhSachBan.TabIndex = 5;
            this.danhSachBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachBan_CellContentClick);
            this.danhSachBan.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachBan_CellContentDoubleClick);
            this.danhSachBan.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.danhSachBan_CellMouseDoubleClick);
            // 
            // timKiem
            // 
            this.timKiem.BackColor = System.Drawing.Color.Chartreuse;
            this.timKiem.Location = new System.Drawing.Point(331, 21);
            this.timKiem.Name = "timKiem";
            this.timKiem.Size = new System.Drawing.Size(118, 46);
            this.timKiem.TabIndex = 30;
            this.timKiem.Text = "Tìm kiếm";
            this.timKiem.UseVisualStyleBackColor = false;
            this.timKiem.Click += new System.EventHandler(this.timKiem_Click);
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Items.AddRange(new object[] {
            ""});
            this.cboMaHD.Location = new System.Drawing.Point(110, 33);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(174, 24);
            this.cboMaHD.TabIndex = 29;
            this.cboMaHD.SelectedIndexChanged += new System.EventHandler(this.cboMaHD_SelectedIndexChanged);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Yellow;
            this.reset.Location = new System.Drawing.Point(498, 316);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(118, 48);
            this.reset.TabIndex = 47;
            this.reset.Text = "Làm lại";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.Chartreuse;
            this.them.Location = new System.Drawing.Point(61, 316);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(118, 48);
            this.them.TabIndex = 16;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sua.Location = new System.Drawing.Point(282, 316);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(118, 48);
            this.sua.TabIndex = 18;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.Yellow;
            this.thoat.Location = new System.Drawing.Point(935, 320);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(118, 48);
            this.thoat.TabIndex = 20;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // themChiTiet
            // 
            this.themChiTiet.BackColor = System.Drawing.Color.DarkOrange;
            this.themChiTiet.Location = new System.Drawing.Point(698, 316);
            this.themChiTiet.Name = "themChiTiet";
            this.themChiTiet.Size = new System.Drawing.Size(118, 48);
            this.themChiTiet.TabIndex = 19;
            this.themChiTiet.Text = "Thêm chi tiết";
            this.themChiTiet.UseVisualStyleBackColor = false;
            this.themChiTiet.Click += new System.EventHandler(this.themChiTiet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1166, 88);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(364, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hóa Đơn Bán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Mã HĐ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ngày bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(686, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã NV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(686, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tên khách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(682, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Điện thoại ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Địa chỉ";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(175, 32);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(275, 40);
            this.txtMaHD.TabIndex = 16;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(175, 189);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(275, 29);
            this.txtTenNV.TabIndex = 15;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Enabled = false;
            this.txtTenKhach.Location = new System.Drawing.Point(786, 73);
            this.txtTenKhach.Multiline = true;
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(275, 36);
            this.txtTenKhach.TabIndex = 14;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Enabled = false;
            this.txtDienThoai.Location = new System.Drawing.Point(786, 118);
            this.txtDienThoai.Multiline = true;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(275, 38);
            this.txtDienThoai.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(786, 167);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(275, 68);
            this.txtDiaChi.TabIndex = 12;
            // 
            // dateNgayBan
            // 
            this.dateNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayBan.Location = new System.Drawing.Point(176, 87);
            this.dateNgayBan.Name = "dateNgayBan";
            this.dateNgayBan.Size = new System.Drawing.Size(277, 22);
            this.dateNgayBan.TabIndex = 17;
            // 
            // cbomaNV
            // 
            this.cbomaNV.FormattingEnabled = true;
            this.cbomaNV.Location = new System.Drawing.Point(175, 139);
            this.cbomaNV.Name = "cbomaNV";
            this.cbomaNV.Size = new System.Drawing.Size(277, 24);
            this.cbomaNV.TabIndex = 19;
            this.cbomaNV.SelectedIndexChanged += new System.EventHandler(this.cbomaNV_SelectedIndexChanged);
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(784, 21);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(277, 24);
            this.cboMaKH.TabIndex = 18;
            this.cboMaKH.SelectedIndexChanged += new System.EventHandler(this.cboMaKH_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cboMaKH);
            this.groupBox4.Controls.Add(this.cbomaNV);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.dateNgayBan);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtDiaChi);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtDienThoai);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtTenKhach);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtTenNV);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtMaHD);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1166, 250);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin bán";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.reset);
            this.groupBox2.Controls.Add(this.timKiem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.themChiTiet);
            this.groupBox2.Controls.Add(this.thoat);
            this.groupBox2.Controls.Add(this.cboMaHD);
            this.groupBox2.Controls.Add(this.sua);
            this.groupBox2.Controls.Add(this.danhSachBan);
            this.groupBox2.Controls.Add(this.them);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1166, 376);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm bán";
            // 
            // FrmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1166, 714);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.hoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView danhSachBan;
        private System.Windows.Forms.Button timKiem;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button themChiTiet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dateNgayBan;
        private System.Windows.Forms.ComboBox cbomaNV;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}