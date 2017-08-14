using System;
using System.Threading;

namespace ThreadNeedsLock2
{
	public class Test
	{
		static int count=0;
    
		static void Main()
		{
			ThreadStart job = new ThreadStart(ThreadJob);
			Thread worker = new Thread(job);
			worker.Start();
        
			for (int i=0; i < 5; i++)
			{
				int tmp = count;
				Console.WriteLine ("Read count={0}", tmp);
				Thread.Sleep(50);
				tmp++;
				Console.WriteLine ("Incremented tmp to {0}", tmp);
				Thread.Sleep(20);
				count = tmp;
				Console.WriteLine ("Written count={0}", tmp);
				Thread.Sleep(30);
			}
        
			worker.Join();
			Console.WriteLine ("Final count: {0}", count);
			Console.Read();
		}
    
		static void ThreadJob()
		{
			for (int i=0; i < 5; i++)
			{
				int tmp = count;
				Console.WriteLine ("\t\t\t\tRead count={0}", tmp);
				Thread.Sleep(20);
				tmp++;
				Console.WriteLine ("\t\t\t\tIncremented tmp to {0}", tmp);
				Thread.Sleep(10);
				count = tmp;
				Console.WriteLine ("\t\t\t\tWritten count={0}", tmp);
				Thread.Sleep(40);
			}
		}
	}

}
