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

        ///<Summary> method : vocabulary()
        //the constructor of vocabulary
        ///</Summary>
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

        ///<Summary> method : addWord()
        //uncompleted method for future use
        ///</Summary>
        public void addWord(string wordLine)
        {
            //sr = new StreamReader("c:\\temp\\WordBank.txt");
        }

        ///<Summary> method : readWord()
        //get word from theWordsList
        ///</Summary>
        public string readWord()
        {
            string word = "";
            currentMeaning = "";


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

        ///<Summary> method : loadWordList()
        //uncompleted method for future use
        ///</Summary>
        public void loadWordList()
        {

        }

        ///<Summary> method : saveWordsList()
        //save the temporary Wordline ArrayList to persistent file
        ///</Summary>
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

        ///<Summary> method : setWord()
        //set the currentWord value with the given value
        ///</Summary>
        public void setWord(string wordFromFile)
        {
            currentWord = wordFromFile;
        }

        ///<Summary> method : append()
        //create a new wordline object with the new word and append it to the theWordsList
        ///</Summary>
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

        ///<Summary> method : getMeaning()
        //get the word's meaning from vocabulary
        ///</Summary>
        public string getMeaning()
        {
            return currentMeaning;
        }

        ///<Summary> method : getWordIndex()
        //get the current word index in the vocabulary
        ///</Summary>
        public int getWordIndex()
        {
            return currentIndex;
        }

    }
}
