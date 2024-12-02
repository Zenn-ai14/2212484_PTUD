namespace QL_BanGiay
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblCasher = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNgayGio = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.grb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.grb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.AutoSize = true;
            this.grb1.BackColor = System.Drawing.Color.Transparent;
            this.grb1.Controls.Add(this.btnBanHang);
            this.grb1.Controls.Add(this.btnNhapHang);
            this.grb1.Controls.Add(this.btnKho);
            this.grb1.Controls.Add(this.btnNhanVien);
            this.grb1.Controls.Add(this.btnKhachHang);
            this.grb1.Controls.Add(this.btnBaoCao);
            this.grb1.Controls.Add(this.picbox);
            this.grb1.Dock = System.Windows.Forms.DockStyle.Left;
            this.grb1.Location = new System.Drawing.Point(0, 0);
            this.grb1.Margin = new System.Windows.Forms.Padding(0);
            this.grb1.Name = "grb1";
            this.grb1.Padding = new System.Windows.Forms.Padding(0);
            this.grb1.Size = new System.Drawing.Size(149, 531);
            this.grb1.TabIndex = 0;
            this.grb1.TabStop = false;
            // 
            // btnBanHang
            // 
            this.btnBanHang.AutoSize = true;
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBanHang.ForeColor = System.Drawing.Color.Red;
            this.btnBanHang.Location = new System.Drawing.Point(0, 183);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(0);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(149, 163);
            this.btnBanHang.TabIndex = 0;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.AutoSize = true;
            this.btnNhapHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNhapHang.ForeColor = System.Drawing.Color.Red;
            this.btnNhapHang.Location = new System.Drawing.Point(0, 346);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(0);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(149, 37);
            this.btnNhapHang.TabIndex = 1;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnKho
            // 
            this.btnKho.AutoSize = true;
            this.btnKho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKho.ForeColor = System.Drawing.Color.Red;
            this.btnKho.Location = new System.Drawing.Point(0, 383);
            this.btnKho.Margin = new System.Windows.Forms.Padding(0);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(149, 37);
            this.btnKho.TabIndex = 2;
            this.btnKho.Text = "Quản lý kho";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.AutoSize = true;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNhanVien.ForeColor = System.Drawing.Color.Red;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 420);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(149, 37);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "Quản lý nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.AutoSize = true;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKhachHang.ForeColor = System.Drawing.Color.Red;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 457);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(149, 37);
            this.btnKhachHang.TabIndex = 4;
            this.btnKhachHang.Text = "Quản lý khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.AutoSize = true;
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBaoCao.ForeColor = System.Drawing.Color.Red;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 494);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(149, 37);
            this.btnBaoCao.TabIndex = 5;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // picbox
            // 
            this.picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.picbox.Image = global::QL_BanGiay.Properties.Resources._465670343_8744956335571035_2310484894972933945_n;
            this.picbox.Location = new System.Drawing.Point(0, 16);
            this.picbox.Margin = new System.Windows.Forms.Padding(0);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(149, 167);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 1;
            this.picbox.TabStop = false;
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // grb2
            // 
            this.grb2.BackColor = System.Drawing.Color.Transparent;
            this.grb2.Controls.Add(this.btnDangXuat);
            this.grb2.Controls.Add(this.lblCasher);
            this.grb2.Controls.Add(this.label2);
            this.grb2.Controls.Add(this.lblNgayGio);
            this.grb2.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb2.Location = new System.Drawing.Point(149, 0);
            this.grb2.Margin = new System.Windows.Forms.Padding(0);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(872, 61);
            this.grb2.TabIndex = 1;
            this.grb2.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.AutoSize = true;
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Red;
            this.btnDangXuat.Location = new System.Drawing.Point(750, 18);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(110, 29);
            this.btnDangXuat.TabIndex = 6;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblCasher
            // 
            this.lblCasher.AutoSize = true;
            this.lblCasher.ForeColor = System.Drawing.Color.White;
            this.lblCasher.Location = new System.Drawing.Point(198, 23);
            this.lblCasher.Name = "lblCasher";
            this.lblCasher.Size = new System.Drawing.Size(53, 16);
            this.lblCasher.TabIndex = 0;
            this.lblCasher.Text = "Casher: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(433, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hotline: 0123654789";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNgayGio
            // 
            this.lblNgayGio.AutoSize = true;
            this.lblNgayGio.ForeColor = System.Drawing.Color.White;
            this.lblNgayGio.Location = new System.Drawing.Point(6, 23);
            this.lblNgayGio.Name = "lblNgayGio";
            this.lblNgayGio.Size = new System.Drawing.Size(65, 16);
            this.lblNgayGio.TabIndex = 0;
            this.lblNgayGio.Text = "DateTime:";
            // 
            // panelMain
            // 
            this.panelMain.AutoSize = true;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(149, 61);
            this.panelMain.Margin = new System.Windows.Forms.Padding(10);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(872, 470);
            this.panelMain.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::QL_BanGiay.Properties.Resources.Halloween;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 531);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.grb2.ResumeLayout(false);
            this.grb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.Label lblCasher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNgayGio;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnBaoCao;
    }
}