
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
    public partial class FrmChatLieu : Form
    {
        public FrmChatLieu()
        {
            InitializeComponent();
        }
        AccessData data = new AccessData();
        private void LoadDataGridView()
        {
            string sql = "select * from tChatLieu";
            dgvChatlieu.DataSource = data.ReadData(sql);
            dgvChatlieu.Columns[0].HeaderText = "Mã Chất Liệu";
            dgvChatlieu.Columns[1].HeaderText = "Tên Chất Liệu";
            dgvChatlieu.AllowUserToAddRows = false;
            dgvChatlieu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValue()
        {
            txtMachatlieu.Text = "";
            txtTenchatlieu.Text = "";
        }
        private void FrmChatLieu_Load(object sender, EventArgs e)
        {
            txtMachatlieu.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
        }

        private void dgvChatlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvChatlieu.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu về chất liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMachatlieu.Text = dgvChatlieu.CurrentRow.Cells["MaChatLieu"].Value.ToString();
            txtTenchatlieu.Text = dgvChatlieu.CurrentRow.Cells["TenChatLieu"].Value.ToString();
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
            txtMachatlieu.Enabled = true;
            txtMachatlieu.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMachatlieu.Text.Trim() == "")
            {
                errChatlieu.SetError(txtMachatlieu, "Bạn chưa nhập mã chất liệu!");
                return;
            }
            else errChatlieu.Clear();
            if (txtTenchatlieu.Text.Trim() == "")
            {
                errChatlieu.SetError(txtTenchatlieu, "Bạn chưa nhập tên chất liệu!");
                return;
            }
            else errChatlieu.Clear();
            sql = "select * from tChatLieu where MaChatLieu=N'"+txtMachatlieu.Text.Trim()+"'";
            if (data.checkKey(sql))
            {
                errChatlieu.SetError(txtMachatlieu, "Đã tồn tại mã chất liệu " + txtMachatlieu.Text);
                return;
            }
            else errChatlieu.Clear();
            sql = "insert into tChatLieu(MaChatLieu,TenChatLieu) values(";
            sql += "N'" + txtMachatlieu.Text + "',";
            sql += "N'" + txtTenchatlieu.Text + "')";
            data.UpdateData(sql);
            LoadDataGridView();
            ResetValue();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtMachatlieu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (dgvChatlieu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachatlieu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMachatlieu.Focus();
                return;
            }
            if (txtTenchatlieu.Text.Trim() == "")
            {
                errChatlieu.SetError(txtTenchatlieu, "Bạn chưa nhập tên chất liệu");
                return;
            }
            else errChatlieu.Clear();
            sql = "update tChatLieu set ";
            sql += "TenChatLieu=N'" + txtTenchatlieu.Text + "' ";
            sql += "where MaChatLieu=N'" + txtMachatlieu.Text + "'";
            data.UpdateData(sql);
            LoadDataGridView();
            ResetValue();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dgvChatlieu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachatlieu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn chất liệu nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa chất liệu "+txtTenchatlieu.Text+"?Hành động này sẽ xóa tất cả sản phẩm có chất liệu "+txtTenchatlieu.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                sql = "delete tChatLieu where MaChatLieu=N'" + txtMachatlieu.Text + "'";
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
            txtMachatlieu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmChatLieu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
