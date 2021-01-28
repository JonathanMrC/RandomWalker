using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWalker
{
    public partial class Form1 : Form
    {
        Walker one;
        Random r;
        Graphics graphic;
        Bitmap btmp;
        bool monochrome;
        int increase, cont, red, blue, green, turn;

        public Form1()
        {
            InitializeComponent();
            monochrome = false;
            increase = 5;
            cont = turn = 0;
            //Creating the image
            btmp = new Bitmap(pic_box.Width, pic_box.Height);
            graphic = Graphics.FromImage(btmp);
            graphic.Clear(Color.White);
            pic_box.Image = btmp;
            //Creating the walker
            one = new Walker(pic_box.Width, pic_box.Height, 2);
            r = new Random(new Random(846213213).Next());
            red = r.Next(20, 241);
            blue = r.Next(20, 241);
            green = r.Next(20, 241);
            Simulation.Start();
        }

        void Draw()
        {
            Pen x = new Pen(Color.Black);
            switch (turn++)
            {
                case 0:
                    {
                        ++red;
                        red %= 240;
                    }
                    break;
                case 1:
                    {
                        ++blue;
                        blue %= 240;
                    }
                    break;
                case 2:
                    {
                        ++green;
                        green %= 240;
                    }
                    break;
            }
            turn %= 3;
            if (!monochrome) x = new Pen(Color.FromArgb(red, green, blue));
            graphic.DrawEllipse(x, one.X, one.Y, one.Radio, one.Radio);
            pic_box.Refresh();
        }

        private void Simulation_Tick(object sender, EventArgs e)
        {
            one.Walk(r);
            Draw();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char x = char.ToLower(e.KeyChar);
            if (x.Equals('w')) one.IncreaseRadio(increase);
            else if (x.Equals('s')) one.DecreaseRadio(increase);
            else if (x.Equals('a') || x.Equals('d')) monochrome = !monochrome;
            else if (x.Equals('r')) graphic.Clear(Color.White);
            else
            {
                if (++cont >= 3)
                {
                    MessageBox.Show("Funciones de las teclas:\r\n"
                                    + "'w' Agrandar el radio del circulo\r\n"
                                    + "'s' Acortar el radio del circulo\r\n"
                                    + "'a' o 'd' Alternar entre negro o colores\r\n"
                                    + "'r' Limpiar el fondo\r\n"
                                    , "Información",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    cont = 0;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Simulation.Stop();
        }

    }
}
