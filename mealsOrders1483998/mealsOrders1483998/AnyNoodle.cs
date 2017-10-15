using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;


namespace mealsOrders1483998
{
    class AnyNoodle: AnyMeal
    {
        bool ifSpicy;

        public AnyNoodle(bool take_away, double meal_price, int due_time, int x_at, int y_at, bool if_spicy)
            : base(take_away, meal_price, due_time, x_at, y_at)
		{
            //flavor = pizza_flavor;
            ifSpicy = if_spicy;
        }

        // override method to display shape as text
        public override string ToString()
        {
             return "Noodle: if spicy " + ifSpicy + " take_away is" + takeaway.ToString() + "price is " + price.ToString() +
                    " " + time.ToString() + " mins after";
        }

        // override method to display shape as graphics
        public override void Display(Graphics g)
        {
            if (g != null)
            {
                // set points of triangle
                Point pt1 = new Point(x, y);
                Point pt2 = new Point(x, 10 + y);
                Point pt3 = new Point(10 + x, y);

                Point[] points = { pt1, pt2, pt3 };

                Brush br = new SolidBrush(System.Drawing.Color.Blue);
                // create triangle (polygon with three points)
                g.FillPolygon(br, points);
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
