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

namespace QL_BanHang
{
    public partial class QL_TaiChinh : Form
    {
        String s = @"Data Source=DESKTOP-B13DRT8\SQLEXPRESS;Initial Catalog=QL_BanHang;Integrated Security=True";
        SqlConnection conn;
        public QL_TaiChinh()
        {
            InitializeComponent();
        }

        private void QL_TaiChinh_Load(object sender, EventArgs e)
        {
            grbNgay.Enabled = false;
            grbNam.Enabled = false;
            grbThang.Enabled = false;
            cmbHinhThuc.Items.Add("Theo ngày");
            cmbHinhThuc.Items.Add("Theo tháng");
            cmbHinhThuc.Items.Add("Theo năm");

            try
            {
                conn = new SqlConnection(s);
                conn.Open();
                String query = "select * from LoiNhuan";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLoiNhuan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thế kết nối. Bạn vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void cmbHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHinhThuc.SelectedItem == "Theo ngày")
            {
                grbNgay.Enabled = true;
                grbNam.Enabled = false;
                grbThang.Enabled = false;
                txtThang.Clear();
                txtNam.Clear();
                txtTienThang.Clear();
                txtTienNam.Clear();
            }
            if (cmbHinhThuc.SelectedItem == "Theo tháng")
            {
                grbNgay.Enabled = false;
                grbNam.Enabled = false;
                grbThang.Enabled = true;
                txtNgay.Clear();
                txtNam.Clear();
                txtTienNgay.Clear();
                txtTienNam.Clear();
            }

            if (cmbHinhThuc.SelectedItem == "Theo năm")
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

        private void dgvLoiNhuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DateTime dt = new DateTime();
            dt = Convert.ToDateTime(dgvLoiNhuan.Rows[row].Cells[6].Value);
            if (cmbHinhThuc.SelectedItem == "Theo ngày")
            {
                txtNgay.Text = dt.ToString("MM/dd/yyyy");
            }
            if (cmbHinhThuc.SelectedItem == "Theo tháng")
            {
                txtThang.Text = dt.Month.ToString() + "/" + dt.Year.ToString();
            }
            if (cmbHinhThuc.SelectedItem == "Theo năm")
            {
                txtNam.Text = dt.Year.ToString();
            }
        }

        private void btnTinhNgay_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(s);
                conn.Open();
                String query = "select sum(SoLuongBan*DonGiaBan) from LoiNhuan where NgayLap = '" + Convert.ToDateTime(txtNgay.Text) + "' group by NgayLap";

                SqlCommand cmd = new SqlCommand(query, conn);
                Int32 da = 0;
                da = Convert.ToInt32(cmd.ExecuteScalar());
                txtTienNgay.Text = da.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thế kết nối. Bạn vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnTinhThang_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime a = Convert.ToDateTime(txtThang.Text);
                int b = a.Month;
                conn = new SqlConnection(s);
                conn.Open();
                String query = "select SUM(SoLuongBan*DonGiaBan) from LoiNhuan where MONTH(NgayLap) = '" + b + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                Int32 da = 0;
                da = Convert.ToInt32(cmd.ExecuteScalar());
                txtTienThang.Text = da.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thế kết nối hoặc do kiểu dữ liệu nhập vào không đúng. Bạn vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnTinhNam_Click(object sender, EventArgs e)
        {
            try
            {
                int b = Convert.ToInt32(txtNam.Text);
                conn = new SqlConnection(s);
                conn.Open();
                String query = "select SUM(SoLuongBan*DonGiaBan) from LoiNhuan where YEAR(NgayLap) = '" + b + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                Int32 da = 0;
                da = Convert.ToInt32(cmd.ExecuteScalar());
                txtTienNam.Text = da.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thế kết nối hoặc do kiểu dữ liệu nhập vào không đúng. Bạn vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
