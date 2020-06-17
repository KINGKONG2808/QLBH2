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
using System.Data.SqlClient;
using QL_BanHang.Object;
using QL_BanHang.BLL;
using QL_BanHang.DAL;

namespace QL_BanHang
{
    public partial class QL_HangHoa : Form
    {
        public static QL_HangHoa fmHH;
        HangHoaBLL hhbll = new HangHoaBLL();
        HangHoaObj hh = new HangHoaObj();
        DataConnect data = new DataConnect();
        int Flag = 0;
        public QL_HangHoa()
        {
            InitializeComponent();
            fmHH = this;
        }

        public void Dis_Enable(bool e)
        {
            txtMaHH.Enabled = e;
            txtTenHH.Enabled = e;
            txtSoLuong.Enabled = e;
            txtDonGia.Enabled = e;
            cboMaNCC.Enabled = e;
            btnLuu.Enabled = e;
            btnSua.Enabled = !e;
            btnThem.Enabled = !e;
            btnXoa.Enabled = !e;
        }

        private void loadControl()
        {
            try
            {
                String sql = "select MaNCC from NhaCungCap";
                DataTable dt = new DataTable();
                dt = data.GetTable(sql);
                cboMaNCC.DataSource = dt;
                cboMaNCC.ValueMember = "MaNCC";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void setTXT()
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            cboMaNCC.Text = "";
        }

        private void QL_HangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHANGDataSet.LoaiHang' table. You can move, or remove it, as needed.
            this.loaiHangTableAdapter.Fill(this.qLHANGDataSet.LoaiHang);
            // TODO: This line of code loads data into the 'qLHANGDataSet.Hang' table. You can move, or remove it, as needed.
            this.hangTableAdapter.Fill(this.qLHANGDataSet.Hang);
            Dis_Enable(false);
            DataTable dtHangHoa = new DataTable();
            dtHangHoa = hhbll.ShowHangHoa();
            dgvHienThiHH.DataSource = dtHangHoa;
            loadControl();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Flag = 1;
            Dis_Enable(true);
            setTXT();
        }

        private void ganDuLieu(HangHoaObj hh)
        {
            hh.MaHH = txtMaHH.Text;
            hh.TenHH = txtTenHH.Text;
            hh.MaNCC = cboMaNCC.Text;
            hh.DonGia = txtDonGia.Text;
            hh.SoLuong = txtSoLuong.Text;
            hh.HoaHong = Int32.Parse(txtDonGia.Text) * 5 / 100;
        }

        String imgLocation;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ganDuLieu(hh);
            if (!string.IsNullOrEmpty(txtMaHH.Text) && !string.IsNullOrEmpty(txtTenHH.Text) && !string.IsNullOrEmpty(txtDonGia.Text) && !string.IsNullOrEmpty(txtSoLuong.Text))
            {

                int val,val1;
                bool check = Int32.TryParse(txtSoLuong.Text, out val);
                bool check1 = Int32.TryParse(txtDonGia.Text, out val1);
                if (!check || !check1)
                {
                    MessageBox.Show("Gía trị số lượng và đơn giá phải là số", "Sai dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    return;
                }
                if (Flag == 1)
                {
                    try
                    {
                        hhbll.InsertHangHoa(hh);
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
                else
                {
                    if (Flag == 2)
                    {
                        try
                        {
                            hhbll.UpdateHangHoa(hh);
                            {
                                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                QL_HangHoa_Load(sender, e);
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
            if (!String.IsNullOrEmpty(txtMaHH.Text))
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        hhbll.DeleteHangHoa(txtMaHH.Text.Trim());
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
                MessageBox.Show("Không có bản ghi!", "Erorr", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaHH.Text))
            {
                    Flag = 2;
                    Dis_Enable(true);
                    txtMaHH.Enabled = false;
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
            txtMaHH.Text = dgvHienThiHH.Rows[row].Cells[0].Value.ToString();
            txtTenHH.Text = dgvHienThiHH.Rows[row].Cells[1].Value.ToString();
            cboMaNCC.Text = dgvHienThiHH.Rows[row].Cells[2].Value.ToString();
            txtDonGia.Text = dgvHienThiHH.Rows[row].Cells[3].Value.ToString();
            txtSoLuong.Text = dgvHienThiHH.Rows[row].Cells[4].Value.ToString();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaHH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
