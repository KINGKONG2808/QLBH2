using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QL_BanHang.Object;
using QL_BanHang.BLL;
using QL_BanHang.DAL;

namespace QL_BanHang
{
    public partial class QL_KhachHang : Form
    {
        KhachHangObj kh = new KhachHangObj();
        KhachHangBLL khbll = new KhachHangBLL();
        DataConnect data = new DataConnect();
        int Flag = 0;
        public QL_KhachHang()
        {
            InitializeComponent();
        }

        public void Dis_Enable(bool e)
        {
            txtMaKH.Enabled = e;
            txtTenKH.Enabled = e;
            cboGioiTinh.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            cboMaNV.Enabled = e;
        }

        public void setTXT()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            cboGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            cboMaNV.Text = "";
        }

        private void loadControl()
        {
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            try
            {
                String sql = "select MaNV from NhanVien ";
                DataTable dt = new DataTable();
                dt = data.GetTable(sql);
                cboMaNV.DataSource = dt;
                cboMaNV.ValueMember = "MaNV";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL!", "Erorr", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }

        private void ganDuLieu(KhachHangObj kh)
        {
            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.GioiTinh = cboGioiTinh.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.SDT = txtSDT.Text;
            kh.MaNV = cboMaNV.Text;
            
        }

        private void QL_KhachHang_Load(object sender, EventArgs e)
        {
            Dis_Enable(false);
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = khbll.ShowKhachHang();
            dgvHienThiKH.DataSource = dtKhachHang;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            loadControl();
            Flag = 1;
            Dis_Enable(true);
            setTXT();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(kh);
            if (!string.IsNullOrEmpty(txtMaKH.Text) && !string.IsNullOrEmpty(txtDiaChi.Text) && !string.IsNullOrEmpty(txtTenKH.Text) && !string.IsNullOrEmpty(txtSDT.Text) && !string.IsNullOrEmpty(cboGioiTinh.Text))
            {

                int val, val1;
                bool check = Int32.TryParse(txtSDT.Text, out val);
                if (!check)
                {
                    MessageBox.Show("Gía trị SDT và số điểm phải là số", "Sai dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return;
                }
                if (Flag == 1)
                {
                    try
                    {
                        khbll.InsertKhachHang(kh);
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            QL_KhachHang_Load(sender, e);
                            setTXT();
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
                    if (Flag == 2)
                    {
                        try
                        {
                            khbll.UpdateKhachHang(kh);
                            {
                                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                QL_KhachHang_Load(sender, e);
                                setTXT();
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
                MessageBox.Show("Chưa điền đủ thông tin!", "Kiểm tra lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaKH.Text))
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        khbll.DeleteKhachHang(txtMaKH.Text.Trim());
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            QL_KhachHang_Load(sender, e);
                            setTXT();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Mã khách hàng đang được sử dụng không thể xóa.Lỗi SQL!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
                if (!String.IsNullOrEmpty(txtMaKH.Text))
                {
                    Flag = 2;
                    Dis_Enable(true);
                    txtMaKH.Enabled = false;
                    loadControl();
                }
                else
                {
                    MessageBox.Show("Không có bản ghi!", "Erorr", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
        }

        int row;
        

        private void dgvHienThiKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            txtMaKH.Text = dgvHienThiKH.Rows[row].Cells[0].Value.ToString();
            txtTenKH.Text = dgvHienThiKH.Rows[row].Cells[1].Value.ToString();
            txtSDT.Text = dgvHienThiKH.Rows[row].Cells[2].Value.ToString();
            if (dgvHienThiKH.Rows[row].Cells[3].Value.Equals(true))
                cboGioiTinh.Text = "Nam";
            else
                cboGioiTinh.Text = "Nữ";
            txtDiaChi.Text = dgvHienThiKH.Rows[row].Cells[4].Value.ToString();
            cboMaNV.Text = dgvHienThiKH.Rows[row].Cells[5].Value.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Dis_Enable(false);
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = khbll.ShowKhachHang();
            dgvHienThiKH.DataSource = dtKhachHang;
        }
    }
}
