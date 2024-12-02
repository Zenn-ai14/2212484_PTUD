namespace QL_BanGiay
{
    partial class FrmBaoCao
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
            this.grb = new System.Windows.Forms.GroupBox();
            this.pnchonngay = new System.Windows.Forms.Panel();
            this.dtpChonNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChucnang = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbBaocao = new System.Windows.Forms.GroupBox();
            this.dgvDoanhthu = new System.Windows.Forms.DataGridView();
            this.flpnel = new System.Windows.Forms.FlowLayoutPanel();
            this.txtDoanhthu = new System.Windows.Forms.TextBox();
            this.grb.SuspendLayout();
            this.pnchonngay.SuspendLayout();
            this.grbChucnang.SuspendLayout();
            this.grbBaocao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhthu)).BeginInit();
            this.flpnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb
            // 
            this.grb.Controls.Add(this.pnchonngay);
            this.grb.Dock = System.Windows.Forms.DockStyle.Right;
            this.grb.Location = new System.Drawing.Point(561, 0);
            this.grb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb.Name = "grb";
            this.grb.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb.Size = new System.Drawing.Size(178, 427);
            this.grb.TabIndex = 2;
            this.grb.TabStop = false;
            // 
            // pnchonngay
            // 
            this.pnchonngay.Controls.Add(this.dtpChonNgay);
            this.pnchonngay.Controls.Add(this.label1);
            this.pnchonngay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnchonngay.Location = new System.Drawing.Point(3, 17);
            this.pnchonngay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnchonngay.Name = "pnchonngay";
            this.pnchonngay.Size = new System.Drawing.Size(172, 408);
            this.pnchonngay.TabIndex = 0;
            // 
            // dtpChonNgay
            // 
            this.dtpChonNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpChonNgay.Location = new System.Drawing.Point(18, 51);
            this.dtpChonNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpChonNgay.Name = "dtpChonNgay";
            this.dtpChonNgay.Size = new System.Drawing.Size(132, 22);
            this.dtpChonNgay.TabIndex = 1;
            this.dtpChonNgay.ValueChanged += new System.EventHandler(this.dtpChonNgay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn ngày:";
            // 
            // grbChucnang
            // 
            this.grbChucnang.Controls.Add(this.btnExcel);
            this.grbChucnang.Controls.Add(this.btnThoat);
            this.grbChucnang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbChucnang.Location = new System.Drawing.Point(0, 0);
            this.grbChucnang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbChucnang.Name = "grbChucnang";
            this.grbChucnang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbChucnang.Size = new System.Drawing.Size(561, 80);
            this.grbChucnang.TabIndex = 3;
            this.grbChucnang.TabStop = false;
            this.grbChucnang.Text = "Chức năng";
            // 
            // btnExcel
            // 
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcel.Location = new System.Drawing.Point(3, 17);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(425, 61);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "In file Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.Location = new System.Drawing.Point(428, 17);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 61);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grbBaocao
            // 
            this.grbBaocao.Controls.Add(this.dgvDoanhthu);
            this.grbBaocao.Controls.Add(this.flpnel);
            this.grbBaocao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbBaocao.Location = new System.Drawing.Point(0, 80);
            this.grbBaocao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbBaocao.Name = "grbBaocao";
            this.grbBaocao.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbBaocao.Size = new System.Drawing.Size(561, 347);
            this.grbBaocao.TabIndex = 4;
            this.grbBaocao.TabStop = false;
            this.grbBaocao.Text = "Báo cáo sản phẩm bán theo ngày";
            // 
            // dgvDoanhthu
            // 
            this.dgvDoanhthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhthu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDoanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhthu.Location = new System.Drawing.Point(3, 71);
            this.dgvDoanhthu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDoanhthu.Name = "dgvDoanhthu";
            this.dgvDoanhthu.RowHeadersWidth = 62;
            this.dgvDoanhthu.RowTemplate.Height = 28;
            this.dgvDoanhthu.Size = new System.Drawing.Size(555, 274);
            this.dgvDoanhthu.TabIndex = 1;
            // 
            // flpnel
            // 
            this.flpnel.Controls.Add(this.txtDoanhthu);
            this.flpnel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpnel.Location = new System.Drawing.Point(3, 17);
            this.flpnel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpnel.Name = "flpnel";
            this.flpnel.Size = new System.Drawing.Size(555, 54);
            this.flpnel.TabIndex = 0;
            // 
            // txtDoanhthu
            // 
            this.txtDoanhthu.Location = new System.Drawing.Point(3, 2);
            this.txtDoanhthu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoanhthu.Name = "txtDoanhthu";
            this.txtDoanhthu.Size = new System.Drawing.Size(523, 22);
            this.txtDoanhthu.TabIndex = 0;
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 427);
            this.Controls.Add(this.grbBaocao);
            this.Controls.Add(this.grbChucnang);
            this.Controls.Add(this.grb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmBaoCao";
            this.Text = "Báo cáo doanh thu";
            this.grb.ResumeLayout(false);
            this.pnchonngay.ResumeLayout(false);
            this.pnchonngay.PerformLayout();
            this.grbChucnang.ResumeLayout(false);
            this.grbBaocao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhthu)).EndInit();
            this.flpnel.ResumeLayout(false);
            this.flpnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.GroupBox grbChucnang;
        private System.Windows.Forms.GroupBox grbBaocao;
        private System.Windows.Forms.DataGridView dgvDoanhthu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpChonNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Panel pnchonngay;
        private System.Windows.Forms.FlowLayoutPanel flpnel;
        private System.Windows.Forms.TextBox txtDoanhthu;
    }
}