using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Julia2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Default;
        bool UserInput;

        


        private void Form1_Shown_1(object sender, EventArgs e)
        {
                
            
        }




        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Default = true;
            UserInput = false;

            Console.Write("hello\n");

            Bitmap bm = new Bitmap(picCanvas.Width, picCanvas.Height);
            for (int x = 0; x < picCanvas.Width; x++)
            {
                for (int y = 0; y < picCanvas.Height; y++)
                {
                    currentc0.Text = "C0 = " + 0;
                    currentc1.Text = "C1 = " + 0;

                    double a = (double)(x - (picCanvas.Width / 2)) / (double)(picCanvas.Width / 4);
                    double b = (double)(y - (picCanvas.Height / 2)) / (double)(picCanvas.Height / 4);
                    Complex c0 = new Complex(a, b);
                    Complex c1 = new Complex(0, 0);
                    Complex z = new Complex(0, 0);
                    int it = 0;
                    do
                    {
                        it++;
                        z.Square();
                        if (it == 1)
                        {
                            z.Add(c0);
                        }
                        else
                        {
                            z.Add(c1);
                        }
                        if (z.Magnitude() > 2.0) break;
                    }
                    while (it < 100);
                    bm.SetPixel(x, y, Color.FromArgb(it % 128 * 2, it % 64 * 4, it % 32 * 8));

                }

                picCanvas.Image = bm;
            }


        }

        private void ffffffffffffffffffffffff_Click(object sender, EventArgs e)
        {

        }

        private void c1textbox_TextChanged(object sender, EventArgs e)
        {
            
            //userc1 = Convert.ToDouble(c1textbox.Text, formatProvider);
           // Console.Write("output is " + userc1);
        }

        private void currentc1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Default = false;
            UserInput = true;

            double userc0;
            double userc1;

            NumberFormatInfo formatProvider = new NumberFormatInfo();
            formatProvider.NumberDecimalSeparator = ".";
            userc0 = Convert.ToDouble(c0textbox.Text, formatProvider);
            userc1 = Convert.ToDouble(c1textbox.Text, formatProvider);
            Complex c1 = new Complex(userc0, userc1);

            Bitmap bm = new Bitmap(picCanvas.Width, picCanvas.Height);
            for (int x = 0; x < picCanvas.Width; x++)
            {
                for (int y = 0; y < picCanvas.Height; y++)
                {
                    currentc0.Text = "C0 = " + userc0;
                    currentc1.Text = "C1 = " + userc1;

                    double a = (double)(x - (picCanvas.Width / 2)) / (double)(picCanvas.Width / 4);
                    double b = (double)(y - (picCanvas.Height / 2)) / (double)(picCanvas.Height / 4);
                    Complex c0 = new Complex(a, b);
                    //Complex c1 = new Complex(0, 0);
                    Complex z = new Complex(0, 0);
                    int it = 0;
                    do
                    {
                        it++;
                        z.Square();
                        if (it == 1)
                        {
                            z.Add(c0);
                        }
                        else
                        {
                            z.Add(c1);
                        }
                        if (z.Magnitude() > 2.0) break;
                    }
                    while (it < 100);
                    bm.SetPixel(x, y, Color.FromArgb(it % 128 * 2, it % 64 * 4, it % 32 * 8));

                }

                picCanvas.Image = bm;
            }


        }

        private void c0textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
