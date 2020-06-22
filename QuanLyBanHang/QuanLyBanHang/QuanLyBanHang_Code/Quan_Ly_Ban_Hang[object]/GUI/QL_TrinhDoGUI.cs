using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_BanHang.BUS;
using QL_BanHang.DTO;

namespace QL_BanHang.GUI
{
    public partial class QL_TrinhDoGUI : Form
    {
        TrinhDoBUS trinhDo = new TrinhDoBUS();
        TrinhDoDTO dto = new TrinhDoDTO();
        public QL_TrinhDoGUI()
        {
            InitializeComponent();
        }

        private void showDataGridView_Click(object sender, EventArgs e)
        {
            dgvtd.DataSource = trinhDo.ShowTrinhDo();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtmatrinhdo.Text = "";
            txtLuongCung.Text = "";
            txttentrinhdo.Text = "";
            txttimkiem.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtmatrinhdo.TextLength == 0)
                MessageBox.Show("Mã trình độ không được bỏ trống");
            else if (txttentrinhdo.TextLength == 0)
                MessageBox.Show("Tên trình độ không được bỏ trống");
            else if (txtLuongCung.TextLength == 0)
                MessageBox.Show("Lương cứng không được bỏ trống");
            else if (!long.TryParse(txtLuongCung.Text, out long n))
                MessageBox.Show("Lương cứng phải là một số");
            else
            {
                try
                {
                    dto.MaTrinhDo = txtmatrinhdo.Text;
                    dto.TenTrinhDo = txttentrinhdo.Text;
                    dto.LuongCung = long.Parse(txtLuongCung.Text);
                    trinhDo.AddTrinhDo(dto);
                    MessageBox.Show("Thêm Thành Công!");
                    showDataGridView_Click(sender, e);
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại !!!");
                }
            }
        }

        private void dgvtd_Click(object sender, EventArgs e)
        {
            txtmatrinhdo.Text = dgvtd.CurrentRow.Cells[0].Value.ToString();
            txttentrinhdo.Text = dgvtd.CurrentRow.Cells[1].Value.ToString();
            txtLuongCung.Text = dgvtd.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtmatrinhdo.TextLength == 0)
                MessageBox.Show("Mã trình độ không được bỏ trống");
            else if (txttentrinhdo.TextLength == 0)
                MessageBox.Show("Tên trình độ không được bỏ trống");
            else if (txtLuongCung.TextLength == 0)
                MessageBox.Show("Lương cứng không được bỏ trống");
            else if (!long.TryParse(txtLuongCung.Text, out long n))
                MessageBox.Show("Lương cứng phải là một số");
            else
            {
                try
                {
                    dto.MaTrinhDo = txtmatrinhdo.Text;
                    dto.TenTrinhDo = txttentrinhdo.Text;
                    dto.LuongCung = long.Parse(txtLuongCung.Text);
                    trinhDo.EditTrinhDo(dto);
                    MessageBox.Show("Sửa Thành Công!");
                    showDataGridView_Click(sender, e);
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại !!!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn có chắc chắn muốn xóa", "tl", MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {
                if (txtmatrinhdo.TextLength == 0)
                {
                    MessageBox.Show("Bạn cần chọn mã trình độ để xóa");
                }
                Boolean check = false;
                List<TrinhDoDTO> trinhDoDTOs = new List<TrinhDoDTO>();
                DataTable data = trinhDo.ShowTrinhDo();
                trinhDoDTOs = (from DataRow dr in data.Rows
                               select new TrinhDoDTO()
                               {
                                   MaTrinhDo = dr["MaTrinhDo"].ToString(),
                                   TenTrinhDo = dr["TenTrinhDo"].ToString(),
                                   LuongCung = Convert.ToInt64(dr["LuongCung"])
                               }).ToList();
                for (int i = 0; i < trinhDoDTOs.Count; i++)
                {
                    if (trinhDoDTOs[i].MaTrinhDo.Equals(txtmatrinhdo.Text))
                    {
                        try
                        {
                            dto.MaTrinhDo = txtmatrinhdo.Text;
                            trinhDo.DeleteTrinhDo(dto.MaTrinhDo);
                            MessageBox.Show("Đã xóa thành công");
                            showDataGridView_Click(sender, e);
                            check = true;
                        }
                        catch { MessageBox.Show("Xóa thất bại "); }
                    }
                }
                if (!check) { MessageBox.Show("Mã Trình độ không tồn tại"); }


            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txttimkiem.TextLength == 0)
                MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
            else
                dgvtd.DataSource = trinhDo.searchTrinhDo(txttimkiem.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchTD_Click(object sender, EventArgs e)
        {
            if (!rbTDAll.Checked)
            {
                if (txttimkiem.TextLength == 0)
                    MessageBox.Show("Bạn chưa nhập từ khóa tìm kiếm ");
                else
                    dgvtd.DataSource = trinhDo.searchTrinhDo(txttimkiem.Text);
            }else
            {
                dgvtd.DataSource = trinhDo.ShowTrinhDo();
            }
        }

        private void QL_TrinhDoGUI_Load(object sender, EventArgs e)
        {
            showDataGridView_Click(sender, e);
            rbTDAll.Checked = true;
        }
    }
}

