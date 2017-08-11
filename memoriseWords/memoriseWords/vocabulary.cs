using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Collections;

namespace memoriseWords
{
    class vocabulary
    {
        protected string word;
        protected string meaning;
        private StreamReader sr;
        private StreamWriter sw;

        private ArrayList theWordsList;

        public vocabulary()
        {
            sr = new StreamReader("c:\\temp\\WordBank0.txt");
            theWordsList = new ArrayList();

            string wordString;
            while((wordString = sr.ReadLine())!=null)
            {
                Wordline wl = new Wordline(wordString);
                theWordsList.Add(wl);
            }

            sr.Close();
            sr = null;
        }
    
        public  void addWord(string wordLine)
        {
            //sr = new StreamReader("c:\\temp\\WordBank.txt");
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
                    //sr = new StreamReader("c:\\temp\\WordBank.txt");
                }

            }

            catch (IOException)
            {
                Console.Write("Exception caught while reading the questions file");
            }

            return word;
        }

        public void loadWordList()
        {

        }

        public void saveWordsList()
        {
            sw = new StreamWriter("c:\\temp\\WordBank0.txt");
            //foreach (CalcLine clc in theCalcs)
            foreach (Wordline wl in theWordsList)
            {
                string data = wl.ToString();
                sw.Write(data);
                sw.WriteLine();
            }
            sw.Flush();
            sw.Close();
        }

        public void setWord(string wordFromFile)
        {
            word = wordFromFile;
        }

        public void append(string newWord, string newMeaning)
        {
            //sw = new StreamWriter("c:\\temp\\WordBank.txt");
            //word = wordFromFile;
            string wordString;
            int initMark = 0;
            wordString = newWord + ";" + newMeaning + ";" + initMark.ToString();
            Wordline wl = new Wordline(wordString);
            theWordsList.Add(wl);
        }

        public string getMeaning()
        {
            return meaning;
        }

    }
}
