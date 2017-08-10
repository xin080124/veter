using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace memoriseWords
{
    class vocabulary
    {
        protected string word;
        protected string meaning;
        private StreamReader sr;

        
        public vocabulary()
        {
            sr = new StreamReader("c:\\temp\\WordBank.txt");
        }
    
        public string readWord()
        {
            try
            {
                word = sr.ReadLine();

                if (word != null)
                {
                    //theVocabulary.setWord(word);
                    meaning = sr.ReadLine();
                    //theVocabulary.setSolution(solution);
                    //wordIndex++;
                }
                else
                {
                    word = null;
                    meaning = null;
                    /*theStudent.writeTimesToFile();
                    if (mode == 0)
                        MessageBox.Show("study finished", "Success");
                    else if (mode == 1)
                        MessageBox.Show("test finished", "Success");
                */
                    sr.Close();
                    sr = new StreamReader("c:\\temp\\WordBank.txt");
                }

            }

            catch (IOException)
            {
                Console.Write("Exception caught while reading the questions file");
            }

            return word;
        }

        public void setWord(string wordFromFile)
        {
            word = wordFromFile;
        }

        
        public string getMeaning()
        {
            return meaning;
        }

    }
}
