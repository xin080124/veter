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
using System.Diagnostics;

namespace mealsOrders1483998
{
    
    public partial class ViewForm2 : System.Windows.Forms.Form, IOrderView
    {
        private OrdersModel myModel;

        AnyMeal topShape; //  variable for selected shape
        AnyMeal editShape; // variable for shape to edit

        bool dragging;

        // variables for mouse position
        Point lastPosition = new Point(0, 0);
        Point currentPosition = new Point(0, 0);

        private int selectIndex;
        public ViewForm2()
        {
            InitializeComponent();
            txtXpos.Text = "10";
            txtYpos.Text = "10";

            txtPrice.Text = "9.99";
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

        private int getCakeSize()
        {
            int res = 12;
            if (comboBoxSize.Text == "6")
            {
                res = 6;
            }
            else if (comboBoxSize.Text == "8")
            {
                res = 8;
            }
            else if (comboBoxSize.Text == "12")
            {
                res = 12;
            }
            else { }
            
            return res;
        }


        private int orderTime()
        {
            int res = 0;
            if (cmbSelectTime.Text == "0 min (right now)")
            {
                res = 0;
            }
            else if (cmbSelectTime.Text == "30 min after")
            {
                res = 30;
            }
            else if (cmbSelectTime.Text == "60 min after")
            {
                res = 60;
            }
            else if (cmbSelectTime.Text == "120 min after")
            {
                res = 120;
            }
            else
            { }
            return res;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AnyMeal aMeal;

            int X = Convert.ToInt32(txtXpos.Text);
            int Y = Convert.ToInt32(txtYpos.Text);
            double price = Convert.ToDouble(txtPrice.Text);
            bool takeAway = checkBoxTakeAway.Checked;

            int time = orderTime();
            
            if (rbPizza.Checked)
            {
                //aShape = new AnyCircle("circle", X, Y, Width, Height, aColor);
                //myModel.AddShape(aShape);

                string aFlavor = "vegetable";
                if (lblColor.BackColor == labelSeafood.BackColor)
                {
                    aFlavor = "seafood";
                }
                else if (lblColor.BackColor == labelBBQ.BackColor)
                {
                    aFlavor = "BBQ";
                }
                else if (lblColor.BackColor == labelBeef.BackColor)
                {
                    aFlavor = "Beef";
                }
                else
                { }
                
                aMeal = new AnyPizza(takeAway, price, time, X, Y, aFlavor);
                myModel.AddMealOrder(aMeal);

            }
            else if (rbNoodle.Checked)
            {
                bool spicyValue = false;
                if (checkBoxIfSpicy.Checked == true)
                    spicyValue = true;
                aMeal = new AnyNoodle(takeAway, price, time, X, Y, spicyValue);
                myModel.AddMealOrder(aMeal);
            }
            else
            {
                int size = getCakeSize();
                aMeal = new AnyCake(takeAway, price, time, X, Y, size);
                myModel.AddMealOrder(aMeal);
            }



        }

        private void pnlDrawOn_MouseClick(object sender, MouseEventArgs e)
        {
            
            Debug.WriteLine(" user pnlDrawOn_MouseClick ");

            // create arrayList of shaapes from myModel
            ArrayList theOrderList = myModel.OrderList;
            // create array of shapes from array list
            AnyMeal[] theMeals = (AnyMeal[])theOrderList.ToArray(typeof(AnyMeal));
            // graphics object to draw shapes when required
            Graphics g = this.pnlDrawOn.CreateGraphics();

            int index = 0;
            selectIndex = -1;
            // loop through array checking if mouse is over shape
            foreach (AnyMeal am in theMeals)
            {
                // check if mouse is over shape
                if (am.HitTest(new Point(e.X, e.Y)))
                {
                    // if so make shape topShape
                    topShape = am;

                    selectIndex = index;
                }

                if (topShape != null) // if there is a topShape
                {
                    //needsDisplay = true; // need to redisplay
                    topShape.Display(g); // redisplay topShape					
                    topShape.Highlight = true;
                }

                index++;
               
            }
            
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            //myModel.AddMealOrder(aMeal);
            if(selectIndex > -1) 
                myModel.DeleteOrder(selectIndex);
        }

        private void rbNoodle_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            checkBoxIfSpicy.Visible = true;

            labelSize.Visible = false;
            comboBoxSize.Visible = false;

        }

        private void rbCake_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            labelSize.Visible = true;
            comboBoxSize.Visible = true;
            checkBoxIfSpicy.Visible = false;
        }

        private void pnlDrawOn__MouseDown(object sender, MouseEventArgs e)
        {
            if (topShape != null)
                dragging = true;
        }

        private void pnlDrawOn_MouseMove(object sender, MouseEventArgs e)
        {
            // set last position to current position
            lastPosition = currentPosition;
            // set current position to mouse position
            currentPosition = new Point(e.X, e.Y);
            // calculate how far mouse has moved 
            int xMove = currentPosition.X - lastPosition.X;
            int yMove = currentPosition.Y - lastPosition.Y;

            if (!dragging) // mouse not down 
            {
                // reset variables 
                topShape = null;
                bool needsDisplay = false;

                /*
                // create arrayList of shaapes from myModel
                ArrayList theShapeList = myModel.ShapeList;
                // create array of shapes from array list
                AnyShape[] theShapes = (AnyShape[])theShapeList.ToArray(typeof(AnyShape));
                // graphics object to draw shapes when required
                Graphics g = this.pnlDrawOn.CreateGraphics();
                */

                // create arrayList of shaapes from myModel
                ArrayList theOrderList = myModel.OrderList;
                // create array of shapes from array list
                AnyMeal[] theMeals = (AnyMeal[])theOrderList.ToArray(typeof(AnyMeal));
                // graphics object to draw shapes when required
                Graphics g = this.pnlDrawOn.CreateGraphics();

                // loop through array checking if mouse is over shape
                foreach (AnyMeal s in theMeals)
                {
                    // check if mouse is over shape
                    if (s.HitTest(new Point(e.X, e.Y)))
                    {
                        // if so make shape topShape
                        topShape = s;
                    }

                    if (s.Highlight == true)
                    {
                        // shape to be redrawn
                        needsDisplay = true;
                        // redraw shape
                        s.Display(g);
                        s.Highlight = false;
                    }
                    // 30 Oct moved this piece up to before highlight test
                    //					if (s.HitTest(new Point(e.X, e.Y)))// check if mouse is over shape
                    //					{
                    //						topShape = s; // make shape topShape
                    //					}
                }

                if (topShape != null) // if there is a topShape
                {
                    needsDisplay = true; // need to redisplay
                    topShape.Display(g); // redisplay topShape					
                    topShape.Highlight = true;
                }

                if (needsDisplay)
                {
                    // redisplay model
                    myModel.UpdateViews();
                }
            }
            else // mouse is down
            {
                // reset position of selected shape by value of mouse move 
                topShape.x_pos = topShape.x_pos + xMove;
                topShape.y_pos = topShape.y_pos + yMove;

                myModel.UpdateViews();
            }
        }

        private void pnlDrawOn__MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            // clear drawOn panel
            clearPanel();
            
            /*// create arrayList of shapes from model and convert to array of shapes
            ArrayList theShapeList = myModel.ShapeList;
            AnyShape[] theShapes = (AnyShape[])theShapeList.ToArray(typeof(AnyShape));
            // graphics object to draw selected shape
            Graphics g = this.pnlDrawOn.CreateGraphics();
            */
             // create arrayList of shaapes from myModel
             ArrayList theOrderList = myModel.OrderList;
             // create array of shapes from array list
             AnyMeal[] theMeals = (AnyMeal[])theOrderList.ToArray(typeof(AnyMeal));
             // graphics object to draw shapes when required
             Graphics g = this.pnlDrawOn.CreateGraphics();
            
            // check if shape selected and if so display
            if (topShape != null)
            {
                theMeals[0] = topShape;
                topShape.Display(g);
            }
            myModel.UpdateViews();
        }

        private void rbPizza_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            checkBoxIfSpicy.Visible = false;

            labelSize.Visible = false;
            comboBoxSize.Visible = false;
        }

        private void lblSelectFlavor_Click(object sender, EventArgs e)
        {
            lblColor.BackColor = (sender as Label).BackColor;
        }
    }
}
