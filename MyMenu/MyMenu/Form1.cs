using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using System.Diagnostics;
using System.Collections;

namespace MyMenu
{
    public partial class Form1 : Form
    {
        //private Person[] ArrayList = new 
        ArrayList personList = new ArrayList(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(" confirm menuItem4_Click");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sname = textBox1.Text;
            int intage = int.Parse(textBox2.Text);
            double dheight = double.Parse(textBox3.Text);
            Person newP = new Person(sname, intage, dheight);
            personList.Add(newP);
            textBox4.Text += newP.CommaText()+ "\r\n";
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            personList.Clear();
            Debug.WriteLine(" reset everything ");
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                personList.Clear();

                StreamReader parseReader = new StreamReader(openFileDialog1.FileName);
                string personInfo;
                while ((personInfo = parseReader.ReadLine()) != null)
                {
                    Debug.WriteLine(personInfo);
                    string[] ss = personInfo.Split(',');
                    int size = 0;
                    foreach (string item in ss)
                    {
                        Debug.WriteLine(item);
                        //Console.Write(item + "\t");
                        size++;
                    }
                    Debug.WriteLine("\r\n");
                    //Console.WriteLine();
                    if (size>=3)
                    {
                        string sname = ss[0];
                        int intage = int.Parse(ss[1]);
                        double dheight = double.Parse(ss[2]);
                        Person newP = new Person(sname, intage, dheight);
                        personList.Add(newP);
                        textBox4.Text += newP.CommaText() + "\r\n";
                    }

                    //textBox4.Text += personInfo + "\r\n";
                }
                parseReader.Close();
            
                /*StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox4.Text = sr.ReadToEnd();
                sr.Close();
                */

                
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = openFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //The save dialog box will automatically
                //generate a warning if the file already exists
                //provided the property .OverWritePrompt is set to true.
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(textBox4.Text);
                sw.Close();
                openFileDialog1.FileName = saveFileDialog1.FileName;
            }
        }
    }
}
