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
    public partial class TraPhong : Form
    {
        public TraPhong()
        {
            InitializeComponent();
        }

        // load tat ca thong tin thue phong ma ngay tra phong sau ngay hom nay


        private void dataThuePhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dataThuePhong.CurrentCell.RowIndex;
            cbPhong.Text = dataThuePhong.Rows[t].Cells[0].Value.ToString();
            tbMaNhan.Text = dataThuePhong.Rows[t].Cells[1].Value.ToString();
            tbKhachHang.Text = dataThuePhong.Rows[t].Cells[4].Value.ToString();
        }

        private void Phong_Load(object sender, EventArgs e)
        {
            KetNoi.openketnoi();
            dataThuePhong.DataSource = KetNoi.gettable("select MaP,MaNhan,NgayNhan,NgayTraDuKien,Hoten from CHITIETPHIEUNHAN where dbo.xacnhan(MaNhan,MaP)='0' and getdate() between NgayNhan and NgayTraDuKien  ");
            dataThuePhong.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataThuePhong.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            cbPhong.DataSource = KetNoi.gettable("select MaP,MaNhan,NgayNhan,NgayTraDuKien,Hoten from CHITIETPHIEUNHAN where dbo.xacnhan(MaNhan,MaP)='0' and getdate() between NgayNhan and NgayTraDuKien");
            cbPhong.DisplayMember = "MaP";
            KetNoi.dongketnoi();
        }


        private void btTraPhong_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.MaNhan = tbMaNhan.Text;
            hd.MaP = cbPhong.Text;
            hd.MaKH = tbKhachHang.Text;
            hd.NgayNhan = ngayNhan.Value;
            hd.NgayTra = ngayTra.Value;
            hd.ShowDialog();
        }

        private void cbPhong_Leave(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)this.dataThuePhong.DataSource;
            DataView view = new DataView(dt);
            view.RowFilter = "MaP like '%" + cbPhong.Text + "%'";
            dataThuePhong.DataSource = view;
        }

        private void tbMaNhan_Leave(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)this.dataThuePhong.DataSource;
            DataView view = new DataView(dt);
            view.RowFilter = "MaNhan like '%" + tbMaNhan.Text + "%'";
            dataThuePhong.DataSource = view;
        }

        private void pnPhong_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
