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

        public string ToString()
        {
            string wordStr = word+";"+meaning+";"+mark.ToString();
            return wordStr;
        }

        public string getWord()
        {
            return word;
        }

        public string getMeaning()
        {
            return meaning;
        }
    }
}
