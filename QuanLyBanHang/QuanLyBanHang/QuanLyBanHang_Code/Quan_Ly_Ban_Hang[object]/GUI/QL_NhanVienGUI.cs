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
using QL_BanHang.DTO;
using QL_BanHang.BUS;

namespace QL_BanHang
{
    public partial class QL_NhanVien : Form
    {
        NhanVienDTO nv = new NhanVienDTO();
        NhanVienBUS nvbus = new NhanVienBUS();
        TrinhDoBUS tdbus = new TrinhDoBUS();
        int Flag = 0;

        public QL_NhanVien()
        {
            InitializeComponent();
        }

        public void loadDataControl()
        {
            Dis_Enable(false);

            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");

            DataTable dtTrinhDo = new DataTable();
            dtTrinhDo = tdbus.ShowTrinhDo();
            cboTrinhDo.DataSource = dtTrinhDo;
            cboTrinhDo.DisplayMember = "MaTrinhDo";
            cboTrinhDo.ValueMember = "MaTrinhDo";

            DataTable dtNhanVien = new DataTable();
            dtNhanVien = nvbus.ShowNhanVien();
            dgvHienThi.DataSource = dtNhanVien;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setTXT();
            loadDataControl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Flag = 1;
            Dis_Enable(true);
            setTXT();
            txtMaNV.Focus();
        }

        public void setTXT()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cboGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cboTrinhDo.Text = "";
            txtTenTrinhDo.Text = "";
        }

        public void Dis_Enable(bool e)
        {
            txtMaNV.Enabled = e;
            txtTenNV.Enabled = e;
            cboGioiTinh.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            txtTaiKhoan.Enabled = e;
            txtMatKhau.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
            cboTrinhDo.Enabled = e;
        }

        private void ganDuLieu(NhanVienDTO nv)
        {
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.GioiTinh = cboGioiTinh.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.Sdt = txtSDT.Text;
            nv.TaiKhoan = txtTaiKhoan.Text;
            nv.MatKhau = txtMatKhau.Text;
            nv.MaTrinhDo = cboTrinhDo.SelectedValue.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(nv);
            if (Flag == 1)
            {
                if (!string.IsNullOrEmpty(txtMaNV.Text) && !string.IsNullOrEmpty(txtDiaChi.Text) && !string.IsNullOrEmpty(txtTenNV.Text) && !string.IsNullOrEmpty(txtSDT.Text) && !string.IsNullOrEmpty(txtTaiKhoan.Text) && !string.IsNullOrEmpty(txtMatKhau.Text) && !string.IsNullOrEmpty(cboGioiTinh.Text) && !string.IsNullOrEmpty(cboTrinhDo.Text))
                {
                    int val;
                    bool check = Int32.TryParse(txtSDT.Text, out val);
                    if (!check)
                    {
                        MessageBox.Show("Gía trị SDT phải là số", "Sai dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        return;
                    }

                    try
                    {
                        nvbus.InsertNhanVien(nv);
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1_Load(sender, e);
                            setTXT();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại , kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin vào các ô textbox");
                    return;
                }
            } else
            {
                if (!String.IsNullOrEmpty(txtMaNV.Text))
                {
                    try
                    {
                        nvbus.UpdateNhanVien(nv);
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1_Load(sender, e);
                            setTXT();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }               
                }
                else
                {
                    MessageBox.Show("Không có bản ghi!", "Erorr",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    return;
                }
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            Flag = 3;
            if (!String.IsNullOrEmpty(txtMaNV.Text))
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        nvbus.DeleteNhanVien(txtMaNV.Text.Trim());
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1_Load(sender, e);
                            setTXT();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Mã nhân viên đang được sử dụng không thể xóa.Lỗi SQL!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dis_Enable(false);
            int row = e.RowIndex;
            txtMaNV.Text = dgvHienThi.Rows[row].Cells[0].Value.ToString();
            txtTenNV.Text = dgvHienThi.Rows[row].Cells[1].Value.ToString();
            string gt = dgvHienThi.Rows[row].Cells[2].Value.ToString();
            if (gt == "True")
                cboGioiTinh.Text = "Nam";
            else
                cboGioiTinh.Text = "Nữ";
            txtDiaChi.Text = dgvHienThi.Rows[row].Cells[3].Value.ToString();
            txtSDT.Text = dgvHienThi.Rows[row].Cells[4].Value.ToString();
            cboTrinhDo.Text = dgvHienThi.Rows[row].Cells[5].Value.ToString();
            txtTaiKhoan.Text = dgvHienThi.Rows[row].Cells[6].Value.ToString();
            txtMatKhau.Text = dgvHienThi.Rows[row].Cells[7].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Flag = 2;
            Dis_Enable(true);
        }

        private void dgvHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrangChu a = new TrangChu();
            this.Close();
            a.Show();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rdMaNhanVien.Checked == true)
            {
                DataTable dt3 = new DataTable();
                dt3 = nvbus.ShowNhanVientk(txtTimKiem.Text);
                dgvHienThi.DataSource = dt3;
            }
            else
            {
                loadDataControl();
            }
        }

        private void cboTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cboTrinhDo.SelectedValue.ToString().Equals(null))
            {
                txtTenTrinhDo.Text = tdbus.onChangeCboBox(cboTrinhDo.SelectedValue.ToString());
            }
        }
    }
}
