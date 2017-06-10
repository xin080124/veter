﻿using System;
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
			//get last char of the string
            int boxStringLen = textBox1.Text.Length;
            str.substring(str.Length - 1, 1)
            string lastChar = textBox1.Text.Substring(boxStringLen - 1, 1);
			
			ArrayList personList = new ArrayList(); 

            Person newP = new Person(sname, intage, dheight);
            personList.Add(newP);

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

        private  void WriteLstToTxt(ListBox lst,string spath) //listbox ??txt??
		{
		    int count = lst.Items.Count;
		    _wstream = new StreamWriter(spath);
		    for (int i = 0; i<count;i++){
		        string data = lst.Items[i].ToString();
		        _wstream.Write(data);
		        _wstream.WriteLine();
		    }
		    _wstream.Flush();
		    _wstream.Close();
		}


		private   void   ReadTxtToLst(ListBox lst,string spath) //listbox ??txt??
		{
		    _rstream = new StreamReader(spath, System.Text.Encoding.Default);
		    string line;
		    while ((line = _rstream.ReadLine()) != null)
		    {
		        lst.Items.Add(line);
		    }
		    _rstream.Close();
		}
		
    }
}
