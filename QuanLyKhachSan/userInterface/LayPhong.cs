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
    public partial class LayPhong : Form
    {
        public LayPhong()
        {
            InitializeComponent();
        }

        private void LayPhong_Load(object sender, EventArgs e)
        {
            cbMaPhong.DataSource= KetNoi.gettable("select MaP from CHITIETPHIEUTHUE as a,PHIEUNHAN as b where a.MaDat=b.MaDat and MaNhan='" + tbMaNhan.Text+"'");
            cbMaPhong.DisplayMember = "MaP";
        }
        public string MaNhan
        {
            set { tbMaNhan.Text = value; }
        }
        public DateTime NgayTra
        {
            set { ngayTra.Value = value; }
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            try
            {
                string ngayden = ngayNhan.Value.ToString("yyyyMMdd");
                string ngaytra = ngayTra.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                KetNoi.executeQuery("addCHITIETPHIEUNHAN '" + tbMaNhan.Text + "','" + cbMaPhong.Text + "',N'" + tbTen.Text + "','" + tbCMND.Text + "','" + ngayden + "','" + ngaytra + "'");
                KetNoi.executeQuery("insert into SDDV(MaSDDV,MaNhan,MaP,MaDV,NgaySD,SoLuong,GhiChu) values(dbo.AUTO_IDDV(),'" + tbMaNhan.Text + "','" + cbMaPhong.Text + "','SV00','" + ngayden + "','1', N'Hệ thống')");
            }
            catch(Exception)
            {
                MessageBox.Show("Sai thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            data.DataSource = KetNoi.gettable("select * from CHITIETPHIEUNHAN where MaNhan='"+tbMaNhan.Text+"'");
            
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
