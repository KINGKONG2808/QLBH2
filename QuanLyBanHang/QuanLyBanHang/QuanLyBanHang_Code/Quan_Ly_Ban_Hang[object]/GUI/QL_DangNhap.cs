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
using QL_BanHang.BLL;
using QL_BanHang.Object;

namespace QL_BanHang
{
    public partial class QL_DangNhap : Form
    {
        public QL_DangNhap()
        {
            InitializeComponent();
        }

        DangNhapBLL dn = new DangNhapBLL();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            /*try
            {
                
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không thể kết nối đến cơ sở dữ liệu vui lòng xem lại đường dẫn đến cơ sở dũ liệu.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }*/
            AdminObj ad = new AdminObj(txtTaiKhoan.Text, txtMatKhau.Text);
            NhanVienObj nv = new NhanVienObj(txtTaiKhoan.Text, txtMatKhau.Text);
            if (dn.getTKAdmin(ad) == true)
            {
                TrangChu tr = new TrangChu();
                tr.Show();
                this.Hide();
            }
            else
            {
                if (dn.getTKNhanVien(nv) == true)
                {
                    TrangChu tr1 = new TrangChu();
                    tr1.toolTripNhaCC.Enabled = false;
                    tr1.toolTripNhanVien.Enabled = false;
                    tr1.toolTripTaiChinh.Enabled = false;
                    tr1.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        txtTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        txtTaiKhoan.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void QL_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
