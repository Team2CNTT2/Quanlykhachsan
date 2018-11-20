using QuanLyKhachSan.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace QuanLyKhachSan.userInterface
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private String m_TenNguoiDung;
        public String lay_TenNguoiDung
        {
            get { return m_TenNguoiDung; }
            set { m_TenNguoiDung = value; }
        }
        private String m_MatKhau;
        public String lay_MatKhau
        {
            get { return m_MatKhau; }
            set { m_MatKhau = value; }
        }
        protected void button1_Click(object sender, EventArgs e)
        {

            String tenDangnhap = USER.Text;
            String matKhau = PASS.Text;
            int ketQua = NguoiDung.DangNhap(tenDangnhap, matKhau);
            switch (ketQua)
            {
                case 0:
                    MessageBox.Show("Không tồn tại người dùng trong hệ thống");
                    break;
                case 1:
                    MessageBox.Show("Mật khẩu sai");
                    notice.Visible = true;
                    break;
                case 2:
                    TrangChinh tc = new TrangChinh();
                    this.Hide();
                    tc.ShowDialog();
                    this.Close();
                    break;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
