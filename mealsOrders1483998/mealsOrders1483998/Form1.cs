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
    public partial class Form1 : Form
    {
        
        private OrdersModel theModel;
        private OrdersController theController;
        private ViewForm1 myViewForm1;
        private ViewForm2 myViewForm2;
        private ViewForm3 myViewForm3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeController_Click(object sender, EventArgs e)
        {
            theController = new OrdersController();
        }

        private void btnMakeModel_Click(object sender, EventArgs e)
        {
            theModel = new OrdersModel(theController);
        }

        private void btnMakeViews_Click(object sender, EventArgs e)
        {
            myViewForm1 = new ViewForm1();
            myViewForm2 = new ViewForm2();
            myViewForm3 = new ViewForm3();
            myViewForm1.MyModel = theModel;
            myViewForm2.MyModel = theModel;
            //myViewForm3.MyModel = theModel;
            theController.AddView(myViewForm1);
            theController.AddView(myViewForm2);
            //theController.AddView(myViewForm3);
        }

        private void btnShowViews_Click(object sender, EventArgs e)
        {
            myViewForm1.Show();
            myViewForm2.Show();
            myViewForm3.Show();

        }
    }
}
