namespace QuanLyKhachSan.userInterface
{
    partial class KhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.btThongTin = new System.Windows.Forms.Button();
            this.pnThongTin = new System.Windows.Forms.Panel();
            this.tbGT = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.lbGT = new System.Windows.Forms.Label();
            this.btSea = new System.Windows.Forms.Button();
            this.btDatPhong = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbCM = new System.Windows.Forms.TextBox();
            this.ttSDT = new System.Windows.Forms.Label();
            this.ttCMND = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.dtgvKH = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // btThongTin
            // 
            this.btThongTin.BackColor = System.Drawing.Color.Aqua;
            this.btThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btThongTin.ForeColor = System.Drawing.Color.Red;
            this.btThongTin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btThongTin.Location = new System.Drawing.Point(12, 49);
            this.btThongTin.Name = "btThongTin";
            this.btThongTin.Size = new System.Drawing.Size(115, 99);
            this.btThongTin.TabIndex = 5;
            this.btThongTin.Text = "Thông tin khách hàng";
            this.btThongTin.UseVisualStyleBackColor = false;
            this.btThongTin.Click += new System.EventHandler(this.KhachHang_Load);
            // 
            // pnThongTin
            // 
            this.pnThongTin.BackColor = System.Drawing.Color.Aqua;
            this.pnThongTin.Controls.Add(this.tbGT);
            this.pnThongTin.Controls.Add(this.cancel);
            this.pnThongTin.Controls.Add(this.ok);
            this.pnThongTin.Controls.Add(this.lbGT);
            this.pnThongTin.Controls.Add(this.btSea);
            this.pnThongTin.Controls.Add(this.btDatPhong);
            this.pnThongTin.Controls.Add(this.btXoa);
            this.pnThongTin.Controls.Add(this.btSua);
            this.pnThongTin.Controls.Add(this.btThem);
            this.pnThongTin.Controls.Add(this.tbSDT);
            this.pnThongTin.Controls.Add(this.tbCM);
            this.pnThongTin.Controls.Add(this.ttSDT);
            this.pnThongTin.Controls.Add(this.ttCMND);
            this.pnThongTin.Controls.Add(this.label12);
            this.pnThongTin.Controls.Add(this.label11);
            this.pnThongTin.Controls.Add(this.tbMa);
            this.pnThongTin.Controls.Add(this.tbTen);
            this.pnThongTin.Controls.Add(this.dtgvKH);
            this.pnThongTin.Location = new System.Drawing.Point(144, 12);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(533, 407);
            this.pnThongTin.TabIndex = 12;
            this.pnThongTin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnThongTin_Paint);
            // 
            // tbGT
            // 
            this.tbGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbGT.FormattingEnabled = true;
            this.tbGT.Location = new System.Drawing.Point(170, 134);
            this.tbGT.Name = "tbGT";
            this.tbGT.Size = new System.Drawing.Size(170, 28);
            this.tbGT.TabIndex = 4;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(453, 179);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(77, 32);
            this.cancel.TabIndex = 21;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.White;
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Image = ((System.Drawing.Image)(resources.GetObject("ok.Image")));
            this.ok.Location = new System.Drawing.Point(374, 179);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(77, 32);
            this.ok.TabIndex = 20;
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // lbGT
            // 
            this.lbGT.AutoSize = true;
            this.lbGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbGT.ForeColor = System.Drawing.Color.Red;
            this.lbGT.Location = new System.Drawing.Point(76, 134);
            this.lbGT.Name = "lbGT";
            this.lbGT.Size = new System.Drawing.Size(83, 22);
            this.lbGT.TabIndex = 19;
            this.lbGT.Text = "Giới Tính";
            // 
            // btSea
            // 
            this.btSea.BackColor = System.Drawing.Color.Lime;
            this.btSea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSea.Location = new System.Drawing.Point(374, 28);
            this.btSea.Name = "btSea";
            this.btSea.Size = new System.Drawing.Size(156, 31);
            this.btSea.TabIndex = 17;
            this.btSea.Text = "Tìm";
            this.btSea.UseVisualStyleBackColor = false;
            this.btSea.Click += new System.EventHandler(this.btSea_Click);
            // 
            // btDatPhong
            // 
            this.btDatPhong.BackColor = System.Drawing.Color.Lime;
            this.btDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDatPhong.Location = new System.Drawing.Point(374, 148);
            this.btDatPhong.Name = "btDatPhong";
            this.btDatPhong.Size = new System.Drawing.Size(156, 32);
            this.btDatPhong.TabIndex = 14;
            this.btDatPhong.Text = "Đặt phòng";
            this.btDatPhong.UseVisualStyleBackColor = false;
            this.btDatPhong.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Lime;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(374, 118);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(156, 31);
            this.btXoa.TabIndex = 13;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Lime;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(374, 88);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(156, 31);
            this.btSua.TabIndex = 12;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Lime;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(374, 58);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(156, 31);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbSDT.Location = new System.Drawing.Point(170, 167);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(170, 27);
            this.tbSDT.TabIndex = 5;
            this.tbSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbCM
            // 
            this.tbCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbCM.Location = new System.Drawing.Point(170, 100);
            this.tbCM.Name = "tbCM";
            this.tbCM.Size = new System.Drawing.Size(170, 27);
            this.tbCM.TabIndex = 3;
            this.tbCM.TextChanged += new System.EventHandler(this.tbCM_TextChanged);
            this.tbCM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ttSDT
            // 
            this.ttSDT.AutoSize = true;
            this.ttSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ttSDT.ForeColor = System.Drawing.Color.Red;
            this.ttSDT.Location = new System.Drawing.Point(44, 167);
            this.ttSDT.Name = "ttSDT";
            this.ttSDT.Size = new System.Drawing.Size(115, 22);
            this.ttSDT.TabIndex = 6;
            this.ttSDT.Text = "Số điện thoại";
            // 
            // ttCMND
            // 
            this.ttCMND.AutoSize = true;
            this.ttCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.ttCMND.ForeColor = System.Drawing.Color.Red;
            this.ttCMND.Location = new System.Drawing.Point(96, 103);
            this.ttCMND.Name = "ttCMND";
            this.ttCMND.Size = new System.Drawing.Size(63, 22);
            this.ttCMND.TabIndex = 5;
            this.ttCMND.Text = "CMND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(96, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 22);
            this.label12.TabIndex = 4;
            this.label12.Text = "Mã KH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(20, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 22);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tên khách hàng";
            // 
            // tbMa
            // 
            this.tbMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbMa.Location = new System.Drawing.Point(170, 34);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(170, 27);
            this.tbMa.TabIndex = 1;
            this.tbMa.TextChanged += new System.EventHandler(this.ttMa_TextChanged);
            // 
            // tbTen
            // 
            this.tbTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tbTen.Location = new System.Drawing.Point(170, 67);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(170, 27);
            this.tbTen.TabIndex = 2;
            this.tbTen.TextChanged += new System.EventHandler(this.TtTen_TextChanged);
            this.tbTen.Enter += new System.EventHandler(this.TtTen_TextChanged);
            // 
            // dtgvKH
            // 
            this.dtgvKH.AllowUserToAddRows = false;
            this.dtgvKH.AllowUserToDeleteRows = false;
            this.dtgvKH.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.HoTen,
            this.CMND,
            this.SDT,
            this.GioiTinh});
            this.dtgvKH.Location = new System.Drawing.Point(0, 234);
            this.dtgvKH.Name = "dtgvKH";
            this.dtgvKH.ReadOnly = true;
            this.dtgvKH.RowHeadersVisible = false;
            this.dtgvKH.Size = new System.Drawing.Size(533, 173);
            this.dtgvKH.TabIndex = 0;
            this.dtgvKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 65;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "Ten";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 120;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số ĐT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 110;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GT";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyKhachSan.Properties.Resources._123123;
            this.ClientSize = new System.Drawing.Size(678, 418);
            this.Controls.Add(this.pnThongTin);
            this.Controls.Add(this.btThongTin);
            this.MaximizeBox = false;
            this.Name = "KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.pnThongTin.ResumeLayout(false);
            this.pnThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btThongTin;
        private System.Windows.Forms.Panel pnThongTin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.DataGridView dtgvKH;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbCM;
        private System.Windows.Forms.Label ttSDT;
        private System.Windows.Forms.Label ttCMND;
        private System.Windows.Forms.Button btDatPhong;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSea;
        private System.Windows.Forms.Label lbGT;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.ComboBox tbGT;
    }
}