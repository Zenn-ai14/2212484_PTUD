using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanGiay
{
    public partial class FrmHoaDonNhap : Form
    {
        AccessData data = new AccessData();
        public FrmHoaDonNhap()
        {
            InitializeComponent();

        }
        void ResetValue()
        {
            maHDN.Text = "";
            ngayNhap.Text = "";
            mNhanVien.Text = "";
            tenNhanVien.Text = "";
            maNCC.Text = "";
            maTim.Text = "";
            mNhanVien.SelectedIndex = -1;
            maNCC.SelectedIndex = -1;
        }


        private void hoaDonNhap_Load(object sender, EventArgs e)
        {
            

            if (maHDN.Text == "")
            {
                themChiTiet.Enabled = false;
            }
            DataTable dtNhanVien = data.ReadData("Select * from tNhanVien");
            DataTable dtNCC = data.ReadData("Select * from tNhaCungCap");
            DataTable dtHDNhap = data.ReadData("Select * from tHoaDonNhap");
            data.FillComboBox(mNhanVien, dtNhanVien, "MaNV", "MaNV");
            data.FillComboBox(maNCC, dtNCC, "MaNCC", "MaNCC");
            data.FillComboBox(maTim, dtHDNhap, "SoHDN", "SoHDN");
            string sql = "";
            sql += "select tChiTietHDN.SoHDN,NgayNhap,tHoaDonNHap.MaNV,TenNV,MaNCC from tHoaDonNhap join tChiTietHDN on tHoaDonNhap.SoHDN=tChiTietHDN.SoHDN" +
                " join tNhanVien on tNhanVien.MaNV=tHoaDonNhap.MaNV";
            danhSachNhap.DataSource = data.ReadData(sql);
            ngayNhap.Text = DateTime.Now.ToString();
            ResetValue();
        }

        private void tim_Click(object sender, EventArgs e)
        {
            string sqlFind = "SELECT * FROM tHoaDonNhap where ";
            //Tim theo MaSP khac rong
            if (maTim.Text.Trim() != "")
            {
                sqlFind += " SoHDN =N'" + maTim.Text + "'";
            }
            //Load dữ liệu tìm được lên dataGridView
            danhSachNhap.DataSource = data.ReadData(sqlFind);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ResetValue();
            string sql = "";
            sql += "select tChiTietHDN.SoHDN,NgayNhap,tHoaDonNHap.MaNV,TenNV,MaNCC from tHoaDonNhap join tChiTietHDN on tHoaDonNhap.SoHDN=tChiTietHDN.SoHDN" +
                " join tNhanVien on tNhanVien.MaNV=tHoaDonNhap.MaNV";
            danhSachNhap.DataSource = data.ReadData(sql);
        }
        private string get_mhdn;
        public string Message
        {
            get { return get_mhdn; }
            set { get_mhdn = value; }
        }
        private void themChiTiet_Click(object sender, EventArgs e)
        {
            if (mNhanVien.Text == "" || maNCC.Text == "")
            {
                MessageBox.Show("khong duoc de trong");
                return;
            }

            string sql = "INSERT INTO tHoaDonNhap(SoHDN,MaNV,NgayNhap,MaNCC) VALUES(";
            sql += "N'" + maHDN.Text + "',N'" + mNhanVien.Text + "'," + ngayNhap.Text.Trim() + ",'" + maNCC.Text + "')";
            data.UpdateData(sql);
            string sql1 = " select SoHDN,MaNV,NgayNhap,MaNCC from tHoaDonNhap";
            danhSachNhap.DataSource = data.ReadData(sql1);
            Message = maHDN.Text.Trim();
            FrmChiTietHDN ctn = new FrmChiTietHDN();
            ctn.x = Message;
            ctn.ShowDialog();
        }

        private void maTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            maTim.Text = "";
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void danhSachNhap_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmChiTietHDN ctn = new FrmChiTietHDN();
            ctn.x = maHDN.Text;
            ctn.Show();
            ctn.xem();
            try
            {
                maHDN.Text = danhSachNhap.CurrentRow.Cells[0].Value.ToString();
                ngayNhap.Text = danhSachNhap.CurrentRow.Cells[1].Value.ToString();
                mNhanVien.Text = danhSachNhap.CurrentRow.Cells[2].Value.ToString();
                tenNhanVien.Text = danhSachNhap.CurrentRow.Cells[3].Value.ToString();
                maNCC.Text = danhSachNhap.CurrentRow.Cells[4].Value.ToString();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }




        private void danhSachNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            maHDN.Text = danhSachNhap.CurrentRow.Cells[0].Value.ToString();
            ngayNhap.Text = danhSachNhap.CurrentRow.Cells[1].Value.ToString();
            mNhanVien.Text = danhSachNhap.CurrentRow.Cells[2].Value.ToString();
            tenNhanVien.Text = danhSachNhap.CurrentRow.Cells[3].Value.ToString();
            maNCC.Text = danhSachNhap.CurrentRow.Cells[4].Value.ToString();
        }

        private void mNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                DataTable dtNV = data.ReadData("Select TenNV from tNhanVien where MaNV='" + mNhanVien.SelectedValue + "'");
                tenNhanVien.Text = dtNV.Rows[0]["TenNV"].ToString();
            }
            catch
            {

            }
        }

        private void them_Click(object sender, EventArgs e)
        {

            themChiTiet.Enabled = true;
            string str = DateTime.Now.ToString("ss-mm-HH").Trim();
            string giay = str.Substring(0, 2);
            string phut = str.Substring(3, 2);
            maHDN.Text = data.AutoCode("tHoaDonNhap", "SoHDN", "HDN" + giay + phut);
            //phut+gio + 
            // DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString());

            //ngayNhap.Text = DateTime.Now.ToString("dd/MM/yyyy").Trim();
        }
        

        private void sua_Click(object sender, EventArgs e)
        {
            string sql = "Update tHoaDonNhap Set";
            sql += " NgayNhap=N'" + ngayNhap.Text.Trim() + "',";
            sql += "MaNV=N'" + mNhanVien.Text.Trim() + "',";
            sql += "MaNCC=N'" + maNCC.Text.Trim() + "'";
            sql += " where SoHDN=N'" + maHDN.Text.Trim() + "'";
            data.UpdateData(sql);
            sql += "select tChiTietHDN.SoHDN,NgayNhap,tHoaDonNHap.MaNV,TenNV,MaNCC from tHoaDonNhap join tChiTietHDN on tHoaDonNhap.SoHDN=tChiTietHDN.SoHDN" +
                " join tNhanVien on tNhanVien.MaNV=tHoaDonNhap.MaNV";
            danhSachNhap.DataSource = data.ReadData(sql);
            ResetValue();
        }
    }
}
