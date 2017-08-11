using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.IO;


namespace memoriseWords
{
    class Student
    {
        protected int passTimes;

        private ArrayList theTimes;
        private StreamReader sr;
        private string name;

        public Student(string studentFirstName)
        {
            passTimes = 0;
            name = studentFirstName;
            theTimes = new ArrayList();
            getTimesFromFile();
        }

        public void getTimesFromFile()
        {
            string timePath = "c:\\temp\\" + name + ".txt";

            if (File.Exists(timePath))
            {

            }
            else
            {
                File.Create(timePath).Close();
            }

            sr = new StreamReader(timePath);

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                int time = int.Parse(line);
                theTimes.Add(time);
            }
            
            sr.Close();
        }

        public void writeTimesToFile()
        {
            int size = theTimes.Count;
            string timePath = "c:\\temp\\" + name + ".txt";

            StreamWriter sw = new StreamWriter(timePath);
            if (size>0)
            {
                for (int i = 0; i < size; i++)
                {
                    int times = (int)theTimes[i];
                    string data = times.ToString();
                    sw.Write(data);
                    sw.WriteLine();
                }

                sw.Flush();
                sw.Close();
            }
        }


        public void setTimes(int index,int times)
        {
            int size = theTimes.Count;
            //int times = 0;
            if (index < size)
                theTimes[index] = times;
            else
            {
                if(times>0)
                    theTimes.Add(1);
                else
                    theTimes.Add(0);
            }
                
        }

        public int getTimes(int index)
        {
            int size = theTimes.Count;
            int times = 0;
            if (index < size)
                times = (int)theTimes[index];
            
            return times;
        }
        
    }
}
