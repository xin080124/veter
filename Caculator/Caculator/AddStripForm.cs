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


using System.IO;

namespace Caculator
//namespace AddStrip
{
    public partial class AddStripForm : Form
    {
        private bool hasOp;
        private bool justTotal;
        private bool hasBeenSaved;

        private string lastInput;
        private string currentInput;

        private Calculation myCalSet;

        private int mode;

        public AddStripForm()
        {
            InitializeComponent();
            hasOp = true;
            justTotal = false;
            hasBeenSaved = false;

            mode = 0; //0:laptop, 1:desktop
            lastInput = "";
            myCalSet = new Calculation(lstDisplay);
            myCalSet.ChangeModeTo(mode);
        }

        private void jkhkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lstDisplay;
        }

   


        private void AddStripForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private bool CheckInput(string inputStr)
        {
            //if (((int)(e.KeyCode) < 122)&&((int)(e.KeyCode) > 65))

            int len = inputStr.Length;
            for(int idx = 0;idx<len;idx++)
            {
                char ch = inputStr[idx];
                int charVal = (int)ch;



                Debug.WriteLine("inputStr  " + idx + "   "+ charVal);
                
                if((charVal<122)&& (charVal > 65))
                {
                    return false;
                }
                if(((charVal < 41) && (charVal > 35))||(charVal == 64))
                {
                    return false;
                }
            }
            return true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("enter: text box = "+ textBox1.Text);
            Debug.WriteLine("enter: key code = " + (int)e.KeyCode);
            lastInput = textBox1.Text;

            int keyPlus = 0;
            int keyMinus = 0;
            int keyTimes = 0;
            int keyDivide = 0;
            //int keyHash = 0;
            int keyEqual = 187;
            int keyEnter = 13;

            bool correctInput = true;

            if (mode == 0)
            {
                keyPlus = 188;  //,
                keyMinus = 189;   //-
                keyTimes = 186;   //;
                keyDivide = 191;  //47????
                //keyHash = 186;
                //keyEqual = 
            }
            else //desktop
            {
                keyPlus = 107;
                keyMinus = 109;
                keyTimes = 106;
                keyDivide = 111;
                //keyHash = 186;
            }


            //if (((int)(e.KeyCode) < 122)&&((int)(e.KeyCode) > 65))
            if (((int)(e.KeyCode) < 1))
            {
                Debug.WriteLine("forbidden");
                MessageBox.Show("Please fill the year box with number and operator.", "Error");
                textBox1.Text = "";
            }
            
            else if (((int) (e.KeyCode) == keyPlus)/*plus*/|| ((int)(e.KeyCode) == keyMinus/*minus*/) ||
                      ((int)(e.KeyCode) == keyTimes)/*times*/|| ((int)(e.KeyCode) == keyDivide)/*divide*/||
                      ((int)(e.KeyCode) == keyEnter)|| ((int)(e.KeyCode) == keyEqual))
            {

                if (!hasOp)
                    hasOp = true;
                else if(justTotal)
                {
                    myCalSet.Clear();
                    justTotal = false;
                }
                else
                {
                    int len = lastInput.Length;
                    Debug.WriteLine("before remove len: " + len.ToString());
                    correctInput = CheckInput(lastInput);

                    //if (((int)(e.KeyCode) != keyEnter) && ((int)(e.KeyCode) != keyEqual))
                    //{
                        if(len==1)
                        {
                            MessageBox.Show("please enter a number after the beginning operator", "Error");
                            return;
                        }
                    //}

                    if ((len>0)&&(correctInput))
                    {
                        myCalSet.AddCalcByStr(lastInput,true);
                        lastInput = lastInput.Remove(0, len);

                        textBox1.Text = lastInput;
                    }
                    if (((int)(e.KeyCode) == keyEnter)|| ((int)(e.KeyCode) == keyEqual))
                    {
                        if(len == 0)
                            MessageBox.Show("No calculation available.So no subtotal or total can be displayed", "Error");
                        else if (correctInput)
                        {
                     //       if(len==1)
                     //           MessageBox.Show("please enter a number after the beginning operator", "Error");
                     //       else
                                myCalSet.AddCalcByStr("=", true);
                        }
                        else 
                            MessageBox.Show("incorrecct data format.", "Error");
                    }

                    if (((int)(e.KeyCode) == keyTimes) || ((int)(e.KeyCode) == keyDivide))
                    {
                        int calsize = myCalSet.sizeOfCal();
                        if(calsize == 0)
                            MessageBox.Show("First data entry must use either + or - as the beginning operator", "Error");
                    }
                    
                    //Debug.WriteLine("after remove: " + lastInput);
                    /*
                    if ((int)(e.KeyCode) == 186)
                    {
                        myCalSet.AddCalcByStr("#",true);
                    }
                    if ((int)(e.KeyCode) == 187)
                    {
                        myCalSet.AddCalcByStr("=",true);
                    }
                    */
                }
                
            }
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Debug.WriteLine("enter: key up text box = " + textBox1.Text);

            currentInput = textBox1.Text;

            int len = currentInput.Length;
            //sDebug.WriteLine("before remove len: " + len.ToString());
            bool correctInput = true;
            correctInput = CheckInput(currentInput);
            
            if (len > 0)
            {

                char ch = currentInput[len - 1];
                if (ch == '#')
                {
                    /*if(len == 1)
                    {
                        MessageBox.Show("please enter a number after the beginning operator", "Error");
                        return;
                    }*/


                    if (correctInput)
                    {
                        currentInput = currentInput.Remove(len - 1, 1);
                        myCalSet.AddCalcByStr(currentInput, true);
                        textBox1.Text = "";
                        myCalSet.AddCalcByStr("#", true);
                    }
                    else
                    {
                        MessageBox.Show("incorrecct data format.", "Error");
                    }
                }
            }

            //if (((int)(e.KeyCode) == 186)|| ((int)(e.KeyCode) == 187))
            //if ((textBox1.Text == "#") || (textBox1.Text == "="))
            /*if (textBox1.Text == "=")
            {
                textBox1.Text = "";

            }
            */
        }
            
    

        private void lstDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Caculation1.cal";
            saveFileDialog1.InitialDirectory = "C:\\Temp\\";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //The save dialog box will automatically
                //generate a warning if the file already exists
                //provided the property .OverWritePrompt is set to true.
                //StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                myCalSet.SaveToFile(saveFileDialog1.FileName);
                //WriteLstToTxt(lstDisplay, saveFileDialog1.FileName);              
                /*sw.Write(textBox4.Text);
                sw.Close();
                openFileDialog1.FileName = saveFileDialog1.FileName;
            */
            }
        }
        
        

        private void menuOpen_Click(object sender, EventArgs e)
        {
            //hasBeenSaved = true;

            //openFileDialog1.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
            //openFileDialog1.Filter = "cal files (*.cal)|*.cal|All files (*.*)|*.*";
            if (myCalSet.SavedState() == false)
            {
                if (MessageBox.Show("Are you sure you want to exit without saving the current calculation?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    myCalSet.Clear();
                    textBox1.Text = "";
                }
                else
                {
                    menuSaveAs_Click(sender, e);
                }
            }
            else
            {
                openFileDialog1.Filter = "cal files (*.cal.txt)|*.cal.txt|All files (*.*)|*.*";
                openFileDialog1.InitialDirectory = "C:\\Temp\\";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //StreamReader parseReader = new StreamReader(openFileDialog1.FileName);
                    //string personInfo;
                    //ReadTxtToLst(lstDisplay, openFileDialog1.FileName);
                    myCalSet.LoadFromFile(openFileDialog1.FileName);
                }
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            //if (hasBeenSaved)
            if (myCalSet.SavedState() == true)
                //WriteLstToTxt(lstDisplay, openFileDialog1.FileName);
                myCalSet.SaveToFile(openFileDialog1.FileName);
            else
                menuSaveAs_Click(sender, e);
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            if (myCalSet.SavedState() == false)
            {
                if (MessageBox.Show("Are you sure you want to exit without saving the current calculation?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    myCalSet.Clear();
                    textBox1.Text = "";
                }
                else
                {
                    menuSaveAs_Click(sender, e);
                }
            }
            else
            {
                //hasBeenSaved = false;
                myCalSet.Clear();
                textBox1.Text = "";
            }
        }

        private void lstDisplay_Click(object sender, EventArgs e)
        {
            textBoxEdit.Text = lstDisplay.SelectedItem.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string calcStr = textBoxEdit.Text;
            int selectIndex = lstDisplay.SelectedIndex;
            myCalSet.ReplaceCalcByStr(calcStr, selectIndex);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectIndex = lstDisplay.SelectedIndex;
            myCalSet.Delete(selectIndex);
            textBoxEdit.Text = "";
        }

        private void menuPrint_Click(object sender, EventArgs e)
        {
            //amountOfPrinted = 0;
            //printPreviewCandidate.Show();
            printPreviewCalc.Show();
        }

        private void printCalc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = 1;
            float x = 1;
            Font btfont = new Font("Arial", 20);
            //SizeF size = e.Graphics.MeasureString("?", btfont); 
            for (int i = 0; i<lstDisplay.Items.Count; i++) 
            {
                e.Graphics.DrawString(lstDisplay.Items[i].ToString(), btfont, Brushes.Black, x, y);
                //e.Graphics.DrawString("======================= ", btfont, Brushes.Black, x, y); 
                y += 50;
                 
            }


        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            if(myCalSet.SavedState() == false)
            {
                if (MessageBox.Show("Are you sure you want to exit without saving the current calculation?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Dispose();
                    Application.Exit();
                }
                else
                {
                    //e.Cancel = true;
                    menuSaveAs_Click(sender, e);
                }
            }
            else
            {
                Close();
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int selectIndex = lstDisplay.SelectedIndex;
            //myCalSet.Delete(selectIndex);
            //textBoxEdit.Text = "";
            string calcStr = textBoxEdit.Text;
            myCalSet.InsertCalc(calcStr, selectIndex);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddStripForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myCalSet.SavedState() == false)
            {
                if (MessageBox.Show("Are you sure you want to exit without saving the current calculation?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //e.Cancel = false;
                    //Close();
                    Dispose();
                    Application.Exit();

                }
                else
                {
                    e.Cancel = true;
                    menuSaveAs_Click(sender, e);
                }
                    
            }
    
        }
    }
}
