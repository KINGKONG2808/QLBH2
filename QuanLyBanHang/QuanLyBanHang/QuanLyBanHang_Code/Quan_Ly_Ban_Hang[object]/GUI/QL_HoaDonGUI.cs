using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanHang.BUS;
using QL_BanHang.DAL;
using QL_BanHang.DTO;

namespace QL_BanHang
{
    public partial class QL_HoaDon : Form
    {
        public static QL_HoaDon fmHD;
        HoaDonDTO hd = new HoaDonDTO();
        ChiTietHoaDonDTO ct = new ChiTietHoaDonDTO();
        HoaDonBUS hdbll = new HoaDonBUS();
        HangBUS hhbll = new HangBUS();
        NhanVienBUS nvbll = new NhanVienBUS();
        KhachHangBUS khbll = new KhachHangBUS();
        ChiTietHoaDonBUS ctbll = new ChiTietHoaDonBUS();
        DataConnect data = new DataConnect();
        int Flag = 0;
        public QL_HoaDon()
        {
            InitializeComponent();
            fmHD = this;
        }

        public void Dis_Enable(bool e)
        {
            txtMaHD.Enabled = e;
            dateNgayLap.Enabled = e;
            cboMaKH.Enabled = e;
            cboMaNV.Enabled = e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
        }

        public void Dis_Enable1(bool e)
        {
            cboMaHD.Enabled = e;
            txtDonGia.Enabled = e;
            txtSoLuong.Enabled = e;
            btnThemHD.Enabled = !e;
            btnLuuHD.Enabled = e;
            btnSuaChiTiet.Enabled = !e;
            btnXoaHD.Enabled = !e;
        }

        public void setTXT1()
        {
            txtMaHD.Text = "";
            dateNgayLap.Text = "";
            cboMaKH.Text = "";
            cboMaNV.Text = "";

        }

        public void setTXT2()
        {
            cboMaHD.Text = "";
            cboMaHH.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
        }

        private void ganDuLieu(HoaDonDTO hd)
        {
            hd.MaHD = txtMaHD.Text;
            hd.MaKH = cboMaKH.Text;
            hd.MaNV = cboMaNV.Text;
            hd.NgayLap = dateNgayLap.Value.ToString("yyyy-MM-dd");
        }

        private void ganDuLieu1(ChiTietHoaDonDTO ct)
        {
            ct.MaHD = cboMaHD.Text;
            ct.MaHH = cboMaHH.Text;
            ct.DonGia = txtDonGia.Text;
            ct.SoLuong = txtSoLuong.Text;
        }

        private void loadControl()
        {
            try
            {
                DataTable dtChiTietHD = new DataTable();
                dtChiTietHD = ctbll.ShowChiTietHD();
                dgvHienThiChiTietHD.DataSource = dtChiTietHD;

                DataTable dtMaHH = new DataTable();
                dtMaHH = hhbll.ShowHang();
                cboMaHH.DataSource = dtMaHH;


                DataTable dtMaNV = new DataTable();
                dtMaNV = nvbll.ShowNhanVien();
                cboMaNV.DataSource = dtMaNV;
                cboMaNV.DisplayMember = "TenNV";
                cboMaNV.ValueMember = "MaNV";

                DataTable dtMaKH = new DataTable();
                dtMaKH = khbll.ShowKhachHang();
                cboMaKH.DataSource = dtMaKH;
                cboMaKH.DisplayMember = "TenKH";
                cboMaKH.ValueMember = "MaKH";

                DataTable dtHoaDon = new DataTable();
                dtHoaDon = hdbll.ShowHoaDon();
                dgvHienThiHDon.DataSource = dtHoaDon;

                DataTable dtMaHD = new DataTable();
                dtMaHD = hdbll.ShowHoaDon();
                cboMaHD.DataSource = dtMaHD;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL!", "Erorr", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }

        private void QL_HoaDon_Load(object sender, EventArgs e)
        {
            txtSLCon.Enabled = false;
            Dis_Enable(false);
            Dis_Enable1(false);
            loadControl();
            DataTable dtHoaDon = new DataTable();
            dtHoaDon = hdbll.ShowHoaDon();
            dgvHienThiHDon.DataSource = dtHoaDon;
            txtSLCon.Text = soLuongNhap().ToString();
        }

        private int soLuongNhap()
        {
            int soLuongNhap = ctbll.SoLuongNhap();
            if (soLuongNhap > 0)
                return soLuongNhap;
            else
                return 0;
            
        }

        private int giaNhap()
        {
            int giaNhap = ctbll.GiaNhap();
            return giaNhap;
        }

        private void btnF5_Click_1(object sender, EventArgs e)
        {
            txtSLCon.Text = soLuongNhap().ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Flag = 2;
            Dis_Enable(true);
            txtMaHD.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Flag = 1;
            setTXT1();
            Dis_Enable(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaHD.Text))
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        hdbll.DeleteHoaDon(txtMaHD.Text.Trim());
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            QL_HoaDon_Load(sender, e);
                            setTXT1();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Mã hóa đơn đang được sử dụng không thể xóa.Lỗi SQL!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi!", "Erorr", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(hd);
            if (!string.IsNullOrEmpty(txtMaHD.Text) && !string.IsNullOrEmpty(cboMaKH.Text) && !string.IsNullOrEmpty(cboMaNV.Text) && !string.IsNullOrEmpty(dateNgayLap.Text))
            {
                if (Flag == 1)
                {
                    try
                    {
                        hdbll.InsertHoaDon(hd);
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            QL_HoaDon_Load(sender, e);
                            setTXT1();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Mã hóa đơn đã tồn tại , kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (Flag == 2)
                    {
                        try
                        {
                            hdbll.UpdateHoaDon(hd);
                            {
                                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                QL_HoaDon_Load(sender, e);
                                setTXT1();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa điền đủ thông tin!", "Kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            setTXT2();
            Dis_Enable1(true);
            Flag = 3;
        }

        private void btnSuaChiTiet_Click(object sender, EventArgs e)
        {
            Dis_Enable1(true);
            Flag = 4;
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            ganDuLieu1(ct);
            if (!String.IsNullOrEmpty(cboMaHD.Text) && !String.IsNullOrEmpty(cboMaHH.Text) && !String.IsNullOrEmpty(txtDonGia.Text) 
                && !String.IsNullOrEmpty(txtSoLuong.Text))
            {
                int val1, val2;
                Boolean check1 = Int32.TryParse(txtDonGia.Text, out val1);
                if (!check1)
                {
                    MessageBox.Show("Gía trị đơn giá phải là số", "Sai dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return;
                }
                Boolean check2 = Int32.TryParse(txtSoLuong.Text, out val2);
                if (!check2)
                {
                    MessageBox.Show("Gía trị số lượng phải là số", "Sai dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return;
                }
                try
                {
                    String s = txtSoLuong.Text;
                    string s1 = txtDonGia.Text;
                    int soLuongBan = Int32.Parse(s);
                    int giaBan = Int32.Parse(s1);
                    if (soLuongNhap() > 0)
                    {
                        if (soLuongNhap() < soLuongBan)
                        {
                            MessageBox.Show("Không đủ hàng hóa để bán , kiểm tra lại!", "Erorr", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            if (giaBan > giaNhap())
                            {
                                if (Flag == 3)
                                {
                                    try
                                    {
                                        ctbll.InsertChiTietHD(ct);
                                        {
                                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            QL_HoaDon_Load(sender, e);
                                            setTXT2();
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Mã khách hàng đã tồn tại , kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                else
                                {
                                    if (Flag == 4)
                                    {
                                        try
                                        {
                                            ctbll.UpdateChiTietHD(ct);
                                            {
                                                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                QL_HoaDon_Load(sender, e);
                                                setTXT2();
                                            }
                                        }
                                        catch
                                        {
                                            MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Gía bán hàng không thể nhỏ hơn giá nhập hàng , kiểm tra lại!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không đủ hàng hóa để bán , kiểm tra lại!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Đã tồn tại chi tiết hóa đơn như trên , lỗi SQL!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Chưa điền đủ thông tin!", "Kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cboMaHD.Text))
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        ctbll.DeleteChiTietHD(cboMaHD.Text.Trim());
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            QL_HoaDon_Load(sender, e);
                            setTXT2();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Xảy ra sự cố với CSDL .Lỗi SQL!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Đổ lại dữ liệu từ DataGridView lên các ô textBox,...
        private void dgvHienThiHDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaHD.Text = dgvHienThiHDon.Rows[row].Cells[0].Value.ToString();
            cboMaKH.Text = dgvHienThiHDon.Rows[row].Cells[1].Value.ToString();
            cboMaNV.Text = dgvHienThiHDon.Rows[row].Cells[2].Value.ToString();
            dateNgayLap.Text = dgvHienThiHDon.Rows[row].Cells[3].Value.ToString();
        }

        private void dgvHienThiChiTietHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            cboMaHD.Text = dgvHienThiChiTietHD.Rows[row].Cells[0].Value.ToString();
            cboMaHH.Text = dgvHienThiChiTietHD.Rows[row].Cells[1].Value.ToString();
            txtDonGia.Text = dgvHienThiChiTietHD.Rows[row].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvHienThiChiTietHD.Rows[row].Cells[3].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateNgayLap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
