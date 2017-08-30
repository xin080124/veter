using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using System.Diagnostics;
using System.Collections;

namespace memoriseWords
{
    class Wordline
    {
        private string word;
        private string meaning;
        private int mark;

        ///<Summary> method : Wordline()
        //the constructor of Wordline
        ///</Summary>
        public Wordline(string wordLine)
        {
            string[] ss = wordLine.Split(';');
            foreach (string item in ss)
            {
                word = ss[0];
                meaning = ss[1];
                mark = int.Parse(ss[2]);
                Debug.WriteLine(item);

                //Console.Write(item + "\t");

                //size++;

            }
        }

        ///<Summary> method : ToString()
        //transform the Wordline object to string
        ///</Summary>
        public string ToString()
        {
            string wordStr = word+";"+meaning+";"+mark.ToString();
            return wordStr;
        }

        ///<Summary> method : getWord()
        //get word from the current Wordline object 
        ///</Summary>
        public string getWord()
        {
            return word;
        }

        ///<Summary> method : getMeaning()
        //get meaningfrom the current Wordline object 
        ///</Summary>
        public string getMeaning()
        {
            return meaning;
        }
    }
}
