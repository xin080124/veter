using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Collections;


using System.Windows.Forms;

namespace memoriseWords
{
    class WordController
    {
        private ctlWords theInterface;
        private vocabulary theVocabulary;
        private Student theStudent;
        private int mode;
        private ArrayList theTimes;

        private int wordIndex;
        
        private string word;
        private string meaning;

        private StreamReader sr;

        public WordController(ctlWords newInterface)
        {
            theInterface = newInterface;
            theVocabulary = new vocabulary();
            
            mode = -1;
            wordIndex = -1;
        }

        public void setStudent(Student currentStudent)
        {
            theStudent = currentStudent;
            theTimes = new ArrayList();
        }

        public void setMode(int newMode)
        {
            mode = newMode;
        }
        public void addStudentPassTimes()
        {
            int oldValue = theStudent.getTimes(wordIndex);
            int newValue = oldValue + 1;
            theStudent.setTimes(wordIndex,newValue);
            //theTimes.Add(newValue);
        }

        public void addNewWord(string newWord, string newMeaning)
        {
            theVocabulary.append(newWord, newMeaning);
        }

        public void saveNewWords()
        {
            theVocabulary.saveWordsList();
        }
        public string getWord()
        {
            word = theVocabulary.readWord();

            if (word != null)
            {
                //theVocabulary.setWord(word);
                //meaning = sr.ReadLine();
                //theVocabulary.setSolution(solution);
                wordIndex++;
            }
            else
            {
                word = null;
                meaning = null;
                theStudent.writeTimesToFile();
                if(mode == 0)
                    MessageBox.Show("study finished", "Success");
                else if(mode == 1)
                    MessageBox.Show("test finished", "Success");
            }
            
            return word;
        }

        public string getMeaning()
        {
            meaning = theVocabulary.getMeaning();
            return meaning;
        }





    }
}
