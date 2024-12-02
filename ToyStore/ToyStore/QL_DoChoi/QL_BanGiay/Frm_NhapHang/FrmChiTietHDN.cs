using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
namespace QL_BanGiay
{
    public partial class FrmChiTietHDN : Form
    {
        public FrmChiTietHDN()
        {
            InitializeComponent();
            DataTable dtDoChoi = data.ReadData("Select * from tDoChoi");
            data.FillComboBox(maDoChoi, dtDoChoi, "MaDoChoi", "MaDoChoi");
        }
        AccessData data= new AccessData();
        public void xem()
        {

            string sql = "  select tDoChoi.MaDoChoi,TenDoChoi,tDoChoi.MaChatLieu,TenChatLieu, KichThuoc, slNhap, DonGiaNhap,(slNhap*DonGiaNhap) as THanhTien  from tChiTietHDN" +
               " join tDoChoi on tDoChoi.MaDoChoi=tChiTietHDN.MaDoChoi join tChatLieu on tChatLieu.MaChatLieu=tDoChoi.MaChatLieu where tChiTietHDN.SoHDN=N'";
            sql += mahdn.Text + "'";
            ctDanhSachNhap.DataSource = data.ReadData(sql);
            tinhtong();
        }
        private void them_Click(object sender, EventArgs e)
        {
            them.Enabled = true;
            if (maDoChoi.Text == "" || tenDoChoi.Text == "" || slNhap.Text == "" || donGiaNhap.Text == "")
            {

                MessageBox.Show("khong duoc de trong");
                e.Equals(false);
                return;
            }
            string sql = " INSERT INTO tChiTietHDN(SoHDN,MaDoChoi,SLNhap) VALUES(" + "N'" + mahdn.Text + "','" + maDoChoi.Text + "','" + int.Parse(slNhap.Text) + "') ";           
            data.UpdateData(sql);
            string sql1 = "  select tDoChoi.MaDoChoi,TenDoChoi,tDoChoi.MaChatLieu,TenChatLieu, KichThuoc, slNhap, DonGiaNhap,(slNhap*DonGiaNhap) as ThanhTien  from tChiTietHDN" +
                " join tDoChoi on tDoChoi.MaDoChoi=tChiTietHDN.MaDoChoi join tChatLieu on tChatLieu.MaChatLieu=tDoChoi.MaChatLieu where tChiTietHDN.SoHDN=N'";
            sql1 += mahdn.Text + "'";
            sql += " Update tDoChoi Set";
            sql += " SoLuong='" + (sl() + int.Parse(slNhap.Text)) + "' ";
            sql += " where MaDoChoi ='" + maDoChoi.Text + "'";
            data.UpdateData(sql);
            ctDanhSachNhap.DataSource = data.ReadData(sql1);
            tinhtong();
            ResetValue();
         }

        public string x;

        private void chiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            them.Enabled=false;
            ResetValue();
            maDoChoi.Focus();
            xoa.Enabled = false;
            sua.Enabled = false;
            FrmHoaDonNhap hdn = new FrmHoaDonNhap();
            mahdn.Text = x;
            string sql = "  select tDoChoi.MaDoChoi,TenDoChoi,tDoChoi.MaChatLieu,TenChatLieu, KichThuoc, slNhap, DonGiaNhap,(slNhap*DonGiaNhap) as ThanhTien from tChiTietHDN" +
                " join tDoChoi on tDoChoi.MaDoChoi=tChiTietHDN.MaDoChoi join tChatLieu on tChatLieu.MaChatLieu=tDoChoi.MaChatLieu where tChiTietHDN.SoHDN=N'";
            sql += mahdn.Text + "'";
            tinhtong();
            ctDanhSachNhap.DataSource = data.ReadData(sql);
        }
        private void ResetValue()
        {
            maDoChoi.Text = "";
            tenDoChoi.Text = "";
            donGiaNhap.Text = "";
            maChatLieu.Text = "";
            tenChatLieu.Text = "";
            kichThuoc.Text = "";
            slNhap.Text = "";
           
        }
        string tinhtong()
        {
            string sql1 = "  select sum(SLNhap*DonGiaNhap) as ThanhTien,tChiTietHDN.SoHDN" +
                " from tChiTietHDN join tDoChoi on tChiTietHDN.MaDoChoi=tDoChoi.MaDoChoi  where SoHDN=N'" + mahdn.Text + "' group by tChiTietHDN.SoHDN";
            DataTable dtTong = data.ReadData(sql1);
            double tong = 0;

            if (dtTong.Rows.Count<1)
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
        private void slNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Trường này phải là số!");
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng form không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                if (ctDanhSachNhap.Rows.Count <=1 )
                {
                string sql = "Delete From tHoaDonNhap Where SoHDN =N'" + mahdn.Text + "'";
                data.UpdateData(sql);
                this.Close();
                }
                else
                {
                    this.Close();
                }               
            }

        }

        private void sua_Click(object sender, EventArgs e)
        {
            string sql = "Update tDoChoi Set";
            sql += " TenDoChoi=N'" + tenDoChoi.Text.Trim() + "',";
            sql += " SoLuong=N'" + slNhap.Text.Trim() + "',";
            sql += " DonGiaNhap=" + donGiaNhap.Text.Trim() + ",";
            sql += " where MaDoChoi=N'" + maDoChoi.Text.Trim() + "'";
            sql += " Update tChiTietHDN Set";
            sql += " SLNhap=N'" + slNhap.Text.Trim() + "',";
            sql += " MaDoChoi=N'" + maDoChoi.Text.Trim() + "',";
            sql += " where SoHDN=N'" + mahdn.Text.Trim() + "'";
            sql += "Update tChatLieu Set";
            sql += " TenChatLieu=N'" + slNhap.Text.Trim() + "',";
            sql += " where MaChatLieu=N'" + maChatLieu.Text.Trim() + "',";
            data.UpdateData(sql);
             sql += "  select tDoChoi.MaDoChoi,TenDoChoi,tDoChoi.MaChatLieu,TenChatLieu, KichThuoc, slNhap, DonGiaNhap,(slNhap*DonGiaNhap) as ThanhTien  from tChiTietHDN" +
                " join tDoChoi on tDoChoi.MaDoChoi=tChiTietHDN.MaDoChoi join tChatLieu on tChatLieu.MaChatLieu=tDoChoi.MaChatLieu where tChiTietHDN.SoHDN=N'";
            sql += mahdn.Text + "'";
            ctDanhSachNhap.DataSource = data.ReadData(sql);
            tinhtong();
            ResetValue();
        }
        public int sl()
        {
            string sql = "select SoLuong  from tDoChoi where tDoChoi.MaDoChoi=N'" + maDoChoi.Text + "'";
            DataTable dt = data.ReadData(sql);
            return int.Parse(dt.Rows[0]["SoLuong"].ToString());
        }
        private void xoa_Click(object sender, EventArgs e)
        {
            string sql;
           
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm khỏi hóa đơn không " + tenDoChoi.Text + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sql = " delete tChiTietHDN where MaDoChoi=N'" + maDoChoi.Text + "' and SoHDN=N'"+mahdn.Text+"'";
                sql += " Update tDoChoi Set";
                sql += " SoLuong='" + (sl() - int.Parse(slNhap.Text)) + "' ";
                sql += " where MaDoChoi='" + maDoChoi.Text + "'";
                data.UpdateData(sql);
                sql += "  select tDoChoi.MaDoChoi,TenDoChoi,tDoChoi.MaChatLieu,TenChatLieu, KichThuoc, slNhap, DonGiaNhap, DonGiaBan  from tChiTietHDN" +
                 " join tDoChoi on tDoChoi.MaDoChoi=tChiTietHDN.MaDoChoi join tChatLieu on tChatLieu.MaChatLieu=tDoChoi.MaChatLieu where tChiTietHDN.SoHDN=N'";
                sql += mahdn.Text + "'";
                ctDanhSachNhap.DataSource = data.ReadData(sql);
                tinhtong();
                ResetValue();
            }
        }

        private void ctDanhSachNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            them.Enabled= false;
            xoa.Enabled = true;
            sua.Enabled = true;
            maDoChoi.Text = ctDanhSachNhap.CurrentRow.Cells[0].Value.ToString();
            tenDoChoi.Text = ctDanhSachNhap.CurrentRow.Cells[1].Value.ToString();
            maChatLieu.Text=ctDanhSachNhap.CurrentRow.Cells[2].Value.ToString();
            tenChatLieu.Text = ctDanhSachNhap.CurrentRow.Cells[3].Value.ToString();
            kichThuoc.Text = ctDanhSachNhap.CurrentRow.Cells[4].Value.ToString();
            slNhap.Text = ctDanhSachNhap.CurrentRow.Cells[5].Value.ToString();
            donGiaNhap.Text = ctDanhSachNhap.CurrentRow.Cells[6].Value.ToString();  
           
        }

        private void inHoaDon_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range shopName = (Excel.Range)exSheet.Cells[1, 1];
            shopName.Font.Size = 20;
            shopName.Font.Bold = true;
            shopName.Value = "CỬA HÀNG ĐỒ CHƠI";
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
            exSheet.get_Range("B6").Value = mahdn.Text;
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
            exSheet.get_Range("B9").Value = "Mã đồ chơi";
            exSheet.get_Range("C9").Value = "Mã chất liệu";
            exSheet.get_Range("D9").Value = "Tên đồ chơi";
            exSheet.get_Range("E9").Value = "Tên chất liệu";
            exSheet.get_Range("F9").Value = "Kích thước";
            exSheet.get_Range("G9").Value = "Số lượng nhập";
            exSheet.get_Range("H9").Value = "Đơn giá";
            exSheet.get_Range("I9").Value = "Thành tiền";
            string sql = "  select tDoChoi.MaDoChoi,TenDoChoi,tDoChoi.MaChatLieu,TenChatLieu, KichThuoc, slNhap, DonGiaNhap,(slNhap*DonGiaNhap) as ThanhTien  from tChiTietHDN" +
               " join tDoChoi on tDoChoi.MaDoChoi=tChiTietHDN.MaDoChoi join tChatLieu on tChatLieu.MaChatLieu=tDoChoi.MaChatLieu where tChiTietHDN.SoHDN=N'";
            sql += mahdn.Text + "'";
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
                exSheet.get_Range("G" + (i + 11).ToString()).Value = dataEx.Rows[i][6].ToString();
                exSheet.get_Range("H" + (i + 11).ToString()).Value = dataEx.Rows[i][7].ToString();
               
                total += Convert.ToDouble(dataEx.Rows[i][7].ToString());
            }
            exSheet.get_Range("G" + (i + 13)).Value = "Tổng tiền";
            exSheet.get_Range("H" + (i + 13)).Value = total;
            exSheet.Name = "Chi tiết hóa đơn nhập" + mahdn.Text;
            exBook.Activate();
            SaveFileDialog dlgSave = new SaveFileDialog();
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
        private void maGiay_SelectedIndexChanged(object sender, EventArgs e)
        {           
            try
            {
                DataTable dt = data.ReadData("Select * from tDoChoi where MaDoChoi='" + maDoChoi.SelectedValue + "'");
                tenDoChoi.Text = dt.Rows[0]["TenDoChoi"].ToString();
                maChatLieu.Text = dt.Rows[0]["MaChatLieu"].ToString();
                kichThuoc.Text = dt.Rows[0]["KichThuoc"].ToString();
                donGiaNhap.Text = dt.Rows[0]["DonGiaNhap"].ToString();
                dt = data.ReadData("Select * from tChatLieu where MaChatLieu='" + maChatLieu.Text + "'");
                tenChatLieu.Text = dt.Rows[0]["TenChatLieu"].ToString();
            }
            catch
            {}
        }
        private void slNhap_TextChanged(object sender, EventArgs e)
        {
            them.Enabled = true;
        }

        private void luu_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

    }
}
