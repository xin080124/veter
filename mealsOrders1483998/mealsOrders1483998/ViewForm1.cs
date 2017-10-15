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
    public partial class ViewForm1 : System.Windows.Forms.Form, IOrderView
    //public class ViewForm1 : System.Windows.Forms.Form, IOrderView
    {
        private OrdersModel myModel;
        //public OrdersModel myModel;
        //public OrdersModel myModel { get; set; }

        public ViewForm1()
        {
            InitializeComponent();
            txtXpos.Text = "10";
            txtXpos.Text = "10";
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
            // clear listBox
            listBox1.Items.Clear();
            // create arrayList from shapes in model
            ArrayList theOrderList = myModel.OrderList;
            //Convert arrayList to array of shapes
            AnyMeal[] theMeals = (AnyMeal[])theOrderList.ToArray(typeof(AnyMeal));
            // graphics object to draw shapes
            //Graphics g = this.pnlDrawOn.CreateGraphics();
            // add each shape in the array to the listBox
            foreach (AnyMeal am in theMeals)
            {
                listBox1.Items.Add(am);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AnyMeal aMeal;
            int X = Convert.ToInt32(txtXpos.Text);
            int Y = Convert.ToInt32(txtYpos.Text);
            
            if (rbPizza.Checked)
            {
                //aShape = new AnyCircle("circle", X, Y, Width, Height, aColor);
                //myModel.AddShape(aShape);
                string aFlavor = "vegetable";
                if (lblColor.BackColor == labelSeafood.BackColor)
                {
                    aFlavor = "seafood";
                }

                aMeal = new AnyPizza(true, 5.99,180,X,Y, aFlavor);
                myModel.AddMealOrder(aMeal);

            }
            if (rbNoodle.Checked)
            {
                aMeal = new AnyNoodle(true, 5.99, 180, X, Y, false);
                myModel.AddMealOrder(aMeal);
            }
        }

        private void rbPizza_Click(object sender, EventArgs e)
        {

        }

        private void lblSelectColor_Click(object sender, EventArgs e)
        {

        }

        private void lblSelectFlavor_Click(object sender, EventArgs e)
        {
            lblColor.BackColor = (sender as Label).BackColor;
        }
    }
}
