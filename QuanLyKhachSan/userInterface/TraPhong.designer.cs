namespace QuanLyKhachSan.userInterface
{
    partial class TraPhong
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
            this.pnPhong = new System.Windows.Forms.Panel();
            this.ngayTra = new System.Windows.Forms.DateTimePicker();
            this.tbMaNhan = new System.Windows.Forms.TextBox();
            this.ngayNhan = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btTraPhong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.tbKhachHang = new System.Windows.Forms.TextBox();
            this.dataThuePhong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataThuePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPhong
            // 
            this.pnPhong.BackColor = System.Drawing.Color.Aqua;
            this.pnPhong.Controls.Add(this.ngayTra);
            this.pnPhong.Controls.Add(this.tbMaNhan);
            this.pnPhong.Controls.Add(this.ngayNhan);
            this.pnPhong.Controls.Add(this.label3);
            this.pnPhong.Controls.Add(this.btTraPhong);
            this.pnPhong.Controls.Add(this.label2);
            this.pnPhong.Controls.Add(this.label1);
            this.pnPhong.Controls.Add(this.cbPhong);
            this.pnPhong.Controls.Add(this.tbKhachHang);
            this.pnPhong.Controls.Add(this.dataThuePhong);
            this.pnPhong.Location = new System.Drawing.Point(1, 0);
            this.pnPhong.Name = "pnPhong";
            this.pnPhong.Size = new System.Drawing.Size(658, 406);
            this.pnPhong.TabIndex = 16;
            this.pnPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPhong_Paint);
            // 
            // ngayTra
            // 
            this.ngayTra.CustomFormat = "dd/MM/yyyy";
            this.ngayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ngayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayTra.Location = new System.Drawing.Point(620, 157);
            this.ngayTra.Name = "ngayTra";
            this.ngayTra.Size = new System.Drawing.Size(10, 30);
            this.ngayTra.TabIndex = 28;
            this.ngayTra.Visible = false;
            // 
            // tbMaNhan
            // 
            this.tbMaNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNhan.Location = new System.Drawing.Point(122, 34);
            this.tbMaNhan.Name = "tbMaNhan";
            this.tbMaNhan.Size = new System.Drawing.Size(164, 24);
            this.tbMaNhan.TabIndex = 7;
            this.tbMaNhan.Leave += new System.EventHandler(this.tbMaNhan_Leave);
            // 
            // ngayNhan
            // 
            this.ngayNhan.CustomFormat = "dd/MM/yyyy";
            this.ngayNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ngayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayNhan.Location = new System.Drawing.Point(636, 157);
            this.ngayNhan.Name = "ngayNhan";
            this.ngayNhan.Size = new System.Drawing.Size(10, 30);
            this.ngayNhan.TabIndex = 27;
            this.ngayNhan.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(37, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã nhận";
            // 
            // btTraPhong
            // 
            this.btTraPhong.BackColor = System.Drawing.Color.Lime;
            this.btTraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraPhong.Location = new System.Drawing.Point(356, 56);
            this.btTraPhong.Name = "btTraPhong";
            this.btTraPhong.Size = new System.Drawing.Size(135, 71);
            this.btTraPhong.TabIndex = 5;
            this.btTraPhong.Text = "Trả phòng";
            this.btTraPhong.UseVisualStyleBackColor = false;
            this.btTraPhong.Click += new System.EventHandler(this.btTraPhong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(54, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(10, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khách hàng";
            // 
            // cbPhong
            // 
            this.cbPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(122, 130);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(121, 26);
            this.cbPhong.TabIndex = 2;
            this.cbPhong.Leave += new System.EventHandler(this.cbPhong_Leave);
            // 
            // tbKhachHang
            // 
            this.tbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKhachHang.Location = new System.Drawing.Point(122, 81);
            this.tbKhachHang.Name = "tbKhachHang";
            this.tbKhachHang.Size = new System.Drawing.Size(164, 24);
            this.tbKhachHang.TabIndex = 1;
            // 
            // dataThuePhong
            // 
            this.dataThuePhong.AllowUserToAddRows = false;
            this.dataThuePhong.AllowUserToDeleteRows = false;
            this.dataThuePhong.BackgroundColor = System.Drawing.Color.White;
            this.dataThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataThuePhong.Location = new System.Drawing.Point(0, 193);
            this.dataThuePhong.Name = "dataThuePhong";
            this.dataThuePhong.ReadOnly = true;
            this.dataThuePhong.RowHeadersVisible = false;
            this.dataThuePhong.Size = new System.Drawing.Size(658, 213);
            this.dataThuePhong.TabIndex = 0;
            this.dataThuePhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataThuePhong_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaP";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Phòng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaNhan";
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Ma Nhan";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayNhan";
            this.Column2.HeaderText = "Ngày đến";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayTraDuKien";
            this.Column3.HeaderText = "Ngày đi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "HoTen";
            this.Column4.HeaderText = "Tên khách hàng";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyKhachSan.Properties.Resources._123123;
            this.ClientSize = new System.Drawing.Size(659, 406);
            this.Controls.Add(this.pnPhong);
            this.MaximizeBox = false;
            this.Name = "TraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phong";
            this.Load += new System.EventHandler(this.Phong_Load);
            this.MouseEnter += new System.EventHandler(this.Phong_Load);
            this.pnPhong.ResumeLayout(false);
            this.pnPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataThuePhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnPhong;
        private System.Windows.Forms.Button btTraPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.TextBox tbKhachHang;
        private System.Windows.Forms.DataGridView dataThuePhong;
        private System.Windows.Forms.TextBox tbMaNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker ngayTra;
        private System.Windows.Forms.DateTimePicker ngayNhan;
    }
}