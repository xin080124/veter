using System;

namespace LockedThread
{
	using System;
	using System.Threading;

	public class Test
	{
		static int count=0;
		static readonly object countLock = new object();
    
		static void Main()
		{
			ThreadStart job = new ThreadStart(ThreadJob);
			Thread thread = new Thread(job);
			thread.Start();
        
			for (int i=0; i < 5; i++)
			{
				lock (countLock)
				{
					int tmp = count;
					Console.WriteLine ("Read count={0}", tmp);
					Thread.Sleep(50);
					tmp++;
					Console.WriteLine ("Incremented tmp to {0}", tmp);
					Thread.Sleep(20);
					count = tmp;
					Console.WriteLine ("Written count={0}", tmp);
				}
				Thread.Sleep(30);
			}
        
			thread.Join();
			Console.WriteLine ("Final count: {0}", count);
			Console.Read();
		}
    
		static void ThreadJob()
		{
			for (int i=0; i < 5; i++)
			{
				lock (countLock)
				{
					int tmp = count;
					Console.WriteLine ("\t\t\t\tRead count={0}", tmp);
					Thread.Sleep(20);
					tmp++;
					Console.WriteLine ("\t\t\t\tIncremented tmp to {0}", tmp);
					Thread.Sleep(10);
					count = tmp;
					Console.WriteLine ("\t\t\t\tWritten count={0}", tmp);
				}
				Thread.Sleep(40);
			}
		}
	}

}
