using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mealsOrderList
{
    class Meals
    {
        protected bool eatOutside;
        protected double price;
        protected int serveTime;
        public viewControl ctrl;

        public Meals(viewControl theCtrl)
        {
            ctrl = theCtrl;
            eatOutside = true;
            price = 1.8;
            serveTime = 0;
        }

        public void setTimes()
        {
            serveTime++;
            ctrl.updateView1();
        }

    }
}
