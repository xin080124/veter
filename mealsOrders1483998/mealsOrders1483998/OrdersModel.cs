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
        private ArrayList shapeList;
        private OrdersController theController;

        public OrdersModel(OrdersController aController)
        {
            shapeList = new ArrayList();
            theController = aController;
        }


    }
}
