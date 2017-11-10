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
            : base("Pizza", take_away, meal_price, due_time, x_at, y_at)
		{
            flavor = pizza_flavor;
        }

        // override method to display shape as text
        public override string ToString()
        {
            //return "Pizza: " + shape_width.ToString() + " cm side at " + this.Position();
            //return "Pizza: flavor " + flavor + " take_away is" + takeaway.ToString() + "price is " + price.ToString() + 
            //        " " + time.ToString() + " mins after" ;
            string res = "Pizza," + takeaway.ToString() + "," + price.ToString() + "," + time.ToString();
            res += "," + x.ToString() + "," + y.ToString() + "," + flavor + "#";

            return res;    
        }

        // override method to display shape as graphics
        public override void Display(Graphics g)
        {
            int shape_width = 20;

            if (g != null)
            {
                Color pizzaColor = System.Drawing.Color.Aqua;
                if(flavor == "vegetable")
                    pizzaColor = System.Drawing.Color.Green;
                else if (flavor == "BBQ")
                    pizzaColor = System.Drawing.Color.Brown;
                else if (flavor == "Beef")
                    pizzaColor = System.Drawing.Color.Red;
                
                //else if (flavor == "seafood")
                //    pizzaColor = System.Drawing.Color;
                Brush br = new SolidBrush(pizzaColor);
                //g.FillRectangle(br, x, y, shape_width, shape_width);
                g.FillEllipse(br, x, y, 30, 30);
                br.Dispose();
            }

            // if shape needs border to be drawn
            if (Highlight)
            //if (false)
            {
                // make slightly smaller than shape to avoid shadow
                float borderDiameter = (float)(shape_width - 3);
                borderDiameter = (float)30.0;
                // draw border around circle
                Pen p = new Pen(Color.Black, 3);
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
