﻿using System;
using Test1_SingleProjectSolution.Objects;
using c = System.Linq.Enumerable;

namespace Test1_SingleProjectSolution
{
	class Program
	{
		static void Main(string[] args)
		{
			var Bob = new Person(new DateTime(1990, 5, 5), new Height(5,10), "Bob");
			foreach(var i in c.Range(0,Bob.PropCount))
			{
				Console.WriteLine($"{Bob[i].Name}: {Bob[i].GetValue(Bob).ToString()}");
			}
		}
		public void DoATing()
		{
			//this doesnt actually do actually thing
		}
	}
}
