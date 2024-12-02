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

namespace QL_BanGiay
{
    public partial class FrmKhachHang : Form
    {
        AccessData database = new AccessData();
        public FrmKhachHang()
        {
            InitializeComponent();
        }
        // phương thức ẩn grbkhachhang
        private void hienthiChitiet(bool hien)
        {
            foreach (Control ctl in grbkhachhang.Controls)
            {
                ctl.Enabled = hien;
            }
        }
        // sự kiện loadform
        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            cbgioitinh.Items.Add("Nam");
            cbgioitinh.Items.Add("Nữ");
            dgvkhachhang.DataSource = database.ReadData("select * from tKhachHang");
            // ẩn grbkhachhang
            hienthiChitiet(false);
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
        }
        // chức năng tìm kiếm
        private void btntim_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            hienthiChitiet(false);
            string sql = "select* from tKhachHang where MaKH is not null";
            // tìm theo mã khách hàng khác rỗng
            if (txtmkh.Text.Trim() != "")
            {
                sql += " and MaKH like '%" + txtmkh.Text + "%'";
            }
            dgvkhachhang.DataSource = database.ReadData(sql);
        }
        // khi người dùng click vào datagridview thì hiển thị nút sửa,xóa ẩn nút thêm
        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // hiển thị nút sửa,xóa
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;
            try
            {
                txtmkh.Text = dgvkhachhang.CurrentRow.Cells[0].Value.ToString();
                txttkh.Text = dgvkhachhang.CurrentRow.Cells[1].Value.ToString();
                cbgioitinh.Text = dgvkhachhang.CurrentRow.Cells[4].Value.ToString();
                txtdiachi.Text = dgvkhachhang.CurrentRow.Cells[2].Value.ToString();
                txtsdt.Text = dgvkhachhang.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Nhân viên
        }
        // phương thức xóa trắng grbkhachhang
        private void xoaTrangChiTiet()
        {
            foreach (Control txt in grbkhachhang.Controls)
            {
                if (txt is TextBox)
                    txt.Text = "";
            }
        }
        // chức năng thêm 
        private void btnthem_Click(object sender, EventArgs e)
        {
            xoaTrangChiTiet();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            hienthiChitiet(true);
            txtmkh.Text = "";
            txttkh.Text = "";
            cbgioitinh.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            hienthiChitiet(true);
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Bạn có muốn xóa khách hàng có mã " + txtmkh.Text + " không?Nếu có ấn nút lưu, không thì ấn hủy", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                btnthem.Enabled = false;
                btnsua.Enabled = false;
                hienthiChitiet(true);
            }
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql = "";
            // sử dụng control errorProvider để hiển thị lỗi
            // kiểm tra xem tên khách hàng có rỗng không
            if (txttkh.Text.Trim() == "")
            {
                errorkhachhang.SetError(txttkh, "Bạn không để trống tên khách hàng!");
                return;
            }
            else
                errorkhachhang.Clear();
            //Kiểm tra giới tính xem có để trống không
            if (cbgioitinh.Text.Trim() == "")
            {
                errorkhachhang.SetError(cbgioitinh, "Bạn không để trống giới tính!");
                return;
            }
            else
                errorkhachhang.Clear();
            //Kiểm tra địa chỉ xem có để trống không
            if (txtdiachi.Text.Trim() == "")
            {
                errorkhachhang.SetError(txtdiachi, "Bạn không để trống địa chỉ!");
                return;
            }
            else
                errorkhachhang.Clear();
            //Kiểm tra điện thoại có rỗng không
            if (txtsdt.Text.Trim() == "")
            {
                errorkhachhang.SetError(txtsdt, "Bạn không để trống điện thoại!");
                return;
            }
            else
                errorkhachhang.Clear();
            // nút thêm enable thì thực hiện thêm mới khách hàng
            if (btnthem.Enabled == true)
            {
                //kiemTraThongTin();
                // kiểm tra xem mã khách hàng có trống không
                if (txtmkh.Text.Trim() == "")
                {
                    errorkhachhang.SetError(txtmkh, "Bạn không để trống khách hàng!");
                    return;
                }
                else
                {
                    // kiểm tra xem mã khách hàng có bị trùng không
                    sql = "select* from tKhachHang where MaKH='" + txtmkh.Text + "'";
                    DataTable dt = database.ReadData(sql);
                    if (dt.Rows.Count > 0)
                    {
                        errorkhachhang.SetError(txtmkh, "Đã tồn tại khách hàng có mã " + txtmkh.Text);
                        return;
                    }
                    errorkhachhang.Clear();
                }
                // insert dữ liệu vào database
                sql = "INSERT  dbo.tKhachHang(MaKH, TenKH, GioiTinh ,DiaChi, DienThoai) VALUES(";
                sql += "N'" + txtmkh.Text + "',N'" + txttkh.Text + "',N'" + cbgioitinh + "',N'" + txtdiachi.Text + "',N'" + txtsdt.Text + "')";
            }
            // nếu nút sửa enable thì thực hiện sửa
            if (btnsua.Enabled == true)
            {
                //kiemTraThongTin();
                sql = "update tKhachHang set ";
                sql += "TenKH=N'" + txttkh.Text + "',";
                sql += "GioiTinh" + cbgioitinh.Text + "',";
                sql += "DiaChi=N'" + txtdiachi.Text + "',";
                sql += "DienThoai='" + txtsdt.Text + "',";
                sql += " Where MaKH = N'" + txtmkh.Text + "'";
            }
            if (btnxoa.Enabled == true)
            {
                sql = "delete from tKhachHang where MaKH='" + txtmkh.Text + "'";
            }
            database.UpdateData(sql);
            sql = "select* from tKhachHang";
            // cập nhật lại datagrid
            dgvkhachhang.DataSource = database.ReadData(sql);
            // cập nhật lại các nút
            hienthiChitiet(false);
            btnsua.Enabled = false;
            btnxoa.Enabled = false;

        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            // cập nhật lại các nút như ban đầu
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnthem.Enabled = true;
            // xóa trang chi tiết
            xoaTrangChiTiet();
            // ẩn grb chi tiết
            hienthiChitiet(true);

        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(" phải nhập số!");
            }
        }

        private void btnin_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook exBook = exApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet exSheet = (Microsoft.Office.Interop.Excel.Worksheet)exBook.Worksheets[1];
            //
            Microsoft.Office.Interop.Excel.Range shopName = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[1, 1];
            shopName.Font.Size = 20;
            shopName.Font.Bold = true;
            shopName.Value = "CỬA HÀNG ĐỒ CHƠI BING CHILING";
            //
            Microsoft.Office.Interop.Excel.Range shopAddress = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[2, 1];
            shopAddress.Font.Size = 14;
            shopAddress.Font.Bold = true;
            shopAddress.Value = "Số 3 P. Cầu Giấy, Láng Thượng, Đống Đa, Hà Nội, Việt Nam";
            //in thông tin người tạo và ngày tháng
            exSheet.Range["A6:B7"].Font.Size = 13;

            exSheet.get_Range("A6:B7").Font.Bold = true;
            exSheet.get_Range("A6").Value = "Người tạo:";
            exSheet.get_Range("B6").Value = "Vũ Khánh Chung"; //*****
            exSheet.get_Range("A7").Value = "Ngày:";
            exSheet.get_Range("B7").Value = DateTime.Now.ToString("dd-MM-yyyy");

            //in chữ danh sách sp

            exSheet.get_Range("C8:E8").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            ////
            exSheet.Range["D8"].Font.Size = 15;
            exSheet.Range["D8"].Font.Bold = true;
            exSheet.Range["D8"].Font.Color = Color.Black;
            exSheet.get_Range("D8").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.Range["D8"].Value = "DANH SÁCH KHÁCH HÀNG";
            //

            /////
            exSheet.Range["A10:H10"].Font.Size = 13;
            exSheet.Range["A10:H10"].Font.Bold = true;
            exSheet.get_Range("A10:H10").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.get_Range("B10:H10").ColumnWidth = 15;
            exSheet.get_Range("A10").Value = "STT";
            exSheet.get_Range("B10").Value = "Mã Khách Hàng";
            exSheet.get_Range("C10").Value = "Tên Khách Hàng";
            exSheet.get_Range("D10").Value = "Giới Tính";
            exSheet.get_Range("E10").Value = "Địa chỉ";
            exSheet.get_Range("F10").Value = "Số Điện Thoại";
            ////
            exSheet.get_Range("A10:H10").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
            ////
            //in danh sách sản phẩm
            int dong = 11;
            //
            // border danh sách
            exSheet.get_Range("A10:H" + (dong + dgvkhachhang.Rows.Count - 1).ToString()).Borders.Color = System.Drawing.Color.Black.ToArgb();
            //
            for (int i = 0; i < dgvkhachhang.Rows.Count; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvkhachhang.Rows[i].Cells[0].Value?.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvkhachhang.Rows[i].Cells[1].Value?.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dgvkhachhang.Rows[i].Cells[2].Value?.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvkhachhang.Rows[i].Cells[3].Value?.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgvkhachhang.Rows[i].Cells[4].Value?.ToString();
            }

            //
            exSheet.Name = "DSNV";
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
    }
}
