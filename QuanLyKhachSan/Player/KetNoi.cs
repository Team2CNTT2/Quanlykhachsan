using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyKhachSan.userInterface
{
    class KetNoi
    {
        
       // public static string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\DuLieu.mdf;Integrated Security=True;Connect Timeout=30";
        public static string chuoiketnoi = @"Data Source = "+SystemInformation.ComputerName+";Initial Catalog = DuLieu; Integrated Security = True";
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public static void openketnoi()
        {
            con = new SqlConnection(chuoiketnoi);
            con.Open();
        }
        public static void dongketnoi()
        {
            con.Close();
        }
        // phuong thuc lấy 1 bảng về
        public static DataTable gettable(string sql)
        {
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            DataTable db = new DataTable();
            da.Fill(db);
            return db;
        }
        //thực hiện lệnh sql
        public static void executeQuery(string sql)
        {
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
        public static string read(string sql)
        {
            string kq = "";
            openketnoi();
            cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                kq = (string)dr["ID"];
            }
            dongketnoi();
            return kq;
        }
    }
}
