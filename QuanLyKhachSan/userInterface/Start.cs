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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            //if (!Program.IsRunningAsAdministrator())
            //{
            //    this.Close();
            //}
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void DangNhap()
        {
            
        }
        private void button_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lo = new login();
            lo.ShowDialog();
            this.Close();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
