using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_BanGiay
{
    class AccessData
    {
        //Khai báo biến
        SqlConnection sqlConn = null;
        string connectionString = "server = DUCPHO; Database = CSDL_DoChoi; Integrated Security = True";
        //Phương thực mở kết nối
        void OpenConnect()
        {
            sqlConn = new SqlConnection(connectionString);
            if (sqlConn.State != ConnectionState.Open)
                sqlConn.Open();

        }
        //Đóng kết nối
        void CloseConnect()
        {
            if (sqlConn.State != ConnectionState.Closed)
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
        }
        //Phương thức đọc dữ liệu trả về một DataTable, input: câu lệnh Select,output: DataTable
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dtData = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlDataA = new SqlDataAdapter(sqlSelect, sqlConn);
            sqlDataA.Fill(dtData);
            CloseConnect();
            return dtData;
        }
        //PT thực các lệnh insert, update, delete
        public void UpdateData(string sql)
        {
            OpenConnect();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConn;
            sqlCommand.CommandText = sql;
            
            
            sqlCommand.ExecuteNonQuery();
            CloseConnect();
        }
        // hàm dùng để fill các ComboBox trong form
        public void fillComboBox(string sql, ComboBox cbo, string ma, string ten)
        {
            cbo.DataSource = this.ReadData(sql);
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }
        public void FillComboBox(ComboBox comboName, DataTable data, string displayMember, string valueMember)
        {
            comboName.DataSource = data;
            comboName.DisplayMember = displayMember;
            comboName.ValueMember = valueMember;
        }
        public string getFieldValue(string sql)
        {
            this.OpenConnect();
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            this.CloseConnect();
            return ma;
        }
        public bool checkKey(string sql)
        {
            OpenConnect();
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnect();
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public string AutoCode(string tableName, string columnName, string startvalue)
        {

            string code;
            bool check = false;
            int id = 0;

            do
            {
                if (id < 10)
                    code = startvalue + "0" + id;
                else
                    code = startvalue + id;
                DataTable dtData = ReadData("Select * from " + tableName + " where " + columnName + "='" + code + "'");
                if (dtData.Rows.Count == 0)
                    check = true;
                else
                    id++;
            } while (check == false);
            return code;
        }
    }
}
