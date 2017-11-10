using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Diagnostics;


namespace MyThreads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butMyThread_Click(object sender, EventArgs e)
        {
            Test test = new Test();
        }

        private void bthThrow_Click(object sender, EventArgs e)
        {
            //clearLabels();
            try
            {
                int n1 = Convert.ToInt32(textBox1.Text);
                //lblOutput.Text = NoSmallNumbers(n1);
            }
            catch (NumberTooSmallException)
            {
                label2.Text = "For this button the first textbox needs" +
    " a number over 100";
            }
            catch
            {
                label2.Text = "A problem has occurred that this program " +
      "cannot handle";
            }
        }
    }
}
