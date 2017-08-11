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
        protected string currentWord;
        protected string currentMeaning;
        private StreamReader sr;
        private StreamWriter sw;
        private int currentIndex;

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

            currentIndex = 0;
        }
    
        public  void addWord(string wordLine)
        {
            //sr = new StreamReader("c:\\temp\\WordBank.txt");
        }

        public string readWord()
        {
            string word = "";
            
            if (currentIndex < theWordsList.Count)
            {
                Wordline wl = (Wordline)theWordsList[currentIndex];
                word = wl.getWord();
                currentMeaning = wl.getMeaning();
                currentIndex++;
            }
            else
            {
                word = null;
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
            currentWord = wordFromFile;
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
            return currentMeaning;
        }

        public int getWordIndex()
        {
            return currentIndex;
        }

    }
}
