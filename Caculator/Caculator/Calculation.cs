using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.Collections;

using System.Windows.Forms;

using System.IO;


namespace Caculator

//namespace AddStrip

{
    class Calculation
    {
        private ArrayList theCalcs;
        private ListBox lstDisplay;
        private double result;
        private int mode;
        private bool beSaved;

        public Calculation(ListBox lb)
        {
            lstDisplay = lb;
            theCalcs = new ArrayList();
            result = 0;
            //            lb_PersonsList.DataSource = persons;        //?????
            //            lb_PersonList.DisplayMember = "Name";    //??????????

            //lstDisplay.DataSource = theCalcs;
            //lstDisplay.DisplayMember = "op";

            mode = 0;
            beSaved = true;
        }

        public void ChangeModeTo(int newMode)
        {
            mode = newMode;
            CalcLine.env = newMode;
        }

        public bool SavedState()
        {
            return beSaved;
        }

        public int sizeOfCal()
        {
            return theCalcs.Count;
        }

        public void Add(CalcLine cl)
        {
            theCalcs.Add(cl);
        }

        public void Redisplay()
        {
            beSaved = false;
            lstDisplay.Items.Clear();
            result = 0;
            foreach (CalcLine cl in theCalcs)
            {
                result = cl.NextResult(result);
                string calcStr = cl.ToString();

                string opStr = calcStr.Substring(0, 1);
                string figure = calcStr.Substring(1, calcStr.Length - 1);

                Debug.WriteLine("opStr: " + opStr + " figure: " + figure);

                if (opStr == "#")
                    lstDisplay.Items.Add(calcStr + result.ToString() + " <subtotal");
                else if (opStr == "=")
                {
                    lstDisplay.Items.Add(calcStr + result.ToString() + " <<total");
                    result = 0;
                }
                else
                    lstDisplay.Items.Add(calcStr);
            }
        }

        public void AddCalcByStr(string calcStr,bool autoShowRes)
        {
            CalcLine clc = new CalcLine(calcStr);
            Add(clc);
            Redisplay();
        }

        public void Replace(CalcLine newCalc, int n)
        {
            //CalcLine clc = (CalcLine)theCalcs[n];
            //clc = newCalc;
            theCalcs[n] = newCalc;
        }

        public void ReplaceCalcByStr(string calcStr, int n)
        {
            CalcLine clc = new CalcLine(calcStr);
            Replace(clc, n);
            Debug.WriteLine("calcStr: " + calcStr + " n: " + n);
            //lstDisplay.Items[n] = calcStr;
            Redisplay();
        }

        public void Delete(int n)
        {
            Debug.WriteLine("before delete size: " + theCalcs.Count);

            theCalcs.RemoveAt(n);

            Debug.WriteLine("after delete size: " + theCalcs.Count);

            //lstDisplay.Items.RemoveAt(n);
            Redisplay();
        }

        public void InsertCalc(string calcStr, int n)
        {
            CalcLine clc = new CalcLine(calcStr);
            Insert(clc,n);
        }

        public void Insert(CalcLine newCalc, int n)
        {
            Debug.WriteLine("before insert size: " + theCalcs.Count);

            //CalcLine clc = new CalcLine(newCalc);
            theCalcs.Insert(n, newCalc);
            
            Debug.WriteLine("after insert size: " + theCalcs.Count);

            //lstDisplay.Items.RemoveAt(n);
            Redisplay();
        }

        public void Clear()
        {
            theCalcs.Clear();
            lstDisplay.Items.Clear();
            result = 0;
        }


        public double getSubtotal()
        {
            double temp = 0;
            double sofar = 0;
            foreach (CalcLine clc in theCalcs)
            {
                temp = clc.NextResult(sofar);
                sofar = temp;
            }


            lstDisplay.Items.Add(("# "+sofar.ToString() + "<subtotal"));
            return sofar;
        }

        public void SaveToFile(string filename)
        {
            WriteLstToTxt(lstDisplay, filename);
            beSaved = true;
        }

        private void WriteLstToTxt(ListBox lst, string spath) //listbox ??txt??
        {
            int count = lst.Items.Count;
            StreamWriter _wstream = new StreamWriter(spath);
            for (int i = 0; i < count; i++)
            {
                string data = lst.Items[i].ToString();
                _wstream.Write(data);
                _wstream.WriteLine();
            }
            _wstream.Flush();
            _wstream.Close();
        }

        public void LoadFromFile(string filename)
        {
            ReadTxtToLst(lstDisplay, filename);
        }

        private void ReadTxtToLst(ListBox lst, string filename) //listbox ??txt??
        {
            StreamReader _rstream = new StreamReader(filename, System.Text.Encoding.Default);
            string line;
            while ((line = _rstream.ReadLine()) != null)
            {
                //lst.Items.Add(line);
                int len = line.Length;
                if (len > 0)
                {
                    char ch = line[0];
                    if ('=' == ch)
                    {
                        AddCalcByStr("=", false);
                    }
                    else if ('#' == ch)
                    {
                        AddCalcByStr("#", false);
                    }
                    else
                        AddCalcByStr(line, false);
                }

            }
            _rstream.Close();
        }
    }
}
