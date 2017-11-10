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

using System.IO;

using System.Threading;

namespace mealsOrders1483998
{
    public partial class ViewForm1 : System.Windows.Forms.Form, IOrderView
    //public class ViewForm1 : System.Windows.Forms.Form, IOrderView
    {
        private OrdersModel myModel;
        //public OrdersModel myModel;
        //public OrdersModel myModel { get; set; }

        private int selectIndex;

        public ViewForm1()
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

        public void AddMealByString(string mealStr)
        {
            AnyMeal aMeal;
            string[] parts = mealStr.Split(',');
            if (parts.Length > 1)
            {
                string mealName = parts[0];
                bool takeAway = Convert.ToBoolean(parts[1]);
                double price = Convert.ToDouble(parts[2]);
                int time = Convert.ToInt32(parts[3]);

                int x = Convert.ToInt32(parts[4]);
                int y = Convert.ToInt32(parts[5]);
                if (parts[0] == "Pizza")
                {
                    aMeal = new AnyPizza(takeAway, price, time, x, y, parts[6]);
                    myModel.AddMealOrder(aMeal);
                }
                else if (parts[0] == "Noodle")
                {
                    aMeal = new AnyNoodle(takeAway, price, time, x, y, Convert.ToBoolean(parts[6]));
                    myModel.AddMealOrder(aMeal);
                }
                else if (parts[0] == "Cake")
                {
                    aMeal = new AnyCake(takeAway, price, time, x, y, Convert.ToInt32(parts[6]));
                    myModel.AddMealOrder(aMeal);
                }
                else { }
            }
            
        }


        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AnyMeal aMeal;
            int X = Convert.ToInt32(txtXpos.Text);
            int Y = Convert.ToInt32(txtYpos.Text);

            double price = Convert.ToDouble(txtPrice.Text);
            bool takeAway = checkBoxTakeAway.Checked;
            
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

                aMeal = new AnyPizza(takeAway, price, 180, X, Y, aFlavor);
                myModel.AddMealOrder(aMeal);

            }
            else if (rbNoodle.Checked)
            {
                bool spicyValue = false;
                if (checkBoxIfSpicy.Checked == true)
                    spicyValue = true;
                aMeal = new AnyNoodle(takeAway, price, 180, X, Y, spicyValue);
                myModel.AddMealOrder(aMeal);
            }
            else if (rbCake.Checked)
            {
                aMeal = new AnyCake(takeAway, price, 180, X, Y, 3);
                myModel.AddMealOrder(aMeal);
            }
            else
            { }
        }

        private void rbPizza_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            checkBoxIfSpicy.Visible = false;

            labelSize.Visible = false;
            comboBoxSize.Visible = false;
        }

        private void rbCake_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            checkBoxIfSpicy.Visible = false;

            labelSize.Visible = true;
            comboBoxSize.Visible = true;
        }

        private void lblSelectColor_Click(object sender, EventArgs e)
        {

        }

        private void lblSelectFlavor_Click(object sender, EventArgs e)
        {
            lblColor.BackColor = (sender as Label).BackColor;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            selectIndex = listBox1.SelectedIndex;
            Debug.WriteLine(selectIndex.ToString() + " is selected ");

            if(selectIndex>-1)
            {
                ArrayList theOrderList = myModel.OrderList;
                AnyMeal[] theMeals = (AnyMeal[])theOrderList.ToArray(typeof(AnyMeal));
                AnyMeal am = theMeals[selectIndex];

                txtXpos.Text = am.x_pos.ToString();
                txtYpos.Text = am.y_pos.ToString();
            }
            
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            //selectIndex = -1;
            selectIndex = listBox1.SelectedIndex;
            if (selectIndex > -1)
                myModel.DeleteOrder(selectIndex);
        }

        private void rbNoodle_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            checkBoxIfSpicy.Visible = true;

            labelSize.Visible = false;
            comboBoxSize.Visible = false;
        }

        private void ifSpicyOnClick(object sender, EventArgs e)
        {
            //if(checkBoxIfSpicy.Checked)

        }

        private void menuNew_Click(object sender, EventArgs e)
        {

        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                myModel.OrderList.Clear();
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string theOrders = sr.ReadToEnd();
                sr.Close();
                string[] theLines = theOrders.Split('#');

                foreach (string stringDot in theLines)
                {
                    AddMealByString(stringDot);
                }
                
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Thread t = new Thread(new ThreadStart(ThreadJob));
                t.IsBackground = true;
                t.Start();
            }
        }

        //this is the method that will be run by the thread
        void ThreadJob()
        {
            StringBuilder sb = new StringBuilder();
               
            ArrayList theOrderList = myModel.OrderList;
            AnyMeal[] theMeals = (AnyMeal[])theOrderList.ToArray(typeof(AnyMeal));
            foreach (AnyMeal am in theMeals)
            {
                //listBox1.Items.Add(am);
                sb.Append(am.ToString());
            }
                
            string temp = sb.ToString();

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.Write(sb);
            sw.Close();
        }

        private void btnUpdOrder_Click(object sender, EventArgs e)
        {
            selectIndex = listBox1.SelectedIndex;
            Debug.WriteLine(selectIndex.ToString() + " is selected ");

            int X = Convert.ToInt32(txtXpos.Text);
            int Y = Convert.ToInt32(txtYpos.Text);

            ArrayList theOrderList = myModel.OrderList;
            AnyMeal[] theMeals = (AnyMeal[])theOrderList.ToArray(typeof(AnyMeal));
            AnyMeal am = theMeals[selectIndex];

            am.x_pos = X;
            am.y_pos = Y;

            myModel.UpdateViews();

        }
    }
}
