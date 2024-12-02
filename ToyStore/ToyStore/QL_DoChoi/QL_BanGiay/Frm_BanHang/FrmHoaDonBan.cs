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
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;


namespace QL_BanGiay
{
    public partial class FrmHoaDonBan : Form
    {
        AccessData data = new AccessData();
        public FrmHoaDonBan()
        {
            InitializeComponent();

            //Fill data in comboBoxes
            DataTable dtNhanVien = data.ReadData("Select * from tNhanVien");
            DataTable dtKH = data.ReadData("Select * from tKhachHang");
            DataTable dtDoChoi = data.ReadData("Select * from tDoChoi");
            DataTable dtHDBan = data.ReadData("Select * from tHoaDonBan");
            data.FillComboBox(cbomaNV, dtNhanVien, "MaNV", "MaNV");
            data.FillComboBox(cboMaKH, dtKH, "MaKH", "MaKH");
            data.FillComboBox(cboMaHD, dtHDBan, "SoHDB", "SoHDB");
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }           
            
        }
        void loaddulieu()
        {
            string sql = "select SoHDB,NgayBan,tNhanVien.MaNV,TenNV,tKhachHang.MaKH,TenKH,tKhachHang.DienThoai,tKhachHang.DiaChi"
            +" from tHoaDonBan join tNhanVien on tNhanVien.MaNV = tHoaDonBan.MaNV join tKhachHang on tKhachHang.MaKH = tHoaDonBan.MaKH ";   
            danhSachBan.DataSource = data.ReadData(sql);
        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            ResetValue();
           
            string str = DateTime.Now.ToString("ss-mm-HH").Trim();
            string giay = str.Substring(0, 2);
            string phut = str.Substring(3, 2);
            themChiTiet.Enabled = true;
            txtMaHD.Text = data.AutoCode("tHoaDonBan", "SoHDB", "HDB" + giay + phut);
            //DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString());
            dateNgayBan.Value = DateTime.Now;
        }
        void ResetValue()
        {
            txtMaHD.Text = "";
            dateNgayBan.Text = "";           
            cbomaNV.Text = "";
            cboMaKH.Text = "";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            //datetimeTim.Text="";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //string sql = "select sum(SLNhap -SLBan) as slcon\r\nfrom  tChiTietHDB \r\njoin tGiay on tChiTietHDB.MaGiay=tGiay.MaGiay join tChiTietHDN on tChiTietHDN.MaGiay=tGiay.MaGiay\r\nwhere tGiay.MaGiay=N'" + cboMaGiay.SelectedValue + "'";
            //DataTable soluongCon = data.ReadData(sql);
            //int slCon = int.Parse(soluongCon.Rows[0]["slcon"].ToString());
            //if (int.Parse(txtSoLuong.Text) < slCon)
            //{               
            //    DialogResult dg = MessageBox.Show("Số lượng giày trong kho đã hết ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               
            //        txtSoLuong.Text = "";
               
            //}
            //string sqlinsertHDBan;
            //float slmua, slcon, tongtien;
            //DateTime dtNgayBan;
            ////Kiểm tra tính đầy đủ của dữ liệu
            //if (cbomaNV.Text.Trim() == "")
            //{
            //    MessageBox.Show("Chưa có thông tin nhân viên bán");
            //    return;
            //}
            //if (cboMaKH.Text.Trim() == "")
            //{
            //    MessageBox.Show("Chưa có thông tin khách hàng");
            //    return;

            //}
            //if (cboMaGiay.Text.Trim() == "")
            //{
            //    MessageBox.Show("Chưa có thông sản phẩm");
            //    return;
            //}
            //if (txtSoLuong.Text.Trim() == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập số lượng sản phẩm");
            //    txtSoLuong.Focus();
            //    return;
            //}
            ////Khi lưu hóa đơn xảy ra hai trường hợp. TH1: tHoaDonBan đã có hóa đơn với mã vừa sinh --> update lại tổng tiền
            ////TH2: chưa có hóa đơn: insert hóa đơn
            //dtNgayBan = Convert.ToDateTime(dateNgayBan.Value.ToLongDateString());
            //DataTable dtHDBan = data.ReadData("Select * from tHoaDonBan where SoHDB='" + txtMaHD.Text + "'");
            //if (dtHDBan.Rows.Count == 0)//chưa tồn tài hóa đơn
            //{
            //    sqlinsertHDBan = "insert into tHoaDonBan values('" + txtMaHD.Text + "','" + cbomaNV.SelectedValue +
            //        "','" + String.Format("{0:MM/dd/yyyy}", dtNgayBan) + "','" + cboMaKH.SelectedValue +
            //        "','" + txtThanhTien.Text + "')";
            //    data.UpdateData(sqlinsertHDBan);
            //}
            ////tblHD đã tồn tại
            ////1. Kiểm tra số lượng hàng còn không
            //DataTable dtHang = data.ReadData("Select * from tGiay where MaGiay='" + cboMaGiay.SelectedValue + "'");
            //slcon = float.Parse(danhSachBan.Rows[0].Cells["SoLuong"].ToString());
            //slmua = float.Parse(txtSoLuong.Text);
            //if (slcon < slmua)
            //{
            //    MessageBox.Show("Không còn đủ số lượng. Sản phẩm " + txtTenGiay.Text + " chỉ còn " + slcon);
            //    txtSoLuong.Focus();
            //    return;
            //}
            //slcon = slcon - slmua;
            ////insert vào bảng tblChiTiet
            //data.UpdateData("insert into tChiTietHDB values('" + txtMaHD.Text + "','" + cboMaGiay.SelectedValue +
            //    "'," + (int)slmua + ",'" + txtGiamGia.Text + "','" + txtThanhTien.Text + "')");
            ////update lại bảng tGiay
            //data.UpdateData("update tGiay set SoLuong=" + (int)slcon + " where MaGiay='" + cboMaGiay.SelectedValue + "'");
            ////update tblcHDBan cho tong tien
            //DataTable dtChiTiet = data.ReadData("Select tChiTietHDB.SoHDB," +
            //   "TenGiay,tChiTietHDB.SoLuong,DonGiaBan,GiamGia,ThanhTien from tChiTietHDB inner " +
            //   "join tGiay on tChiTietHDB.SoHDB=tGiay.MaGiay where SoHDB='" + txtMaHD.Text + "'");
            //tongtien = 0;
            //for (int i = 0; i < dtC   +hiTiet.Rows.Count; i++)
            //{
            //    tongtien = tongtien + float.Parse(dtChiTiet.Rows[i]["ThanhTien"].ToString());
            //}
            //data.UpdateData("update tHoaDonBan set TongTien='" + tongtien.ToString() + "' where SoHDB='" + txtMaHD.Text + "'");
            ////Hiển thị dữ liệu lên dataGridView
            //danhSachBan.DataSource = dtChiTiet;
            //tongTien.Text = "Tổng tiền:" + tongtien.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void danhSachBan_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn trả lại sản phẩm này không?", "Messager",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//Hủy SP
            //{
            //    //1. Update lại số lượng hàng trong bảng tGiay
            //    float slcon, slmua;
            //    DataTable dtHang = data.ReadData("Select * from tGiay where MaGiay='" +
            //        danhSachBan.CurrentRow.Cells[0].Value.ToString() + "'");
            //    slcon = float.Parse(danhSachBan.Rows[0].Cells["SoLuong"].ToString());
            //    slmua = float.Parse(danhSachBan.CurrentRow.Cells[2].Value.ToString());
            //    slcon = slcon + slmua;
            //    data.UpdateData("update tGiay set SoLuong=" + (int)slcon + " where MaGiay='" +
            //        danhSachBan.CurrentRow.Cells[0].Value.ToString() + "'");

            //    //2.Xóa ChiTiet ra khỏi dataBase
            //    data.UpdateData("delete tChiTietHDB where SoHDB='" + txtMaHD.Text + "' and MaGiay='" +
            //        danhSachBan.CurrentRow.Cells[0].Value.ToString() + "'");
            //    //3. Tính lại tổng tiền hóa đơn
            //    //update tblcHDBan cho tong tien
            //    DataTable dtChiTiet = data.ReadData("Select tChiTietHDB.SoHDB," +
            //       "TenHang,tChiTietHDB.SoLuong,DonGiaBan,GiamGia,ThanhTien from tChiTietHDB inner " +
            //       "join tGiay on tChiTietHDB.SoHDB=tGiay.MaGiay where SoHDB='" + txtMaHD.Text + "'");
            //    if (dtChiTiet.Rows.Count == 0) //Khi da xoa het cac chi tiet hoa don thi xoa luon hoa don
            //    {
            //        data.UpdateData("delete tHoaDonBan where SoHDB='" + txtMaHD.Text + "'");
            //        return;
            //    }
            //    float tongtien = 0;
            //    for (int i = 0; i < dtChiTiet.Rows.Count; i++)
            //    {
            //        tongtien = tongtien + float.Parse(dtChiTiet.Rows[i]["ThanhTien"].ToString());
            //    }
            //    data.UpdateData("update tHoaDonBan set TongTien='" + tongtien.ToString() + "' where SoHDB='" +
            //        txtMaHD.Text + "'");
            //    //Hiển thị dữ liệu lên dataGridView
            //    danhSachBan.DataSource = dtChiTiet;
            //    //tongTien.Text = "Tổng tiền:" + tongtien.ToString();
            //}
        }

        private void timKiem_Click(object sender, EventArgs e)
        {
            DataTable dtHDBan = data.ReadData("Select * from tHoaDonBan where SoHDB='" + cboMaHD.Text + "'");
            txtMaHD.Text = cboMaHD.Text;
            //dateNgayBan.Text = dtHDBan.Rows[0]["NgayBan"].ToString();
            //cbomaNV.SelectedValue = dtHDBan.Rows[0]["MaNV"];
            //cboMaKH.SelectedValue = dtHDBan.Rows[0]["MaKH"];
            danhSachBan.DataSource = dtHDBan;
            //if (datetimeTim.Text != ""&& cboMaHD.Text=="")
            //{
            //    string sql = "Select * from tHoaDonBan where NgayBan='" + datetimeTim.Text + "'";
            //    danhSachBan.DataSource = data.ReadData(sql);
            //}
        }

        void xuatexcel()
        {
            if (danhSachBan.Rows.Count > 0) //TH có dữ liệu để ghi
            {
                //Khai báo và khởi tạo các đối tượng
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook =
               exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                //Định dạng chung
                Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
                tenCuaHang.Font.Size = 12;
                tenCuaHang.Font.Bold = true;
                tenCuaHang.Font.Color = Color.Blue;
                tenCuaHang.Value = "CỬA HÀNG BÁN ĐỒ CHƠI";
                Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[2, 1];
                dcCuaHang.Font.Size = 12;
                dcCuaHang.Font.Bold = true;
                dcCuaHang.Font.Color = Color.Blue;
                dcCuaHang.Value = "Địa chỉ: 3 - Cầu Giấy - Hà Nội";
                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                dtCuaHang.Font.Size = 12;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Blue;
                dtCuaHang.Value = "Điện thoại: 0976967619";
                Excel.Range header = (Excel.Range)exSheet.Cells[5, 2];
                exSheet.get_Range("B5:G5").Merge(true);
                header.Font.Size = 13;
                header.Font.Bold = true;
                header.Font.Color = Color.Red;
                header.Value = "DANH SÁCH CÁC Hóa Đơn";
                //Định dạng tiêu đề bảng

                exSheet.get_Range("A7:G7").Font.Bold = true;
                exSheet.get_Range("A7:G7").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A7").Value = "Số hóa đơn bán";
                exSheet.get_Range("B7").Value = "Mã đồ chơi";
                exSheet.get_Range("C7").Value = "Tên đồ chơi";
                exSheet.get_Range("C7").ColumnWidth = 20;
                exSheet.get_Range("D7").Value = "Số lượng";
                exSheet.get_Range("E7").Value = "Đơn giá";
                exSheet.get_Range("F7").Value = "Thành Tiền";
               // exSheet.get_Range("G7").Value = "Tổng tiền:"+tongTien();

                //In dữ liệu
                for (int i = 0; i < danhSachBan.Rows.Count; i++)
                    {
                    exSheet.get_Range("A" + (i + 8).ToString() + ":G" + (i + 8).ToString())
                   .Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("B" + (i + 8).ToString()).Value = danhSachBan.CurrentRow.Cells[0].ToString();
                    exSheet.get_Range("C" + (i + 8).ToString()).Value = danhSachBan.Rows[i].ToString();
                    exSheet.get_Range("D" + (i + 8).ToString()).Value = danhSachBan.Rows[i].Cells["MaDoChoi"].ToString();
                    exSheet.get_Range("E" + (i + 8).ToString()).Value = danhSachBan.Rows[i].Cells["TenDoChoi"].ToString();
                    exSheet.get_Range("F" + (i + 8).ToString()).Value = danhSachBan.Rows[i].Cells["SLBan"].ToString();               
                    exSheet.get_Range("G" + (i + 8).ToString()).Value = danhSachBan.Rows[i].Cells["DonGiaBan"].ToString();
                    exSheet.get_Range("H" + (i + 8).ToString()).Value = danhSachBan.Rows[i].Cells["ThanhTien"].ToString();
                    }
               // exSheet.get_Range("I" + (danhSachBan.Rows.Count+1 + 8).ToString()) = tongTien.Text;
                exSheet.Name = "Hang";
                exBook.Activate(); //Kích hoạt file Excel
                                   //Thiết lập các thuộc tính của
                SaveFileDialog ex = new SaveFileDialog();
                ex.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc) | *.doc | All files(*.*) | *.* ";
                ex.FilterIndex = 1;
                ex.AddExtension = true;
                ex.DefaultExt = ".xls";
                if (ex.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(ex.FileName.ToString());//Lưu file Excel
                exApp.Quit();//Thoát khỏi ứng dụng
            }
            else
                MessageBox.Show("Không có danh sách hàng để in");

        }           
        private void sua_Click(object sender, EventArgs e)
        {
            string sql = "Update tHoaDonBan Set";
            sql += " NgayBan=N'" + dateNgayBan.Text.Trim() + "',";
            sql += "MaNV=N'" + cbomaNV.Text.Trim() + "',";
            sql += "MaKH=N'" + cboMaKH.Text.Trim() + "'";           
            sql += " where SoHDB=N'" + txtMaHD.Text.Trim() + "'";
            data.UpdateData(sql);
            sql += " Select tChiTietHDB.MaDoChoi,TenDoChoi,SLBan,DonGiaBan,KhuyenMai from tChiTietHDB join tDoChoi on tChiTietHDB.MaDoChoi = tDoChoi.MaDoChoi ";
            danhSachBan.DataSource = data.ReadData(sql);
        }

        private void danhSachBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sua.Enabled = true;
            them.Enabled = true;
            txtMaHD.Text = danhSachBan.CurrentRow.Cells[0].Value.ToString();
            dateNgayBan.Text = danhSachBan.CurrentRow.Cells[1].Value.ToString();
            cbomaNV.Text = danhSachBan.CurrentRow.Cells[2].Value.ToString();
            txtTenNV.Text = danhSachBan.CurrentRow.Cells[3].Value.ToString();
            cboMaKH.Text = danhSachBan.CurrentRow.Cells[4].Value.ToString();
            txtTenKhach.Text = danhSachBan.CurrentRow.Cells[5].Value.ToString();
            txtDiaChi.Text = danhSachBan.CurrentRow.Cells[6].Value.ToString();
            txtDienThoai.Text = danhSachBan.CurrentRow.Cells[7].Value.ToString();
        }
        private void hoaDonBan_Load(object sender, EventArgs e)
        {
            //cboMaHD.AddItem "phan tu 1";
            danhSachBan.Width = groupBox2.Width;
            sua.Enabled = false;
            themChiTiet.Enabled = false;
            cboMaHD.SelectedIndex = -1;
            cbomaNV.SelectedIndex = -1;
            cboMaKH.SelectedIndex= -1;
            loaddulieu();
        }


        private void cbomaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNV = data.ReadData("Select TenNV from tNhanVien where MaNV=N'" + cbomaNV.SelectedValue + "'");
                txtTenNV.Text = dtNV.Rows[0]["TenNV"].ToString();
            }
            catch
            {

            }
        }

        

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtKH = data.ReadData("Select * from tKhachHang where MaKH='" + cboMaKH.SelectedValue + "'");
                txtTenKhach.Text = dtKH.Rows[0]["TenKH"].ToString();
                txtDiaChi.Text = dtKH.Rows[0]["DiaChi"].ToString();
                txtDienThoai.Text = dtKH.Rows[0]["DienThoai"].ToString();

            }
            catch { }

        }

      

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng form không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                    this.Close();            
            }
        }
        private string get_mhdb;
        public string Message
        {
            get { return get_mhdb; }
            set { get_mhdb = value; }
        }
        private void themChiTiet_Click(object sender, EventArgs e)
        {
            Message = txtMaHD.Text.Trim();
            FrmChitietHDB ctb = new FrmChitietHDB();
            ctb.x = Message;
            ctb.xem();
            ctb.Show();
            string sql = "INSERT INTO tHoaDonBan(SoHDB,MaNV,NgayBan,MaKH) VALUES(";
            sql += "N'" + txtMaHD.Text + "',N'" + cbomaNV.Text + "',"+ dateNgayBan.Text.Trim() + ",'" + cboMaKH.Text + "')";
            data.UpdateData(sql);
        }

        private void danhSachBan_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Message = danhSachBan.CurrentRow.Cells[0].Value.ToString();
            FrmChitietHDB ctb = new FrmChitietHDB();
            ctb.x = Message;
            ctb.xem();
            ctb.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValue();
            loaddulieu();
        }

        private void cboMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
