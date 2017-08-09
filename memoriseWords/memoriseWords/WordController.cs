using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Collections;

namespace memoriseWords
{
    class WordController
    {
        private ctlWords theInterface;
        private vocabulary theVocabulary;
        private Student theStudent;
        private ArrayList theTimes;

        private int wordIndex;
        
        private string word;
        private string meaning;

        private StreamReader sr;

        public WordController(ctlWords newInterface)
        {
            theInterface = newInterface;
            theVocabulary = new vocabulary();
            sr = new StreamReader("c:\\temp\\WordBank.txt");

            wordIndex = -1;
        }

        public void setStudent(Student currentStudent)
        {
            theStudent = currentStudent;
            theTimes = new ArrayList();
        }

        public void addStudentPassTimes()
        {
            int oldValue = theStudent.getTimes(wordIndex);
            int newValue = oldValue + 1;
            theStudent.setTimes(wordIndex,newValue);
            //theTimes.Add(newValue);
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
                    wordIndex++;
                }
                else
                {
                    word = null;
                    theStudent.writeTimesToFile();
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
