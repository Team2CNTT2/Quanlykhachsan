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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dtgvKH.CurrentCell.RowIndex;
            tbMa.Text = dtgvKH.Rows[t].Cells[0].Value.ToString();
            tbTen.Text = dtgvKH.Rows[t].Cells[1].Value.ToString();
            tbCM.Text = dtgvKH.Rows[t].Cells[2].Value.ToString();
            tbGT.Text = dtgvKH.Rows[t].Cells[3].Value.ToString();
            tbSDT.Text = dtgvKH.Rows[t].Cells[4].Value.ToString();

        }
        //ham chi cho phep nhap so
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            tbTen.Text = "";
            tbMa.Text = "";
            tbCM.Text = "";
            tbSDT.Text = "";
            tbGT.Text = "";
            load();
        }
        public void load()
        {
            KetNoi.openketnoi();
            dtgvKH.DataSource = KetNoi.gettable("select * from KHACHHANG");
            tbGT.Items.Add("Nam");
            tbGT.Items.Add("Nữ");
            KetNoi.dongketnoi();
        }
        private int timkiem = 0;
        private int chon = 0;
        private void TtTen_TextChanged(object sender, EventArgs e)
        {
            timkiem = 1;
        }
        private void ttMa_TextChanged(object sender, EventArgs e)
        {
            timkiem = 0;
        }
        private void tbCM_TextChanged(object sender, EventArgs e)
        {
            timkiem = 2;
        }
        private void btReload_Click(object sender, EventArgs e)
        {
            tbTen.Text = "";
            tbMa.Text = "";
            tbCM.Text = "";
            tbSDT.Text = "";
            tbGT.Text = "";
            load();
        }

        private void btSea_Click(object sender, EventArgs e)
        {
            tbTen.Text = "";
            tbMa.Text = "";
            tbCM.Text = "";
            tbSDT.Text = "";
            tbGT.Text = "";
            chon = 0;
            btSea.BackColor = System.Drawing.Color.ForestGreen;
            btXoa.BackColor = btThem.BackColor = btSua.BackColor = System.Drawing.Color.Lime;
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            tbTen.Text = "";
            tbMa.Text = "";
            tbCM.Text = "";
            tbSDT.Text = "";
            tbGT.Text = "";
            chon = 3;
            btXoa.BackColor = System.Drawing.Color.ForestGreen;
            btSea.BackColor = btThem.BackColor = btSua.BackColor = System.Drawing.Color.Lime;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            tbMa.Text = KetNoi.read("select dbo.AUTO_IDKH() as ID");
            tbTen.Text = "";
            tbCM.Text = "";
            tbSDT.Text = "";
            tbGT.Text = "";
            chon = 1;
            btThem.BackColor = System.Drawing.Color.ForestGreen;
            btXoa.BackColor = btSea.BackColor = btSua.BackColor = System.Drawing.Color.Lime;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            chon = 2;
            tbMa.Enabled = false;
            btSua.BackColor = System.Drawing.Color.ForestGreen;
            btXoa.BackColor = btThem.BackColor = btSea.BackColor = System.Drawing.Color.Lime;
        }

        public string getMaKH
        {
            get { return tbMa.Text; }
        }
        private void btOK_Click(object sender, EventArgs e)
        {
                string check = tbMa.Text;
                KetNoi.openketnoi();
                dtgvKH.DataSource = KetNoi.gettable("select * from KHACHHANG where MaKH='" + check + "'");
                KetNoi.dongketnoi();
                if (check == "") return;
            try
            {
                if (dtgvKH.Rows[0].Cells[0].Value.ToString() == "") return; 
            }
            catch(Exception)
            {
                MessageBox.Show("Chưa có khách hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DatPhong dat = new DatPhong();
            dat.MaKH = getMaKH;
            dat.Show();
            this.Hide();
        }

        private void pnThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            KetNoi.openketnoi();
            switch(chon)
            {
                case 0:
                    string filter = "";
                    switch (timkiem)
                    {
                        case 0: filter = "seaMaKH " + tbMa.Text; break;
                        case 1: filter = "seaTenKH N'" + tbTen.Text + "'"; break;
                        case 2: filter = "seaCMND '" + tbCM.Text + "'"; break;
                    }
                    dtgvKH.DataSource = KetNoi.gettable(filter);
                    
                    break;
                case 1:
                    try
                    {
                        tbMa.Text = KetNoi.read("select dbo.AUTO_IDKH() as ID");
                        KetNoi.openketnoi();
                        KetNoi.executeQuery("addKHACHHANG '" + tbMa.Text + "',N'" + tbTen.Text + "','" + tbCM.Text + "',N'" + tbGT.Text + "','" + tbSDT.Text + "' ");
                        MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                        load();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nhập sai", "Thông báo", MessageBoxButtons.OK);
                    }
                    break;
                case 2:
                    try
                    {
                        KetNoi.executeQuery("update KHACHHANG set Ten = N'" + tbTen.Text + "',CMND='" + tbCM.Text + "',GioiTinh= N'" + tbGT.Text + "',SDT='" + tbSDT.Text + "' where MaKH = '" + tbMa.Text + "'");
                        load();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nhập sai", "Thông báo", MessageBoxButtons.OK);
                    }
                    break;
                case 3:
                    DialogResult = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (DialogResult == DialogResult.OK)
                    {
                        KetNoi.executeQuery("delete from KHACHHANG where MaKH='" + dtgvKH.Rows[dtgvKH.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                    }
                    load();
                    break;

            }

            KetNoi.dongketnoi();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            tbMa.Enabled = true;
            int t = dtgvKH.CurrentCell.RowIndex;
            tbMa.Text = dtgvKH.Rows[t].Cells[0].Value.ToString();
            tbTen.Text = dtgvKH.Rows[t].Cells[1].Value.ToString();
            tbCM.Text = dtgvKH.Rows[t].Cells[2].Value.ToString();
            tbGT.Text = dtgvKH.Rows[t].Cells[3].Value.ToString();
            tbSDT.Text = dtgvKH.Rows[t].Cells[4].Value.ToString();
            btSua.BackColor =  btXoa.BackColor = btThem.BackColor = btSea.BackColor = System.Drawing.Color.Lime;
        }
    }
}
