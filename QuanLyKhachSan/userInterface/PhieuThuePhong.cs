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
    public partial class PhieuThuePhong : Form
    {
        public PhieuThuePhong()
        {
            InitializeComponent();
        }
        public string MaP
        {
            set { tbMaPhong.Text = value; }
        }
        public string MaKH
        {
            set { tbMa.Text = value; }
        }
        public int flag = 0;
        //ham chi cho phep nhap so
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void PhieuThuePhong_Load(object sender, EventArgs e)
        {
            tbMaPhieu.Text = KetNoi.read("select dbo.AUTO_IDTP() as ID");
            tbMaPhieu.Enabled = false;
            if (tbMa.Text != "")
            {
                KetNoi.openketnoi();
                data.DataSource = KetNoi.gettable("select Ten from KHACHHANG where MaKH='" + tbMa.Text + "'");
                KetNoi.dongketnoi();
                tbTen.Text = data.Rows[0].Cells[0].Value.ToString();
            } 
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (tbMaPhieu.Text == "") return;
            try
            {
                string ngayden = ngayNhan.Value.ToString("yyyyMMdd");
                DateTime a = ngayNhan.Value;
                string ngaytra = ngayTra.Value.ToString("yyyyMMdd");
                DateTime b = ngayTra.Value;
                if (b < a) { MessageBox.Show("Sai ngày trả", "Thông báo", MessageBoxButtons.OK); return; }
                KetNoi.openketnoi();
                // string format = "yyyy-MM-dd";
                if (flag == 0)
                {
                    KetNoi.executeQuery("addPHIEUTHUE '" + tbMaPhieu.Text + "','" + tbMa.Text + "', '" + tbTien.Text + "'");
                    tbTen.Enabled = false;
                    flag++;
                }
                KetNoi.executeQuery("addCHITIETPHIEUTHUE '" + tbMaPhieu.Text + "','"+tbMaPhong.Text+"','"+ngayden+"','"+ngaytra+"'");
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //sau khi nhap xong ngay thi hiện ra bảng để nhân viên có hể xem minhf nhập có đúng hay không?
        private void ngayTra_Leave(object sender, EventArgs e)
        {
            string ngayden = ngayNhan.Value.ToString("yyyyMMdd");
            string ngaytra = ngayTra.Value.ToString("yyyyMMdd");
            KetNoi.openketnoi();
            data.DataSource = KetNoi.gettable("select Map,NgayDen,NgayDi from CHITIETPHIEUTHUE where trangthai = '1' and (('" + ngayden + "' between NgayDen and NgayDi) or ('" + ngaytra + "' between NgayDen and NgayDi)) and  MaP="+tbMaPhong.Text+"");
            data.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            data.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            KetNoi.dongketnoi();
            data.Visible = true;
            label7.Visible = true;
            label7.Text = tbMaPhong.Text;
        }

        private void tbMa_Click(object sender, EventArgs e)
        {

        }
    }
}
