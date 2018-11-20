using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.userInterface;

namespace QuanLyKhachSan.Player
{
    class NguoiDung
    {
        public static string nhanvien;
        public static int DangNhap(String tenDangNhap, String matKhau)
        {
            KetNoi.openketnoi();
            DataTable nd = new DataTable();
            nd = KetNoi.gettable("select * from DANGNHAP where MaNV='"+tenDangNhap+"'");
            if (nd.Rows.Count == 0)
                return 0;
            String matkhau_hethong = nd.Rows[0]["MatKhau"].ToString();
            if (matkhau_hethong != matKhau)
            {
                return 1;//Sai mat khau
            }
            else
            {
                nhanvien = tenDangNhap;
                return 2;//Dang Nhap thanh cong
            }
        }
    }
}
