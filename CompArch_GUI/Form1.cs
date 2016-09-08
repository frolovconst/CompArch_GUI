using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompArch_GUI
{
    public partial class Form1 : Form
    {
        static byte infoByte = 0xAA;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monitorVM_Click(object sender, EventArgs e)
        {
            //Bitmap monBmp = new Bitmap(;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
            
        //}

        private void renderByteHorizontally(Bitmap image, byte infoByte, int startCol, int startRow)
        {
            int i;
            byte auxByte = 0x80;
            for (i = 0; i < 8; i++)
            {
                if((infoByte & auxByte) == 0)
                {
                    image.SetPixel(i + startCol, startRow, Color.White);
                }
                else
                {
                    image.SetPixel(i + startCol, startRow, Color.Black);
                }
                auxByte = (byte)(auxByte >> 1);
            }
        
        }


        private void runButton_Click(object sender, EventArgs e)
        {
            runButton.Text = "Been pushed";
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            //infoByte = 170;
            int bMapSizeX = 256, bMapSizeY = 256;
            Bitmap monitorPicture = new Bitmap(bMapSizeX, bMapSizeY);
            for (int xPos = 0; xPos < 256; xPos += 8)
            {
                for (int yPos = 0; yPos < 256; yPos++)
                    renderByteHorizontally(monitorPicture, infoByte, xPos, yPos);
            }
            monitorVM.Image = monitorPicture;
            infoByte = (byte)(~infoByte);
            //infoByte = (byte)(infoByte << 1);
        }
    }
}
