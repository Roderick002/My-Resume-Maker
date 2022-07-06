using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace Resume_Maker
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

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader File = new StreamReader(@"C:\Users\damtr\OneDrive\Desktop\Programs\Resume Maker\Resume.json");
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadToEnd());
            File.Close();

            string[] Extra = new string[6] {"{", "}", ",", "[", "]","\""};
            RtbRmInformationPanel.Text = ($"{jsonFile["PALMES_RODERICK"]}");

            for (int i = 0; i < 6; i++)
            {
                RtbRmInformationPanel.Text = RtbRmInformationPanel.Text.Replace(Extra[i], string.Empty);
            }

            //RtbRmInformationPanel.Lines = RtbRmInformationPanel.Lines.Where(line => line.Trim() != string.Empty).ToArray();

        }



        private void BtnRmSave_Click(object sender, EventArgs e)
        {

            iTextSharp.text.Document Doc = new iTextSharp.text.Document(PageSize.LETTER);
            PdfWriter.GetInstance(Doc, new FileStream(@"C:\Users\damtr\OneDrive\Desktop\Programs\Resume Maker\Resume.pdf", FileMode.Create));
            Doc.Open();
            Doc.Add(new iTextSharp.text.Paragraph(RtbRmInformationPanel.Text));
           

            Doc.Close();
                    
        }
    }
}