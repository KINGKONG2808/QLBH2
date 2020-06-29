namespace QL_BanHang.GUI
{
    partial class QL_LoaiHangGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_LoaiHangGUI));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbMaLoaiHang = new System.Windows.Forms.RadioButton();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvloaihang = new System.Windows.Forms.DataGridView();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaihang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(177, 47);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(177, 22);
            this.txtTimKiem.TabIndex = 2;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Controls.Add(this.rbAll);
            this.groupBox3.Controls.Add(this.rbMaLoaiHang);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Location = new System.Drawing.Point(35, 257);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(371, 165);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rbMaLoaiHang
            // 
            this.rbMaLoaiHang.AutoSize = true;
            this.rbMaLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaLoaiHang.Location = new System.Drawing.Point(5, 47);
            this.rbMaLoaiHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMaLoaiHang.Name = "rbMaLoaiHang";
            this.rbMaLoaiHang.Size = new System.Drawing.Size(125, 24);
            this.rbMaLoaiHang.TabIndex = 0;
            this.rbMaLoaiHang.TabStop = true;
            this.rbMaLoaiHang.Text = "Mã loại hàng";
            this.rbMaLoaiHang.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(201, 90);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 41);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvloaihang
            // 
            this.dgvloaihang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloaihang.Location = new System.Drawing.Point(27, 22);
            this.dgvloaihang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvloaihang.Name = "dgvloaihang";
            this.dgvloaihang.RowHeadersWidth = 51;
            this.dgvloaihang.RowTemplate.Height = 24;
            this.dgvloaihang.Size = new System.Drawing.Size(485, 385);
            this.dgvloaihang.TabIndex = 0;
            this.dgvloaihang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloaihang_CellClick);
            this.dgvloaihang.Click += new System.EventHandler(this.dgvloaihang_Click);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(85, 81);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(431, 22);
            this.txtTenLoai.TabIndex = 4;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(85, 27);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(431, 22);
            this.txtMaLoai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(85, 138);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(431, 75);
            this.txtGhiChu.TabIndex = 5;
            this.txtGhiChu.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenLoai);
            this.groupBox1.Controls.Add(this.txtMaLoai);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(524, 234);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvloaihang);
            this.groupBox2.Location = new System.Drawing.Point(536, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(537, 428);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu loại hàng";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Image = global::QL_BanHang.Properties.Resources.add;
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(35, 471);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(141, 47);
            this.btnNhapLai.TabIndex = 28;
            this.btnNhapLai.Text = "Thêm";
            this.btnNhapLai.UseMnemonic = false;
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(908, 475);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 44);
            this.button2.TabIndex = 29;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(435, 471);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 48);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(219, 471);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(141, 48);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QL_BanHang.Properties.Resources.meter;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(653, 471);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(141, 48);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Lưu";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // QL_LoaiHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1101, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QL_LoaiHangGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QL_LoaiHangGUI";
            this.Load += new System.EventHandler(this.QL_LoaiHangGUI_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaihang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbMaLoaiHang;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvloaihang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}