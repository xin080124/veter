using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace mealsOrders1483998
{
    
    public partial class ViewForm2 : System.Windows.Forms.Form, IOrderView
    {
        private OrdersModel myModel;

        public ViewForm2()
        {
            InitializeComponent();
        }

        // set method for myModel
        //public OrdersModel myModel
        public OrdersModel MyModel
        {
            set
            {
                myModel = value;
            }
        }



        /// <summary>method: clearPanel
		/// clear all shapes from display on panel
		/// </summary>
		private void clearPanel()
        {
            //pnlDrawOn.CreateGraphics().Clear(pnlDrawOn.BackColor);
        }
        
        public void RefreshView()
        {
            // clear drawOn panel
            clearPanel();
            // create arrayList from model and convert to array of shapes
            ArrayList theOrderList = myModel.OrderList;
            AnyMeal[] theMeals = (AnyMeal[])theOrderList.ToArray(typeof(AnyMeal));
            Graphics g = this.pnlDrawOn.CreateGraphics();
            // draw all shapes in array
            foreach (AnyMeal am in theMeals)
            {
                am.Display(g);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AnyMeal aMeal;

            if (rbPizza.Checked)
            {
                //aShape = new AnyCircle("circle", X, Y, Width, Height, aColor);
                //myModel.AddShape(aShape);

                aMeal = new AnyPizza(true, 5.99, 180, 10, 10, "hah");
                myModel.AddMealOrder(aMeal);

            }
            else if (rbNoodle.Checked)
            {
                aMeal = new AnyPizza(true, 5.99, 180, 10, 10, "hah");
                myModel.AddMealOrder(aMeal);
            }
            else
            {

            }

            

        }
    }
}
