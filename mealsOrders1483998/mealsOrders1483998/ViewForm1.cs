using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //ArrayList theShapeList = myModel.ShapeList;
            //AnyShape[] theShapes = (AnyShape[])theShapeList.ToArray(typeof(AnyShape));
            //Graphics g = this.pnlDrawOn.CreateGraphics();
            // draw all shapes in array

            //foreach (AnyShape sh in theShapes)
            //{
            //    sh.Display(g);
            //}
        }
    }
}
