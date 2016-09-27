using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGame
{
    public partial class Form1 : Form
    {
        public int top = 50;
        int speed = 4;
        int max = 50;       // height elevation
               
        public Form1()
        {
            InitializeComponent();            
        }

         public void timer1_Tick(object sender, EventArgs e)
        {
            top = top + speed;
            speed += 10;
            

            if (top >= 400 || top <= max )
            {
                speed = -speed ;  // change direction
                max += 15;        // change height elevation
            }         
                     
            Invalidate();
         }

        public void btn1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        public void btn2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.ForestGreen, new Rectangle(400, top, 50, 50));
        }
    }
}
