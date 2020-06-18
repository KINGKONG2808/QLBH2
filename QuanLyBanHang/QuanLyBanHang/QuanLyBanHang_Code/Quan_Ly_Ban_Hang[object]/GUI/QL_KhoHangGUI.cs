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
using QL_BanHang.DAL;

namespace QL_BanHang
{
    public partial class QL_KhoHang : Form
    {
        KhoHangBUS khbus = new KhoHangBUS();
        public QL_KhoHang()
        {
            InitializeComponent();
        }

        private void KhoHang_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtHangBan = new DataTable();
                dtHangBan = khbus.ShowHangBan();
                dgvHangBan.DataSource = dtHangBan;

                DataTable dtHangTon = new DataTable();
                dtHangTon = khbus.ShowHangTon();
                dgvHangTon.DataSource = dtHangTon;

            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi không thế kết nối. Bạn vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
