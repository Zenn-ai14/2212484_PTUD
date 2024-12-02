
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
    public partial class FrmKieuDoChoi : Form
    {
        public FrmKieuDoChoi()
        {
            InitializeComponent();
        }
        AccessData data = new AccessData();
        private void LoadDataGridView()
        {
            string sql = "select * from tTheLoai";
            dgvKieuDoChoi.DataSource = data.ReadData(sql);
            dgvKieuDoChoi.Columns[0].HeaderText = "Mã Thương Hiệu";
            dgvKieuDoChoi.Columns[1].HeaderText = "Tên Thương Hiệu";
            dgvKieuDoChoi.AllowUserToAddRows = false;
            dgvKieuDoChoi.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValue()
        {
            txtMakieudochoi.Text = "";
            txtTenkieudochoi.Text = "";
        }
        private void FrmKieuGiay_Load(object sender, EventArgs e)
        {
            txtMakieudochoi.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
        }

        private void dgvKieuGiay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvKieuDoChoi.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu về kiểu giầy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMakieudochoi.Text = dgvKieuDoChoi.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            txtTenkieudochoi.Text = dgvKieuDoChoi.CurrentRow.Cells["TenTheLoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();
            txtMakieudochoi.Enabled = true;
            txtMakieudochoi.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMakieudochoi.Text.Trim() == "")
            {
                errKieuGiay.SetError(txtMakieudochoi, "Bạn chưa nhập mã kiểu đồ chơi!");
                return;
            }
            else errKieuGiay.Clear();
            if (txtTenkieudochoi.Text.Trim() == "")
            {
                errKieuGiay.SetError(txtTenkieudochoi, "Bạn chưa nhập tên kiểu đồ chơi!");
                return;
            }
            else errKieuGiay.Clear();
            sql = "select * from tTheLoai where MaTheLoai=N'" + txtMakieudochoi.Text.Trim() + "'";
            if (data.checkKey(sql))
            {
                errKieuGiay.SetError(txtMakieudochoi, "Đã tồn tại kiểu giầy có mã " + txtMakieudochoi.Text);
                return;
            }
            else errKieuGiay.Clear();
            sql = "insert into tTheLoai(MaTheLoai,TenTheLoai) values(";
            sql += "N'" + txtMakieudochoi.Text + "',";
            sql += "N'" + txtTenkieudochoi.Text + "')";
            data.UpdateData(sql);
            LoadDataGridView();
            ResetValue();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtMakieudochoi.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (dgvKieuDoChoi.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMakieudochoi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakieudochoi.Focus();
                return;
            }
            if (txtTenkieudochoi.Text.Trim() == "")
            {
                errKieuGiay.SetError(txtTenkieudochoi, "Bạn chưa nhập tên kiểu giầy");
                return;
            }
            else errKieuGiay.Clear();
            sql = "update tTheLoai set ";
            sql += "TenTheLoai=N'" + txtTenkieudochoi.Text + "' ";
            sql += "where MaTheLoai=N'" + txtMakieudochoi.Text + "'";
            data.UpdateData(sql);
            LoadDataGridView();
            ResetValue();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dgvKieuDoChoi.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMakieudochoi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn kiểu giầy nào nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa kiểu giầy " + txtTenkieudochoi.Text + "? Hành động này sẽ xóa tất cả sản phẩm có kiểu đồ chơi "+txtTenkieudochoi.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                sql = "delete tTheLoai where MaTheLoai=N'" + txtMakieudochoi.Text + "'";
                data.UpdateData(sql);
                LoadDataGridView();
                ResetValue();
                btnBoqua.Enabled = false;
            }
        }
        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMakieudochoi.Enabled = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
