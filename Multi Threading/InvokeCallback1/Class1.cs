using System;
using System.Threading;

namespace InvokeCallback1
{
//I want to call the Printout() method asynchronously. This is the whole point of this example
	public class Test
	{
		//set up a delegate type to match the PrintOut() method
		delegate int TestDelegate(string myString);
    
		static void Main()
		{
			Console.WriteLine("Main thread: About to call PrintOut asynchronously");
			TestDelegate d = new TestDelegate(PrintOut);

			//d points to the PrintOut() method
			//d can be used to run the method synchronously 
			//but here we use it to run the method asynchronously
			//we give the parameter(s) of PrintOut, followed by a delegate for our
			//Callback method, followed by d (the delegate itself)
			d.BeginInvoke("Hello There", new AsyncCallback(myCallback), d);
        
			//Console.WriteLine("Main thread: Child thread has been started");
			Console.WriteLine("Main thread: Printout has been called asynchronously");
			// Give the callback time to execute - otherwise the app
			// may terminate before it is called
			Thread.Sleep(1000);
			Console.WriteLine("Main thread: Main thread now ending");
			Console.Read();
		}
    
		static int PrintOut (string str1)
		{
			Console.WriteLine("\t\tchild thread: " + str1);
			return str1.Length;
		}
    
		static void myCallback (IAsyncResult ar)
		//the void return and IAsyncResult parameter are required for all callback methods
		{
			TestDelegate d = (TestDelegate)ar.AsyncState;
			int n = d.EndInvoke(ar);  //n will get the return value of PrintOut()
			Console.WriteLine ("\t\tchild thread: " + "Delegate returned " + n.ToString());
		}
	}

}
