
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
    public partial class FrmThuongHieu : Form
    {
        AccessData data = new AccessData();
        public FrmThuongHieu()
        {
            InitializeComponent();
        }
        private void LoadDataGridView()
        {
            string sql = "select * from tThuongHieu";
            dgvThuonghieu.DataSource = data.ReadData(sql);
            dgvThuonghieu.Columns[0].HeaderText = "Mã Thương Hiệu";
            dgvThuonghieu.Columns[1].HeaderText = "Tên Thương Hiệu";
            dgvThuonghieu.AllowUserToAddRows = false;
            dgvThuonghieu.EditMode= DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValue()
        {
            txtMaThuonghieu.Text = "";
            txtTenThuongHieu.Text = "";
        }

        private void FrmThuongHieu_Load(object sender, EventArgs e)
        {
            txtMaThuonghieu.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
        }

        private void dgvThuonghieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvThuonghieu.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu về thương hiệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaThuonghieu.Text = dgvThuonghieu.CurrentRow.Cells["MaThuongHieu"].Value.ToString();
            txtTenThuongHieu.Text = dgvThuonghieu.CurrentRow.Cells["TenThuongHieu"].Value.ToString();
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
            txtMaThuonghieu.Enabled = true;
            txtMaThuonghieu.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaThuonghieu.Text.Trim() == "")
            {
                errThuongHieu.SetError(txtMaThuonghieu, "Bạn chưa nhập mã thương hiệu!");
                return;
            }
            else errThuongHieu.Clear();
            if (txtTenThuongHieu.Text.Trim() == "")
            {
                errThuongHieu.SetError(txtTenThuongHieu, "Bạn chưa nhập tên thương hiệu!");
                return;
            }
            else errThuongHieu.Clear();
            sql = "select * from tThuongHieu where MaThuongHieu=N'"+txtMaThuonghieu.Text.Trim()+"'";
            if (data.checkKey(sql))
            {
                errThuongHieu.SetError(txtMaThuonghieu, "Đã tồn tại thương hiệu có mã " + txtMaThuonghieu.Text);
                return;
            }
            else errThuongHieu.Clear();
            sql = "insert into tThuongHieu(MaThuongHieu,TenThuongHieu) values(";
            sql += "N'" + txtMaThuonghieu.Text + "',";
            sql += "N'" + txtTenThuongHieu.Text + "')";
            data.UpdateData(sql);
            LoadDataGridView();
            ResetValue();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtMaThuonghieu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (dgvThuonghieu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaThuonghieu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaThuonghieu.Focus();
                return;
            }
            if (txtTenThuongHieu.Text.Trim() == "")
            {
                errThuongHieu.SetError(txtTenThuongHieu, "Bạn chưa nhập tên thương hiệu");
                return;
            }
            else errThuongHieu.Clear();
            sql = "update tThuonghieu set ";
            sql += "TenThuongHieu=N'" + txtTenThuongHieu.Text + "' ";
            sql += "where MaThuongHieu=N'" + txtMaThuonghieu.Text + "'";
            data.UpdateData(sql);
            LoadDataGridView();
            ResetValue();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dgvThuonghieu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaThuonghieu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn thương hiệu nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(MessageBox.Show("Bạn có muốn xóa thương hiệu "+txtTenThuongHieu.Text+"?Hành động này sẽ xóa tất cả các sản phẩm có thương hiệu "+txtTenThuongHieu.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                sql = "delete tThuongHieu where MaThuongHieu=N'" + txtMaThuonghieu.Text + "'";
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
            txtMaThuonghieu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
