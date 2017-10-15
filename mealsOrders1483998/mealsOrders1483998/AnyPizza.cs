using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;

namespace mealsOrders1483998
{
    class AnyPizza: AnyMeal
    {
        //public AnySquare(string shapeName, int x_at, int y_at, int shape_width, int shape_height, Color bkColor) 
        //	: base(shapeName, x_at, y_at, shape_width, shape_height, bkColor)

        private string flavor;

        public AnyPizza(bool take_away, double meal_price, int due_time, int x_at, int y_at, string pizza_flavor)
            : base(take_away, meal_price, due_time, x_at, y_at)
		{
            flavor = pizza_flavor;
        }

        // override method to display shape as text
        public override string ToString()
        {
            //return "Pizza: " + shape_width.ToString() + " cm side at " + this.Position();
            return "Pizza: flavor " + flavor + " take_away is" + takeaway.ToString() + "price is " + price.ToString() + 
                    " " + time.ToString() + " mins after" ;
        }

        // override method to display shape as graphics
        public override void Display(Graphics g)
        {
            int shape_width = 20;

            if (g != null)
            {
                Brush br = new SolidBrush(System.Drawing.Color.Blue);
                //g.FillRectangle(br, x, y, shape_width, shape_width);
                g.FillRectangle(br, x, y, 15, 15);
                br.Dispose();
            }

            //if (Highlight)
            {
                // add in border if shape selected
                // to define point and size
                Point pt = new Point(x + 1, y + 1); // to avoid shadow

                int borderSide = shape_width - 3; // make slightly smaller than shape to avoid shadow
                Size size = new Size(borderSide, borderSide);
                // draw border
                Pen p = new Pen(Color.Black, 3);
                p.DashStyle = DashStyle.Solid;
                g.DrawRectangle(p, new Rectangle(pt, size));

                p.Dispose();
            }
        }

        public override int x_pos //non abstract property
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public override int y_pos //non abstract property
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }


    }
}
