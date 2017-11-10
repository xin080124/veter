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
    public partial class ViewForm3 : System.Windows.Forms.Form, IOrderView
    {
        private OrdersModel myModel;

        public ViewForm3()
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
            pnlDrawOn.CreateGraphics().Clear(pnlDrawOn.BackColor);
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

        private void cmbFilterDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterDisplay.Text == "All Orders")
                RefreshView();
            else if (cmbFilterDisplay.Text == "Pizzas only")
                DisplayPizzas();
            else if (cmbFilterDisplay.Text == "Noodles only")
                DisplayNoodles();
            else if (cmbFilterDisplay.Text == "Cakes only")
                DisplayCakes();
        }

        public void DisplayOnlyOneMeal(string mealName)
        {
            // clear panel
            clearPanel();
            // create arraylist of shapes from model and convery
            // to array of shapes
            ArrayList theOrderList = myModel.OrderList;
            AnyMeal[] theMeals = (AnyMeal[])theOrderList.ToArray(typeof(AnyMeal));
            // graphics object to draw shapes
            Graphics g = this.pnlDrawOn.CreateGraphics();

            foreach (AnyMeal am in theMeals)
            {
                // redraw circles only
                if (am.name.Equals(mealName))
                    am.Display(g);
            }
        }

        /// <summary>method: DisplayCircles
		/// display circles only
		/// </summary>
		public void DisplayPizzas()
        {
            DisplayOnlyOneMeal("Pizza");
        }

        /// <summary>method: DisplayCircles
		/// display circles only
		/// </summary>
		public void DisplayNoodles()
        {
            DisplayOnlyOneMeal("Noodle");
        }

        /// <summary>method: DisplayCircles
		/// display circles only
		/// </summary>
		public void DisplayCakes()
        {
            DisplayOnlyOneMeal("Cake");
        }


    }

    
}
