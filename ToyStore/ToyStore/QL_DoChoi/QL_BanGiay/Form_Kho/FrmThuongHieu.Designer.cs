namespace QL_BanGiay
{
    partial class FrmThuongHieu
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
            this.lbThuonghieu = new System.Windows.Forms.Label();
            this.lbMaThuongHieu = new System.Windows.Forms.Label();
            this.lbTenThuongHieu = new System.Windows.Forms.Label();
            this.txtMaThuonghieu = new System.Windows.Forms.TextBox();
            this.txtTenThuongHieu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.errThuongHieu = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvThuonghieu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errThuongHieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuonghieu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbThuonghieu
            // 
            this.lbThuonghieu.AutoSize = true;
            this.lbThuonghieu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbThuonghieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbThuonghieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuonghieu.ForeColor = System.Drawing.Color.Red;
            this.lbThuonghieu.Location = new System.Drawing.Point(236, 0);
            this.lbThuonghieu.Name = "lbThuonghieu";
            this.lbThuonghieu.Size = new System.Drawing.Size(273, 31);
            this.lbThuonghieu.TabIndex = 1;
            this.lbThuonghieu.Text = "Danh mục thương hiệu";
            // 
            // lbMaThuongHieu
            // 
            this.lbMaThuongHieu.AutoSize = true;
            this.lbMaThuongHieu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbMaThuongHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaThuongHieu.ForeColor = System.Drawing.Color.Red;
            this.lbMaThuongHieu.Location = new System.Drawing.Point(23, 55);
            this.lbMaThuongHieu.Name = "lbMaThuongHieu";
            this.lbMaThuongHieu.Size = new System.Drawing.Size(128, 20);
            this.lbMaThuongHieu.TabIndex = 2;
            this.lbMaThuongHieu.Text = "Mã thương hiệu:";
            // 
            // lbTenThuongHieu
            // 
            this.lbTenThuongHieu.AutoSize = true;
            this.lbTenThuongHieu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbTenThuongHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenThuongHieu.ForeColor = System.Drawing.Color.Red;
            this.lbTenThuongHieu.Location = new System.Drawing.Point(23, 103);
            this.lbTenThuongHieu.Name = "lbTenThuongHieu";
            this.lbTenThuongHieu.Size = new System.Drawing.Size(133, 20);
            this.lbTenThuongHieu.TabIndex = 3;
            this.lbTenThuongHieu.Text = "Tên thương hiệu:";
            // 
            // txtMaThuonghieu
            // 
            this.txtMaThuonghieu.Location = new System.Drawing.Point(204, 56);
            this.txtMaThuonghieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaThuonghieu.Name = "txtMaThuonghieu";
            this.txtMaThuonghieu.Size = new System.Drawing.Size(449, 22);
            this.txtMaThuonghieu.TabIndex = 4;
            // 
            // txtTenThuongHieu
            // 
            this.txtTenThuongHieu.Location = new System.Drawing.Point(204, 103);
            this.txtTenThuongHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenThuongHieu.Name = "txtTenThuongHieu";
            this.txtTenThuongHieu.Size = new System.Drawing.Size(449, 22);
            this.txtTenThuongHieu.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(26, 8);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 45);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Red;
            this.btnSua.Location = new System.Drawing.Point(146, 8);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 45);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(267, 8);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 45);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(635, 8);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 45);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Red;
            this.btnLuu.Location = new System.Drawing.Point(405, 8);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 45);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBoqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoqua.ForeColor = System.Drawing.Color.Red;
            this.btnBoqua.Location = new System.Drawing.Point(520, 8);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(96, 45);
            this.btnBoqua.TabIndex = 11;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = false;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // errThuongHieu
            // 
            this.errThuongHieu.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenThuongHieu);
            this.panel1.Controls.Add(this.txtMaThuonghieu);
            this.panel1.Controls.Add(this.lbTenThuongHieu);
            this.panel1.Controls.Add(this.lbMaThuongHieu);
            this.panel1.Controls.Add(this.lbThuonghieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 134);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btnBoqua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 370);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 55);
            this.panel2.TabIndex = 13;
            // 
            // dgvThuonghieu
            // 
            this.dgvThuonghieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuonghieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvThuonghieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuonghieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThuonghieu.Location = new System.Drawing.Point(0, 134);
            this.dgvThuonghieu.Name = "dgvThuonghieu";
            this.dgvThuonghieu.RowHeadersWidth = 51;
            this.dgvThuonghieu.RowTemplate.Height = 24;
            this.dgvThuonghieu.Size = new System.Drawing.Size(757, 236);
            this.dgvThuonghieu.TabIndex = 14;
            this.dgvThuonghieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuonghieu_CellClick);
            // 
            // FrmThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 425);
            this.Controls.Add(this.dgvThuonghieu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmThuongHieu";
            this.Text = "Thương hiệu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmThuongHieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errThuongHieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuonghieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbThuonghieu;
        private System.Windows.Forms.Label lbMaThuongHieu;
        private System.Windows.Forms.Label lbTenThuongHieu;
        private System.Windows.Forms.TextBox txtMaThuonghieu;
        private System.Windows.Forms.TextBox txtTenThuongHieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.ErrorProvider errThuongHieu;
        private System.Windows.Forms.DataGridView dgvThuonghieu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}