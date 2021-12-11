using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imcane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string FilePath;

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
            
            FilePath = openFileDialog1.FileName;
            pictureBox1.ImageLocation = FilePath;
            Image m = pictureBox1.Image;
           
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        

        
    }
}
