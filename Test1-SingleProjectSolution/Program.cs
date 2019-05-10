using System;
using c = System.Linq.Enumerable;

namespace Test1_SingleProjectSolution
{
	class Program
	{
		static void Main(string[] args)
		{
			foreach(var i in c.Range(0,5))
			{
				Console.Write($"{i}");
			}
			Console.WriteLine("\nHello World!");
		}
	}
}
