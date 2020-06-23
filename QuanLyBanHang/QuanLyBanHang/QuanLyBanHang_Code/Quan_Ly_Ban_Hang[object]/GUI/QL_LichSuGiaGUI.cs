using QL_BanHang.BUS;
using QL_BanHang.DTO;
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

namespace QL_BanHang.GUI
{
    public partial class QL_LichSuGiaGUI : Form
    {
        LichSuGiaDTO a = new LichSuGiaDTO();
        LichSuGiaBUS bus = new LichSuGiaBUS();
        public QL_LichSuGiaGUI()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            QL_LichSuGiaGUI_Load(sender, e);
        }

        private void QL_LichSuGiaGUI_Load(object sender, EventArgs e)
        {
            DataTable dtLichSuGia = new DataTable();
            dtLichSuGia = bus.ShowLichSuGia();
            dgvlichsugia.DataSource = dtLichSuGia;
            rbAll.Checked = true;
            dtLichSuGia = bus.ShowComboBox();
            cbmahang.DataSource = dtLichSuGia;
            cbmahang.DisplayMember = "TenHang";
            cbmahang.ValueMember = "MaHH";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbmahang.SelectedValue == null)
            {
                MessageBox.Show("Bạn cần chọn mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtdg.Text.Length <= 0)
            {
                MessageBox.Show("Bạn cần nhập vào đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                a.MaHang = cbmahang.SelectedValue.ToString();
                a.NgayBatDau = dateBatDau.Value.ToString("yyyy-MM-dd");
                a.NgayKetThuc = dateKetThuc.Value.ToString("yyyy-MM-dd");
                a.DonGia = Int32.Parse(txtdg.Text);
                a.NgayCapNhat = ngaycapnhat.Value.ToString("yyyy-MM-dd");
                bus.UpdateLichSuGia(a);
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    QL_LichSuGiaGUI_Load(sender, e);
                    cbmahang.Focus();
                    cbmahang.Refresh();
                    dateBatDau.Refresh();
                    dateKetThuc.Refresh();
                    txtdg.Clear();
                    ngaycapnhat.Refresh();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Sửa Thất Bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void dgvlichsugia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (dgvlichsugia.Rows[row].Cells[4].Value != null)
            {
                cbmahang.Text = dgvlichsugia.Rows[row].Cells[4].Value.ToString();
                dateBatDau.Text = dgvlichsugia.Rows[row].Cells[0].Value.ToString();
                dateKetThuc.Text = dgvlichsugia.Rows[row].Cells[1].Value.ToString();
                txtdg.Text = dgvlichsugia.Rows[row].Cells[2].Value.ToString();
                ngaycapnhat.Text = dgvlichsugia.Rows[row].Cells[3].Value.ToString();

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
                    bus.DeleteLichSuGia(cbmahang.SelectedValue.ToString(), dateBatDau.Value.ToString("yyyy-MM-dd"));
                    MessageBox.Show("Xóa thành công");
                    QL_LichSuGiaGUI_Load(sender, e);
                    cbmahang.Focus();
                    cbmahang.Refresh();
                    dateBatDau.Refresh();
                    dateKetThuc.Refresh();
                    txtdg.Clear();
                    ngaycapnhat.Refresh();
                }
                catch (SqlException)
                {
                    MessageBox.Show("không xóa được vui long nhập đúng mã cần xóa");
                }
            }
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!rbMaNcc.Checked)
            {
                if (txtMaNCCSearch.TextLength == 0)
                    MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
                else
                    dgvlichsugia.DataSource = bus.ShowLichSuGia(txtMaNCCSearch.Text);
            }
            else
            {
                dgvlichsugia.DataSource = bus.ShowLichSuGia();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbmahang.SelectedValue == null)
            {
                MessageBox.Show("Bạn cần chọn mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtdg.Text.Length <= 0)
            {
                MessageBox.Show("Bạn cần nhập vào đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                a.MaHang = cbmahang.SelectedValue.ToString();
                a.NgayBatDau = dateBatDau.Value.ToString("yyyy-MM-dd");
                a.NgayKetThuc = dateKetThuc.Value.ToString("yyyy-MM-dd");
                a.DonGia = Int32.Parse(txtdg.Text);
                a.NgayCapNhat = ngaycapnhat.Value.ToString("yyyy-MM-dd");
                bus.addLichSuGia(a);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QL_LichSuGiaGUI_Load(sender, e);
                cbmahang.Focus();
                cbmahang.Refresh();
                dateBatDau.Refresh();
                dateKetThuc.Refresh();
                txtdg.Clear();
                ngaycapnhat.Refresh();
            }
            catch (SqlException)
            {
                MessageBox.Show("Thêm Thất Bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
