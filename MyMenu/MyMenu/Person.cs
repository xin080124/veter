using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMenu
{
    class Person
    {
        private string name;
        private int age;
        private double height;

        public Person(string strName, int intAge, double douHeight)
        {
            name = strName;
            age = intAge;
            height = douHeight;
        }

        public string CommaText()
        {
            //string str = "Name:" + name +
            //           " Age:" + age.ToString() +
            //           " Height:" + height.ToString();

            string str =  name +
                      "," + age.ToString() +
                      "," + height.ToString();
            return str;
        }
    }

    
}
