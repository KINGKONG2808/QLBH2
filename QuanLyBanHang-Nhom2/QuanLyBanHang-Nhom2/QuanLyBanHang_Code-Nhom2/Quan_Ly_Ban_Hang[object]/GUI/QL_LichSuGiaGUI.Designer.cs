namespace QL_BanHang.GUI
{
    partial class QL_LichSuGiaGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_LichSuGiaGUI));
            this.label6 = new System.Windows.Forms.Label();
            this.ngaycapnhat = new System.Windows.Forms.DateTimePicker();
            this.cbmahang = new System.Windows.Forms.ComboBox();
            this.txtdg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvlichsugia = new System.Windows.Forms.DataGridView();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCapNhat1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateKetThuc = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaNCCSearch = new System.Windows.Forms.TextBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbMaNcc = new System.Windows.Forms.RadioButton();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlichsugia)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "(vui lòng nhập ngày theo đúng định dạng dd/mm/yyyy)";
            // 
            // ngaycapnhat
            // 
            this.ngaycapnhat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaycapnhat.Location = new System.Drawing.Point(120, 172);
            this.ngaycapnhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ngaycapnhat.Name = "ngaycapnhat";
            this.ngaycapnhat.Size = new System.Drawing.Size(457, 22);
            this.ngaycapnhat.TabIndex = 11;
            // 
            // cbmahang
            // 
            this.cbmahang.FormattingEnabled = true;
            this.cbmahang.Location = new System.Drawing.Point(119, 27);
            this.cbmahang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmahang.Name = "cbmahang";
            this.cbmahang.Size = new System.Drawing.Size(459, 24);
            this.cbmahang.TabIndex = 10;
            // 
            // txtdg
            // 
            this.txtdg.Location = new System.Drawing.Point(119, 135);
            this.txtdg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdg.Name = "txtdg";
            this.txtdg.Size = new System.Drawing.Size(459, 22);
            this.txtdg.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày cập nhật:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá:";
            // 
            // dgvlichsugia
            // 
            this.dgvlichsugia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlichsugia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.TenHang,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.DonGia,
            this.NgayCapNhat1});
            this.dgvlichsugia.Location = new System.Drawing.Point(35, 23);
            this.dgvlichsugia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvlichsugia.Name = "dgvlichsugia";
            this.dgvlichsugia.RowHeadersWidth = 51;
            this.dgvlichsugia.Size = new System.Drawing.Size(772, 309);
            this.dgvlichsugia.TabIndex = 0;
            this.dgvlichsugia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlichsugia_CellClick);
            // 
            // MaHH
            // 
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Mã Hàng Hóa";
            this.MaHH.MinimumWidth = 6;
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 125;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên Hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 125;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.NgayBatDau.MinimumWidth = 6;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Width = 125;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // NgayCapNhat1
            // 
            this.NgayCapNhat1.DataPropertyName = "NgayCapNhat";
            this.NgayCapNhat1.HeaderText = "Ngày Cập Nhật";
            this.NgayCapNhat1.MinimumWidth = 6;
            this.NgayCapNhat1.Name = "NgayCapNhat1";
            this.NgayCapNhat1.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvlichsugia);
            this.groupBox2.Location = new System.Drawing.Point(9, 270);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(851, 341);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "dữ liệu lịch sử giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateBatDau);
            this.groupBox1.Controls.Add(this.dateKetThuc);
            this.groupBox1.Controls.Add(this.ngaycapnhat);
            this.groupBox1.Controls.Add(this.cbmahang);
            this.groupBox1.Controls.Add(this.txtdg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(625, 212);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lịch sử giá";
            // 
            // dateBatDau
            // 
            this.dateBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBatDau.Location = new System.Drawing.Point(120, 60);
            this.dateBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Size = new System.Drawing.Size(457, 22);
            this.dateBatDau.TabIndex = 13;
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateKetThuc.Location = new System.Drawing.Point(119, 97);
            this.dateKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Size = new System.Drawing.Size(459, 22);
            this.dateKetThuc.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaNCCSearch);
            this.groupBox3.Controls.Add(this.rbAll);
            this.groupBox3.Controls.Add(this.rbMaNcc);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Location = new System.Drawing.Point(771, 32);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(415, 172);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txtMaNCCSearch
            // 
            this.txtMaNCCSearch.Location = new System.Drawing.Point(177, 47);
            this.txtMaNCCSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNCCSearch.Name = "txtMaNCCSearch";
            this.txtMaNCCSearch.Size = new System.Drawing.Size(177, 22);
            this.txtMaNCCSearch.TabIndex = 2;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAll.Location = new System.Drawing.Point(5, 92);
            this.rbAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(80, 24);
            this.rbAll.TabIndex = 1;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Tất Cả";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // rbMaNcc
            // 
            this.rbMaNcc.AutoSize = true;
            this.rbMaNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaNcc.Location = new System.Drawing.Point(5, 47);
            this.rbMaNcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMaNcc.Name = "rbMaNcc";
            this.rbMaNcc.Size = new System.Drawing.Size(136, 24);
            this.rbMaNcc.TabIndex = 0;
            this.rbMaNcc.TabStop = true;
            this.rbMaNcc.Text = "Mã hàng hóa :";
            this.rbMaNcc.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(223, 90);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 41);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1121, 378);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(133, 47);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(912, 378);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 47);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1121, 554);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 48);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(912, 270);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(139, 47);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1121, 270);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 48);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // QL_LichSuGiaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1276, 617);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QL_LichSuGiaGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_LichSuGiaGUI";
            this.Load += new System.EventHandler(this.QL_LichSuGiaGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlichsugia)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ngaycapnhat;
        private System.Windows.Forms.ComboBox cbmahang;
        private System.Windows.Forms.TextBox txtdg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvlichsugia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaNCCSearch;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbMaNcc;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DateTimePicker dateBatDau;
        private System.Windows.Forms.DateTimePicker dateKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapNhat1;
    }
}