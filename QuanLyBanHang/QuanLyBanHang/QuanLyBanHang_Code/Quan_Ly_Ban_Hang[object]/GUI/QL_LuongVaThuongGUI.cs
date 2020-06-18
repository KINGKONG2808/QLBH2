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
    public partial class QL_LuongVaThuong : Form
    {
        DataConnect data = new DataConnect();
        LuongVaThuongBUS ltbll = new LuongVaThuongBUS();
        public QL_LuongVaThuong()
        {
            InitializeComponent();
        }

        private void QL_LuongVaThuong_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTT = new DataTable();
                dtTT = ltbll.ShowTiepThi();
                dgvTiepThi.DataSource = dtTT;

                DataTable dtLapHD = new DataTable();
                dtLapHD = ltbll.ShowLapHD();
                dgvBanTC.DataSource = dtLapHD;

                DataTable dtBL = new DataTable();
                dtBL = ltbll.ShowBangLuong();
                dgvBangLuong.DataSource = dtBL;

                DataTable dtTL = new DataTable();
                dtTL = ltbll.ShowTongLuong();
                dgvTongLuong.DataSource = dtTL;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL!", "Erorr", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }

        private void dgvBanTC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
