using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanGiay
{
    public partial class FrmNhanVien : Form
    {

        AccessData database = new AccessData();

        public FrmNhanVien()
        {
            InitializeComponent();
        }
        // phương thức ẩn grbnhanvien
        private void hienthiChitiet(bool hien)
        {
            foreach (Control ctl in grbnhanvien.Controls)
            {
                ctl.Enabled = hien;
            }
        }
        // sự kiện loadform
        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            cbogioitinh.Items.Add("Nam");
            cbogioitinh.Items.Add("Nữ");
            dgvnhanvien.DataSource = database.ReadData("select * from tNhanVien");
            // ẩn grbnhanvien
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
            string sql = "select* from tNhanVien where MaNV is not null";
            // tìm theo mã nhân viên khác rỗng
            if (txtmanv.Text.Trim() != "")
            {
                sql += " and MaNV like '%" + txtmanv.Text + "%'";
            }
            dgvnhanvien.DataSource = database.ReadData(sql);
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
                txtmanv.Text = dgvnhanvien.CurrentRow.Cells[0].Value.ToString();
                txttnv.Text = dgvnhanvien.CurrentRow.Cells[1].Value.ToString();
                cbogioitinh.Text = dgvnhanvien.CurrentRow.Cells[2].Value.ToString();
                dtpngaysinh.Value = (DateTime)dgvnhanvien.CurrentRow.Cells[3].Value;
                txtdiachi.Text = dgvnhanvien.CurrentRow.Cells[4].Value.ToString();
                txtsdt.Text = dgvnhanvien.CurrentRow.Cells[5].Value.ToString();
                txtluong.Text = dgvnhanvien.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // phương thức xóa trắng grbnhanvien
        private void xoaTrangChiTiet()
        {
            foreach (Control txt in grbnhanvien.Controls)
            {
                if (txt is TextBox)
                    txt.Text = "";
            }
            dtpngaysinh.Value = DateTime.Today;
        }
        // chức năng thêm 
        private void btnthem_Click(object sender, EventArgs e)
        {
            xoaTrangChiTiet();
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            hienthiChitiet(true);
            txtmanv.Text = "";
            txttnv.Text = "";
            cbogioitinh.Text = "";
            dtpngaysinh.Value = DateTime.Today;
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtluong.Text = "";

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            hienthiChitiet(true);
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Bạn có muốn xoá nhân viên có mã " + txtmanv.Text + " không?Nếu có ấn nút lưu, không thì ấn hủy", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            // kiểm tra xem tên sản phẩm có rỗng không
            if (txttnv.Text.Trim() == "")
            {
                errornhanvien.SetError(txttnv, "Bạn không để trống tên nhân viên!");
                return;
            }
            else
                errornhanvien.Clear();
            //Kiểm tra giới tính xem có để trống không
            if (cbogioitinh.Text.Trim() == "")
            {
                errornhanvien.SetError(cbogioitinh, "Bạn không để trống giới tính!");
                return;
            }
            else
                errornhanvien.Clear();
            //Kiểm tra ngày sinh, lỗi nếu người sử dụng nhập vào ngày sinh lớn hơn ngày hiện tại
            if (dtpngaysinh.Value > DateTime.Now)
            {
                errornhanvien.SetError(dtpngaysinh, "Ngày sinh không hợp lệ!");
                return;
            }
            else
                errornhanvien.Clear();
            //Kiểm tra địa chỉ xem có để trống không
            if (txtdiachi.Text.Trim() == "")
            {
                errornhanvien.SetError(txtdiachi, "Bạn không để trống địa chỉ!");
                return;
            }
            else
                errornhanvien.Clear();
            //Kiểm tra điện thoại có rỗng không
            if (txtsdt.Text.Trim() == "")
            {
                errornhanvien.SetError(txtsdt, "Bạn không để trống điện thoại!");
                return;
            }
            else
                errornhanvien.Clear();
            //Kiểm tra Lương có rỗng không
            if (txtluong.Text.Trim() == "")
            {
                errornhanvien.SetError(txtluong, "Bạn không để trống lương!");
                return;
            }
            else
                errornhanvien.Clear();
            // nút thêm enable thì thực hiện thêm mới sản phẩm
            if (btnthem.Enabled == true)
            {
                //kiemTraThongTin();
                // kiểm tra xem mã sản phẩm có trống không
                if (txtmanv.Text.Trim() == "")
                {
                    errornhanvien.SetError(txtmanv, "Bạn không để trống mã nhân viên!");
                    return;
                }
                else
                {
                    // kiểm tra xem mã sản phẩm có bị trùng không
                    sql = "select* from tNhanVien where MaNV='" + txtmanv.Text + "'";
                    DataTable dt = database.ReadData(sql);
                    if (dt.Rows.Count > 0)
                    {
                        errornhanvien.SetError(txtmanv, "Đã tồn tại nhân viên có mã " + txtmanv.Text);
                        return;
                    }
                    errornhanvien.Clear();
                }
                // insert dữ liệu vào database
                sql = "INSERT  dbo.tNhanVien(MaNV, TenNV, GioiTinh, NgaySinh,  DiaChi, DienThoai, Luong) VALUES(";
                sql += "N'" + txtmanv.Text + "',N'" + txttnv.Text + "',N'" + cbogioitinh.Text + "','" + dtpngaysinh.Value.Date + "',N'" + txtdiachi.Text + "',N'" + txtsdt.Text + "',N'" + txtluong.Text + "')";
            }
            // nếu nút sửa enable thì thực hiện sửa
            if (btnsua.Enabled == true)
            {
                //kiemTraThongTin();
                sql = "update tNhanVien set ";
                sql += "TenNV=N'" + txttnv.Text + "',";
                sql += "GioiTinh=N'" + cbogioitinh.Text + "',";
                sql += "ngaySinh='" + dtpngaysinh.Value.Date + "',";
                sql += "DiaChi=N'" + txtdiachi.Text + "',";
                sql += "DienThoai='" + txtsdt.Text + "',";
                sql += "Luong = N'" + txtluong.Text + "'";
                sql += " Where MaNV = N'" + txtmanv.Text + "'";
            }
            if (btnxoa.Enabled == true)
            {
                sql = "delete from tNhanVien where MaNV='" + txtmanv.Text + "'";
            }
            database.UpdateData(sql);
            sql = "select* from tNhanVien";
            // cập nhật lại datagrid
            dgvnhanvien.DataSource = database.ReadData(sql);
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
            shopName.Value = "CỬA HÀNG BÁN ĐỒ CHƠI";
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

            //in chữ danh sách 

            exSheet.get_Range("C8:E8").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            ////
            exSheet.Range["D8"].Font.Size = 15;
            exSheet.Range["D8"].Font.Bold = true;
            exSheet.Range["D8"].Font.Color = Color.Black;
            exSheet.get_Range("D8").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.Range["D8"].Value = "DANH SÁCH NHÂN VIÊN";
            //

            /////
            exSheet.Range["A10:H10"].Font.Size = 13;
            exSheet.Range["A10:H10"].Font.Bold = true;
            exSheet.get_Range("A10:H10").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.get_Range("B10:H10").ColumnWidth = 15;
            exSheet.get_Range("A10").Value = "STT";
            exSheet.get_Range("B10").Value = "MaNV";
            exSheet.get_Range("C10").Value = "TenNV";
            exSheet.get_Range("D10").Value = "GioiTinh";
            exSheet.get_Range("E10").Value = "NgaySinh";
            exSheet.get_Range("F10").Value = "DiaChi";
            exSheet.get_Range("G10").Value = "DienThoai";
            exSheet.get_Range("H10").Value = "Luong";
            ////
            exSheet.get_Range("A10:H10").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
            ////
            //in danh sách sản phẩm
            int dong = 11;
            //
            // border danh sách
            exSheet.get_Range("A10:H" + (dong + dgvnhanvien.Rows.Count - 1).ToString()).Borders.Color = System.Drawing.Color.Black.ToArgb();
            //
            for (int i = 0; i < dgvnhanvien.Rows.Count; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvnhanvien.Rows[i].Cells[0].Value?.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvnhanvien.Rows[i].Cells[1].Value?.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dgvnhanvien.Rows[i].Cells[2].Value?.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvnhanvien.Rows[i].Cells[3].Value?.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgvnhanvien.Rows[i].Cells[4].Value?.ToString();
                exSheet.Range["G" + (dong + i).ToString()].Value = dgvnhanvien.Rows[i].Cells[5].Value?.ToString();
                exSheet.Range["H" + (dong + i).ToString()].Value = dgvnhanvien.Rows[i].Cells[6].Value?.ToString();
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
        }
    }
}
