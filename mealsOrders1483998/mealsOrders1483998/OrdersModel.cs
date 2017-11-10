using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections;
using System.Drawing;

namespace mealsOrders1483998
{
    public class OrdersModel
    {
        private ArrayList orderList;
        private OrdersController theController;

        public OrdersModel(OrdersController aController)
        {
            orderList = new ArrayList();
            theController = aController;
        }

        public ArrayList OrderList
        {
            get
            {
                return orderList;
            }
        }

        /// <summary>method: AddShape
		/// add shape to the model and update views
		/// </summary>
		/// <param name="aShape"></param>
		public void AddMealOrder(AnyMeal aMeal)
        {
            //shapeList.Add(aShape);
            //UpdateViews();
            orderList.Add(aMeal);
            UpdateViews();
        }

        public void DeleteOrder(int n)
        {
            orderList.RemoveAt(n);
            UpdateViews();
        }

        /// <summary>method: UpdateViews
		/// refresh all views
		/// </summary>
		public void UpdateViews()
        {
            theController.UpdateViews();
        }

    }
}
