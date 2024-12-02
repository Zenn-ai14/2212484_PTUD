using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QL_BanGiay
{
    public partial class frmLogin : Form
    {
        public bool Thoat { get; set; }
        public bool Logined { get; set; }
        public string username { get; set; }
        string password { get; set; }
        public bool IsMananger { get; set; }
        public frmLogin()
        {
            InitializeComponent();
            Logined = false;
            Thoat = false;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            grbLogin.BackColor = Color.FromArgb(90, 0, 0, 0);   // Làm mờ nền 90%
            lblTieuDe.Width = grbLogin.Width;
            lblTieuDe.BackColor = Color.FromArgb(150,255,255,255);

            txtUser.Focus();
        }

        private void chkbtnShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbtnShowPass.Checked)
                txtPassword.PasswordChar = (char)0;
            else
                txtPassword.PasswordChar = '.';
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.LightGreen;
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
        }
        private void chkbtnShowPass_MouseEnter(object sender, EventArgs e)
        {
            chkbtnShowPass.BackColor = Color.LightGreen;
        }

        private void chkbtnShowPass_MouseLeave(object sender, EventArgs e)
        {
            chkbtnShowPass.BackColor = Color.White;
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            btn.BackColor = Color.LightGreen;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                Thoat = true;
            }    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu input từ giao diện
            username = txtUser.Text.Trim();
            password = txtPassword.Text.Trim();
            // Kiểm tra string empty
            if (username == "")
            {
                MessageBox.Show("Bạn vui lòng nhập 'tên đăng nhập'");
                txtUser.Focus();
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Bạn vui lòng nhập 'mật khẩu'");
                txtPassword.Focus();
                return;
            }

            // Kết nối CSDL để kiểm tra tài khoản
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "server = DUCPHO; Database = CSDL_DoChoi; Integrated Security = True";

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Login";
                cmd.Parameters.AddWithValue("@UserName", txtUser.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Connection = conn;
                //UserName = txtUser.Text;
                object kq = cmd.ExecuteScalar();
                conn.Close();
                int code = Convert.ToInt32(kq);
                if (code == 0)
                {
                //    MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsMananger = false;
                    Logined = true;
                    this.Close();
                }
                else if (code == 1)
                {
                //    MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IsMananger = true;
                    Logined = true;
                    this.Close();
                }
                else if (code == 2)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Text = "";
                    txtUser.Text = "";
                    txtUser.Focus();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Text = "";
                    txtUser.Text = "";
                    txtUser.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grbLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}
