using QL_BanHang.DAL;
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

namespace QL_BanHang
{
    public partial class QL_DoanhThu : Form
    {
        public static QL_DoanhThu fmDT;
        DataConnect data = new DataConnect();
        DoanhSoBUS dtbll = new DoanhSoBUS();
        public QL_DoanhThu()
        {
            InitializeComponent();
            fmDT = this;
        }

        public void ShowFrm()
        {
            QL_DoanhThu dt = new QL_DoanhThu();
            dt.Show();
        }

        public void QL_DoanhThu_Load(object sender, EventArgs e)
        {
            grbNgay.Enabled = false;
            grbNam.Enabled = false;
            grbThang.Enabled = false;
            txtTienNam.Enabled = false;
            txtTienThang.Enabled = false;
            txtTienNgay.Enabled = false;
            cmbHinhThuc.Items.Add("Theo ngày");
            cmbHinhThuc.Items.Add("Theo tháng");
            cmbHinhThuc.Items.Add("Theo năm");
            try
            {
                DataTable dtDoanhThu = new DataTable();
                dtDoanhThu = dtbll.ShowDoanhThu();
                dgvLoiNhuan.DataSource = dtDoanhThu;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không thế kết nối. Bạn vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmbHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHinhThuc.SelectedItem.ToString() == "Theo ngày")
            {
                grbNgay.Enabled = true;
                grbNam.Enabled = false;
                grbThang.Enabled = false;
                txtThang.Clear();
                txtNam.Clear();
                txtTienThang.Clear();
                txtTienNam.Clear();
            }
            if (cmbHinhThuc.SelectedItem.ToString() == "Theo tháng")
            {
                grbNgay.Enabled = false;
                grbNam.Enabled = false;
                grbThang.Enabled = true;
                txtNgay.Clear();
                txtNam.Clear();
                txtTienNgay.Clear();
                txtTienNam.Clear();
            }

            if (cmbHinhThuc.SelectedItem.ToString() == "Theo năm")
            {
                grbNgay.Enabled = false;
                grbNam.Enabled = true;
                grbThang.Enabled = false;
                txtNgay.Clear();
                txtThang.Clear();
                txtTienNgay.Clear();
                txtTienThang.Clear();
            }
        }
        int row;
        private void dgvLoiNhuan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(dgvLoiNhuan.Rows[row].Cells[6].Value);
            if (cmbHinhThuc.SelectedItem.ToString() == "Theo ngày")
            {
                txtNgay.Text = dt.ToString("MM/dd/yyyy");

            }
            if (cmbHinhThuc.SelectedItem.ToString() == "Theo tháng")
            {
                txtThang.Text = dt.Month.ToString() + "/" + dt.Year.ToString();
            }
            if (cmbHinhThuc.SelectedItem.ToString() == "Theo năm")
            {
                txtNam.Text = dt.Year.ToString();
            }
        }

        public void btnTinhNgay_Click(object sender, EventArgs e)
        {
            try
            {
                int dtNgay = dtbll.DoanhThuNgay();
                txtTienNgay.Text = dtNgay + "";
                DateTime ngay = Convert.ToDateTime(dgvLoiNhuan.Rows[row].Cells[6].Value);
                DataTable dtDSBan = new DataTable();
                dtDSBan = dtbll.ShowTheoNgay(ngay);
                dgvDSBan.DataSource = dtDSBan;
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi không thế kết nối hoặc do kiểu dữ liệu nhập vào không đúng. Bạn vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int TotalMonth(String thang)
        {
            return dtbll.DoanhThuThang(thang);
        }

        public void btnTinhThang_Click(object sender, EventArgs e)
        {
            try
            {
                int dtThang = TotalMonth(txtThang.Text.ToString());
                txtTienThang.Text = dtThang + "";
                DateTime ngay = Convert.ToDateTime(dgvLoiNhuan.Rows[row].Cells[6].Value);
                DataTable dtDSBan = new DataTable();
                dtDSBan = dtbll.ShowTheoThang(ngay);
                dgvDSBan.DataSource = dtDSBan;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thế kết nối hoặc do kiểu dữ liệu nhập vào không đúng. Bạn vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void btnTinhNam_Click(object sender, EventArgs e)
        {
            try
            {
                int dtNam = dtbll.DoanhThuNam();
                txtTienNam.Text = dtNam + "";
                DateTime ngay = Convert.ToDateTime(dgvLoiNhuan.Rows[row].Cells[6].Value);
                DataTable dtDSBan = new DataTable();
                dtDSBan = dtbll.ShowTheoNam(ngay);
                dgvDSBan.DataSource = dtDSBan;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thế kết nối hoặc do kiểu dữ liệu nhập vào không đúng. Bạn vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
