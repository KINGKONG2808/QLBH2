using QL_BanHang.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanHang
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void fnv_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_HoaDon fnv = new QL_HoaDon();
            fnv.FormClosed += new FormClosedEventHandler(fnv_FormClosed);
            fnv.Show();
            this.Hide();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_HangHoa fnv = new QL_HangHoa();
            fnv.FormClosed += new FormClosedEventHandler(fnv_FormClosed);
            fnv.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QL_KhachHang fnv = new QL_KhachHang();
            fnv.FormClosed += new FormClosedEventHandler(fnv_FormClosed);
            fnv.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            QL_NhaCungCap fnv = new QL_NhaCungCap();
            fnv.FormClosed += new FormClosedEventHandler(fnv_FormClosed);
            fnv.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            QL_NhanVien fnv = new QL_NhanVien();
            fnv.FormClosed += new FormClosedEventHandler(fnv_FormClosed);
            fnv.Show();
            this.Hide();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_KhoHang fnv = new QL_KhoHang();
            fnv.FormClosed += new FormClosedEventHandler(fnv_FormClosed);
            fnv.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            QL_DoanhThu fnv = new QL_DoanhThu();
            fnv.FormClosed += new FormClosedEventHandler(fnv_FormClosed);
            fnv.Show();
            this.Hide();    
        }

        private void vốnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            QL_LuongVaThuong fnv = new QL_LuongVaThuong();
            fnv.FormClosed += new FormClosedEventHandler(fnv_FormClosed);
            fnv.Show();
            this.Hide();
        }

        private void TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolTripQuanLy_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
            else
                return;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_DangNhap fdn = new QL_DangNhap();
            fdn.FormClosed += new FormClosedEventHandler(fnv_FormClosed);
            this.Hide();
            fdn.Show();
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_LoaiHangGUI fnv = new QL_LoaiHangGUI();
            fnv.FormClosed += new FormClosedEventHandler(fnv_FormClosed);
            fnv.Show();
            this.Hide();
        }

        private void lịchSửGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_LichSuGiaGUI fnv = new QL_LichSuGiaGUI();
            fnv.FormClosed += new FormClosedEventHandler(fnv_FormClosed);
            fnv.Show();
            this.Hide();
        }

        private void thôngTinTrìnhĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_TrinhDoGUI fnv = new QL_TrinhDoGUI();
            fnv.FormClosed += new FormClosedEventHandler(fnv_FormClosed);
            fnv.Show();
            this.Hide();
        }
    }
}
