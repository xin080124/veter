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
            : base("Noodle",take_away, meal_price, due_time, x_at, y_at)
		{
            //flavor = pizza_flavor;
            ifSpicy = if_spicy;

           
        }

        // override method to display shape as text
        public override string ToString()
        {
            //return "Noodle: if spicy " + ifSpicy + " take_away is" + takeaway.ToString() + "price is " + price.ToString() +
            //        " " + time.ToString() + " mins after";

            string res = "Noodle," + takeaway.ToString() + "," + price.ToString() + "," + time.ToString();
            res += "," + x.ToString() + "," + y.ToString() + "," + ifSpicy.ToString() + "#";

            return res;

        }

        // override method to display shape as graphics
        public override void Display(Graphics g)
        {
            int shape_width = 20;

            if (g != null)
            {
                Brush br;
                if (Highlight)
                {
                    //else if (flavor == "seafood")
                    //    pizzaColor = System.Drawing.Color;
                    br = new SolidBrush(System.Drawing.Color.Black);
                    //g.FillRectangle(br, x, y, shape_width, shape_width);
                    
                }
                else
                {
                    br = new SolidBrush(System.Drawing.Color.White);
                }

                g.FillEllipse(br, x, y, 30, 30);
                br.Dispose();
            }

            // if shape needs border to be drawn
            //if (Highlight)
            if (true)
            {
                Color noodleColor = System.Drawing.Color.Blue;
                if (ifSpicy == true)
                    noodleColor = System.Drawing.Color.Red;
                // make slightly smaller than shape to avoid shadow
                float borderDiameter = (float)(shape_width - 3);
                borderDiameter = (float)30.0;
                // draw border around circle
                Pen p = new Pen(noodleColor, 3);
                p.DashStyle = DashStyle.Solid;
                // to avoid shadow position move position by 1.5
                float xFloat = (float)(x + 1.5); float yFloat = (float)(y + 1.5);

                g.DrawEllipse(p, xFloat, yFloat, borderDiameter, borderDiameter);

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
