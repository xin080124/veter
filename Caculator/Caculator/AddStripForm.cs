using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class AddStripForm : Form
    {
        private bool hasOp;

        public AddStripForm()
        {
            InitializeComponent();
            hasOp = false;
        }

        private void jkhkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lstDisplay;
        }

   


        private void AddStripForm_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if (e.KeyCode == Keys.Return)
            {
                Debug.WriteLine("enter");
            }
            */
            /*
            int kc = (int)e.KeyCode;
            Debug.WriteLine(kc);
            */
            
            if (((int)(e.KeyCode) < 122)&&((int)(e.KeyCode) > 65))
            {
                Debug.WriteLine("forbidden");
                MessageBox.Show("Please fill the year box with number and operator.", "Error");
                textBox1.Text = "";
            }
            else
            {
                Debug.WriteLine("ok");
                if (hasOp)
                {

                }
            }
            
        }
    }
}
