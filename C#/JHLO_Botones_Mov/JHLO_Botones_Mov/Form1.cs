using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JHLO_Botones_Mov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void JTimer_Tick(object sender, EventArgs e)
        {
            int k, j, i;         ////Y

            int[] Y = new int[4];
            Random mRand = new Random();

            for (i = 0; i < 4; i++)
            {
                k = mRand.Next(30, 200);
                Y[i] = k;
            }

            for (i = 0; i < 4; i++)
            {
                for (j = i + 1; j < 4; j++)
                {
                    if (Y[i] == Y[j])
                    {
                        k = mRand.Next(30, 200);
                        Y[i] = k;
                    }
                }
            }
            int Xcero = 0, A = 0, B = 0, N = 0;
            Xcero = Y[0];
            A = Y[1];
            B = Y[2];
            N = Y[3];
            //MessageBox.Show("This " + i);
            int[] XY = new int[20];
            for (i = 0; i < 20; i++)
            {
                Xcero = (Xcero * A + B) % N;
                double R = (double)Xcero / N;
                float Temp = (float)R * 1000;
                if (Temp > 900)
                {
                   // MessageBox.Show("This " + i);
                    Temp = Temp - 500;
                }
                else if (Temp < 50)
                {
                     Temp = Temp + 50;
                }
                XY[i] = (int)Temp;
            }

            for (i = 10; i < 20; i++)
            {
                if (XY[i] > 600)
                {
                    
                    XY[i] = XY[i] - 100;
                }
                else if (XY[i] < 50)
                {
                    XY[i] = XY[i] + 50;
                }
             
            }



            BTN_10.Location = new Point(XY[0], XY[10]);
            BTN_20.Location = new Point(XY[1], XY[11]);
            BTN_30.Location = new Point(XY[2], XY[12]);
            BTN_40.Location = new Point(XY[3], XY[13]);
            BTN_50.Location = new Point(XY[4], XY[14]);
            BTN_60.Location = new Point(XY[5], XY[15]);
            BTN_70.Location = new Point(XY[6], XY[16]);
            BTN_80.Location = new Point(XY[7], XY[17]);
            BTN_90.Location = new Point(XY[8], XY[18]);
            BTN_100.Location = new Point(XY[9], XY[19]);
        }

        private void BTN_10_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Elegiste 10");

            MessageBox.Show("Lo Siento!! Elegiste 10", "!!!! Calificacion Eelegida!!!!", 
                MessageBoxButtons.OK, MessageBoxIcon.Information); 
            JTimer.Enabled = false;
            BTN_10.Location = new Point(58, 86);
            BTN_20.Location = new Point(233, 86);
            BTN_30.Location = new Point(388, 86);
            BTN_40.Location = new Point(550, 86);
            BTN_50.Location = new Point(712, 86);
            BTN_60.Location = new Point(58, 321);
            BTN_70.Location = new Point(233, 321);
            BTN_80.Location = new Point(388, 321);
            BTN_90.Location = new Point(550, 321);
            BTN_100.Location = new Point(712, 321);
        }

        private void BTN_20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lo Siento!! Elegiste 20", "!!!! Calificacion Eelegida!!!!",
               MessageBoxButtons.OK, MessageBoxIcon.Information); 
            JTimer.Enabled = false;
            BTN_10.Location = new Point(58, 86);
            BTN_20.Location = new Point(233, 86);
            BTN_30.Location = new Point(388, 86);
            BTN_40.Location = new Point(550, 86);
            BTN_50.Location = new Point(712, 86);
            BTN_60.Location = new Point(58, 321);
            BTN_70.Location = new Point(233, 321);
            BTN_80.Location = new Point(388, 321);
            BTN_90.Location = new Point(550, 321);
            BTN_100.Location = new Point(712, 321);
        }

        private void BTN_30_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No fue tan malo!! Elegiste 30", "!!!! Calificacion Eelegida!!!!",
               MessageBoxButtons.OK, MessageBoxIcon.Information); 
            JTimer.Enabled = false;
            BTN_10.Location = new Point(58, 86);
            BTN_20.Location = new Point(233, 86);
            BTN_30.Location = new Point(388, 86);
            BTN_40.Location = new Point(550, 86);
            BTN_50.Location = new Point(712, 86);
            BTN_60.Location = new Point(58, 321);
            BTN_70.Location = new Point(233, 321);
            BTN_80.Location = new Point(388, 321);
            BTN_90.Location = new Point(550, 321);
            BTN_100.Location = new Point(712, 321);
        }

        private void BTN_40_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No esta mal!!! 40", "!!!! Calificacion Eelegida!!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information); 
            JTimer.Enabled = false;
            BTN_10.Location = new Point(58, 86);
            BTN_20.Location = new Point(233, 86);
            BTN_30.Location = new Point(388, 86);
            BTN_40.Location = new Point(550, 86);
            BTN_50.Location = new Point(712, 86);
            BTN_60.Location = new Point(58, 321);
            BTN_70.Location = new Point(233, 321);
            BTN_80.Location = new Point(388, 321);
            BTN_90.Location = new Point(550, 321);
            BTN_100.Location = new Point(712, 321);
        }

        private void BTN_50_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bien!! Elegiste 50", "!!!! Calificacion Eelegida!!!!",
               MessageBoxButtons.OK, MessageBoxIcon.Information); 
            JTimer.Enabled = false;
            BTN_10.Location = new Point(58, 86);
            BTN_20.Location = new Point(233, 86);
            BTN_30.Location = new Point(388, 86);
            BTN_40.Location = new Point(550, 86);
            BTN_50.Location = new Point(712, 86);
            BTN_60.Location = new Point(58, 321);
            BTN_70.Location = new Point(233, 321);
            BTN_80.Location = new Point(388, 321);
            BTN_90.Location = new Point(550, 321);
            BTN_100.Location = new Point(712, 321);
        }

        private void BTN_60_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buen numero!! Elegiste 60", "!!!! Calificacion Eelegida!!!!",
               MessageBoxButtons.OK, MessageBoxIcon.Information); 
            JTimer.Enabled = false;
            BTN_10.Location = new Point(58, 86);
            BTN_20.Location = new Point(233, 86);
            BTN_30.Location = new Point(388, 86);
            BTN_40.Location = new Point(550, 86);
            BTN_50.Location = new Point(712, 86);
            BTN_60.Location = new Point(58, 321);
            BTN_70.Location = new Point(233, 321);
            BTN_80.Location = new Point(388, 321);
            BTN_90.Location = new Point(550, 321);
            BTN_100.Location = new Point(712, 321);
        }

        private void BTN_70_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muy Bien!! Elegiste 70", "!!!! Calificacion Eelegida!!!!",
               MessageBoxButtons.OK, MessageBoxIcon.Information); 
            JTimer.Enabled = false;
            BTN_10.Location = new Point(58, 86);
            BTN_20.Location = new Point(233, 86);
            BTN_30.Location = new Point(388, 86);
            BTN_40.Location = new Point(550, 86);
            BTN_50.Location = new Point(712, 86);
            BTN_60.Location = new Point(58, 321);
            BTN_70.Location = new Point(233, 321);
            BTN_80.Location = new Point(388, 321);
            BTN_90.Location = new Point(550, 321);
            BTN_100.Location = new Point(712, 321);
        }

        private void BTN_80_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!! Genial !!! Elegiste 80", "!!!! Calificacion Eelegida!!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information); 
            JTimer.Enabled = false;
            BTN_10.Location = new Point(58, 86);
            BTN_20.Location = new Point(233, 86);
            BTN_30.Location = new Point(388, 86);
            BTN_40.Location = new Point(550, 86);
            BTN_50.Location = new Point(712, 86);
            BTN_60.Location = new Point(58, 321);
            BTN_70.Location = new Point(233, 321);
            BTN_80.Location = new Point(388, 321);
            BTN_90.Location = new Point(550, 321);
            BTN_100.Location = new Point(712, 321);
        }

        private void BTN_90_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!Maravilloso!! Elegiste 10", "!!!! Calificacion Eelegida!!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information); 
            JTimer.Enabled = false;
            BTN_10.Location = new Point(58, 86);
            BTN_20.Location = new Point(233, 86);
            BTN_30.Location = new Point(388, 86);
            BTN_40.Location = new Point(550, 86);
            BTN_50.Location = new Point(712, 86);
            BTN_60.Location = new Point(58, 321);
            BTN_70.Location = new Point(233, 321);
            BTN_80.Location = new Point(388, 321);
            BTN_90.Location = new Point(550, 321);
            BTN_100.Location = new Point(712, 321);
        }

        private void BTN_100_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!! Excelente Felicidadez !!! Elegiste 100", "!!!! Calificacion Eelegida!!!!",
               MessageBoxButtons.OK, MessageBoxIcon.Information); 
            JTimer.Enabled = false;
            BTN_10.Location = new Point(58, 86);
            BTN_20.Location = new Point(233, 86);
            BTN_30.Location = new Point(388, 86);
            BTN_40.Location = new Point(550, 86);
            BTN_50.Location = new Point(712, 86);
            BTN_60.Location = new Point(58, 321);
            BTN_70.Location = new Point(233, 321);
            BTN_80.Location = new Point(388, 321);
            BTN_90.Location = new Point(550, 321);
            BTN_100.Location = new Point(712, 321);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (JTimer.Enabled == true)
            {

            }
            else
            {
                JTimer.Enabled = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (JTimer.Enabled == false)
            {

            }
            else
            {
                JTimer.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            JTimer.Enabled = true;
        }
    }
}
