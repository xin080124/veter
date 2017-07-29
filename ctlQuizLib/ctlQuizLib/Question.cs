using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctlQuizLib
{
    class Question
    {
        protected string description;
        protected string solution;

        public string getDescription()
        {
            return description;
        }

        public string getSolution()
        {
            return solution;
        }
        
        public void setDescription(string newDescription)
        {
            description = newDescription;
        }

        public void setSolution(string newSolution)
        {
            solution = newSolution;
        }

        public bool checkAnswer(string answer)
        {
            bool result;
            if (solution == answer)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result; 
        }
    }
}
