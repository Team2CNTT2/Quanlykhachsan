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
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
        }
        //load tên dịch vụ lên combox
        private void DichVu_Load(object sender, EventArgs e)
        {

            KetNoi.openketnoi();
            tbTenDV.DataSource = KetNoi.gettable("select * from DICHVU");
            tbTenDV.DisplayMember = "TenDV";
            tbTenDV.ValueMember = "MaDV";
            KetNoi.dongketnoi();
        }

        private void tbTenKH_Enter(object sender, EventArgs e)
        {
            KetNoi.openketnoi();
            data.DataSource = KetNoi.gettable("seaPhong N'" + tbTenKH.Text + "'");
            KetNoi.dongketnoi();
            int i = 0;
            // nap vao list những giá trị của số phòng
            List<string> list = new List<string>();
            for (; i < data.RowCount - 1; i++)
            {
                list.Add(data.Rows[i].Cells[0].Value.ToString());
            }
            //lọc những phòng có số khác nhau
            List<string> khacnhau = list.Distinct().ToList();
            foreach (string value in khacnhau)
            {
                tbPhong.Items.Add(value);
            }
        }
        private void tbPhong_Leave(object sender, EventArgs e)
        {
            tbPhong.Items.Clear();
        }
        //ham chi cho phep nhap so
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            try
            {
                KetNoi.openketnoi();
                data.DataSource = KetNoi.gettable(" select MaNhan from CHITIETPHIEUNHAN where MaP = '" + tbPhong.Text + "' and('" + dateTimePicker1.Value.ToString("yyyyMMdd") + "' between NgayNhan and NgayTraDuKien)  ");
                if (data.Rows[0].Cells[0].Value != null)
                { data.Visible = true; }
                else
                { data.Visible = false; }
           
                string manhan = data.Rows[0].Cells[0].Value.ToString();
                KetNoi.executeQuery("addSDDV '" + manhan + "','"+ tbPhong.Text + "','"+tbTenDV.SelectedValue.ToString()+"','"+dateTimePicker1.Value.ToString("yyyyMMdd") +"','"+tbSoLuong.Text+ "', N'"+tbGhiChu.Text+ "'");
                data.DataSource = KetNoi.gettable(" xemDV '" + tbPhong.Text + "','" +manhan+"'");
                KetNoi.dongketnoi();
            }
            catch (Exception)
            {
                MessageBox.Show("Khách hàng không thuê phòng", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
