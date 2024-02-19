using iTextSharp.text;
using iTextSharp.text.pdf;
//Yukarıdaki 2 kodu iTextSharpı kullanabilmek için yazdım.
using System;
using System.IO;
using System.Windows.Forms;

namespace Dernek_Takip_Projesi.Business_Layer.Features.Dgw_Business
{
    public class ExportDgw
    {
        public bool ExportPdf(DataGridView dataGrid)
        {
            try
            {
                PdfPTable pdfTable = new PdfPTable(dataGrid.ColumnCount);
                pdfTable.DefaultCell.Padding = 2;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 2;
                //Pdf içeriklerinin nasıl olacağını belirledim.
                foreach (DataGridViewColumn column in dataGrid.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                    //Hücredeki satır rengini belirledim.
                }
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }
                //DataGridView içerisindeki hücrelerin icinde döndüm.
                string folderPath = string.Empty;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PDF Files|*.pdf";
                saveFileDialog1.Title = "Save a Pdf File";
                saveFileDialog1.ShowDialog();
                //Konum seçilmesi için gereken pencerenin özelliklerini belirledim.
                if (saveFileDialog1.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    fs.Close();
                    folderPath = fs.Name;
                }
                //Seçilen dosyanın dosya yolunu tutup pencreyi kapadımm
                using (FileStream stream = new FileStream(folderPath, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
                //Boyutları belirledim.
                MessageBox.Show("PDF'e aktarma işlemi başarıyla gerçekleşmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (ArgumentException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF'e aktarma işlemi başarısız. Bilgileri kontrol edip tekrar deneyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
