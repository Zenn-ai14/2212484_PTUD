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
    public partial class TuNgay : UserControl
    {
        public TuNgay()
        {
            InitializeComponent();
        }

        private void TuNgay_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value= new DateTime(DateTime.Now.Year, DateTime.Now.Month,1);
            dtpDenNgay.Value = DateTime.Now;
        }
        public string getTuNgay()
        {
            return dtpTuNgay.Value.ToString("yyyy-MM-dd");
        }
        public string getDenNgay()
        {
            return dtpDenNgay.Value.ToString("yyyy-MM-dd");
        }
        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value > dtpDenNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpTuNgay.Select();
                return;
            }
        }

        private void dtpTuNgay_Leave(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value > dtpDenNgay.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpTuNgay.Select();
                return;
            }
        }

    }
}
