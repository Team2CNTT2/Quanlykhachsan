using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Player;
using System.IO;

namespace QuanLyKhachSan.userInterface
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        public string MaP
        {
            set { tbMaP.Text = value; }
        }
        public DateTime NgayNhan
        {
            set { ngayNhan.Value = value; }
        }
        public DateTime NgayTra
        {
            set { ngayTra.Value = value; }
        }
        private static int Flag = 0;
        public string MaNhan;
        public string MaKH;
        private void HoaDon_Load(object sender, EventArgs e)
        {
            KetNoi.openketnoi();
            tbMaP.DataSource = KetNoi.gettable("select MaP from CHITIETPHIEUNHAN where MaNhan='" + MaNhan + "' and MaP not in (select MaP from CHITIETHOADON as a,HOADON as b where a.MaHD = b.MaHD and MaNhan='" + MaNhan + "') ");
            tbMaP.DisplayMember = "MaP";
            tbMaP.ValueMember = "MaP";
            KetNoi.dongketnoi();
        }
        private void load()
        {
            KetNoi.openketnoi();
            data.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            data.DataSource = KetNoi.gettable("hoadondv '" + MaNhan + "','" + tbMaP.Text.ToString().Substring(0, 3) + "'");
            dichvu.DataSource = KetNoi.gettable("select tien=DonGia*SoLuong,MaSDDV from sddv,DICHVU where SDDV.MaDV=DICHVU.MaDV and MaNhan='" + MaNhan + "' and MaP='" + tbMaP.Text + "'");
            dataGridView1.DataSource = KetNoi.gettable("select GiaTien from LOAIPHONG,PHONG where LOAIPHONG.MaLP=PHONG.MaLP and MaP='" + tbMaP.Text + "'");
            dataGridView2.DataSource = KetNoi.gettable("select NgayNhan,NgayTraDuKien from CHITIETPHIEUNHAN where MaNhan='" + MaNhan + "' and MaP='" + tbMaP.Text + "'");
            dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
            if (date.Length == 21) date = "0" + date;
            if (date.Length == 20) date = "0" + date.Substring(0, 2) + "0" + date.Substring(2);
            int ngay, thang, nam;
            thang = int.Parse(date.Substring(0, 2));
            ngay = int.Parse(date.Substring(3, 2));
            nam = int.Parse(date.Substring(6, 4));
            ngayNhan.Value = new DateTime(nam, thang, ngay);
            string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
            if (date2.Length == 20) date2 = "0" + date2.Substring(0, 2) + "0" + date2.Substring(2);
            if (date2.Length == 21) date2 = "0" + date2;
            ngay = int.Parse(date2.Substring(3, 2));
            thang = int.Parse(date2.Substring(0, 2));
            nam = int.Parse(date2.Substring(6, 4));
            ngayTra.Value = new DateTime(nam, thang, ngay);
            tinhtong();
            tienphong();
            thanhtien();
            KetNoi.dongketnoi();
        }
        private int tienphong()
        {
            DateTime a = DateTime.Now;
            TimeSpan d = a.Subtract(ngayNhan.Value);
            int day = (int)d.TotalDays;
            string gia = dataGridView1.Rows[0].Cells[0].Value.ToString();
            int tien = day * int.Parse(gia);
            tbTienPhong.Text = tien.ToString();
            return tien;
        }
        private int tinhtong()
        {
            int tongdv = 0;
            int i = 0;
            for (; i < dichvu.RowCount-1; i++)
            {
                string a = dichvu.Rows[i].Cells[0].Value.ToString();
                tongdv += int.Parse(a);
            }
            tienDV.Text = tongdv.ToString();
            return tongdv;
        }
        private int thanhtien()
        {
            int tong;
            int a = tinhtong();
            int b = tienphong();
            int c = int.Parse(tbGiamGia.Text);
            tong = a + b - c;
            TongTien.Text = "Tổng = " + tong.ToString() + "VND";
            return tong;
        }
        // button thanh toán
        private string mahd = KetNoi.read("select dbo.AUTO_IDHD() as ID");
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult =MessageBox.Show("Xác nhận thanh toán", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.OK)
                {
                try
                {
                    string makh = KetNoi.read("select id=makh from phieunhan where manhan='" + MaNhan + "'");
                KetNoi.openketnoi();
                KetNoi.executeQuery("update CHITIETPHIEUNHAN set NgayTraThucTe = GETDATE() where MaNhan='" + MaNhan + "'");
                DateTime a = DateTime.Now;
                    if (Flag == 0)
                    {
                        KetNoi.executeQuery("addHOADON '" + mahd + "','" + NguoiDung.nhanvien + "','" + makh + "','" + MaNhan + "','" + tinhtong() + "','" + tienphong() + "','" + tbGiamGia.Text + "','" + thanhtien() + "','" + a.ToString("yyyyMMdd") + "'");
                        Flag++;
                    }

                 int i = 0;
                
                for (; i < dichvu.RowCount; i++)
                {
                    KetNoi.executeQuery("addCHITIETHOADON '" + mahd + "','" + tbMaP.Text + "','"+ dichvu.Rows[i].Cells[1].Value.ToString() + "'");
                }
                KetNoi.executeQuery("update CHITIETPHIEUTHUE set trangthai = '0' where MaP = '" + tbMaP.Text + "' and  MaDat = (select MaDat from PHIEUNHAN where MaNhan = '" + MaNhan + "')");
                KetNoi.dongketnoi();
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                    PhieuHoaDon hd = new PhieuHoaDon();
                    hd.MaP = tbMaP.Text;
                    hd.TienPhong = tienphong().ToString();
                    hd.mahd = mahd;
                    hd.TongTien = TongTien.Text;
                    hd.Show();
            }
                    catch (Exception)
            {
                MessageBox.Show("Thao tác lỗi", "Thông báo", MessageBoxButtons.OK);
            }
        }
        }
        //button hủy
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
