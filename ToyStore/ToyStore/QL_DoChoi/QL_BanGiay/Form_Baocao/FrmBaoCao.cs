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

namespace QL_BanGiay
{
    public partial class FrmBaoCao : Form
    {
        AccessData data = new AccessData();
        public FrmBaoCao()
        {
            InitializeComponent();
            dtpChonNgay.Value = DateTime.Now;
            LoadDataGridView();
            DoanhThu();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "select * from DoanhThuTheoNgay('"+dtpChonNgay.Value.ToString()+"')";
            System.Data.DataTable dt = data.ReadData(sql);
            dgvDoanhthu.DataSource = dt;
            dgvDoanhthu.Columns[0].HeaderText = "Thời gian thực";
            dgvDoanhthu.Columns[1].HeaderText = "Số hóa đơn";
            dgvDoanhthu.Columns[2].HeaderText = "Tên sản phẩm";
            dgvDoanhthu.Columns[3].HeaderText = "Số lượng";
            dgvDoanhthu.Columns[4].HeaderText = "Đơn giá";
            dgvDoanhthu.Columns[5].HeaderText = "Thành tiền";
            dgvDoanhthu.AllowUserToAddRows = false;
            dgvDoanhthu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void DoanhThu()
        {
            string sql= "select dbo.TinhDoanhThuTheoNgay('" + dtpChonNgay.Value.ToString() + "')";
            System.Data.DataTable dt = data.ReadData(sql);
            string doanhthu = dt.Rows[0][0].ToString();
            if (doanhthu == "")
            {
                doanhthu = "0";
            }
            string text= "Doanh thu ngày " + dtpChonNgay.Value.ToString("dd-MM-yyyy")+": "+doanhthu + " VND";
            txtDoanhthu.Text = text;
            
            txtDoanhthu.ForeColor = Color.Blue;
            txtDoanhthu.Font = new System.Drawing.Font(txtDoanhthu.Font, FontStyle.Bold);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnExcel_Click_1(object sender, EventArgs e)
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
            exSheet.get_Range("B6").Value = "Nguyễn Công Chính"; //*****
            exSheet.get_Range("A7").Value = "Ngày:";
            exSheet.get_Range("B7").Value = DateTime.Now.ToString("dd-MM-yyyy");

            

            exSheet.get_Range("C8:E8").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            ////
            exSheet.Range["D8"].Font.Size = 15;
            exSheet.Range["D8"].Font.Bold = true;
            exSheet.Range["D8"].Font.Color = Color.Black;
            exSheet.get_Range("D8").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.Range["D8"].Value = "CHI TIẾT BÁN HÀNG NGÀY "+ dtpChonNgay.Value.ToString("dd-MM-yyyy");
            //
            exSheet.Range["A10:F10"].Font.Size = 13;
            
            exSheet.Range["A10:F10"].Font.Bold = true;
            exSheet.get_Range("A10:F10").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.get_Range("A10:F10").ColumnWidth = 15;
            exSheet.get_Range("A10").Value="Thời gian thực";
            exSheet.get_Range("B10").Value="Số hóa đơn";
            exSheet.get_Range("C10").Value="Tên sản phẩm";
            exSheet.get_Range("D10").Value="Số lượng";
            exSheet.get_Range("E10").Value="Đơn giá";
            exSheet.get_Range("F10").Value="Thành tiền";
            exSheet.get_Range("A10:F10").Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
            ////
            double tongtien = 0;
            int dong = 11;
            // border danh sách
            exSheet.get_Range("A10:F" + (dong + dgvDoanhthu.Rows.Count - 1).ToString()).Borders.Color = System.Drawing.Color.Black.ToArgb();
            ////
            for (int i = 0; i < dgvDoanhthu.Rows.Count; i++)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = dgvDoanhthu.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvDoanhthu.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvDoanhthu.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dgvDoanhthu.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvDoanhthu.Rows[i].Cells[4].Value.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgvDoanhthu.Rows[i].Cells[5].Value.ToString();
                tongtien += Convert.ToDouble(dgvDoanhthu.Rows[i].Cells[5].Value.ToString());
            }
            //
            exSheet.get_Range("E" + (dong + dgvDoanhthu.Rows.Count).ToString()).Value = "Doanh thu: ";
            exSheet.get_Range("F" + (dong + dgvDoanhthu.Rows.Count).ToString()).Value = tongtien.ToString();
            exSheet.Range["E" + (dong + dgvDoanhthu.Rows.Count).ToString() + ":F" + (dong + dgvDoanhthu.Rows.Count)].Font.Bold = true;
            exSheet.Range["E" + (dong + dgvDoanhthu.Rows.Count).ToString() + ":F" + (dong + dgvDoanhthu.Rows.Count)].Interior.Color = Color.Green;
            exSheet.Range["E" + (dong + dgvDoanhthu.Rows.Count).ToString() + ":F" + (dong + dgvDoanhthu.Rows.Count)].Font.Size = 13;
            //
            exSheet.Name = "CTBH";
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

        private void dtpChonNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadDataGridView();
            DoanhThu();
        }
    }
}
