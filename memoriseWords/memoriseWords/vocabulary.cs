using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoriseWords
{
    class vocabulary
    {
        protected string word;
        protected string meaning;
        //private StreamReader sr;

            /*
        public vocabulary()
        {
            sr = new StreamReader("c:\\temp\\WordBank.txt");
        }
        */

        public void setWord(string wordFromFile)
        {
            word = wordFromFile;
        }

        /*
        public string getMeaning()
        {
            
        }*/

    }
}
