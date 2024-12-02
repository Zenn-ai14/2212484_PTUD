namespace QL_BanGiay
{
    partial class FrmHoaDonNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDonNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maTim = new System.Windows.Forms.ComboBox();
            this.tim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tenNhanVien = new System.Windows.Forms.TextBox();
            this.tNhanVien = new System.Windows.Forms.Label();
            this.nv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.thoat = new System.Windows.Forms.Button();
            this.maHDN = new System.Windows.Forms.TextBox();
            this.them = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.themChiTiet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ngayNhap = new System.Windows.Forms.DateTimePicker();
            this.maNCC = new System.Windows.Forms.ComboBox();
            this.mNhanVien = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.danhSachNhap = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(373, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mã nhà cung cấp";
            // 
            // maTim
            // 
            this.maTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maTim.FormattingEnabled = true;
            this.maTim.Location = new System.Drawing.Point(638, 16);
            this.maTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maTim.Name = "maTim";
            this.maTim.Size = new System.Drawing.Size(148, 24);
            this.maTim.TabIndex = 31;
            this.maTim.SelectedIndexChanged += new System.EventHandler(this.maTim_SelectedIndexChanged);
            // 
            // tim
            // 
            this.tim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tim.AutoSize = true;
            this.tim.BackColor = System.Drawing.Color.Chartreuse;
            this.tim.Location = new System.Drawing.Point(830, 0);
            this.tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(117, 48);
            this.tim.TabIndex = 28;
            this.tim.Text = "Tìm kiếm";
            this.tim.UseVisualStyleBackColor = false;
            this.tim.Click += new System.EventHandler(this.tim_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã hóa đơn nhập";
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.Location = new System.Drawing.Point(723, 41);
            this.tenNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tenNhanVien.Multiline = true;
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.ReadOnly = true;
            this.tenNhanVien.Size = new System.Drawing.Size(207, 32);
            this.tenNhanVien.TabIndex = 18;
            // 
            // tNhanVien
            // 
            this.tNhanVien.AutoSize = true;
            this.tNhanVien.Location = new System.Drawing.Point(604, 44);
            this.tNhanVien.Name = "tNhanVien";
            this.tNhanVien.Size = new System.Drawing.Size(91, 16);
            this.tNhanVien.TabIndex = 17;
            this.tNhanVien.Text = "Tên nhân viên";
            // 
            // nv
            // 
            this.nv.AutoSize = true;
            this.nv.Location = new System.Drawing.Point(35, 127);
            this.nv.Name = "nv";
            this.nv.Size = new System.Drawing.Size(86, 16);
            this.nv.TabIndex = 9;
            this.nv.Text = "Mã nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hóa đơn nhập";
            // 
            // thoat
            // 
            this.thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.thoat.AutoSize = true;
            this.thoat.BackColor = System.Drawing.Color.Yellow;
            this.thoat.Location = new System.Drawing.Point(755, 15);
            this.thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(117, 48);
            this.thoat.TabIndex = 33;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // maHDN
            // 
            this.maHDN.Enabled = false;
            this.maHDN.Location = new System.Drawing.Point(151, 37);
            this.maHDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maHDN.Multiline = true;
            this.maHDN.Name = "maHDN";
            this.maHDN.Size = new System.Drawing.Size(211, 31);
            this.maHDN.TabIndex = 0;
            // 
            // them
            // 
            this.them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.them.AutoSize = true;
            this.them.BackColor = System.Drawing.Color.Chartreuse;
            this.them.Location = new System.Drawing.Point(54, 15);
            this.them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(117, 48);
            this.them.TabIndex = 31;
            this.them.Text = "Thêm Phiếu";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reset.AutoSize = true;
            this.reset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reset.Location = new System.Drawing.Point(228, 16);
            this.reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(117, 48);
            this.reset.TabIndex = 32;
            this.reset.Text = "Làm lại";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // themChiTiet
            // 
            this.themChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.themChiTiet.AutoSize = true;
            this.themChiTiet.BackColor = System.Drawing.Color.Aqua;
            this.themChiTiet.Location = new System.Drawing.Point(564, 15);
            this.themChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.themChiTiet.Name = "themChiTiet";
            this.themChiTiet.Size = new System.Drawing.Size(117, 48);
            this.themChiTiet.TabIndex = 34;
            this.themChiTiet.Text = "Thêm chi tiết";
            this.themChiTiet.UseVisualStyleBackColor = false;
            this.themChiTiet.Click += new System.EventHandler(this.themChiTiet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.ngayNhap);
            this.groupBox2.Controls.Add(this.maNCC);
            this.groupBox2.Controls.Add(this.mNhanVien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tenNhanVien);
            this.groupBox2.Controls.Add(this.tNhanVien);
            this.groupBox2.Controls.Add(this.nv);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.maHDN);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 87);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(977, 170);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhập";
            // 
            // ngayNhap
            // 
            this.ngayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayNhap.Location = new System.Drawing.Point(155, 81);
            this.ngayNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngayNhap.Name = "ngayNhap";
            this.ngayNhap.Size = new System.Drawing.Size(200, 22);
            this.ngayNhap.TabIndex = 37;
            // 
            // maNCC
            // 
            this.maNCC.FormattingEnabled = true;
            this.maNCC.Location = new System.Drawing.Point(723, 82);
            this.maNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maNCC.Name = "maNCC";
            this.maNCC.Size = new System.Drawing.Size(207, 24);
            this.maNCC.TabIndex = 36;
            // 
            // mNhanVien
            // 
            this.mNhanVien.FormattingEnabled = true;
            this.mNhanVien.Location = new System.Drawing.Point(148, 127);
            this.mNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mNhanVien.Name = "mNhanVien";
            this.mNhanVien.Size = new System.Drawing.Size(207, 24);
            this.mNhanVien.TabIndex = 35;
            this.mNhanVien.SelectedIndexChanged += new System.EventHandler(this.mNhanVien_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(977, 87);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // sua
            // 
            this.sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sua.AutoSize = true;
            this.sua.BackColor = System.Drawing.Color.Aqua;
            this.sua.Location = new System.Drawing.Point(391, 16);
            this.sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(117, 48);
            this.sua.TabIndex = 35;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.themChiTiet);
            this.panel1.Controls.Add(this.sua);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.them);
            this.panel1.Controls.Add(this.thoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 383);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 78);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.maTim);
            this.panel2.Controls.Add(this.tim);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 50);
            this.panel2.TabIndex = 37;
            // 
            // danhSachNhap
            // 
            this.danhSachNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.danhSachNhap.BackgroundColor = System.Drawing.Color.White;
            this.danhSachNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhSachNhap.Location = new System.Drawing.Point(0, 307);
            this.danhSachNhap.Name = "danhSachNhap";
            this.danhSachNhap.RowHeadersWidth = 51;
            this.danhSachNhap.RowTemplate.Height = 24;
            this.danhSachNhap.Size = new System.Drawing.Size(977, 76);
            this.danhSachNhap.TabIndex = 38;
            this.danhSachNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachNhap_CellClick);
            this.danhSachNhap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachNhap_CellContentDoubleClick);
            // 
            // FrmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(977, 461);
            this.Controls.Add(this.danhSachNhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHoaDonNhap";
            this.Text = "Hóa đơn nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.hoaDonNhap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox maTim;
        private System.Windows.Forms.Button tim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenNhanVien;
        private System.Windows.Forms.Label tNhanVien;
        private System.Windows.Forms.Label nv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.TextBox maHDN;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button themChiTiet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox mNhanVien;
        private System.Windows.Forms.ComboBox maNCC;
        private System.Windows.Forms.DateTimePicker ngayNhap;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView danhSachNhap;
    }
}

