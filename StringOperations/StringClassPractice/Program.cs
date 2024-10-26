using System;
using System.Text;
using System.Text.RegularExpressions;

namespace StringClassPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a string with number");
			string s = Console.ReadLine();
			int num = GetNumber(s);
			Console.WriteLine(num);
		}

		public static int GetNumber(string s)
		{
			string[] n = Regex.Split(s, @"\D+");
			string s1 = string.Empty;
			/*
			foreach (var item in n)
			{
				s1 += item;
			}  */
			for(int i = 0; i < n.Length; i++)
			{
				s1 += n[i];
			}
			int num = int.Parse(s1);
			return num;
		}
	}
}
