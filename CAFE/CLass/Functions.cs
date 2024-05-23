using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE.CLass
{
    internal class Functions
    {
        public static SqlConnection conn;
        public static string connString;
          
        public static void connect()
        {
            connString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLCafe;Integrated Security=True;Encrypt=False";
            conn = null;
            conn = new SqlConnection(connString);
            conn.Open();
        }
        public static void disconnect() {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();   	//Đóng kết nối
                conn.Dispose();     //Giải phóng tài nguyên
                conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter();	// Khai báo
            // Tạo đối tượng Command thực hiện câu lệnh SELECT        
            Mydata.SelectCommand = new SqlCommand();
            Mydata.SelectCommand.Connection = Functions.conn; 	// Kết nối CSDL
            Mydata.SelectCommand.CommandText = sql;	// Gán câu lệnh SELECT
            DataTable table = new DataTable();    // Khai báo DataTable nhận dữ liệu trả về
            Mydata.Fill(table); 	//Thực hiện câu lệnh SELECT và đổ dữ liệu vào bảng table
            return table;
        }
        public static void RunSQL(string sql)
        {
            SqlCommand cmd;	// Khai báo đối tượng SqlCommand
            cmd = new SqlCommand();	// Khởi tạo đối tượng
            cmd.Connection = Functions.conn;	// Kết nối
            cmd.CommandText = sql;	// Gán câu lệnh SQL
            try
            {
                cmd.ExecuteNonQuery();	// Thực hiện câu lệnh SQL
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();	// Giải phóng bộ nhớ
            cmd = null;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Functions.conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Functions.conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;	//Trường giá trị
            cbo.DisplayMember = ten;	//Trường hiển thị
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Functions.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }

    }
}
