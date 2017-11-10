using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;

namespace mealsOrders1483998
{
    class AnyCake : AnyMeal
    {
        int size;

        public AnyCake(bool take_away, double meal_price, int due_time, int x_at, int y_at, int cake_size)
            : base("Cake",take_away, meal_price, due_time, x_at, y_at)
		{
            size = cake_size;
        }

        // override method to display shape as text
        public override string ToString()
        {
            //return "Cake: size is " + size.ToString() + " take_away is" + takeaway.ToString() + "price is " + price.ToString() +
            //       " " + time.ToString() + " mins after";
            string res = "Cake," + takeaway.ToString() + "," + price.ToString() + "," + time.ToString();
            res += "," + x.ToString() + "," + y.ToString() + "," + size.ToString() + "#";

            return res;
        }

        // override method to display shape as graphics
        public override void Display(Graphics g)
        {
            int shape_width = 5*size;
            if (g != null)
            {
                Brush br = new SolidBrush(System.Drawing.Color.Yellow);
                g.FillRectangle(br, x, y, shape_width, shape_width);
                br.Dispose();
            }

            if (Highlight)
            //if(false)
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

        public override string name //non abstract property
        {
            get
            {
                return mealName;
            }
            set
            {
                mealName = value;
            }
        }

    }
}
