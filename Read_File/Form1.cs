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
using Microsoft.Office.Interop.Word;
using GemBox.Document;
namespace Read_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //public static string readword(string path)
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //string path = @"D:\Chuyên đề CNPM\Midterm\text.docx";
            //StreamReader stream = new StreamReader(path);
            //string filedata = stream.ReadToEnd();
            //richTextBox1.Text = filedata.ToString();
            //stream.Close();

            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.ShowDialog();
            string filedata = filedialog.FileName.ToString();
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");

            //// Load Word document from file's path.
            var document = DocumentModel.Load(filedata);

            // Get Word document's plain text.
            string text = document.Content.ToString();
            richTextBox1.Text = text;

            //Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            //Document doc = app.Documents.Open(filedata);
            //string data = doc.Content.Text;
            //richTextBox1.Text = filedata;
            //app.Quit();

            //ComponentInfo.SetLicense("FREE-LIMITED-KEY");

            ////// Load Word document from file's path.
            //var document = DocumentModel.Load(@"D:\Chuyên đề CNPM\Midterm\text.docx");

            //// Get Word document's plain text.
            //string text = document.Content.ToString();
            //richTextBox1.Text = text;







        }
    }
}
