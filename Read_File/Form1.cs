using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Document;
using ExcelDataReader;
using PdfiumViewer;

namespace Read_File
{
    public partial class Form1 : Form
    {
        PdfiumViewer.PdfViewer pdf;

        public Form1()
        {
            InitializeComponent();
            pdf = new PdfViewer();
            this.Controls.Add(pdf);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void readText(string path)
        {
            richTextBox1.Text = File.ReadAllText(path);
        }

        public void readWord(string path)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            var document = DocumentModel.Load(path);

            // Get Word document's plain text.
            string text = document.Content.ToString();
            richTextBox1.Text = text;
        }

       

        public void readExcel(string path)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            var stream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var result = reader.AsDataSet();
            var tables = result.Tables.Cast<DataTable>();
            foreach(DataTable table in tables)
            {
                dataGridView1.DataSource = table;
            }
        }

        public void readPDF(string path)
        {
            byte[] bytes = System.IO.File.ReadAllBytes(path);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdf.Document = pdfDocument;
        }

        public void textBoxShow()
        {
            richTextBox1.Show();
            dataGridView1.Hide();
        }

        public void gridViewShow()
        {
            richTextBox1.Hide();
            dataGridView1.Show();
        }

        public void hiden()
        {
            richTextBox1.Hide();
            dataGridView1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "File|*.txt;*.doc;*.docx;*.xlsx;*.xlsm;*.pdf|All Files (*.*)|*.*";
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                hiden();
                richTextBox_Path.Text = filedialog.FileName;
                if (filedialog.FileName.EndsWith("txt"))
                {
                    textBoxShow();
                    readText(filedialog.FileName);
                }
                else if (filedialog.FileName.EndsWith("docx") || filedialog.FileName.EndsWith("doc"))
                {
                    textBoxShow();
                    readWord(filedialog.FileName);
                }
                else if (filedialog.FileName.EndsWith("xlsx") || filedialog.FileName.EndsWith("xlsm"))
                {
                    gridViewShow();
                    readExcel(filedialog.FileName);
                    
                }
                else if (filedialog.FileName.EndsWith("pdf"))
                {
                    hiden();
                    richTextBox_Path.Hide();
                    readPDF(filedialog.FileName);

                }


            }


        }
    }
}
