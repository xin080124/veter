using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDraw
{
    public partial class Form1 : Form
    {
        public int click;
        public int[,] chess = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
            //MarkSquare();
            click = 0;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    chess[row, col] = 0;
                }
            }


        }


        private void MarkSquare(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pn = new Pen(Color.Blue, 4);
            Point pt1 = new Point(30, 80);
            Point pt2 = new Point(110, 150);
            g.DrawLine(pn, pt1, pt2);

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.Location.X / 100;
            int y = e.Location.Y / 100;

            //MarkSquare(object sender, System.Windows.Forms.PaintEventArgs e)
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                chess[x, y] = 1;
                this.panel1.Invalidate();
            }
            else if (e.Button == MouseButtons.Right && e.Clicks == 1)
            {
                chess[x, y] = 2;
                this.panel1.Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            click++;
            int x = click * 5;
            //if (willShowLine)
            {
                Pen pn = new Pen(Color.Blue, 4);
                Point pt1 = new Point(x, 80);
                Point pt2 = new Point(110, 150);
                g.DrawLine(pn, pt1, pt2);
            }
        }

        private void paintChess(Graphics g, object sender, PaintEventArgs e)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (chess[row, col] == 0)
                    {
                        //do nothing
                    }
                    else if (chess[row, col] == 1)
                    {
                        //draw cross
                        Pen pn = new Pen(Color.Black, 4);
                        Point pt1 = new Point(row * 100 + 5, col * 100 + 5);
                        Point pt2 = new Point(row * 100 + 95, col * 100 + 95);
                        g.DrawLine(pn, pt1, pt2);

                        Point pt3 = new Point(row * 100 + 95, col * 100 + 5);
                        Point pt4 = new Point(row * 100 + 5, col * 100 + 95);
                        g.DrawLine(pn, pt3, pt4);

                    }
                    else if (chess[row, col] == 2)
                    {
                        //draw circle
                        Rectangle rect = new Rectangle(row * 100 + 5, col * 100 + 5, 90, 90);
                        Pen pn = new Pen(Color.Red, 3);
                        g.DrawEllipse(pn, rect);
                    }
                }
            }
        }

            
            private void panel1_Paint(object sender, PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                //click++;
                //int x = click * 5;
                //if (willShowLine)
                for (int i = 0; i < 2; i++)
                {
                    Pen pn = new Pen(Color.Orange, 2);
                    Point pt1 = new Point((i + 1) * 100, 0);
                    Point pt2 = new Point((i + 1) * 100, 300);
                    g.DrawLine(pn, pt1, pt2);
                }

                for (int j = 0; j < 2; j++)
                {
                    Pen pn = new Pen(Color.Orange, 2);
                    Point pt1 = new Point(0, (j + 1) * 100);
                    Point pt2 = new Point(300, (j + 1) * 100);
                    g.DrawLine(pn, pt1, pt2);


                }

                paintChess(g, sender, e);

            }
     }
        
    
}
