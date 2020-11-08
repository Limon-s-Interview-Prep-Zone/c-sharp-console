using System;
using System.Threading;

namespace ThreadExample
{
	//TypeSafe class for Type-safe threadclass
	class TypeSafe
	{
		public int Number;
		public TypeSafe(int num)
		{
			Number = num;
		}
		public void DisplayNumbers()
		{
			for (int i = 1; i <= Number; i++)
			{
				Console.WriteLine("Type-safe : " + i);
			}
		}
	}
	class Program
	{
		//Thread constructor method//
		static void DisplayNumbers()
		{
			for (int i = 1; i <= 20; i++)
			{
				Console.WriteLine("Method1 :" + i);
			}
		}

		//ParameterizedThreadStart example//
		public void ParameterizeThread(object num)
		{
			//int n = ((int)num);
			int n = Convert.ToInt32(num);
			for (int i = 1; i <= n; i++)
			{
				Console.WriteLine("Method1 :" + i);
			}
		}
		static void Main(string[] args)
		{
			//Thread constructor//
			Console.ForegroundColor = ConsoleColor.Red;
			Console.BackgroundColor = ConsoleColor.Green;
			Console.WriteLine("******** Thread with constructor******");
			Console.ResetColor();
			//ThreadStart t = new ThreadStart(DisplayNumbers);
			//Thread t1 = new Thread(t);
			//Thread t1 = new Thread(new ThreadStart(DisplayNumbers));
			Thread t1 = new Thread(()=> { DisplayNumbers(); });
			//t1.Start();
			
			 //thread with anonymos object
			Thread t2 = new Thread(()=>{
				for (int i = 1; i <= 20; i++)
				{
					Console.WriteLine("Inside thread :" + i);
				}
			});
			//t2.Start();
			Console.WriteLine();
			
			//ParameterizedThreadStart example//
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Green;
			Console.WriteLine("********Parameterized Thread with example******");
			//create a object of the class
			Program obj = new Program();
			//ParameterizedThreadStart pmT = new ParameterizedThreadStart(obj.ParameterizeThread);
			Thread pmt = new Thread(new ParameterizedThreadStart(obj.ParameterizeThread));
			pmt.Start(10);
			Console.ResetColor();

			//TypeSafe with parameter// 
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Green;
			Console.WriteLine("********Parameter with Type-Safe Thread with example******");
			Console.ResetColor();
			TypeSafe tf = new TypeSafe(10);
			Thread tsafe = new Thread(new ThreadStart(tf.DisplayNumbers));
			tsafe.Start();

		}

	}
}
