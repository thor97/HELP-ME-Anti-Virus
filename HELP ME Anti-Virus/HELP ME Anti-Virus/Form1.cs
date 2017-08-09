using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELP_ME_Anti_Virus
{
    public partial class Form1 : Form
    {
        public static int isScannig;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            button2.Enabled = false;

            if (Directory.Exists("C:\\newfolder"))
            {
                
            } 
            else
            {
                Directory.CreateDirectory("C:\\HELP ME Anti-Virus");
                
            }
            SetMyButtonIcon();
        }

        private void SetMyButtonIcon()
        {
            var bmp = new Bitmap(Properties.Resources.search1600);
            // Assign an image to the button.
            button1.Image = bmp;
            // Align the image and text on the button.
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.TextAlign = ContentAlignment.MiddleRight;

            var bmp2 = new Bitmap(Properties.Resources._687474703a2f2f692e696d6775722e636f6d2f48656c687441782e706e67);
            // Assign an image to the button.
            button2.Image = bmp2;
            // Align the image and text on the button.
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.TextAlign = ContentAlignment.MiddleRight;

            var bmp3 = new Bitmap(Properties.Resources.notepad_icon);
            // Assign an image to the button.
            button3.Image = bmp3;
            // Align the image and text on the button.
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.TextAlign = ContentAlignment.MiddleRight;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void customScanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customScan();
        }

        public void customScan()
        {
            MessageBox.Show("Thor");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            customScan();
        }
    }
}
