using System;

namespace ThreadConsole1
{
	using System;
	using System.Threading;

	public class Test
	{
		static void Main()
		{
			ThreadStart job = new ThreadStart(ThreadJob);
			Thread thread = new Thread(job);
			thread.Start();
        
			for (int i=0; i < 5; i++)
			{
				Console.WriteLine ("Main thread: {0}", i);
				Thread.Sleep(1000);
			}
			Console.Read();
		}
    
		static void ThreadJob()
		{
			for (int i=0; i < 10; i++)
			{
				Console.WriteLine ("\t\t\tOther thread: {0}", i);
				Thread.Sleep(500);
			}
		}
	}
}
