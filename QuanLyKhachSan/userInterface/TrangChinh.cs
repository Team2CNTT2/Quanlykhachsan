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
    public partial class TrangChinh : Form
    {
       
        public TrangChinh()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TraPhong p = new TraPhong();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            KhachHang kh = new KhachHang();
            kh.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            dv.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.Show();
        }

        private void TrangChinh_Load(object sender, EventArgs e)
        {
            if (NguoiDung.nhanvien == "Boss")
                button6.Visible = true;
            else button6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NhanPhong np = new NhanPhong();
            np.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QuanLy tk = new QuanLy();
            tk.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            dv.Show();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatPhong dp = new DatPhong();
            dp.Show();
        }

        private void nhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanPhong np = new NhanPhong();
            np.Show();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraPhong p = new TraPhong();
            p.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lo = new login();
            lo.ShowDialog();
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachSan ks = new KhachSan();
            ks.Show();
        }

        private void xóaDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KetNoi.openketnoi();
            KetNoi.executeQuery("xoaall");
        }
    }
}
