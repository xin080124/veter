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
using System.Threading;

namespace MyDrag
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.ListBox SourceList;
        //private fixed int accounts[6];
        private int[] accounts = new int[6];
        private int account;
        private int itemIndex;

        public Form1()
        {
            InitializeComponent();
            InitializeAccounts();
        }
        /*
        private void InitializeComponent()
        {

        }
        */

        private void InitializeAccounts()
        {
            /*
            foreach (int account in accounts)
            {
                account = 0;
            }
            */
            for(int i=0;i<6;i++)
            {
                accounts[i] = 0;
            }
            //accounts[0] = 0;
            itemIndex = 0;
            //account = 0;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            Debug.WriteLine(" user panel1_DragDrop ");
            label3.Text = "";
            string name = listBox1.Items[itemIndex].ToString();
            label3.Text += name + " : $";
            accounts[itemIndex] += 10;
            label3.Text += accounts[itemIndex].ToString();
            string winMessage = name + " wins!!";
            ShowResult(label4, winMessage);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            Debug.WriteLine(" user panel1_DragEnter ");
            e.Effect = DragDropEffects.All;
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Debug.WriteLine(" enter listBox1_MouseDown ");
            ListBox box = (sender as ListBox);
            SourceList = box; //store the box the drag began in with a global reference

            //find the line we are dragging in the textbox
            int index = box.IndexFromPoint(e.X, e.Y);

            itemIndex = index;

            Debug.WriteLine(" before box.DoDragDrop ");
            DragDropEffects result = box.DoDragDrop(box.Items[index], DragDropEffects.All);
            Debug.WriteLine(" after box.DoDragDrop ");
            //the next lines do not run until the drop is completed
            //if ((rbMove.Checked) && (result != DragDropEffects.None))
            if (result != DragDropEffects.None)
            {
                //box.Items.RemoveAt(index);
                Debug.WriteLine(" output ");

            }
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            Debug.WriteLine(" user panel2_DragEnter ");
            e.Effect = DragDropEffects.All;
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            Debug.WriteLine(" user panel2_DragDrop ");
            label3.Text = "";
            string name = listBox1.Items[itemIndex].ToString();
            label3.Text += name+" : $";
            accounts[itemIndex] -= 10;
            label3.Text += accounts[itemIndex].ToString();
            string loseMessage = name + " loses!!";
            ShowResult(label5, loseMessage);
        }

        private void ShowResult(Label textLabel, string words)
        {
            //textLabel.Text = words;
            //textLabel.Visible = true;
            //labResult.BackColor = Color.Red;
            //Thread.Sleep(3000);
            //textLabel.Text = "";
            //textLabel.Visible = false;
            //labResult.BackColor = Color.White;
            textLabel.Text = words;
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";
            timer1.Enabled = false;
        }
    }
}
