using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Panel_moving
{
    public partial class Form1 : Form
    {
        int Flag;
        Point pp;
        Point z;
        Point a = new Point();
        Point b = new Point();
        Point c = new Point();
        Point d = new Point();

        public Form1()
        {
            setpanel();
            InitializeComponent();
            
        }
        public void setpanel()
        {


        }
        public void setpanelagain()
        {

            panel1.Location = a;

            panel2.Location = b;

            panel3.Location = c;

            panel4.Location = d;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = panel1.Location;

            b = panel2.Location;

            c = panel3.Location;

            d = panel4.Location;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Flag = 1;
                z = panel1.Location;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Flag = 2;

                z = panel2.Location;
            }

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Flag = 3;

                z = panel3.Location;
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Flag = 4;

                z = panel4.Location;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p = MousePosition;
            p.X -= 200;
            p.Y -= 200;
            if (Flag == 1)
            {
                panel1.Location = p;
            }
            else if (Flag == 2)
            {
                panel2.Location = p;
            }
            else if (Flag == 3)
            {
                panel3.Location = p;
            }
            else if (Flag == 4)
            {
                panel4.Location = p;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Flag = 0;
            pp = panel1.Location;
            if (pp.X >= b.X && pp.X < b.X + 300 && pp.Y >= b.Y && pp.Y < b.Y + 200)
            {
                Point k = a;
                a = b;
                b = k;
            }
            else if (pp.X >= c.X && pp.X < c.X + 300 && pp.Y >= c.Y && pp.Y < c.Y + 200)
            {
                Point k = a;
                a = c;
                c = k;
            }
            else if (pp.X >= d.X && pp.X < d.X + 300 && pp.Y >= d.Y && pp.Y < d.Y + 200)
            {
                Point k = a;
                a = d;
                d = k;
            }
            setpanelagain();
            

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Flag = 0;
            pp = panel2.Location;

            if (pp.X >= a.X && pp.X < a.X + 300 && pp.Y >= a.Y && pp.Y < a.Y + 200)
            {
                Point k = b;
                b = a;
                a = k;
            }
            else if (pp.X >= c.X && pp.X < c.X + 300 && pp.Y >= c.Y && pp.Y < c.Y + 200)
            {
                Point k = b;
                b = c;
                c = k;
            }
            else if (pp.X >= d.X && pp.X < d.X + 300 && pp.Y >= d.Y && pp.Y < d.Y + 200)
            {
                Point k = b;
                b = d;
                d = k;
            }
            setpanelagain();
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            Flag = 0;
            pp = panel3.Location;
            if (pp.X >= b.X && pp.X < b.X + 300 && pp.Y >= b.Y && pp.Y < b.Y + 200)
            {
                Point k = c;
                c = b;
                b = k;
            }
            else if (pp.X >= a.X && pp.X < a.X + 300 && pp.Y >= a.Y && pp.Y < a.Y + 200)
            {
                Point k = c;
                c = a;
                a = k;
            }
            else if (pp.X >= d.X && pp.X < d.X + 300 && pp.Y >= d.Y && pp.Y < d.Y + 200)
            {
                Point k = c;
                c = d;
                d = k;
            }
            setpanelagain();
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            Flag = 0;
            pp = panel4.Location;
            if (pp.X >= b.X && pp.X < b.X + 300 && pp.Y >= b.Y && pp.Y < b.Y + 200)
            {
                Point k = d;
                d = b;
                b = k;
            }
            else if (pp.X >= a.X && pp.X < a.X + 300 && pp.Y >= a.Y && pp.Y < a.Y + 200)
            {
                Point k = d;
                d = a;
                a = k;
            }
            else if (pp.X >= c.X && pp.X < c.X + 300 && pp.Y >= c.Y && pp.Y < c.Y + 200)
            {
                Point k = d;
                d = c;
                c = k;
            }
            setpanelagain();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

     
            
        }
}
