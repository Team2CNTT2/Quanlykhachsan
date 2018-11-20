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
using System.Data.SqlClient;
using System.IO;

namespace QuanLyKhachSan.userInterface
{
    public partial class DatPhong : Form
    {
        public DatPhong()
        {
            InitializeComponent();
        }
        private void DatPhong_Load(object sender, EventArgs e)
        {
            if (tbMa.Text == "") tbMa.ReadOnly = false;
            check();
        }
        public string MaKH
        {
            set { tbMa.Text = value; }
        }
        public void check2(string ma)
        {
            int a;
             Int32.TryParse(ma,out a);
            switch (a)
            {
                case 101:
                    bt101.BackColor = System.Drawing.Color.Red; break;
                case 102:
                    bt102.BackColor = System.Drawing.Color.Red; break;
                case 103:
                    bt103.BackColor = System.Drawing.Color.Red; break;
                case 104:
                    bt104.BackColor = System.Drawing.Color.Red; break;
                case 105:
                    bt105.BackColor = System.Drawing.Color.Red; break;
                case 106:
                    bt106.BackColor = System.Drawing.Color.Red; break;
                case 107:
                    bt107.BackColor = System.Drawing.Color.Red; break;
                case 108:
                    bt108.BackColor = System.Drawing.Color.Red; break;
                case 109:
                    bt109.BackColor = System.Drawing.Color.Red; break;
                case 110:
                    bt110.BackColor = System.Drawing.Color.Red; break;
                case 111:
                    bt111.BackColor = System.Drawing.Color.Red; break;
                case 112:
                    bt112.BackColor = System.Drawing.Color.Red; break;
                case 201:
                    bt201.BackColor = System.Drawing.Color.Red; break;
                case 202:
                    bt202.BackColor = System.Drawing.Color.Red; break;
                case 203:
                    bt203.BackColor = System.Drawing.Color.Red; break;
                case 204:
                    bt204.BackColor = System.Drawing.Color.Red; break;
                case 205:
                    bt205.BackColor = System.Drawing.Color.Red; break;
                case 206:
                    bt206.BackColor = System.Drawing.Color.Red; break;
                case 207:
                    bt207.BackColor = System.Drawing.Color.Red; break;
                case 208:
                    bt208.BackColor = System.Drawing.Color.Red; break;
                case 209:
                    bt209.BackColor = System.Drawing.Color.Red; break;
                case 301:
                    bt301.BackColor = System.Drawing.Color.Red; break;
                case 302:
                    bt302.BackColor = System.Drawing.Color.Red; break;
                case 303:
                    bt303.BackColor = System.Drawing.Color.Red; break;
                case 304:
                    bt304.BackColor = System.Drawing.Color.Red; break;
                case 305:
                    bt305.BackColor = System.Drawing.Color.Red; break;
                case 306:
                    bt306.BackColor = System.Drawing.Color.Red; break;
                case 307:
                    bt307.BackColor = System.Drawing.Color.Red; break;
                case 308:
                    bt308.BackColor = System.Drawing.Color.Red; break;
                default:
                    break;
            } 
        }
        public void check()
        {
            string ngay = dateTime.Value.ToString("yyyyMMdd");
            KetNoi.openketnoi();
            datagv.DataSource = KetNoi.gettable("select MaP from CHITIETPHIEUTHUE where trangthai = '1' and '" + ngay + "' between NgayDen and NgayDi");
            KetNoi.dongketnoi();
            int i = 0;
            for (; i < datagv.RowCount - 1; i++)
            {
                    check2(datagv.Rows[i].Cells[0].Value.ToString()); 
            }
        }

        private void bt101_Click(object sender, EventArgs e)
        {
            if (bt101.BackColor == System.Drawing.Color.Lime)
                PhieuThue("101");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt102_Click(object sender, EventArgs e)
        {
            if (bt102.BackColor == System.Drawing.Color.Lime)
                PhieuThue("102");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt103_Click(object sender, EventArgs e)
        {
            if (bt103.BackColor == System.Drawing.Color.Lime)
                PhieuThue("103");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt104_Click(object sender, EventArgs e)
        {
            if (bt104.BackColor == System.Drawing.Color.Lime)
                PhieuThue("104");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt105_Click(object sender, EventArgs e)
        {
            if (bt105.BackColor == System.Drawing.Color.Lime)
                PhieuThue("105");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt106_Click(object sender, EventArgs e)
        {
            if (bt106.BackColor == System.Drawing.Color.Lime)
                PhieuThue("106");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt107_Click(object sender, EventArgs e)
        {
            if (bt107.BackColor == System.Drawing.Color.Lime)
                PhieuThue("107");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt108_Click(object sender, EventArgs e)
        {
            if (bt108.BackColor == System.Drawing.Color.Lime)
                PhieuThue("108");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt109_Click(object sender, EventArgs e)
        {
            if (bt109.BackColor == System.Drawing.Color.Lime)
                PhieuThue("109");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt110_Click(object sender, EventArgs e)
        {
            if (bt110.BackColor == System.Drawing.Color.Lime)
                PhieuThue("110");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt111_Click(object sender, EventArgs e)
        {
            if (bt111.BackColor == System.Drawing.Color.Lime)
                PhieuThue("111");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt112_Click(object sender, EventArgs e)
        {
            if (bt112.BackColor == System.Drawing.Color.Lime)
                PhieuThue("112");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt201_Click(object sender, EventArgs e)
        {
            if (bt201.BackColor == System.Drawing.Color.Lime)
                PhieuThue("201");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt202_Click(object sender, EventArgs e)
        {
            if (bt202.BackColor == System.Drawing.Color.Lime)
                PhieuThue("202");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt203_Click(object sender, EventArgs e)
        {
            if (bt203.BackColor == System.Drawing.Color.Lime)
                PhieuThue("203");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt204_Click(object sender, EventArgs e)
        {
            if (bt204.BackColor == System.Drawing.Color.Lime)
                PhieuThue("204");
            else {co=1; groupBox1.Visible = true;}
        }

        private void bt205_Click(object sender, EventArgs e)
        {
            if (bt205.BackColor == System.Drawing.Color.Lime)
                PhieuThue("205");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt206_Click(object sender, EventArgs e)
        {
            if (bt206.BackColor == System.Drawing.Color.Lime)
                PhieuThue("206");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt207_Click(object sender, EventArgs e)
        {
            if (bt207.BackColor == System.Drawing.Color.Lime)
                PhieuThue("207");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt208_Click(object sender, EventArgs e)
        {
            if (bt208.BackColor == System.Drawing.Color.Lime)
                PhieuThue("208");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt209_Click(object sender, EventArgs e)
        {
            if (bt209.BackColor == System.Drawing.Color.Lime)
                PhieuThue("209");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt301_Click(object sender, EventArgs e)
        {
            if (bt301.BackColor == System.Drawing.Color.Lime)
                PhieuThue("301");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt302_Click(object sender, EventArgs e)
        {
            if (bt302.BackColor == System.Drawing.Color.Lime)
                PhieuThue("302");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt303_Click(object sender, EventArgs e)
        {
            if (bt303.BackColor == System.Drawing.Color.Lime)
                PhieuThue("303");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt304_Click(object sender, EventArgs e)
        {
            if (bt304.BackColor == System.Drawing.Color.Lime)
                PhieuThue("304");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt305_Click(object sender, EventArgs e)
        {
            if (bt305.BackColor == System.Drawing.Color.Lime)
                PhieuThue("305");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt306_Click(object sender, EventArgs e)
        {
            if (bt306.BackColor == System.Drawing.Color.Lime)
                PhieuThue("306");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt307_Click(object sender, EventArgs e)
        {
            if (bt307.BackColor == System.Drawing.Color.Lime)
                PhieuThue("307");
            else {co=1; groupBox1.Visible = true;}
        }
        private void bt308_Click(object sender, EventArgs e)
        {
            if (bt308.BackColor == System.Drawing.Color.Lime)
                PhieuThue("308");
            else {co=1; groupBox1.Visible = true;}
        }
        public void PhieuThue(string MaP)
        {
            if (tbMa.Text == "") return;
            KetNoi.openketnoi();
            string na = KetNoi.read("select ID=Ten from KHACHHANG where MaKH='" + tbMa.Text + "'");
            if (na == "") return;
            PhieuThuePhong phieu = new PhieuThuePhong();
            phieu.MaP = MaP;
            phieu.MaKH = tbMa.Text;
            phieu.Show();
        }
        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            bt101.BackColor = System.Drawing.Color.Lime;
            bt102.BackColor = System.Drawing.Color.Lime;
            bt103.BackColor = System.Drawing.Color.Lime;
            bt104.BackColor = System.Drawing.Color.Lime;
            bt105.BackColor = System.Drawing.Color.Lime;
            bt106.BackColor = System.Drawing.Color.Lime;
            bt107.BackColor = System.Drawing.Color.Lime;
            bt108.BackColor = System.Drawing.Color.Lime;
            bt109.BackColor = System.Drawing.Color.Lime;
            bt110.BackColor = System.Drawing.Color.Lime;
            bt111.BackColor = System.Drawing.Color.Lime;
            bt112.BackColor = System.Drawing.Color.Lime;
            bt201.BackColor = System.Drawing.Color.Lime;
            bt202.BackColor = System.Drawing.Color.Lime;
            bt203.BackColor = System.Drawing.Color.Lime;
            bt204.BackColor = System.Drawing.Color.Lime;
            bt205.BackColor = System.Drawing.Color.Lime;
            bt206.BackColor = System.Drawing.Color.Lime;
            bt207.BackColor = System.Drawing.Color.Lime;
            bt208.BackColor = System.Drawing.Color.Lime;
            bt209.BackColor = System.Drawing.Color.Lime;
            bt301.BackColor = System.Drawing.Color.Lime;
            bt302.BackColor = System.Drawing.Color.Lime;
            bt303.BackColor = System.Drawing.Color.Lime;
            bt304.BackColor = System.Drawing.Color.Lime;
            bt305.BackColor = System.Drawing.Color.Lime;
            bt306.BackColor = System.Drawing.Color.Lime;
            bt307.BackColor = System.Drawing.Color.Lime;
            bt308.BackColor = System.Drawing.Color.Lime;
            check();
        }
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DichVu dv = new DichVu();
            dv.Show();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatPhong dp = new DatPhong();
            dp.Show();
        }

        private void nhậnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanPhong np = new NhanPhong();
            np.Show();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void sT02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Standard sd = new Standard();
            sd.Show();
        }

        private void superiorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Superior sp = new Superior();
            sp.Show();
        }

        private void deluxeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deluxe de = new Deluxe();
            de.Show();
        }
        private int co = 0;
        private void bt101_MouseHover(object sender, EventArgs e)
        {
            if (bt101.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "101";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='101' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt101_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt102_MouseHover(object sender, EventArgs e)
        {
            if (bt102.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "102";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='102' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt102_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt103_MouseHover(object sender, EventArgs e)
        {
            if (bt103.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "103";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='103' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt103_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt104_MouseHover(object sender, EventArgs e)
        {
            if (bt104.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "104";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='104' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt104_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt105_MouseHover(object sender, EventArgs e)
        {
            if (bt105.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "105";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='105' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt105_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt106_MouseHover(object sender, EventArgs e)
        {
            if (bt106.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "106";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='106' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt106_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt107_MouseHover(object sender, EventArgs e)
        {
            if (bt107.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "107";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='107' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt107_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt108_MouseHover(object sender, EventArgs e)
        {
            if (bt108.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "108";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='108' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt108_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt109_MouseHover(object sender, EventArgs e)
        {
            if (bt109.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "109";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='109' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt109_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt110_MouseHover(object sender, EventArgs e)
        {
            if (bt110.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "110";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='110' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt110_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt111_MouseHover(object sender, EventArgs e)
        {
            if (bt111.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "111";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='111' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt111_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt112_MouseHover(object sender, EventArgs e)
        {
            if (bt112.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "112";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='112' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt112_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt201_MouseHover(object sender, EventArgs e)
        {
            if (bt201.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "201";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='201' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt201_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt202_MouseHover(object sender, EventArgs e)
        {
            if (bt202.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "202";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='202' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt202_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt203_MouseHover(object sender, EventArgs e)
        {
            if (bt203.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "203";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='203' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt203_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt204_MouseHover(object sender, EventArgs e)
        {
            if (bt204.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "204";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='204' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt204_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt205_MouseHover(object sender, EventArgs e)
        {
            if (bt205.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "205";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='205' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt205_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt206_MouseHover(object sender, EventArgs e)
        {
            if (bt206.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "206";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='206' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt206_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt207_MouseHover(object sender, EventArgs e)
        {
            if (bt207.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "207";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='207' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt207_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt208_MouseHover(object sender, EventArgs e)
        {
            if (bt208.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "208";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='208' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt208_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt209_MouseHover(object sender, EventArgs e)
        {
            if (bt209.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "209";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='209' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt209_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt301_MouseHover(object sender, EventArgs e)
        {
            if (bt301.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "301";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='301' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt301_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt302_MouseHover(object sender, EventArgs e)
        {
            if (bt302.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "302";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='302' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt302_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt303_MouseHover(object sender, EventArgs e)
        {
            if (bt303.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "303";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='303' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt303_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt304_MouseHover(object sender, EventArgs e)
        {
            if (bt304.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "304";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='304' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt304_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt305_MouseHover(object sender, EventArgs e)
        {
            if (bt305.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "305";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='305' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt305_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt306_MouseHover(object sender, EventArgs e)
        {
            if (bt306.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "306";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='306' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt306_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt307_MouseHover(object sender, EventArgs e)
        {
            if (bt307.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
                groupBox1.Text = "307";
                string ngay1 = dateTime.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='307' and '" + ngay1 + "' between NgayDen and NgayDi");
                KetNoi.openketnoi();
                string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
                KetNoi.openketnoi();
                dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
                dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
                string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
                label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
            }
        }
        private void bt307_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }
        private void bt308_MouseHover(object sender, EventArgs e)
        {
            if (bt308.BackColor == System.Drawing.Color.Red)
            {
                groupBox1.Visible = true;
            groupBox1.Text = "308";
            string ngay1 = dateTime.Value.ToString("yyyyMMdd");
            KetNoi.openketnoi();
            string mathue = KetNoi.read("select ID=MaDat from CHITIETPHIEUTHUE where MaP='308' and '" + ngay1 + "' between NgayDen and NgayDi");
            KetNoi.openketnoi();
            string ten = KetNoi.read("select ID=Ten from KHACHHANG,PHIEUTHUE where KHACHHANG.MaKH = PHIEUTHUE.MaKH and MaDat='" + mathue + "'");
            KetNoi.openketnoi();
            dataGridView2.DataSource = KetNoi.gettable("select NgayDen,NgayDi from CHITIETPHIEUTHUE where MaDat='" + mathue + "'");
            dataGridView2.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView2.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            string date = dataGridView2.Rows[0].Cells[0].Value.ToString();
            string date2 = dataGridView2.Rows[0].Cells[1].Value.ToString();
            label1.Text = "Khách hàng: " + ten + "\n" + "Thời gian \n" + date + " \n" + date2;
        }
            }
        private void bt308_MouseLeave(object sender, EventArgs e)
        {
            if(co==0) groupBox1.Visible = false;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            KetNoi.openketnoi();
            string ngay1 = dateTime.Value.ToString("yyyyMMdd");
            KetNoi.executeQuery("delete from chitietphieuthue where MaP='" + groupBox1.Text + "' and '" + ngay1 + "' between NgayDen and NgayDi");
        }
    }
}
