
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
//using Microsoft.Reporting.Map.WebForms.BingMaps;

namespace QL_BanGiay
{
    public partial class FrmSanPham : Form
    {
        string userName;
        AccessData data = new AccessData();
        
        public FrmSanPham(string userName)
        {
            InitializeComponent();
            // làm watermark tìm kiếm sản phẩm
            txtTimkiem.ForeColor = Color.LightGray;
            txtTimkiem.Text = "Nhập mã sản phẩm hoặc tên sản phẩm";
            this.txtTimkiem.Leave += new System.EventHandler(this.txtTimkiem_Leave);
            this.txtTimkiem.Enter += new System.EventHandler(this.txtTimkiem_Enter);

            this.userName= userName;
            //
            
            //
            cbTamgia.Items.Add("Nhỏ hơn 1 triệu");
            cbTamgia.Items.Add("Từ 1-5 triệu");
            cbTamgia.Items.Add("Từ 5-10 triệu");
            cbTamgia.Items.Add("Trên 10 triệu");
            //
            System.Windows.Forms.ListBox lbox =SanPhamNoiBat();
            lbox.SelectedIndexChanged += new System.EventHandler(this.lbox_SelectedIndexChanged);
            
        }
        private void lbox_SelectedIndexChanged(object sender,EventArgs e)
        {
            string masp;
            string sql="select top(5) tDoChoi.MaDoChoi from tDoChoi join tChitietHDB on tDoChoi.maDoChoi=tchitiethdb.MaDoChoi group by tDoChoi.MaDoChoi order by SUM(SLBAN) DESC";
            System.Data.DataTable dt= data.ReadData(sql);
            System.Windows.Forms.ListBox lbox2 = new System.Windows.Forms.ListBox();
            lbox2 = (System.Windows.Forms.ListBox)sender;
            if (lbox2.SelectedIndex == 0)
            {
                masp = dt.Rows[0][0].ToString();
                FrmChiTietSanPham ctsp= new FrmChiTietSanPham(masp);
                ctsp.Show();
            }
            if (lbox2.SelectedIndex == 1)
            {
                masp = dt.Rows[1][0].ToString();
                FrmChiTietSanPham ctsp = new FrmChiTietSanPham(masp);
                ctsp.Show();
            }
            if (lbox2.SelectedIndex == 2)
            {
                masp = dt.Rows[2][0].ToString();
                FrmChiTietSanPham ctsp = new FrmChiTietSanPham(masp);
                ctsp.Show();
            }
            if (lbox2.SelectedIndex == 3)
            {
                masp = dt.Rows[3][0].ToString();
                FrmChiTietSanPham ctsp = new FrmChiTietSanPham(masp);
                ctsp.Show();
            }
            if (lbox2.SelectedIndex == 4)
            {
                masp = dt.Rows[4][0].ToString();
                FrmChiTietSanPham ctsp = new FrmChiTietSanPham(masp);
                ctsp.Show();
            }
        }
        private void LoadDataGridView()
        {
            string sql = "select MaDoChoi,TenDoChoi,TenTheLoai,TenThuongHieu,DonGiaNhap,DonGiaBan," +
                "SoLuong,KichThuoc,GioiTinh,MauSac,TenChatLieu " +
                "from tDoChoi join tThuongHieu on tDoChoi.MaThuongHieu=tThuongHieu.MaThuongHieu " +
                "join tTheLoai on tTheLoai.MaTheLoai=tDoChoi.MaTheLoai " +
                "join tChatLieu on tChatLieu.MaChatLieu=tDoChoi.MaChatLieu";
            dgvSanPham.DataSource = data.ReadData(sql);
            dgvSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns[2].HeaderText = "Kiểu đồ chơi";
            dgvSanPham.Columns[3].HeaderText = "Thương hiệu";
            dgvSanPham.Columns[4].HeaderText = "Đơn giá nhập";
            dgvSanPham.Columns[5].HeaderText = "Đơn giá bán";
            dgvSanPham.Columns[6].HeaderText = "Số lượng tồn";
            dgvSanPham.Columns[7].HeaderText = "Kích thước";
            dgvSanPham.Columns[8].HeaderText = "Giới tính";
            dgvSanPham.Columns[9].HeaderText = "Màu sắc";
            dgvSanPham.Columns[10].HeaderText = "Chất liệu";
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValue()
        {
            
            cbThuonghieu.SelectedIndex = -1;
            cbKieuDoChoi.SelectedIndex = -1;
            cbTamgia.SelectedIndex = -1;
        }
        private void FrmSanPham2_Load(object sender, EventArgs e)
        {
            btnThem.Width = (int)(grbChucnang.Width / 4);
            btnHienthi.Width = (int)(grbChucnang.Width / 4);
            btnExcel.Width = (int)(grbChucnang.Width / 4);
            btnDong.Width = (int)(grbChucnang.Width / 4);


            string sql_thuonghieu = "select * from tthuonghieu";
            string sql_kieudochoi = "select* from tTheLoai";
            LoadDataGridView();
            data.fillComboBox(sql_thuonghieu, cbThuonghieu, "MaThuongHieu", "TenThuongHieu");
            data.fillComboBox(sql_kieudochoi, cbKieuDoChoi, "MaTheLoai", "TenTheLoai");
            ResetValue();
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu về sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string masp = dgvSanPham.CurrentRow.Cells["MaDoChoi"].Value.ToString();
            FrmChiTietSanPham chitietsp = new FrmChiTietSanPham(masp);
            chitietsp.ShowDialog();
            LoadDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmChiTietSanPham chitietsp = new FrmChiTietSanPham();
            //chitietsp.MdiParent = this;
            chitietsp.ShowDialog();
            //chitietsp.Dock = DockStyle.Fill;
            LoadDataGridView();
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
            ResetValue();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimkiem_Leave(object sender, EventArgs e)
        {
            if (txtTimkiem.Text == "")
            {
                txtTimkiem.ForeColor = Color.LightGray;
                txtTimkiem.Text = "Nhập mã sản phẩm hoặc tên sản phẩm";
            }
        }

        private void txtTimkiem_Enter(object sender, EventArgs e)
        {
            if(txtTimkiem.Text== "Nhập mã sản phẩm hoặc tên sản phẩm")
            {
                txtTimkiem.Text = "";
                txtTimkiem.ForeColor = Color.Black;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if(txtTimkiem.Text== "Nhập mã sản phẩm hoặc tên sản phẩm" &&
                cbThuonghieu.Text=="" &&
                cbKieuDoChoi.Text=="" &&
                cbTamgia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = "select * from tDoChoi where 1=1";
            if (txtTimkiem.Text!= "Nhập mã sản phẩm hoặc tên sản phẩm")
            {
                sql += " and ( MaDoChoi like N'%"+txtTimkiem.Text+"%' or TenDoChoi like N'%"+txtTimkiem.Text+"%')";
            }
            if (cbThuonghieu.Text != "")
            {
                sql += " and MaThuongHieu like N'%" + cbThuonghieu.SelectedValue + "%'";
            }
            if (cbKieuDoChoi.Text != "")
            {
                sql += " and MaTheLoai like N'%" + cbKieuDoChoi.SelectedValue + "%'";
            }
            if(cbTamgia.Text!="")
            {
                if (cbTamgia.SelectedIndex == 0)
                {
                    sql += " and DonGiaBan<1000";
                }
                if (cbTamgia.SelectedIndex == 1)
                {
                    sql += " and (DonGiaBan between 1000 and 5000)";
                }
                if (cbTamgia.SelectedIndex == 2)
                {
                    sql += " and (DonGiaBan between 5001 and 10000)";
                }
                if (cbTamgia.SelectedIndex == 3)
                {
                    sql += " and DonGiaBan >10000";
                }
            }
            System.Data.DataTable dt = data.ReadData(sql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + dt.Rows.Count + " bản ghi thỏa mã điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvSanPham.DataSource = dt;
            ResetValue();
            txtTimkiem.ForeColor = Color.LightGray;
            txtTimkiem.Text = "Nhập mã sản phẩm hoặc tên sản phẩm";
            // done!
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            //
            Excel.Range shopName = (Excel.Range)exSheet.Cells[1, 1];
            shopName.Font.Size = 20;
            shopName.Font.Bold = true;
            shopName.Value = "CỬA HÀNG ĐỒ CHƠI BING CHILING";
            //
            Excel.Range shopAddress = (Excel.Range)exSheet.Cells[2, 1];
            shopAddress.Font.Size = 14;
            shopAddress.Font.Bold = true;
            shopAddress.Value = "Số 3 P. Cầu Giấy, Láng Thượng, Đống Đa, Hà Nội, Việt Nam";
            //in thông tin người tạo và ngày tháng
            exSheet.Range["A6:B7"].Font.Size = 13;

            exSheet.get_Range("A6:B7").Font.Bold = true;
            exSheet.get_Range("A6").Value = "Người tạo:";
            exSheet.get_Range("B6").Value = userName; //*****
            exSheet.get_Range("A7").Value = "Ngày:";
            exSheet.get_Range("B7").Value = DateTime.Now.ToString("dd-MM-yyyy");

            //in chữ danh sách sp

            exSheet.get_Range("C8:E8").Interior.Color= System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            ////
            exSheet.Range["D8"].Font.Size = 15;
            exSheet.Range["D8"].Font.Bold = true;
            exSheet.Range["D8"].Font.Color = Color.Black;
            exSheet.get_Range("D8").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.Range["D8"].Value = "DANH SÁCH SẢN PHẨM";
            //

            /////
            exSheet.Range["A10:L10"].Font.Size = 13;
            exSheet.Range["A10:L10"].Font.Bold = true;
            exSheet.get_Range("A10:L10").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.get_Range("A10:L10").ColumnWidth = 15;
            exSheet.get_Range("A10").Value = "STT";
            exSheet.get_Range("B10").Value = "Mã sản phẩm";
            exSheet.get_Range("C10").Value = "Tên sản phẩm";
            exSheet.get_Range("D10").Value = "Kiểu đồ chơi";
            exSheet.get_Range("E10").Value = "Thương hiệu";
            exSheet.get_Range("F10").Value = "Đơn giá nhập";
            exSheet.get_Range("G10").Value = "Đơn giá bán";
            exSheet.get_Range("H10").Value = "Số lượng tồn";
            exSheet.get_Range("I10").Value = "Kích thước";
            exSheet.get_Range("J10").Value = "Giới tính";
            exSheet.get_Range("K10").Value = "Màu sắc";
            exSheet.get_Range("L10").Value = "Chất liệu";
            ////
            exSheet.get_Range("A10:L10").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
            ////
            //in danh sách sản phẩm
            int dong = 11;
            //
            // border danh sách
            exSheet.get_Range("A10:L"+(dong + dgvSanPham.Rows.Count-1).ToString()).Borders.Color = System.Drawing.Color.Black.ToArgb();
            //
            for (int i = 0; i < dgvSanPham.Rows.Count; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvSanPham.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvSanPham.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dgvSanPham.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvSanPham.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgvSanPham.Rows[i].Cells[4].Value.ToString();
                exSheet.Range["G" + (dong + i).ToString()].Value = dgvSanPham.Rows[i].Cells[5].Value.ToString();
                exSheet.Range["H" + (dong + i).ToString()].Value = dgvSanPham.Rows[i].Cells[6].Value.ToString();
                exSheet.Range["I" + (dong + i).ToString()].Value = dgvSanPham.Rows[i].Cells[7].Value.ToString();
                exSheet.Range["J" + (dong + i).ToString()].Value = dgvSanPham.Rows[i].Cells[8].Value.ToString();
                exSheet.Range["K" + (dong + i).ToString()].Value = dgvSanPham.Rows[i].Cells[9].Value.ToString();
                exSheet.Range["L" + (dong + i).ToString()].Value = dgvSanPham.Rows[i].Cells[10].Value.ToString();
            }

            //
            exSheet.Name = "DSSP";
            exBook.Activate();
            // lưu file
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel WorkBook|*xlsx|All Files|*.*";
            save.FilterIndex = 1;
            if (save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToLower());
            }

            exApp.Quit();
            // done!
        }
        public System.Windows.Forms.ListBox SanPhamNoiBat()
        {
            string sql;
            
            sql = "select top(5) tDoChoi.MaDoChoi,TenDoChoi,SUM(SLBan) from tDoChoi join tChitietHDB on tDoChoi.maDoChoi=tchitiethdb.maDoChoi group by tDoChoi.MaDoChoi,TenDoChoi order by SUM(SLBAN) DESC";
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = data.ReadData(sql);
            System.Windows.Forms.ListBox lboxspnoibat = new System.Windows.Forms.ListBox();
            if (dt.Rows.Count >= 5)
            {
                lboxspnoibat.Items.Add("TOP 1: " + dt.Rows[0][0].ToString() + " - " + dt.Rows[0][1].ToString() + " - Số lượng bán ra:" + dt.Rows[0][2].ToString());
                lboxspnoibat.Items.Add("TOP 2: " + dt.Rows[1][0].ToString() + " - " + dt.Rows[1][1].ToString() + " - Số lượng bán ra:" + dt.Rows[1][2].ToString());
                lboxspnoibat.Items.Add("TOP 3: " + dt.Rows[2][0].ToString() + " - " + dt.Rows[2][1].ToString() + " - Số lượng bán ra:" + dt.Rows[2][2].ToString());
                lboxspnoibat.Items.Add("TOP 4: " + dt.Rows[3][0].ToString() + " - " + dt.Rows[3][1].ToString() + " - Số lượng bán ra:" + dt.Rows[3][2].ToString());
                lboxspnoibat.Items.Add("TOP 5: " + dt.Rows[4][0].ToString() + " - " + dt.Rows[4][1].ToString() + " - Số lượng bán ra:" + dt.Rows[4][2].ToString());
            }
            if (dt.Rows.Count == 4)
            {
                lboxspnoibat.Items.Add("TOP 1: " + dt.Rows[0][0].ToString() + " - " + dt.Rows[0][1].ToString() + " - Số lượng bán ra:" + dt.Rows[0][2].ToString());
                lboxspnoibat.Items.Add("TOP 2: " + dt.Rows[1][0].ToString() + " - " + dt.Rows[1][1].ToString() + " - Số lượng bán ra:" + dt.Rows[1][2].ToString());
                lboxspnoibat.Items.Add("TOP 3: " + dt.Rows[2][0].ToString() + " - " + dt.Rows[2][1].ToString() + " - Số lượng bán ra:" + dt.Rows[2][2].ToString());
                lboxspnoibat.Items.Add("TOP 4: " + dt.Rows[3][0].ToString() + " - " + dt.Rows[3][1].ToString() + " - Số lượng bán ra:" + dt.Rows[3][2].ToString());
            }
            if (dt.Rows.Count == 3)
            {
                lboxspnoibat.Items.Add("TOP 1: " + dt.Rows[0][0].ToString() + " - " + dt.Rows[0][1].ToString() + " - Số lượng bán ra:" + dt.Rows[0][2].ToString());
                lboxspnoibat.Items.Add("TOP 2: " + dt.Rows[1][0].ToString() + " - " + dt.Rows[1][1].ToString() + " - Số lượng bán ra:" + dt.Rows[1][2].ToString());
                lboxspnoibat.Items.Add("TOP 3: " + dt.Rows[2][0].ToString() + " - " + dt.Rows[2][1].ToString() + " - Số lượng bán ra:" + dt.Rows[2][2].ToString());
            }
            if (dt.Rows.Count == 2)
            {
                lboxspnoibat.Items.Add("TOP 1: " + dt.Rows[0][0].ToString() + " - " + dt.Rows[0][1].ToString() + " - Số lượng bán ra:" + dt.Rows[0][2].ToString());
                lboxspnoibat.Items.Add("TOP 2: " + dt.Rows[1][0].ToString() + " - " + dt.Rows[1][1].ToString() + " - Số lượng bán ra:" + dt.Rows[1][2].ToString());
            }
            if (dt.Rows.Count == 1)
            {
                lboxspnoibat.Items.Add("TOP 1: " + dt.Rows[0][0].ToString() + " - " + dt.Rows[0][1].ToString() + " - Số lượng bán ra:" + dt.Rows[0][2].ToString());
            }
            if (dt.Rows.Count == 0)
            {
                lboxspnoibat.Visible = false;
            }
            grbSpnoibat.Controls.Add(lboxspnoibat);
            lboxspnoibat.Dock = DockStyle.Fill;
            lboxspnoibat.Font = new System.Drawing.Font(lboxspnoibat.Font,FontStyle.Underline);
            lboxspnoibat.ForeColor = Color.Blue;
            return lboxspnoibat;
        }
    }
}
