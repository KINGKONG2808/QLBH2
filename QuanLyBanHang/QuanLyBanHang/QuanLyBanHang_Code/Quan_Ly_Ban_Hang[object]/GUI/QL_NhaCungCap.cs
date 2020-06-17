using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanHang.Object;
using System.Data.SqlClient;
using QL_BanHang.BLL;

namespace QL_BanHang
{
    public partial class QL_NhaCungCap : Form
    {
        NhaCungCapObj ncc = new NhaCungCapObj();
        int Flag = 0;
        NhaCungCapBLL nccbll = new NhaCungCapBLL();
        public QL_NhaCungCap()
        {
            InitializeComponent();
        }

        private void QL_NhaCungCap_Load(object sender, EventArgs e)
        {
            Dis_Enable(false);
            DataTable dtNhaCungCap = new DataTable();
            dtNhaCungCap = nccbll.ShowNhaCungCap();
            dgvHienThi.DataSource = dtNhaCungCap;
        }

        public void Dis_Enable(bool e)
        {
            txtMaNCC.Enabled = e;
            txtTenNCC.Enabled = e;
            txtDiaChi.Enabled = e;
            txtSDT.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
        }

        public void setTXT()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Flag = 1;
            Dis_Enable(true);
            setTXT();
        }

        private void ganDuLieu(NhaCungCapObj ncc)
        {
            ncc.MaNCC = txtMaNCC.Text;
            ncc.TenNCC = txtTenNCC.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.SDT = txtSDT.Text;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaNCC.Text))
            {
                Flag = 2;

                Dis_Enable(true);
                //txtMaNCC.Enabled = false;
                txtMaNCC.Enabled = true;
            }
            else
            {
                MessageBox.Show("Không có bản ghi!", "Erorr", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaNCC.Text))
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        nccbll.DeleteNhaCungCap(txtMaNCC.Text.Trim());
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            QL_NhaCungCap_Load(sender, e);
                            setTXT();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Mã nhà cung cấp đang được sử dụng không thể xóa.Lỗi SQL!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtMaNCC.Text = dgvHienThi.Rows[row].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvHienThi.Rows[row].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvHienThi.Rows[row].Cells[3].Value.ToString();
            txtSDT.Text = dgvHienThi.Rows[row].Cells[2].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(ncc);
            if (!string.IsNullOrEmpty(txtMaNCC.Text) && !string.IsNullOrEmpty(txtDiaChi.Text) && !string.IsNullOrEmpty(txtTenNCC.Text)){
                int val;
                bool check = Int32.TryParse(txtSDT.Text, out val);
                if (!check){
                    MessageBox.Show("Giá trị SDT phải là số", "Sai dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return;}
                if (Flag == 1){
                    try{
                        nccbll.InsertNhaCungCap(ncc);
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            QL_NhaCungCap_Load(sender, e);
                            setTXT();
                    }
                    catch{
                        MessageBox.Show("Mã nhà cung cấp không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;} }
                else{
                    if (Flag == 2){
                        try
                        {
                            nccbll.UpdateNhaCungCap(ncc);
                                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                QL_NhaCungCap_Load(sender, e);
                                setTXT();
                            
                        }
                        catch{
                            MessageBox.Show("Sửa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;}
                    } } }
            else{
                MessageBox.Show("Chưa điền đủ thông tin!", "Kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return; } }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Dis_Enable(false);
            DataTable dtNhaCungCap = new DataTable();
            dtNhaCungCap = nccbll.ShowNhaCungCap();
            dgvHienThi.DataSource = dtNhaCungCap;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            NhaCungCapBLL a = new NhaCungCapBLL();
            if(rbMaNcc.Checked == true)
            {
                DataTable dt3 = new DataTable();
                dt3 = a.ShowNhaCungCaptk(txtMaNCCSearch.Text);
                dgvHienThi.DataSource = dt3;
            }
            if(rbAll.Checked==true)
            {
                DataTable dt3 = new DataTable();
                dt3 = a.ShowNhaCungCap();
                dgvHienThi.DataSource = dt3;
            }
               
        }
    }
        }
