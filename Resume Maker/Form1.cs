using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            StreamReader File = new StreamReader(@"C:\Users\damtr\OneDrive\Desktop\Programs\JSON files\Resume.json");
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadToEnd());
            File.Close();

            MessageBox.Show($"My name is: {jsonFile["Objective"]}");
        }
    }
}