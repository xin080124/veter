using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace mealsOrders1483998
{
    public abstract class AnyMeal
    {
        protected string mealName;

        protected bool takeaway;
        protected double price;
        protected int time;

        protected int x;
        protected int y;

        // added for hittest and highlight
        bool highlight;
        
        // constructor
        public AnyMeal(string name , bool take_away, double meal_price, int due_time, int x_at, int y_at)
        {
            mealName = name;
            takeaway = take_away;
            price = meal_price;
            time = due_time;

            x = x_at;
            y = y_at;
        }


        

        public abstract void Display(Graphics g); // abstract method

        public bool Highlight
        {
            get
            {
                return highlight;
            }
            set
            {
                highlight = value;
            }
        }

        public string Position()  //non abstract method
        {
            return "(" + x.ToString() + "," + y.ToString() + ")";
        }

        public abstract int x_pos //abstract property
        {
            get;
            set;
        }

        public abstract int y_pos //abstract property
        {
            get;
            set;
        }

        public abstract string name //abstract property
        {
            get;
            set;
        }

        // virtual method
        public virtual bool HitTest(Point p)
        {
            Point pt = new Point(x, y);
            Size size = new Size(100, 100);
            //default behaviour
            return new Rectangle(pt, size).Contains(p);
        }


    }
}
