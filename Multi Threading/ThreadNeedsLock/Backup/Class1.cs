using System;
using System.Threading;

namespace ThreadNeedsLock
{

	public class Test
	{
		static int count=0;
    
		static void Main()
		{
			for (int i=0; i < 15; i++)
			{
				FiveThreads();
				count=0;
			}
			Console.Read();
		}

		private static void FiveThreads()
		{
			ThreadStart job = new ThreadStart(ThreadJob);
			Thread thread = new Thread(job);
			thread.Start();
        
			for (int i=0; i < 5; i++)
			{
				count++;
			}
        
			thread.Join();
			Console.WriteLine ("Final count: {0}", count);
		}
    
		static void ThreadJob()
		{
			for (int i=0; i < 5; i++)
			{
				count++;
			}
		}
	}    
}
