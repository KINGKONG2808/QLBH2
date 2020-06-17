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
using System.IO;
using System.Drawing.Imaging;


using QL_BanHang.Object;
using QL_BanHang.BLL;
using QL_BanHang.DAL;

namespace QL_BanHang
{
    public partial class QL_HangHoa : Form
    {
        public static QL_HangHoa fmHH;


        HangBUS hbus = new HangBUS();


        
        DataConnect data = new DataConnect();
        public QL_HangHoa()
        {
            InitializeComponent();
            fmHH = this;
        }

    

        

        public void setTXT()
        {
            txtMaHH.Focus();
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtDonViTinh.Text = "";
        }

        private void QL_HangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHANGDataSet.LoaiHang' table. You can move, or remove it, as needed.
            //this.loaiHangTableAdapter.Fill(this.qLHANGDataSet.LoaiHang);
            // TODO: This line of code loads data into the 'qLHANGDataSet.Hang' table. You can move, or remove it, as needed.
            //this.hangTableAdapter.Fill(this.qLHANGDataSet.Hang);

            
            DataTable dtHangHoa = new DataTable();
            dtHangHoa = hbus.ShowHang();
            dgvhang.DataSource = dtHangHoa;


            DataTable dt1 = new DataTable();
            dt1 = hbus.ShowHangloaihang();
            cboMaLoai.DisplayMember = "MaLoai";
            cboMaLoai.ValueMember = "TenLoai";
            cboMaLoai.DataSource = dt1;


            DataTable dt2 = new DataTable();
            dt2 = hbus.ShowHangnhacungcap();
            cboMaNCC.DisplayMember = "MaNCC";
            cboMaNCC.ValueMember = "TenNCC";
            cboMaNCC.DataSource = dt2;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HangDTO h = new HangDTO();
            h.Mahang = txtMaHH.Text;
            h.Tenhang = txtTenHH.Text;
            h.Donvitinh = txtDonViTinh.Text;
            h.Dongia = Convert.ToInt32(txtDonGia.Text);
            h.Soluongco = Convert.ToInt32(txtSoLuong.Text);
            h.Nhacungcap = cboMaNCC.SelectedValue.ToString();
            h.Maloai = cboMaLoai.SelectedValue.ToString();



            if (!string.IsNullOrEmpty(txtMaHH.Text) && !string.IsNullOrEmpty(txtTenHH.Text) && !string.IsNullOrEmpty(txtDonGia.Text) && !string.IsNullOrEmpty(txtSoLuong.Text) && !string.IsNullOrEmpty(txtDonViTinh.Text))
            {

                int val, val1;
                bool check = Int32.TryParse(txtSoLuong.Text, out val);
                bool check1 = Int32.TryParse(txtDonGia.Text, out val1);
                if (!check || !check1)
                {
                    MessageBox.Show("Gía trị số lượng và đơn giá phải là số", "Sai dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return;
                }
               else
                { 
                    try
                    {
                        hbus.InsertHangHoa(h);
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            QL_HangHoa_Load(sender, e);
                            setTXT();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Mã hàng hóa đã tồn tại , kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
               
                }
                
            }
            else
            {
                MessageBox.Show("Chưa điền đủ thông tin!", "Kiểm tra lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }

        }

 
        //String imgLocation;
        private void btnLuu_Click(object sender, EventArgs e)
        {         
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaHH.Text))
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        hbus.DeleteHangHoa(txtMaHH.Text.Trim());
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            QL_HangHoa_Load(sender, e);
                            setTXT();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Mã hàng hóa đang được sử dụng không thể xóa.Lỗi SQL!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Vui lòng nhập mã hàng muốn xóa!", "Erorr", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            HangDTO h = new HangDTO();
            h.Mahang = txtMaHH.Text;
            h.Tenhang = txtTenHH.Text;
            h.Donvitinh = txtDonViTinh.Text;
            h.Dongia = Convert.ToInt32(txtDonGia.Text);
            h.Soluongco = Convert.ToInt32(txtSoLuong.Text);
            h.Nhacungcap = cboMaNCC.SelectedValue.ToString();
            h.Maloai = cboMaLoai.SelectedValue.ToString();


            if (!String.IsNullOrEmpty(txtMaHH.Text))
            {
                try
                {
                    hbus.UpdateHangHoa(h);
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        QL_HangHoa_Load(sender, e);
                        setTXT();
                    }
                }
                catch
                {
                    MessageBox.Show("Mã hàng hóa đã tồn tại , kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void dgvHienThiHH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            txtMaHH.Text = dgvhang.Rows[row].Cells[0].Value.ToString();
            txtTenHH.Text = dgvhang.Rows[row].Cells[1].Value.ToString();
            txtDonViTinh.Text = dgvhang.Rows[row].Cells[2].Value.ToString();
            txtDonGia.Text = dgvhang.Rows[row].Cells[3].Value.ToString();
            cboMaLoai.Text = dgvhang.Rows[row].Cells[4].Value.ToString();
            cboMaNCC.Text = dgvhang.Rows[row].Cells[5].Value.ToString();           
            txtSoLuong.Text = dgvhang.Rows[row].Cells[6].Value.ToString();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaHH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataTable dtHangHoa = new DataTable();
            dtHangHoa = hbus.ShowHang();
            dgvhang.DataSource = dtHangHoa;


            DataTable dt1 = new DataTable();
            dt1 = hbus.ShowHangloaihang();
            cboMaLoai.DisplayMember = "MaLoai";
            cboMaLoai.ValueMember = "TenLoai";
            cboMaLoai.DataSource = dt1;


            DataTable dt2 = new DataTable();
            dt2 = hbus.ShowHangnhacungcap();
            cboMaNCC.DisplayMember = "MaNCC";
            cboMaNCC.ValueMember = "TenNCC";
            cboMaNCC.DataSource = dt2;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(rdMaLoaiHang.Checked == true)
            {
                DataTable dt3 = new DataTable();
                dt3 = hbus.ShowHangtk(txtTimKiem.Text);
                dgvhang.DataSource = dt3;
            }
            else
            {
                DataTable dtHangHoa = new DataTable();
                dtHangHoa = hbus.ShowHang();
                dgvhang.DataSource = dtHangHoa;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaHH.Focus();
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtDonViTinh.Text = "";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("trở về trang chủ", "thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(thoat == DialogResult.OK)
            {
                TrangChu a = new TrangChu();
                a.Show();
            }
        }
    }
}
