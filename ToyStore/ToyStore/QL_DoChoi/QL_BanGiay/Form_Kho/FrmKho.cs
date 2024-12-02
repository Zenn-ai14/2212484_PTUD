
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
    public partial class FrmKho : Form
    {
        string UserName;
        public FrmKho(string userName)
        {
            InitializeComponent();
            this.UserName = userName;
        }
        void DisplayPanel(Form frm)
        {
            frm.TopLevel = false;
            panelKho.Controls.Clear();
            panelKho.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.BackColor = Color.FromArgb(255, 255, 179);
            frm.Show();
        }
        private void mnuSanPham_Click(object sender, EventArgs e)
        {

            FrmSanPham frm = new FrmSanPham(UserName);
            DisplayPanel(frm);
        }

        private void kiểuGiàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKieuDoChoi frm = new FrmKieuDoChoi();
            DisplayPanel(frm);
        }

        private void thươngHiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThuongHieu frm = new FrmThuongHieu
                ();
            DisplayPanel(frm);
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChatLieu frm = new FrmChatLieu();
            DisplayPanel(frm);
        }

        private void FrmKho_Load(object sender, EventArgs e)
        {
           
            mnuSanPham_Click(sender, e);

        }
    }
}
