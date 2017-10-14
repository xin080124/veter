using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace mealsOrders1483998
{
    public interface IOrderView
    {
        void RefreshView();
    }

    public class OrdersController
    {
        private ArrayList ViewList;

        // constructor
        public OrdersController()
        {
            ViewList = new ArrayList();
        }

        /// <summary>method: AddView
        /// add view to viewlist
        /// </summary>
        /// <param name="aView"></param>
        public void AddView(IOrderView aView)
        {
            ViewList.Add(aView);
        }

        /// <summary>method: UpdateViews
        /// update each view 
        /// </summary>
        public void UpdateViews()
        {
            IOrderView[] theViews = (IOrderView[])ViewList.ToArray(typeof(IOrderView));
            foreach (IOrderView v in theViews)
            {
                v.RefreshView();
            }
        }
    }
}
