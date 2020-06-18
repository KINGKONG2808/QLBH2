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
        int Flag = 0;
        public QL_NhanVien()
        {
            InitializeComponent();
        }

        NhanVienBUS nvbus = new NhanVienBUS();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = nvbus.ShowNhanVien();
            dgvHienThi.DataSource = dtNhanVien;
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {

            ganDuLieu(nv);
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
                

            //Dis_Enable(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        private void ganDuLieu(NhanVienDTO nv)
        {
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.GioiTinh = cboGioiTinh.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.SDT = txtSDT.Text;
            nv.TaiKhoan = txtTaiKhoan.Text;
            nv.MatKhau = txtMatKhau.Text;
            nv.Rank = cboTrinhDo.Text;
        }

        private void loadControl()
        {
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboTrinhDo.Items.Clear();
            cboTrinhDo.Items.Add("Rank A");
            cboTrinhDo.Items.Add("Rank B");
            cboTrinhDo.Items.Add("Rank C");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
                
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
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

        int row;

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            txtMaNV.Text = dgvHienThi.Rows[row].Cells[0].Value.ToString();
            txtTenNV.Text = dgvHienThi.Rows[row].Cells[1].Value.ToString();
            string gt = dgvHienThi.Rows[row].Cells[2].Value.ToString();
            if (gt == "True")
                cboGioiTinh.Text = "Nam";
            else
                cboGioiTinh.Text = "Nữ";
            txtDiaChi.Text = dgvHienThi.Rows[row].Cells[3].Value.ToString();
            txtSDT.Text = dgvHienThi.Rows[row].Cells[4].Value.ToString();
            String luong = dgvHienThi.Rows[row].Cells[5].Value.ToString();
            if (luong == "3000000")
                cboTrinhDo.Text = "Rank C";
            else
            {
                if (luong == "5000000")
                    cboTrinhDo.Text = "Rank B";
                else
                    cboTrinhDo.Text = "Rank A";
            }
            txtTaiKhoan.Text = dgvHienThi.Rows[row].Cells[6].Value.ToString();
            txtMatKhau.Text = dgvHienThi.Rows[row].Cells[7].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaNV.Text))
            {
                try
                {
                    nvbus.UpdateNhanVien(nv);
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1_Load(sender, e);
                        loadControl();
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

        private void dgvHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("trở về trang chủ", "thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thoat == DialogResult.OK)
            {
                TrangChu a = new TrangChu();
                a.Show();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien = nvbus.ShowNhanVien();
            dgvHienThi.DataSource = dtNhanVien;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaNV.Focus();
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cboGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cboTrinhDo.Text = "";
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
                DataTable dtHangHoa = new DataTable();
                dtHangHoa = nvbus.ShowNhanVien();
                dgvHienThi.DataSource = dtHangHoa;
            }
        }


        /* public void Dis_Enable(bool e)
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
         */
    }
}
