using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ctlQuizLib
{
    class QuizController
    {
        private ctlQuiz theInterface;
        private Question theQuestion;
        private int correct;
        private int incorrect;
        private string question;
        private string solution;
        private StreamReader sr;


        public QuizController(ctlQuiz newInterface)
        {
            theInterface = newInterface;
        }

        public void startQuiz()
        {
            sr = new StreamReader("c:\\temp\\QuestionBank.txt");
            theQuestion = new Question();
            correct = 0;
            incorrect = 0;
        }
        
        public void processAnswer(string answer)
        {
            if(theQuestion.getSolution().Equals(answer))
            {
                correct += 1;
            }
            else
            {
                incorrect += 1;
            }
        }
        
        public string readQuestion()
        {
            try
            {
                question = sr.ReadLine();
                if(question != null)
                {
                    theQuestion.setDescription(question);
                    solution = sr.ReadLine();
                    theQuestion.setSolution(solution);
                }
                else
                {
                    question = null;
                }
            }
            catch(IOException)
            {
                Console.Write("Exception caught while reading the questions file");
            }
            return question;
        }

        public outcome gameover()
        {
            outcome result;
            if(correct == incorrect)
            {
                result = outcome.Draw;
            }
            else
            {
                if(correct > incorrect)
                {
                    result = outcome.Win;
                }
                else
                {
                    result = outcome.Lose;
                }
            }
            return result;
        }

        public void reset()
        {
            sr.Close();
        }
    }
}
