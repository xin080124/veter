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
        protected bool takeaway;
        protected double price;
        protected int time;

        protected int x;
        protected int y;


        // constructor
        public AnyMeal(bool take_away, double meal_price, int due_time)
        {
            takeaway = take_away;
            price = meal_price;
            time = due_time;
        }

        public abstract void Display(Graphics g); // abstract method

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


    }
}
