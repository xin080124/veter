using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace mealsOrderList
{
    public partial class viewControl : UserControl
    {
        private View1 view1;        //the reference to the cat form 
        private View2 view2;

        public viewControl()
        {
            InitializeComponent();
        }

        private void view1_Click(object sender, EventArgs e)
        {
            //if (view1 == null)
            //{
            //    view1 = new View1();
            //}
            //view1.ShowDialog();

        }

        private void butOpenView1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(ThreadJob1));
            t.IsBackground = true;
            t.Start();
            
        }

        void ThreadJob1()
        {
            if (view1 == null)
            {
                view1 = new View1(this);
            }
            view1.ShowDialog();
            while (true)
            {

            }
        }

        private void openView2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(ThreadJob2));
            t.IsBackground = true;
            t.Start();
        }

        void ThreadJob2()
        {
            if (view2 == null)
            {
                view2 = new View2(this);
            }
            view2.ShowDialog();
        }

        public void updateView1()
        {
            Thread t = new Thread(new ThreadStart(ThreadUpdateView1));
            t.IsBackground = true;
            t.Start();
        }

        void ThreadUpdateView1()
        {
            view1.update("new value");
        }
    }
}
