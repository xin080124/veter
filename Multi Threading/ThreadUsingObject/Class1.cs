using System;
using System.Threading;

namespace TheadUsingObject
{

	class MultiThread
	{
		public static void Main()
		{
			Console.WriteLine("Main thread starting.");

			// First, construct a ShowCount object.
			ShowCount counter = new ShowCount ("child #1");
		
			//Next, construct a thread using the Run() method of
			// that object.
			Thread newThread = new Thread(new ThreadStart(counter.Run));

			//Finally, start execution of the thread.
			newThread.Start();

			do
			{
				Console.Write("~");
				Thread.Sleep(100);
			}while (!counter.Finished);

			Console.WriteLine("Main thread ending.");
			Console.Read();
		}

		class ShowCount
		{
			private int count;
			private string threadName;
			private bool finished;

			public ShowCount (string name)
			{
				count = 0;
				threadName = name;
				finished = false;
			}

			//job for thread to do
			public void Run()
			{
				Console.WriteLine(threadName + " starting.");
				do
				{
					Thread.Sleep(500);
					Console.WriteLine("In " 
						+threadName 
						+ ",count is " +count);
					count++;
				}while(count < 10);

				Console.WriteLine(threadName + " terminating.");
				finished = true;
			}

			public bool Finished
			{
				get 
				{
					return finished;
				}
			}
		}

	}
}
