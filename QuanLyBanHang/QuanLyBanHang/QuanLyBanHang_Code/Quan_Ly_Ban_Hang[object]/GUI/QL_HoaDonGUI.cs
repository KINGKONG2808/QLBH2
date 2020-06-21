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
        TimKiemBUS search = new TimKiemBUS();
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
            cboMaHH.Enabled = e;
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
            txtTenNV.Text = "";
            txtTenKH.Text = "";
        }

        public void setTXT2()
        {
            cboMaHD.Text = "";
            cboMaHH.Text = "";
            txtSoLuong.Text = "";
            txtSLCon.Text = "";
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
            ct.SoLuong = txtSoLuong.Text;
        }

        private void loadControl()
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
            cboMaNV.DisplayMember = "MaNV";
            cboMaNV.ValueMember = "MaNV";

            DataTable dtMaKH = new DataTable();
            dtMaKH = khbll.ShowKhachHang();
            cboMaKH.DataSource = dtMaKH;
            cboMaKH.DisplayMember = "MaKH";
            cboMaKH.ValueMember = "MaKH";

            DataTable dtHoaDon = new DataTable();
            dtHoaDon = hdbll.ShowHoaDon();
            dgvHienThiHDon.DataSource = dtHoaDon;

            DataTable dtMaHD = new DataTable();
            dtMaHD = hdbll.onLoadHoaDon();
            cboMaHD.DataSource = dtMaHD;
            /*try
            {
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL!", "Erorr", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }*/
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
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            if (!String.IsNullOrEmpty(cboMaHD.Text) && !String.IsNullOrEmpty(cboMaHH.Text) && !String.IsNullOrEmpty(txtSoLuong.Text))
            {
                int val2;
                Boolean check2 = Int32.TryParse(txtSoLuong.Text, out val2);
                if (!check2)
                {
                    MessageBox.Show("Gía trị số lượng phải là số", "Sai dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return;
                }
                try
                {
                    int soLuongBan = Int32.Parse(txtSoLuong.Text);
                    if (soLuongNhap() > 0)
                    {
                        if (soLuongNhap() < soLuongBan)
                        {
                            MessageBox.Show("Không đủ hàng hóa để bán , kiểm tra lại!", "Erorr", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            if (Flag == 3)
                            {
                                try
                                {
                                    ctbll.InsertChiTietHD(ct);
                                    {
                                        MessageBox.Show("Thêm hóa đơn chi tiết thành công", "Thông báo thêm mới hóa đơn chi tiết", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        QL_HoaDon_Load(sender, e);
                                        setTXT2();
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Mã hóa đơn và mã khách hàng đã tồn tại, kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                            MessageBox.Show("Sửa hóa đơn chi tiết thành công", "Thông báo cập nhật hóa đơn chi tiết", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            QL_HoaDon_Load(sender, e);
                                            setTXT2();
                                        }
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Sửa hóa đơn chi tiết thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
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
                    MessageBox.Show("Đã tồn tại chi tiết hóa đơn, lỗi SQL!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Dis_Enable(false);
            int row = e.RowIndex;
            txtMaHD.Text = dgvHienThiHDon.Rows[row].Cells[0].Value.ToString();
            dateNgayLap.Text = dgvHienThiHDon.Rows[row].Cells[1].Value.ToString();
            cboMaNV.Text = dgvHienThiHDon.Rows[row].Cells[2].Value.ToString();
            txtTenNV.Text = dgvHienThiHDon.Rows[row].Cells[3].Value.ToString();
            cboMaKH.Text = dgvHienThiHDon.Rows[row].Cells[4].Value.ToString();
            txtTenKH.Text = dgvHienThiHDon.Rows[row].Cells[5].Value.ToString();
        }

        private void dgvHienThiChiTietHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Dis_Enable1(false);
            int row = e.RowIndex;
            cboMaHD.Text = dgvHienThiChiTietHD.Rows[row].Cells[0].Value.ToString();
            cboMaHH.Text = dgvHienThiChiTietHD.Rows[row].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvHienThiChiTietHD.Rows[row].Cells[3].Value.ToString();
            txtSLCon.Text = (ctbll.SoLuongNhap() - Int32.Parse(txtSoLuong.Text)) < 0 ? "0" : (ctbll.SoLuongNhap() - Int32.Parse(txtSoLuong.Text)).ToString();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboMaNV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(!cboMaNV.SelectedValue.ToString().Equals(null))
            {
                txtTenNV.Text = hdbll.onChangeCboBox(cboMaNV.SelectedValue.ToString(), true);
            }
        }

        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboMaKH.SelectedValue.ToString().Equals(null))
            {
                txtTenKH.Text = hdbll.onChangeCboBox(cboMaKH.SelectedValue.ToString(), false);
            }
        }

        private void btnSearchHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbMaHoaDon.Checked)
                {
                    dgvHienThiHDon.DataSource = search.searchHoaDonById(txtMaHoaDon.Text);
                } else
                {
                    loadControl();
                    setTXT1();
                    Dis_Enable(false);
                }
            } catch (Exception)
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn cần tìm kiếm");
            }
        }

        private void exitHyperLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Trở về trang chủ", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thoat == DialogResult.OK)
            {
                TrangChu home = new TrangChu();
                this.Close();
                home.Show();
            }
        }

        private void btnSearchHDCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!rbHoaDonChiTietAll.Checked)
                {
                    if (rbMaHoaDonChiTiet.Checked)
                    {
                        dgvHienThiChiTietHD.DataSource = search.searchHoaDonChiTiet(txtMaHoaDonChiTiet.Text, true);
                    } else
                    {
                        dgvHienThiChiTietHD.DataSource = search.searchHoaDonChiTiet(txtMaHangHoa.Text, false);
                    }
                } else
                {
                    loadControl();
                    setTXT1();
                    Dis_Enable(false);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn hoặc mã hàng hóa cần tìm kiếm");
            }
        }
    }
}
