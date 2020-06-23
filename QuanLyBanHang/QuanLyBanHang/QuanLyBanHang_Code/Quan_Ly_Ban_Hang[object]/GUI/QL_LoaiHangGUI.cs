using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanHang.DAL;
using System.Data.SqlClient;
using QL_BanHang.BUS;
using QL_BanHang.DTO;

namespace QL_BanHang.GUI
{
    public partial class QL_LoaiHangGUI : Form
    {
        DataConnect data = new DataConnect();
        LoaiHangBUS lhbus = new LoaiHangBUS();

        public QL_LoaiHangGUI()
        {
            InitializeComponent();
        }

        private void QL_LoaiHangGUI_Load(object sender, EventArgs e)
        {
            DataTable dtLoaiHang = new DataTable();
            dtLoaiHang = lhbus.ShowLoaiHang();
            dgvloaihang.DataSource = dtLoaiHang;
            rbAll.Checked = true;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaLoai.Focus();
            txtMaLoai.Clear();
            txtGhiChu.Clear();
            txtTenLoai.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaiHangDTO a = new LoaiHangDTO();
            a.MaLoai = txtMaLoai.Text;
            a.TenLoai = txtTenLoai.Text;
            a.GhiChu = txtGhiChu.Text;


            try
            {
                lhbus.addLoaiHang(a);
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    QL_LoaiHangGUI_Load(sender, e);
                    txtMaLoai.Focus();
                    txtMaLoai.Clear();
                    txtGhiChu.Clear();
                    txtTenLoai.Clear();

                }
            }
            catch
            {
                MessageBox.Show("loai hang da ton tai nhap lai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataTable dtLoaiHang = new DataTable();
            dtLoaiHang = lhbus.ShowLoaiHang();
            dgvloaihang.DataSource = dtLoaiHang;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoaiHangDTO a = new LoaiHangDTO();
            a.MaLoai = txtMaLoai.Text;
            a.TenLoai = txtTenLoai.Text;
            a.GhiChu = txtGhiChu.Text;

            if (txtMaLoai.Text == "")
            {
                MessageBox.Show("vui lòng nhập mã loại hàng muốn sửa");
            }
            else
            {
                try
                {
                    lhbus.UpdateLoaiHang(a);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QL_LoaiHangGUI_Load(sender, e);
                    txtMaLoai.Focus();
                    txtMaLoai.Clear();
                    txtGhiChu.Clear();
                    txtTenLoai.Clear();

                }
                catch (SqlException)
                {
                    MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("Xác nhận", "Bạn có chắc chắc muốn xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == tl)
            {
                try
                {
                    lhbus.DeleteLoaiHang(txtMaLoai.Text);
                    MessageBox.Show("xóa thành công...");

                    QL_LoaiHangGUI_Load(sender, e);
                    txtMaLoai.Focus();
                    txtMaLoai.Clear();
                    txtGhiChu.Clear();
                    txtTenLoai.Clear();
                }
                catch (SqlException)
                {
                    MessageBox.Show("không xóa được vui long nhập đúng mã cần xóa");
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(rbMaLoaiHang.Checked == true)
            {
                DataTable dtLoaiHangg = new DataTable();
                dtLoaiHangg = lhbus.ShowLoaiHangtk(txtTimKiem.Text);
                dgvloaihang.DataSource = dtLoaiHangg;
            }
            else
            {
                DataTable dtLoaiHang = new DataTable();
                dtLoaiHang = lhbus.ShowLoaiHang();
                dgvloaihang.DataSource = dtLoaiHang;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Trở về trang chủ???", "Trở về", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(DialogResult.OK == thoat)
            {
                TrangChu a = new TrangChu();
                a.Show();
                
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgvloaihang_Click(object sender, EventArgs e)
        {
        }

        private void dgvloaihang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtMaLoai.Text = dgvloaihang.Rows[row].Cells[0].Value.ToString();
            txtTenLoai.Text = dgvloaihang.Rows[row].Cells[1].Value.ToString();
            txtGhiChu.Text = dgvloaihang.Rows[row].Cells[2].Value.ToString();

        }
    }
}
