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
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
        }

        private void ThongKecs_Load(object sender, EventArgs e)
        {
            dataPhong.Visible = false;
            dataNhanVien.Visible = false;
        }

        private void btDoanhSo_Click(object sender, EventArgs e)
        {
            dataPhong.Visible = true;
            dataNhanVien.Visible = false;
            groupBox1.Visible = false;
            KetNoi.openketnoi();
            dataPhong.DataSource = KetNoi.gettable("select MaP, NgayNhan, NgayTraThucTe, thoigian = DATEDIFF(day, NgayNhan, NgayTraThucTe), TongTien from CHITIETPHIEUNHAN as a,HOADON as b where a.MaNhan = b.MaNhan");
            KetNoi.dongketnoi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataPhong.Visible = false;
            dataNhanVien.Visible = true;
            groupBox1.Visible = true;
            KetNoi.openketnoi();
            dataNhanVien.DataSource = KetNoi.gettable("select a.MaNV,TenNV,SDT, ngaysinh, matkhau from NHANVIEN a,DANGNHAP b where a.MaNV=b.MaNV");
            KetNoi.dongketnoi();
        }

        private void dataNhanVien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        //ham chi cho phep nhap so
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private int flag = 0;
        //them
        private void button1_Click(object sender, EventArgs e)
        {
            flag = 1;
            ngaySinh.Visible = true;
            groupBox2.Visible = true;
            groupBox2.Text = "Thêm";
        }
        //sua
        private void button3_Click(object sender, EventArgs e)
        {
            flag = 2;
            ns.Visible = true;
            groupBox2.Visible = true;
            groupBox2.Text = "Sửa";
            int t = dataNhanVien.CurrentCell.RowIndex;
            tbMa.Text = dataNhanVien.Rows[t].Cells[0].Value.ToString();
            tbTen.Text = dataNhanVien.Rows[t].Cells[1].Value.ToString();
            ns.Text = dataNhanVien.Rows[t].Cells[2].Value.ToString();
            SDT.Text = dataNhanVien.Rows[t].Cells[3].Value.ToString();
            MK1.Text = dataNhanVien.Rows[t].Cells[4].Value.ToString();
            MK2.Text = dataNhanVien.Rows[t].Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KetNoi.openketnoi();
            int t = dataNhanVien.CurrentCell.RowIndex;
            KetNoi.executeQuery("delete from dangnhap where MaNV= '" + dataNhanVien.Rows[t].Cells[0].Value.ToString() + "'");
            dataNhanVien.DataSource = KetNoi.gettable("select a.MaNV,TenNV,SDT, ngaysinh, matkhau from NHANVIEN a,DANGNHAP b where a.MaNV=b.MaNV");
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if(flag==1)
            {
                if(MK1.Text==MK2.Text)
                {
                string ngaysinh = ngaySinh.Value.ToString("yyyyMMdd");
                KetNoi.openketnoi();
                KetNoi.executeQuery("addNHANVIEN '" + tbMa.Text + "',N'"+tbTen.Text +"','"+ngaysinh+ "','" + SDT.Text + "'");
                KetNoi.executeQuery("addDANGNHAP '" + tbMa.Text + "','" + MK1.Text + "'");
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("xác nhận mật khẩu lỗi", "Thông báo", MessageBoxButtons.OK);
            }
            if(flag==2)
            {
                if (MK1.Text == MK2.Text)
                {
                    string ngaysinh = ngaySinh.Value.ToString("yyyyMMdd");
                    KetNoi.openketnoi();
                    KetNoi.executeQuery("update NHANVIEN set TenNV=N'" + tbTen.Text + "', ngaysinh='" + ngaysinh + "',SDT='" + SDT.Text + "' where MaNV='"+tbMa.Text+"'");
                    KetNoi.executeQuery("update DANGNHAP '" + MK1.Text + "' where MaNV='" + tbMa.Text + "'");
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("xác nhận mật khẩu lỗi", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            ns.Visible = false;
            ngaySinh.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //select count(map) from CHITIETPHIEUNHAN	where GETDATE() between NgayNhan and NgayTraThucTe

    }
}
