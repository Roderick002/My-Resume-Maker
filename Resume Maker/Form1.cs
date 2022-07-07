using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace Resume_Maker
{
    public partial class Resume_Maker : Form
    {
        public Resume_Maker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnRmSave.Enabled = false;
        }

        private void BtnRmGenerate_Click(object sender, EventArgs e)
        {
            if (TbRmJsonFileName.Text == string.Empty)
            {
                MessageBox.Show("ENTER FILE NAME!");
            }
            else
            {
                StreamReader File = new StreamReader(@"C:\Users\damtr\OneDrive\Desktop\Programs\Resume Maker\JSON Files\" + TbRmJsonFileName.Text + ".json");
                dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadToEnd());

                string[] Extra = new string[6] { "{", "}", ",", "[", "]", "\"" };

                TbRmName.Text = $"{jsonFile["Name"]}";
                TbRmProfile.Text = $"{jsonFile["Profile"]}";
                TbRmObjective.Text = $"{jsonFile["Objective"]}";
                TbRmSkills.Text = $"{jsonFile["Skills"]}";
                TbRmHobbies.Text = $"{jsonFile["Hobbies"]}";
                TbRmEducation.Text = $"{jsonFile["Educational Background"]}";
                TbRmWork.Text = $"{jsonFile["Work Experiences"]}";
                for (int i = 0; i < 6; i++)
                {
                    TbRmProfile.Text = TbRmProfile.Text.Replace(Extra[i], string.Empty);
                    TbRmObjective.Text = TbRmObjective.Text.Replace(Extra[i], string.Empty);
                    TbRmSkills.Text = TbRmSkills.Text.Replace(Extra[i], string.Empty);
                    TbRmHobbies.Text = TbRmHobbies.Text.Replace(Extra[i], string.Empty);
                    TbRmEducation.Text = TbRmEducation.Text.Replace(Extra[i], string.Empty);
                    TbRmWork.Text = TbRmWork.Text.Replace(Extra[i], string.Empty);
                }
                this.TbRmProfile.Text = this.TbRmProfile.Text.Trim();
                this.TbRmObjective.Text = this.TbRmObjective.Text.Trim();
                this.TbRmSkills.Text = this.TbRmSkills.Text.Trim();
                this.TbRmHobbies.Text = this.TbRmHobbies.Text.Trim();
                this.TbRmEducation.Text = this.TbRmEducation.Text.Trim();
                this.TbRmWork.Text = this.TbRmWork.Text.Trim();

                File.Close();
                
                using (var jpeg = new Bitmap(PanelRmDesign.Width, PanelRmDesign.Height))
                {
                    PanelRmDesign.DrawToBitmap(jpeg, new System.Drawing.Rectangle(0, 0, jpeg.Width, jpeg.Height));
                    jpeg.Save(@"C:\Users\damtr\OneDrive\Desktop\Programs\Resume Maker\" + TbRmJsonFileName.Text + ".jpeg");

                }
                
                PbRmPreview.Image = Bitmap.FromFile(@"C:\Users\damtr\OneDrive\Desktop\Programs\Resume Maker\" + TbRmJsonFileName.Text + ".jpeg");
                BtnRmSave.Enabled = true;
                BtnRmGenerate.Enabled = false;
            }
        }

        private void BtnRmSave_Click(object sender, EventArgs e)
        {

            iTextSharp.text.Document Doc = new iTextSharp.text.Document(PageSize.LETTER);
            PdfWriter.GetInstance(Doc, new FileStream(@"C:\Users\damtr\OneDrive\Desktop\Programs\Resume Maker\Resumes\"+ TbRmJsonFileName.Text +".pdf", FileMode.Create));
            Doc.Open();
            System.Drawing.Image img = System.Drawing.Image.FromFile(@"C:\Users\damtr\OneDrive\Desktop\Programs\Resume Maker\" + TbRmJsonFileName.Text + ".jpeg");
            iTextSharp.text.Image Itextimage = iTextSharp.text.Image.GetInstance(img, System.Drawing.Imaging.ImageFormat.Jpeg);
            Itextimage.Alignment = Element.ALIGN_CENTER;
            Itextimage.ScaleToFit(563, 750);
            Doc.Add(Itextimage);
            Doc.Close();

            MessageBox.Show("Your Resume Has Been Successfully Saved!");
            File.Delete(@"C:\Users\damtr\OneDrive\Desktop\Programs\Resume Maker\" + TbRmJsonFileName.Text + ".jpeg");
            BtnRmGenerate.Enabled = true;
            PbRmPreview = null;
            BtnRmSave.Enabled = false;
        }


        private void LblRmName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelRmDesign_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblRmTitle_Click(object sender, EventArgs e)
        {

        }
    }
}