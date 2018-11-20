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
    public partial class NhanPhong : Form
    {
        public NhanPhong()
        {
            InitializeComponent();
        }
        private int chon = 0;
        private void NhanPhong_Load(object sender, EventArgs e)
        {
            KetNoi.openketnoi();
            data.DataSource = KetNoi.gettable("LayPhong");
            KetNoi.dongketnoi();
        }

        //ham chi cho phep nhap so
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void bntTim_Click(object sender, EventArgs e)
        {
            if (data.DataSource != null)
            {
                //lọc dtgv ko cần nạp lại dữ liệu 
                KetNoi.openketnoi();
                DataTable dt = (DataTable)this.data.DataSource;
                DataView view = new DataView(dt);
                switch (chon)
                {
                    case 0:

                        view.RowFilter = "MaDat like '%" + tbDatPhong.Text + "%'";
                        data.DataSource = view;
                        break;
                    case 1:
                        // loc theo câu lệnh sql
                        data.DataSource = KetNoi.gettable("TimPhong "+tbTenKH.Text);
                        break;
                    case 2:
                        data.DataSource = KetNoi.gettable("TimPhong2 '" + tbSDT.Text+"'");
                        break;

                }
                KetNoi.dongketnoi();
            }
        }
        private void tbPhong_TextChanged(object sender, EventArgs e)
        {
            tbTenKH.Text = "";
            tbSDT.Text = "";
          
            chon = 0;
        }

        private void tbTenKH_TextChanged(object sender, EventArgs e)
        {
            tbDatPhong.Text = "";
            tbSDT.Text = "";
            chon = 1;
        }

        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            tbDatPhong.Text = "";
            tbTenKH.Text = "";
            chon = 2;
        }
        private void data_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = data.CurrentCell.RowIndex;
            KetNoi.openketnoi();
            string manhan = KetNoi.read("select dbo.AUTO_IDNP() as ID");
            string mes = "Mã nhận phòng: " + manhan + "\nMã đặt phòng: " + data.Rows[t].Cells[0].Value.ToString()+"\nTên khách hàng: "+KetNoi.read("select ID=Ten from KHACHHANG where MaKH='" + data.Rows[t].Cells[2].Value.ToString() +"'");
            DialogResult = MessageBox.Show(mes, "Xác nhận", MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.OK)
            {
                KetNoi.dongketnoi();
                KetNoi.openketnoi();
                KetNoi.executeQuery("addPHIEUNHAN '"+manhan+"','" + data.Rows[t].Cells[0].Value.ToString() + "','"+ data.Rows[t].Cells[2].Value.ToString() + "'");
                int h = data.CurrentCell.RowIndex;
                //cat chuoi
                string date = data.Rows[h].Cells[4].Value.ToString();
                if (date.Length == 21) date = "0" + date;
                if (date.Length == 20) date = "0" + date.Substring(0, 2) + "0" + date.Substring(2);
                int ngay, thang, nam;
                thang = int.Parse(date.Substring(0, 2));
                ngay = int.Parse(date.Substring(3, 2));
                nam = int.Parse(date.Substring(6, 4));
                LayPhong lp = new LayPhong();
                lp.MaNhan = manhan;
                lp.NgayTra = new DateTime(nam, thang, ngay);
                lp.Show();
            }
           
        }
    }
}
