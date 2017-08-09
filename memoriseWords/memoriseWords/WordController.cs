using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace memoriseWords
{
    class WordController
    {
        private ctlWords theInterface;
        private vocabulary theVocabulary;

        private string word;
        private string meaning;

        private StreamReader sr;

        public WordController(ctlWords newInterface)
        {
            theInterface = newInterface;
            theVocabulary = new vocabulary();
            sr = new StreamReader("c:\\temp\\WordBank.txt");
        }

        public string readWord()
        {
            try
            {
                word = sr.ReadLine();

                if (word != null)
                {
                    theVocabulary.setWord(word);
                    meaning = sr.ReadLine();
                    //theVocabulary.setSolution(solution);
                }

                else

                {

                    word = null;

                }

            }

            catch (IOException)

            {

                Console.Write("Exception caught while reading the questions file");

            }

            return word;
        }

        public string readMeaning()
        {
            return meaning;
        }





    }
}
