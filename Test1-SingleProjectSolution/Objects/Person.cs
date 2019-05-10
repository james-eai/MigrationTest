using System;
using System.Collections.Generic;
using System.Text;
using DemoUtils;

namespace Test1_SingleProjectSolution.Objects
{
	class Person : Indexable
	{
		public string Name { get; set; }
		public Height Height { get; set; }
		public DateTime BirthDate
		{
			get => BirthDate;
			set { BirthDate = value; Age = DateTime.Now.Year - value.Year; }
		}
		public int Age
		{
			get
			{
				if (BirthDate == null)
					throw new Exception("Cannot derrive age without birth date");
				else
					return Age;
			}
			private set
			{
				if (BirthDate == null)
					throw new Exception("Cannot derrive age without birth date");
				else
					Age = value;
			}
		}
		
	}

	class Height
	{
		private int Feet;
		private int Inches;
		public string this[string key]
		{
			get => $"{Feet}'{Inches}\"";
			set { GetType().GetProperty(key).SetValue(this, value); }
		}

	}
}
