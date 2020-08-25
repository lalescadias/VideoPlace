
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;

class Util
{

    public static string title = "Video Place";

    public static string removeSpaces(string data)
    {
        data = data.Trim();
        data = Regex.Replace(data, @"\s+", " ");
        return data;

    }
    public static void cleanfields(ref TextBox text, ref TextBox text2, ref TextBox text3)
    {
        text.Clear();
        text2.Clear();
        text3.Clear();
    }
    public static void cleanfields(ref TextBox text, ref ComboBox cb1, ref TextBox text3, ref TextBox text4, ref TextBox text5)
    {
        text.Clear();
        cb1.SelectedIndex = 25;
        text3.Clear();
        text4.Clear();
        text5.Clear();
    }
    public static void cleanfields1(ref TextBox text, ref ComboBox cb1, ref TextBox text3, ref TextBox text4, ref TextBox text5)
    {
        text.Clear();
        cb1.Text = "";
        text3.Clear();
        text4.Clear();
        text5.Clear();
    }
    public static void printDataGridView(DataGridView dataGridView)
    {
        if (dataGridView.Rows.Count > 0)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "print.pdf";
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
                        PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;



                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }



                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(cell.Value.ToString());
                            }
                        }



                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
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





}

