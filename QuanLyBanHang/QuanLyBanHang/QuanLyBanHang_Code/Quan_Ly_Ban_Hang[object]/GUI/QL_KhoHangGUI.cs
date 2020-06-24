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

            if (dgvHangBan.Rows.Count > 0)
            {

                StringWriter sw = new StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);
                htw.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">");
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "DanhSachHangDaBan.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvHangBan.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvHangBan.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            for (int i = 0; i < dgvHangBan.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < dgvHangBan.Columns.Count; j++)
                                {
                                    pdfTable.AddCell(dgvHangBan.Rows[i].Cells[j].Value.ToString());
                                }
                            }
                            FontFactory.Register("C:\\Windows\\Fonts\\times.ttf", "arial unicode ms");
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.HtmlStyleClass = "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">";
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
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
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
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
            workbook.SaveAs("E:\\QLBH2\\DanhSachHangDaBan.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application 
            MessageBox.Show("Data Exported Successfully !!!", "Info");
            app.Quit();
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvHangTon.Rows.Count > 0)
            {

                StringWriter sw = new StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);
                htw.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">");
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "DanhSachHangTon.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgvHangTon.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvHangTon.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            for (int i = 0; i < dgvHangTon.Rows.Count - 1; i++)
                            {
                                for (int j = 0; j < dgvHangTon.Columns.Count; j++)
                                {
                                    pdfTable.AddCell(dgvHangTon.Rows[i].Cells[j].Value.ToString());
                                }
                            }
                            FontFactory.Register("C:\\Windows\\Fonts\\times.ttf", "arial unicode ms");
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.HtmlStyleClass = "<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">";
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
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
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
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
            workbook.SaveAs("E:\\QLBH2\\DanhSachHangTon.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            MessageBox.Show("Data Exported Successfully !!!", "Info");
            app.Quit();
            */
        }
    }
}
