namespace QL_BanHang.GUI
{
    partial class QL_TrinhDoGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_TrinhDoGUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLuongCung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttentrinhdo = new System.Windows.Forms.TextBox();
            this.txtmatrinhdo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvtd = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.rbTDAll = new System.Windows.Forms.RadioButton();
            this.rbMaTD = new System.Windows.Forms.RadioButton();
            this.btnSearchTD = new System.Windows.Forms.Button();
            this.MaTrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtd)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLuongCung);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txttentrinhdo);
            this.groupBox1.Controls.Add(this.txtmatrinhdo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(444, 206);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Trình độ";
            // 
            // txtLuongCung
            // 
            this.txtLuongCung.Location = new System.Drawing.Point(123, 154);
            this.txtLuongCung.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuongCung.Name = "txtLuongCung";
            this.txtLuongCung.Size = new System.Drawing.Size(302, 22);
            this.txtLuongCung.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lương cứng:";
            // 
            // txttentrinhdo
            // 
            this.txttentrinhdo.Location = new System.Drawing.Point(123, 100);
            this.txttentrinhdo.Margin = new System.Windows.Forms.Padding(4);
            this.txttentrinhdo.Name = "txttentrinhdo";
            this.txttentrinhdo.Size = new System.Drawing.Size(302, 22);
            this.txttentrinhdo.TabIndex = 3;
            // 
            // txtmatrinhdo
            // 
            this.txtmatrinhdo.Location = new System.Drawing.Point(123, 39);
            this.txtmatrinhdo.Margin = new System.Windows.Forms.Padding(4);
            this.txtmatrinhdo.Name = "txtmatrinhdo";
            this.txtmatrinhdo.Size = new System.Drawing.Size(302, 22);
            this.txtmatrinhdo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên trình độ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã trình độ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvtd);
            this.groupBox2.Location = new System.Drawing.Point(490, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(585, 374);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin trình độ";
            // 
            // dgvtd
            // 
            this.dgvtd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTrinhDo,
            this.TenTrinhDo,
            this.LuongCung});
            this.dgvtd.Location = new System.Drawing.Point(8, 23);
            this.dgvtd.Margin = new System.Windows.Forms.Padding(4);
            this.dgvtd.Name = "dgvtd";
            this.dgvtd.RowHeadersWidth = 51;
            this.dgvtd.Size = new System.Drawing.Size(569, 343);
            this.dgvtd.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(758, 426);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(119, 37);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(416, 426);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 37);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(929, 426);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 37);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(245, 426);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 37);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(588, 426);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(113, 37);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txttimkiem);
            this.groupBox6.Controls.Add(this.rbTDAll);
            this.groupBox6.Controls.Add(this.rbMaTD);
            this.groupBox6.Location = new System.Drawing.Point(38, 269);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(346, 135);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tìm kiếm trình độ";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(146, 38);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(183, 22);
            this.txttimkiem.TabIndex = 2;
            // 
            // rbTDAll
            // 
            this.rbTDAll.AutoSize = true;
            this.rbTDAll.Location = new System.Drawing.Point(22, 86);
            this.rbTDAll.Name = "rbTDAll";
            this.rbTDAll.Size = new System.Drawing.Size(69, 21);
            this.rbTDAll.TabIndex = 1;
            this.rbTDAll.TabStop = true;
            this.rbTDAll.Text = "Tất cả";
            this.rbTDAll.UseVisualStyleBackColor = true;
            // 
            // rbMaTD
            // 
            this.rbMaTD.AutoSize = true;
            this.rbMaTD.Location = new System.Drawing.Point(22, 38);
            this.rbMaTD.Name = "rbMaTD";
            this.rbMaTD.Size = new System.Drawing.Size(104, 21);
            this.rbMaTD.TabIndex = 0;
            this.rbMaTD.TabStop = true;
            this.rbMaTD.Text = "Mã trình độ:";
            this.rbMaTD.UseVisualStyleBackColor = true;
            // 
            // btnSearchTD
            // 
            this.btnSearchTD.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchTD.Image")));
            this.btnSearchTD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchTD.Location = new System.Drawing.Point(60, 426);
            this.btnSearchTD.Name = "btnSearchTD";
            this.btnSearchTD.Size = new System.Drawing.Size(137, 33);
            this.btnSearchTD.TabIndex = 37;
            this.btnSearchTD.Text = "Tìm kiếm";
            this.btnSearchTD.UseVisualStyleBackColor = true;
            // 
            // MaTrinhDo
            // 
            this.MaTrinhDo.DataPropertyName = "MaTrinhDo";
            this.MaTrinhDo.HeaderText = "Mã trình độ";
            this.MaTrinhDo.MinimumWidth = 6;
            this.MaTrinhDo.Name = "MaTrinhDo";
            this.MaTrinhDo.Width = 125;
            // 
            // TenTrinhDo
            // 
            this.TenTrinhDo.DataPropertyName = "TenTrinhDo";
            this.TenTrinhDo.HeaderText = "Tên trình độ";
            this.TenTrinhDo.MinimumWidth = 6;
            this.TenTrinhDo.Name = "TenTrinhDo";
            this.TenTrinhDo.Width = 125;
            // 
            // LuongCung
            // 
            this.LuongCung.DataPropertyName = "LuongCung";
            this.LuongCung.HeaderText = "Lương cứng";
            this.LuongCung.MinimumWidth = 6;
            this.LuongCung.Name = "LuongCung";
            this.LuongCung.Width = 125;
            // 
            // QL_TrinhDoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1109, 491);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnSearchTD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Name = "QL_TrinhDoGUI";
            this.Text = "QL_TrinhDoGUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtd)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttentrinhdo;
        private System.Windows.Forms.TextBox txtmatrinhdo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvtd;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtLuongCung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.RadioButton rbTDAll;
        private System.Windows.Forms.RadioButton rbMaTD;
        private System.Windows.Forms.Button btnSearchTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCung;
    }
}