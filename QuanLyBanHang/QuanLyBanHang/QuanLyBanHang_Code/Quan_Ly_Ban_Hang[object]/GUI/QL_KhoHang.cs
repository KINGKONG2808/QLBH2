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
using QL_BanHang.DAL;

namespace QL_BanHang
{
    public partial class QL_KhoHang : Form
    {
        String s = @"Data Source=DESKTOP-B13DRT8\SQLEXPRESS;Initial Catalog=QL_BanHang;Integrated Security=True";
        SqlConnection conn;
        KhoHangBLL khbll = new KhoHangBLL();
        public QL_KhoHang()
        {
            InitializeComponent();
        }

        private void KhoHang_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtHangBan = new DataTable();
                dtHangBan = khbll.ShowHangBan();
                dgvHangBan.DataSource = dtHangBan;

                DataTable dtHangTon = new DataTable();
                dtHangTon = khbll.ShowTonKho();
                dgvHangTon.DataSource = dtHangTon;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thế kết nối. Bạn vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
