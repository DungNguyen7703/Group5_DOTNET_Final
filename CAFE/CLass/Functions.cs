using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFE.CLass
{
    internal class Functions
    {
        public static SqlConnection conn;
        public static string connstring;
        public static void ketnoi()
        {
            connstring = "Data Source=DESKTOP-P92U971\\SQLEXPRESS;Initial Catalog=QLCafe;Integrated Security=True";
            conn = new SqlConnection();
            conn.ConnectionString = connstring;
            conn.Open();
            //MessageBox.Show("Ket noi thanh cong");
        }
        public static DataTable GetDataTable(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter();
            mydata.SelectCommand = new SqlCommand();
            mydata.SelectCommand.Connection = CLass.Functions.conn;
            mydata.SelectCommand.CommandText = sql;
            DataTable table = new DataTable();
            //mydata.Fill(table);
            mydata.Fill(table);
            return table;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Functions.conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void runsql(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand(sql);
            cmd.Connection = Functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception loi)
            {
                MessageBox.Show(loi.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void fillcombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, CLass.Functions.conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;  //Trường giá trị 
            cbo.DisplayMember = ten;  //Trường hiển thị 
        }
        public static string getfieldvalues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, CLass.Functions.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
    }
}
