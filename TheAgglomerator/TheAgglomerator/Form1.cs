using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D; 

namespace TheAgglomerator
{
    public partial class Form1 : Form
    {
        ArrayList dropletHolder = new ArrayList();       
        int interval;
        private Bitmap aBitMap;
        private int counter = 0;
        int redColor; 
        int greenColor;
        int blueColor;
        public Form1()
        {
            InitializeComponent();
            interval = trackBar1.Value;
            timer1.Interval = interval;
        }

        public void makeDrops()
        {
            try
            {
                int w = agglomBox.Width;
                int h = agglomBox.Height;
                int numOfDrops = int.Parse(numOfDrop.Text);
                float maxVelocity = float.Parse(maxVeloc.Text);
                float dropletSizes = float.Parse(dropSize.Text);
                redColor = int.Parse(red.Text);
                greenColor = int.Parse(green.Text);
                blueColor = int.Parse(blue.Text);
                Random rng1 = new Random();
                System.Threading.Thread.Sleep(10);
                Random rng2 = new Random();
                float[] listOfX = new float[numOfDrops];
                float[] listOfY = new float[numOfDrops];
                float[] listOfSpeedx = new float[numOfDrops];
                float[] listOfSpeedy = new float[numOfDrops];
                for(int i=0;i<listOfX.Length;i++)
                {
                    float temp = (float)((Math.Sqrt(-2.0 * Math.Log(rng1.NextDouble())) * Math.Cos(2.0 * Math.PI * rng2.NextDouble())));
                    temp += 1;
                    temp *= (w/2);
                    listOfX[i] = temp;
                }
                for(int i=0;i<listOfY.Length;i++)
                {
                    float temp = (float)((Math.Sqrt(-2.0 * Math.Log(rng1.NextDouble())) * Math.Cos(2.0 * Math.PI * rng2.NextDouble())));
                    temp += 1;
                    temp *= (w/2);
                    listOfY[i] = temp;
                }
                for(int i=0;i<listOfY.Length;i++)
                {
                    float tempx = (float)((Math.Sqrt(-2.0 * Math.Log(rng1.NextDouble())) * Math.Cos(2.0 * Math.PI * rng2.NextDouble())));
                    float tempy = (float)((Math.Sqrt(-2.0 * Math.Log(rng1.NextDouble())) * Math.Cos(2.0 * Math.PI * rng2.NextDouble())));
                    tempx *= maxVelocity;
                    tempy *= maxVelocity;
                    listOfSpeedx[i] = tempx;
                    listOfSpeedy[i] = tempy;
                }
                for(int i=0;i<numOfDrops;i++)
                {
                    dropletHolder.Add(new droplets(listOfX[i],listOfY[i],listOfSpeedx[i],listOfSpeedy[i],dropletSizes,redColor,blueColor,greenColor,(float)(Math.Pow(dropletSizes/2,2))));
                }
            }
            catch(Exception e)
            {
                Console.Write("Please enter valid values");
            }

        }

        private void resetFrameBuffer()
        {
            Graphics g = CreateGraphics();
            if(aBitMap != null)
                aBitMap.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            aBitMap = new Bitmap(agglomBox.Width, agglomBox.Height, g);
        }

        private void drawDroplets()
        {
            resetFrameBuffer();
            Graphics g = Graphics.FromImage(aBitMap);
            System.Drawing.SolidBrush dropletDrawer = new System.Drawing.SolidBrush(Color.Black);
            foreach(droplets drop in dropletHolder)
            {
                dropletDrawer.Color = drop.Color;
                g.FillEllipse(dropletDrawer,drop.X,drop.Y,drop.Size,drop.Size);
            }
            agglomBox.Image = aBitMap;
        }

        private void updateDroplets()
        {
            foreach(droplets drop in dropletHolder)
            {
                drop.move();
                drop.wrap(agglomBox.Width,agglomBox.Height);
            }
        }

        private void collisionCheck()
        {
            ArrayList temp = new ArrayList();           
                for (int i = 0; i < dropletHolder.Count - 1; i++)
                {
                    for (int j = i+1; j < dropletHolder.Count; j++)
                    {
                        droplets one = (droplets)(dropletHolder[i]);
                        droplets two = (droplets)(dropletHolder[j]);
                        float cx1 = one.X + (one.Size / 2.0F);
                        float cx2 = two.X + (two.Size / 2.0F);
                        float cy1  = one.Y + (one.Size / 2.0F);
                        float cy2 = two.Y + (two.Size / 2.0F);
                        if (Math.Sqrt(Math.Pow(cx1 - cx2,2) + Math.Pow(cy1 - cy2,2)) < one.Size / 2 + two.Size / 2)
                        {
                            float diameter = (float)(2*Math.Sqrt(one.Mass + two.Mass));
                            float x = (one.Mass * one.X + two.Mass * two.X) / (one.Mass + two.Mass);
                            float y = (one.Mass * one.Y + two.Mass * two.Y) / (one.Mass + two.Mass);
                            float vx = (one.Mass * one.VX + two.Mass * two.VX) / (one.Mass + two.Mass);
                            float vy = (one.Mass * one.VY + two.Mass * two.VY) / (one.Mass + two.Mass);
                            float massD = one.Mass + two.Mass;
                            dropletHolder.Add(new droplets(x, y, vx, vy, diameter, redColor, greenColor, blueColor,massD));
                            dropletHolder.Remove(one);
                            dropletHolder.Remove(two);
                        }
                    }
                }
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            drawDroplets();
            updateDroplets();
            collisionCheck();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            interval = trackBar1.Value;
            timer1.Interval = interval;
            tickLabel.Text = interval.ToString();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if(counter == 0)
                makeDrops();
            counter++;
            timer1.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }


    }
}
