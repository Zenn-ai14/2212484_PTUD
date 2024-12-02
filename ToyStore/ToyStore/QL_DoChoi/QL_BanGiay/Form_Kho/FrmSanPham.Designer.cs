namespace QL_BanGiay
{
    partial class FrmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbTimkiem = new System.Windows.Forms.GroupBox();
            this.lbKieugiay = new System.Windows.Forms.Label();
            this.cbKieuDoChoi = new System.Windows.Forms.ComboBox();
            this.cbThuonghieu = new System.Windows.Forms.ComboBox();
            this.lbThuonghieu = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.cbTamgia = new System.Windows.Forms.ComboBox();
            this.lbTamgia = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.grbSpnoibat = new System.Windows.Forms.GroupBox();
            this.grbChucnang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grbSanPham = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grbTimkiem.SuspendLayout();
            this.grbChucnang.SuspendLayout();
            this.grbSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbTimkiem);
            this.panel1.Controls.Add(this.grbSpnoibat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(403, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 452);
            this.panel1.TabIndex = 4;
            // 
            // grbTimkiem
            // 
            this.grbTimkiem.Controls.Add(this.lbKieugiay);
            this.grbTimkiem.Controls.Add(this.cbKieuDoChoi);
            this.grbTimkiem.Controls.Add(this.cbThuonghieu);
            this.grbTimkiem.Controls.Add(this.lbThuonghieu);
            this.grbTimkiem.Controls.Add(this.btnTimkiem);
            this.grbTimkiem.Controls.Add(this.cbTamgia);
            this.grbTimkiem.Controls.Add(this.lbTamgia);
            this.grbTimkiem.Controls.Add(this.txtTimkiem);
            this.grbTimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTimkiem.Location = new System.Drawing.Point(0, 0);
            this.grbTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.grbTimkiem.Name = "grbTimkiem";
            this.grbTimkiem.Padding = new System.Windows.Forms.Padding(2);
            this.grbTimkiem.Size = new System.Drawing.Size(273, 263);
            this.grbTimkiem.TabIndex = 5;
            this.grbTimkiem.TabStop = false;
            this.grbTimkiem.Text = "Tìm kiếm sản phẩm";
            // 
            // lbKieugiay
            // 
            this.lbKieugiay.AutoSize = true;
            this.lbKieugiay.Location = new System.Drawing.Point(14, 102);
            this.lbKieugiay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKieugiay.Name = "lbKieugiay";
            this.lbKieugiay.Size = new System.Drawing.Size(67, 13);
            this.lbKieugiay.TabIndex = 9;
            this.lbKieugiay.Text = "Kiểu đồ chơi";
            // 
            // cbKieuDoChoi
            // 
            this.cbKieuDoChoi.FormattingEnabled = true;
            this.cbKieuDoChoi.Location = new System.Drawing.Point(16, 116);
            this.cbKieuDoChoi.Margin = new System.Windows.Forms.Padding(2);
            this.cbKieuDoChoi.Name = "cbKieuDoChoi";
            this.cbKieuDoChoi.Size = new System.Drawing.Size(242, 21);
            this.cbKieuDoChoi.TabIndex = 8;
            // 
            // cbThuonghieu
            // 
            this.cbThuonghieu.FormattingEnabled = true;
            this.cbThuonghieu.Location = new System.Drawing.Point(16, 67);
            this.cbThuonghieu.Margin = new System.Windows.Forms.Padding(2);
            this.cbThuonghieu.Name = "cbThuonghieu";
            this.cbThuonghieu.Size = new System.Drawing.Size(242, 21);
            this.cbThuonghieu.TabIndex = 7;
            // 
            // lbThuonghieu
            // 
            this.lbThuonghieu.AutoSize = true;
            this.lbThuonghieu.Location = new System.Drawing.Point(14, 53);
            this.lbThuonghieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThuonghieu.Name = "lbThuonghieu";
            this.lbThuonghieu.Size = new System.Drawing.Size(67, 13);
            this.lbThuonghieu.TabIndex = 6;
            this.lbThuonghieu.Text = "Thương hiệu";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(100, 220);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(92, 38);
            this.btnTimkiem.TabIndex = 10;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // cbTamgia
            // 
            this.cbTamgia.FormattingEnabled = true;
            this.cbTamgia.Location = new System.Drawing.Point(16, 178);
            this.cbTamgia.Margin = new System.Windows.Forms.Padding(2);
            this.cbTamgia.Name = "cbTamgia";
            this.cbTamgia.Size = new System.Drawing.Size(242, 21);
            this.cbTamgia.TabIndex = 9;
            // 
            // lbTamgia
            // 
            this.lbTamgia.AutoSize = true;
            this.lbTamgia.Location = new System.Drawing.Point(14, 152);
            this.lbTamgia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTamgia.Name = "lbTamgia";
            this.lbTamgia.Size = new System.Drawing.Size(45, 13);
            this.lbTamgia.TabIndex = 3;
            this.lbTamgia.Text = "Tầm giá";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(16, 24);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(251, 20);
            this.txtTimkiem.TabIndex = 6;
            this.txtTimkiem.Enter += new System.EventHandler(this.txtTimkiem_Enter);
            this.txtTimkiem.Leave += new System.EventHandler(this.txtTimkiem_Leave);
            // 
            // grbSpnoibat
            // 
            this.grbSpnoibat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbSpnoibat.Location = new System.Drawing.Point(0, 263);
            this.grbSpnoibat.Margin = new System.Windows.Forms.Padding(2);
            this.grbSpnoibat.Name = "grbSpnoibat";
            this.grbSpnoibat.Padding = new System.Windows.Forms.Padding(2);
            this.grbSpnoibat.Size = new System.Drawing.Size(273, 189);
            this.grbSpnoibat.TabIndex = 11;
            this.grbSpnoibat.TabStop = false;
            this.grbSpnoibat.Text = "Top 5 sản phẩm bán chạy";
            // 
            // grbChucnang
            // 
            this.grbChucnang.Controls.Add(this.btnThem);
            this.grbChucnang.Controls.Add(this.btnHienthi);
            this.grbChucnang.Controls.Add(this.btnExcel);
            this.grbChucnang.Controls.Add(this.btnDong);
            this.grbChucnang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbChucnang.Location = new System.Drawing.Point(0, 0);
            this.grbChucnang.Margin = new System.Windows.Forms.Padding(2);
            this.grbChucnang.Name = "grbChucnang";
            this.grbChucnang.Padding = new System.Windows.Forms.Padding(2);
            this.grbChucnang.Size = new System.Drawing.Size(403, 66);
            this.grbChucnang.TabIndex = 0;
            this.grbChucnang.TabStop = false;
            this.grbChucnang.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Location = new System.Drawing.Point(2, 15);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(151, 49);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHienthi.Location = new System.Drawing.Point(153, 15);
            this.btnHienthi.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(87, 49);
            this.btnHienthi.TabIndex = 2;
            this.btnHienthi.Text = "&Hiển thị DS";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExcel.Location = new System.Drawing.Point(240, 15);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(83, 49);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "In file &Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnDong
            // 
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDong.Location = new System.Drawing.Point(323, 15);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(78, 49);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // grbSanPham
            // 
            this.grbSanPham.Controls.Add(this.dgvSanPham);
            this.grbSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbSanPham.Location = new System.Drawing.Point(0, 66);
            this.grbSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.grbSanPham.Name = "grbSanPham";
            this.grbSanPham.Padding = new System.Windows.Forms.Padding(2);
            this.grbSanPham.Size = new System.Drawing.Size(403, 386);
            this.grbSanPham.TabIndex = 8;
            this.grbSanPham.TabStop = false;
            this.grbSanPham.Text = "Danh sách sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(2, 15);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 62;
            this.dgvSanPham.RowTemplate.Height = 28;
            this.dgvSanPham.Size = new System.Drawing.Size(399, 369);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 452);
            this.Controls.Add(this.grbSanPham);
            this.Controls.Add(this.grbChucnang);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSanPham";
            this.Text = "Danh sách sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSanPham2_Load);
            this.panel1.ResumeLayout(false);
            this.grbTimkiem.ResumeLayout(false);
            this.grbTimkiem.PerformLayout();
            this.grbChucnang.ResumeLayout(false);
            this.grbSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbTimkiem;
        private System.Windows.Forms.GroupBox grbSpnoibat;
        private System.Windows.Forms.GroupBox grbChucnang;
        private System.Windows.Forms.ComboBox cbTamgia;
        private System.Windows.Forms.Label lbTamgia;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbSanPham;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label lbKieugiay;
        private System.Windows.Forms.ComboBox cbKieuDoChoi;
        private System.Windows.Forms.ComboBox cbThuonghieu;
        private System.Windows.Forms.Label lbThuonghieu;
    }
}