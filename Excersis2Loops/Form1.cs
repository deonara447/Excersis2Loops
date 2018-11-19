using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Excersis2Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            //initialize
            int x = 50;
            int y = 200;
            int starSize = 10;

            //test 
            while (y > 50)
            {
                //act
                formGraphics.Clear(Color.Black);
                formGraphics.FillRectangle(drawBrush, x, y, starSize, starSize);
                Thread.Sleep(5);

                //change
                y--;
            }
            int pixelGrow = 1;
            int r = 255;
            int g = 255;
            int b = 0;
            while (pixelGrow < 50)

            {
                //act
                formGraphics.Clear(Color.Black);
                formGraphics.FillRectangle(drawBrush, x - pixelGrow / 2, y - pixelGrow, starSize + pixelGrow, starSize + pixelGrow);
                

                Thread.Sleep(5);

                //change
                pixelGrow++;
                drawBrush.Color = Color.FromArgb(r, g, b);
                b +=5;

            }



            
                    
            }
        }
    }

