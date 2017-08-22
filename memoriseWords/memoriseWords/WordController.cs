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

        private int successNum;
        private int showedNum;

        //private int wordIndex;

        private string word;
        private string meaning;

        private StreamReader sr;
        private bool toEnd;

        public WordController(ctlWords newInterface)
        {
            theInterface = newInterface;
            theVocabulary = new vocabulary();
            
            mode = -1;
            //wordIndex = -1;
            successNum = 0;
            showedNum = 0;

            toEnd = false;
        }

        public bool ifEnd()
        {
            return toEnd;
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
            int wordIndex = theVocabulary.getWordIndex()-1;
            int oldValue = theStudent.getTimes(wordIndex);
            int newValue = oldValue + 1;
            theStudent.setTimes(wordIndex,newValue);
            //theTimes.Add(newValue);

            successNum++;
        }

        public String generateReportString()
        {
            String reportStr = "";
            reportStr += "Totally showed " + showedNum.ToString() + " words";
            reportStr += "\n " + successNum.ToString() + " has been recalled successfully!";
            return reportStr;
        }

        public void resetStudentPassTimes()
        {
            int wordIndex = theVocabulary.getWordIndex()-1;
            int newValue = 0;
            theStudent.setTimes(wordIndex, newValue);
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
            //hide the words the student is already familiar with

            if(mode == 1)
            {
                int nextIndex = theVocabulary.getWordIndex();
                while (theStudent.getTimes(nextIndex) > 2)
                {
                    word = theVocabulary.readWord();
                    nextIndex = theVocabulary.getWordIndex();
                }
            }
            
            word = theVocabulary.readWord();

            if (word != null)
            {
                //wordIndex++;
                showedNum++;
            }
            else
            {
                word = null;
                meaning = null;
                
                if(mode == 0)
                    MessageBox.Show("study finished", "Success");
                else if(mode == 1)
                {
                    toEnd = true;
                    theStudent.writeTimesToFile();
                    MessageBox.Show("test finished", "Success");
                }
                    
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
