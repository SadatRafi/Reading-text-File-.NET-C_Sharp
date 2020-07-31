using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 
namespace Reading_text_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var File_Path = string.Empty;
            openFileDialog1.InitialDirectory = "E:\\Dot Net Framework Notes\\Visual Studio 2019 Notes\\AP01 - Reading text files";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                File_Path = openFileDialog1.FileName;
            }

            StreamReader Dataset = new StreamReader(File_Path);
            string Data_Value = Dataset.ReadToEnd();
            Dataset.Close();

            textBox1.Text = Data_Value;
        }
    }
}
