
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
    public partial class frmMain : Form
    {
        public bool Logouted { get; set; }
        string Username;
        bool IsManager;
        public frmMain(string Username, bool IsManager)
        {
            InitializeComponent();
            this.Username = Username;
            this.IsManager = IsManager;
            Logouted = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Get casher
            AccessData ad = new AccessData();
            DataTable dt = new DataTable();
            dt = ad.ReadData("select * from tnhanvien where manv = N'" + Username + "'");
            foreach (DataRow dr in dt.Rows)
            {
                Username = dr["TenNV"].ToString();
            }
            lblCasher.Text = "Casher: " + Username;


            // Xử lý đồng hồ thời gian thực
            tmr.Start();
            grb1.Width = (int)(Width * 0.2);
            picbox.ImageLocation = "background_login.gif";
            picbox.SizeMode = PictureBoxSizeMode.StretchImage;

            /* Xử lý grb1 */
            foreach (Control c in grb1.Controls)
            {
                c.Height = (int)(grb1.Height / 7);
            }

            btnBanHang.BackColor = Color.FromArgb(255, 179, 179);   // Đỏ nhạt
            btnNhapHang.BackColor = Color.FromArgb(255, 209, 179);  // Cam nhạt
            btnKho.BackColor = Color.FromArgb(255, 255, 179);       // Vàng nhạt
            btnNhanVien.BackColor = Color.FromArgb(179, 179, 255);  // xanh lục nhạt
            btnKhachHang.BackColor = Color.FromArgb(255, 179, 255); // tím nhạt
            btnBaoCao.BackColor = Color.FromArgb(179, 255, 179);    // lime nhạt

            if (!IsManager)
            {
                btnNhapHang.Visible = false;
                btnKho.Visible = false;
                btnNhanVien.Visible = false;
                btnKhachHang.Visible = false;
                btnBaoCao.Visible = false;
            }

            btnBanHang_Click(sender, e);

        }
        
        private void tmr_Tick(object sender, EventArgs e)
        {
            lblNgayGio.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Logouted = true;
                this.Close();
            }
        }

        void DisplayPanel(Form frm)
        {
            frm.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {


            
            FrmHoaDonBan frmBanHang = new FrmHoaDonBan();
            frmBanHang.BackColor = Color.FromArgb(255, 179, 179);
            DisplayPanel(frmBanHang);
            
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {

            
            FrmHoaDonNhap frmNhapHang = new FrmHoaDonNhap();
            frmNhapHang.BackColor = Color.FromArgb(255, 209, 179);
            DisplayPanel(frmNhapHang);
            

        }

        private void btnKho_Click(object sender, EventArgs e)
        {

            FrmKho frmKho = new FrmKho(Username);
            frmKho.BackColor = Color.FromArgb(255, 255, 179);
            DisplayPanel(frmKho);

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            

            FrmNhanVien frmNhanVien = new FrmNhanVien();
            frmNhanVien.BackColor = Color.FromArgb(179, 179, 255);  // xanh lục nhạt
            DisplayPanel(frmNhanVien);

        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            

            FrmKhachHang frmKhachHang = new FrmKhachHang();
            frmKhachHang.BackColor = Color.FromArgb(255, 179, 255); // tím nhạt
            DisplayPanel(frmKhachHang);

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            

            FrmBaoCao frmBaoCao = new FrmBaoCao();
            frmBaoCao.BackColor = Color.FromArgb(179, 255, 179);    // lime nhạt
            DisplayPanel(frmBaoCao);

        }
    }
}
