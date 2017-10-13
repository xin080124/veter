using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Diagnostics;


namespace MyConsoleMultiThread
{
    class Program
    {
        static int count = 0;
        static readonly object countLock = new object();
        
        static void Main(string[] args)
        {
            //error 2:ThreadStart require a task param  
            ThreadStart job = new ThreadStart(ThreadJob);

            //error 3:Thread require a ThreadStart param
            Thread thread = new Thread(job);

            //error 4:A thread can only be called by start method, not stop.
            //thread.Stop();
            thread.Start();
            for (int i = 0; i < 5; i++)
            {
                //error 1:lose lock param
                lock (countLock)
                {
                    int tmp = count;
                    Console.WriteLine("Read count={0}", tmp);
                    Thread.Sleep(50);
                    tmp++;
                    Console.WriteLine("Incremented tmp to {0}", tmp);
                    Thread.Sleep(20);
                    count = tmp;
                    Console.WriteLine("Written count={0}", tmp);
                }
                Thread.Sleep(30);
            }
            thread.Join();
            Console.WriteLine("Final count: {0}", count);
        }

        static void ThreadJob()
        {
            for (int i = 0; i < 5; i++)
            {
                lock (countLock)
                {
                    int tmp = count;
                    Console.WriteLine("\t\t\t\tRead count={0}", tmp);
                    Thread.Sleep(20);
                    tmp++;
                    Console.WriteLine("\t\t\t\tIncrementedtmp to {0}", tmp);
                    //error 5: an exception should not be throwed out in the following condition.
                    //if (count < 100)
                    //    throw new Exception();
                    Thread.Sleep(10);
                    count = tmp;
                    Console.WriteLine("\t\t\t\tWritten count={0}", tmp);
                }
                Thread.Sleep(40);
            }
        }
    }
}
