using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using DGVPrinterHelper;
using iTextSharp.text;
using iTextSharp.text.pdf;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Danh sách hàng đã bán";
                printer.SubTitle = string.Format("Ngày : {0}", DateTime.Now);
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Danh Sách Hàng Bán";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dgvHangBan);
            }
            catch
            {
                MessageBox.Show("In thất bại !!!", "Info");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            // creating Excel Application
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets["Sheet1"];
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Danh Sach Hang Da Ban";
            // storing header part in Excel  
            for (int i = 1; i < dgvHangBan.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvHangBan.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvHangBan.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvHangBan.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvHangBan.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("C:\\QLBH2\\DanhSachHangDaBan.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application 
            MessageBox.Show("Data Exported Successfully !!!", "Info");
            app.Quit();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Danh sách hàng tồn";
                printer.SubTitle = string.Format("Ngày : {0}", DateTime.Now);
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Danh Sách Hàng Tồn";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dgvHangTon);
            }
            catch
            {
                MessageBox.Show("In thất bại !!!", "Info");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets["Sheet1"];
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Danh Sach Hang Ton";
            // storing header part in Excel  
            for (int i = 1; i < dgvHangTon.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvHangTon.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgvHangTon.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvHangTon.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvHangTon.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("C:\\QLBH2\\DanhSachHangTon.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            MessageBox.Show("Data Exported Successfully !!!", "Info");
            app.Quit();
            
        }
    }
}
