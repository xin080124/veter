using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mealsOrderList
{
    public partial class View1 : Form
    {
        //Meals mealData;
        viewControl ctrl;

        public View1(viewControl theCtrl)
        {
            InitializeComponent();
            ctrl = theCtrl;
            //mealData = new Meals();
        }

        public void update(string newstr)
        {
            //textBox1.Text = newstr;
            textBox1.Text = "mama";
        }
    }
}
