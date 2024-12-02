
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using iTextSharp.text.pdf;
//using iTextSharp.text;
using System.IO;
//using Org.BouncyCastle.Utilities.Collections;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace QL_BanGiay
{
    public partial class FrmChitietHDB : Form
    {
        AccessData data = new AccessData();
        public FrmChitietHDB()
        {
            InitializeComponent();
            DataTable dtDoChoi = data.ReadData("Select * from tDoChoi");
            data.FillComboBox(cboMaDoChoi, dtDoChoi, "MaDoChoi", "MaDoChoi");
        }
        
        public void xem()
        {
            huy.Enabled = false;
            tinhTong();
            select();
        }
       
        private void inHoaDon_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

            Excel.Range shopName = (Excel.Range)exSheet.Cells[1, 1];
            shopName.Font.Size = 20;
            shopName.Font.Bold = true;
            shopName.Value = "CỬA HÀNG ĐỒ CHƠI BING CHILLING";

            Excel.Range shopAddress = (Excel.Range)exSheet.Cells[2, 1];
            shopAddress.Font.Size = 14;
            shopAddress.Font.Bold = true;
            shopAddress.Value = "31 P. Quan Hoa, Quan Hoa, Cầu Giấy, Hà Nội, Việt Nam";

            Excel.Range header = (Excel.Range)exSheet.Cells[4, 2];
            exSheet.get_Range("D4:F4").Merge(true);
            header.Font.Size = 14;
            header.Font.Bold = true;
            header.Value = "CHI TIẾT HÓA ĐƠN NHẬP";

            exSheet.get_Range("A6").Value = "Số hóa đơn";
            exSheet.get_Range("B6").Value = "";
            exSheet.get_Range("A7").Value = "Người tạo";
            exSheet.get_Range("B7").Value = "";
            exSheet.get_Range("G6").Value = "Mã nhà cung cấp";
            exSheet.get_Range("H6").Value = "";
            exSheet.get_Range("G7").Value = "Nhà cung cấp";
            exSheet.get_Range("H7").Value = "";

            exSheet.get_Range("A9:H9").Font.Bold = true;
            exSheet.get_Range("A9:H9").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.get_Range("A9:H9").ColumnWidth = 15;
            exSheet.get_Range("C9").ColumnWidth = 25;
            exSheet.get_Range("A9").Value = "Mã chi tiết";
            exSheet.get_Range("B9").Value = "Mã sản phẩm";
            exSheet.get_Range("C9").Value = "Tên sản phẩm";
            exSheet.get_Range("D9").Value = "Số lượng bán";
            exSheet.get_Range("E9").Value = "Đơn giá";
            exSheet.get_Range("F9").Value = "Khuyến mại";
            exSheet.get_Range("G9").Value = "Thành tiền";
            
            string sql = "select tDoChoi.MaDoChoi,TenDoChoi,SLBan,DonGiaBan,KhuyenMai,(SLBan*(DonGiaBan*(1-KhuyenMai/100))) as ThanhTien \r\n from tChiTietHDB\r\n join tDoChoi on tChiTietHDB.MaDoChoi=tDoChoi.MaDoChoi";
            sql += "where SoHDB=N'" + maHDB.Text + "'";
            DataTable dataEx = data.ReadData(sql);
            int i = 0;
            double total = 0;
            for (i = 0; i < dataEx.Rows.Count; i++)
            {
                exSheet.get_Range("A" + (i + 11).ToString() + ":H" + (i + 11).ToString()).Font.Bold = false;
                exSheet.get_Range("A" + (i + 11).ToString()).Value = dataEx.Rows[i][0].ToString();
                exSheet.get_Range("B" + (i + 11).ToString()).Value = dataEx.Rows[i][1].ToString();
                exSheet.get_Range("C" + (i + 11).ToString()).Value = dataEx.Rows[i][2].ToString();
                exSheet.get_Range("D" + (i + 11).ToString()).Value = dataEx.Rows[i][3].ToString();
                exSheet.get_Range("E" + (i + 11).ToString()).Value = dataEx.Rows[i][4].ToString();
                exSheet.get_Range("F" + (i + 11).ToString()).Value = dataEx.Rows[i][5].ToString();
                               
                total += Convert.ToDouble(dataEx.Rows[i][5].ToString());
            }
            exSheet.get_Range("G" + (i + 13)).Value = "Tổng tiền";
            exSheet.get_Range("H" + (i + 13)).Value = total;
            exSheet.Name = "Chi tiết hóa đơn " + maHDB.Text;
            exBook.Activate();
            SaveFileDialog dlgSave=new SaveFileDialog();
            dlgSave.Filter = "Excel Document(*.xlsx)|*.xlsx |All files(*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.AddExtension = true;
            dlgSave.DefaultExt = ".xlsx";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(dlgSave.FileName.ToString());
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            exApp.Quit();          
        }            
        public string x;
         string tinhTong()
        {
            string sql1 = "  select sum(SLBan*DonGiaBan) as ThanhTien,tChiTietHDB.SoHDB" +
               " from tChiTietHDB join tDoChoi on tChiTietHDB.MaDoChoi=tDoChoi.MaDoChoi  where SoHDB=N'" + maHDB.Text + "' group by tChiTietHDB.SoHDB";
            DataTable dtTong = data.ReadData(sql1);
            double tong = 0;
            if (dtTong.Rows.Count < 1)
            {
                tong = 0;
                tongTien.Text = tong.ToString();
                return tongTien.Text;
            }
            else
            {
                tong += double.Parse(dtTong.Rows[0][0].ToString());
                tongTien.Text = tong.ToString();
                return tongTien.Text;
            }         
        }
        private void chiTietHDB_Load(object sender, EventArgs e)
        {
            xoa.Enabled = false;
            them.Enabled = false;
            sua.Enabled = false;           
            FrmHoaDonBan hdb = new FrmHoaDonBan();
            maHDB.Text = x;                       
            //Tính tổng tiền
            tinhTong();
            select();
        }

        private void cboMaGiay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtG = data.ReadData("Select * from tDoChoi where MaDoChoi='" + cboMaDoChoi.SelectedValue + "'");
                txtTenDoChoi.Text = dtG.Rows[0]["TenDoChoi"].ToString();
                txtDonGia.Text = dtG.Rows[0]["DonGiaBan"].ToString();
            }
            catch
            {

            }
        }
        void resetvalue()
        {
            cboMaDoChoi.Text = "";
            txtTenDoChoi.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "";
            txtThanhTien.Text = "";
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            them.Enabled = true;
            if (txtSoLuong.Text == "" || txtGiamGia.Text == "")
            {
            }
            else
            {
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * double.Parse(txtDonGia.Text) * (1 - double.Parse(txtGiamGia.Text) / 100)).ToString();
            }
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "" || txtGiamGia.Text == "")
            { }
            else
            {
                txtThanhTien.Text = (int.Parse(txtSoLuong.Text) * (double.Parse(txtDonGia.Text)*(1 - double.Parse(txtGiamGia.Text) / 100))).ToString();
            }
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Trường này phải là số!");
            }
        }
        private void select()
        {
            string sql = "select tDoChoi.MaDoChoi,TenDoChoi,SLBan,DonGiaBan,KhuyenMai,(SLBan*(DonGiaBan-DonGiaBan*(KhuyenMai/100))) as ThanhTien \r\n from tChiTietHDB\r\n join tDoChoi on tChiTietHDB.MaDoChoi=tDoChoi.MaDoChoi ";
            sql += "where SoHDB=N'" + maHDB.Text + "'";
            danhSachBan.DataSource = data.ReadData(sql);
        }
        public int slban() {
            string sql = "select sum(SLBan) as SLBan from tChiTietHDB where tChiTietHDB.MaDoChoi=N'" + cboMaDoChoi.Text + "'\r\ngroup by tChiTietHDB.MaDoChoi";
            DataTable dt = data.ReadData(sql);
            return int.Parse(dt.Rows[0]["SLBan"].ToString());
        }
        public int sl()
        {
            string sql = "select SoLuong  from tDoChoi where tDoChoi.MaDoChoi=N'" + cboMaDoChoi.Text + "'";
            DataTable dt = data.ReadData(sql);
            return int.Parse(dt.Rows[0]["SoLuong"].ToString());
        }
        private void them_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtSoLuong.Text) - (sl()) > 0)
            {
                MessageBox.Show("Số lượng bạn muốn mua không đủ");
                return;
            }
           
            string sql = " INSERT INTO tChiTietHDB(SoHDB,MaDoChoi,SLBan,KhuyenMai) VALUES(" + "N'" + maHDB.Text + "','" + cboMaDoChoi.Text + "','" + int.Parse(txtSoLuong.Text) + "','" + double.Parse(txtGiamGia.Text) + "') ";
            sql += " Update tDoChoi Set";
            sql += " SoLuong='" + (sl() - int.Parse(txtSoLuong.Text)) + "' ";
            sql += " where MaDoChoi='" + cboMaDoChoi.Text + "'";
            data.UpdateData(sql);
            select();
            tinhTong();
            resetvalue();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng form không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                if (danhSachBan.Rows.Count <=1)
                {
                    string sql = "Delete From tHoaDonBan Where SoHDB =N'" + maHDB.Text + "'";
                    data.UpdateData(sql);
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void huy_Click(object sender, EventArgs e)
        {
            resetvalue();
        }

        private void danhSachBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            xoa.Enabled = true;
            sua.Enabled = true;
            cboMaDoChoi.Text = danhSachBan.CurrentRow.Cells[0].Value.ToString();
            txtTenDoChoi.Text = danhSachBan.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = danhSachBan.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = danhSachBan.CurrentRow.Cells[3].Value.ToString();
            txtThanhTien.Text = danhSachBan.CurrentRow.Cells[5].Value.ToString();
            txtGiamGia.Text = danhSachBan.CurrentRow.Cells[4].Value.ToString();
        }
        private void sua_Click(object sender, EventArgs e)
        {
            string sql = " Update tChiTietHDB Set";
            sql += " SLBan=N'" + txtSoLuong.Text.Trim() + "',";           
            sql += " KhuyenMai='" + double.Parse(txtGiamGia.Text.Trim()) + "'";
            sql += " where SoHDB=N'" + maHDB.Text.Trim() + "' and MaDoChoi='"+cboMaDoChoi.Text+"'";
            data.UpdateData(sql);
            tinhTong();
            select();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string sql;           
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm " + txtTenDoChoi.Text + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sql = "delete tChiTietHDB where MaDoChoi=N'" + cboMaDoChoi.Text + "' and SoHDB=N'"+maHDB.Text+"'";
                data.UpdateData(sql);
            }
            tinhTong();
            select();
        }
    }
}
