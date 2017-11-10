using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

namespace review6421
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            float res = yxDivide("4", "0");
            Debug.WriteLine("forbidden");
            int res1 = yxOpStr();
        }

        public float yxDivide(string figStr1, string figStr2)
        {
            int fig1 = 1;
            int fig2 = 1;
            float res = 0;

            try
            {
                fig1 = int.Parse(figStr1);
                fig2 = int.Parse(figStr2);
            }
            catch
            {
                MessageBox.Show("Please fill the year box.", "Error");
            }
            try
            {
                res = fig1 / fig2;
            }
            catch
            {
                MessageBox.Show("Dividing 0 is nonsense.", "Error");
            }
            return res;
        }

        public int yxOpStr()
        {
            string longStr = "hehezzhahazzhoho";
            string shortStr = "zz";
            int len = shortStr.Length;
            int cutPos = longStr.IndexOf(shortStr);
            int count = 0;
            while(cutPos>-1)
            {
                count++;
                longStr = longStr.Substring(cutPos + len);
                Debug.WriteLine(longStr);
                cutPos = longStr.IndexOf(shortStr);
            }

            return count;
        }
    }
}