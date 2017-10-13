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
    public partial class View2 : Form
    {
        viewControl ctrl;

        public View2(viewControl theCtrl)
        {
            InitializeComponent();
            ctrl = theCtrl;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ctrl.updateView1();
        }
    }
}
