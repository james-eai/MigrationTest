using System;
using System.Collections.Generic;
using System.Text;
using DemoUtils;

namespace Test1_SingleProjectSolution.Objects
{
	class Person : Creature
	{
		public string Name { get; set; }
		public Height Height { get; set; }
		public new string Designation
		{
			get { return Name; }
		}
		public DateTime BirthDate
		{
			get; set;
		}
		public int Age
		{
			get
			{
				try
				{
					return DateTime.Now.Year - BirthDate.Year;
				}
				catch (NullReferenceException)
				{

					throw new NullReferenceException("Cannot get age without birth date");
				}
			}
		}
		public Person(DateTime birth_date, Height height, string name = null)
		{
			Name = name;
			BirthDate = birth_date;
			Height = height;
			NumberOfArms = 2;
			NumberOfEars = 2;
			NumberOfEyes = 2;
			NumberOfLegs = 2;
			NumberOfTeeth = 32;
			HasBrain = true;
			IsAlive = true;
			IsHuman = true;
		}
		
	}

	class Height
	{
		private readonly int Feet;
		private readonly int Inches;
		public object this[string key]
		{
			get => GetType().GetProperty(key).GetValue(this); 
			set { GetType().GetProperty(key).SetValue(this, value); }
		}
		public Height(int feet = 0, int inches = 0)
		{
			Feet = feet;
			Inches = inches;
		}
		public override string ToString()
		{
			return $"{Feet}\'{Inches}\"";
		}

	}
}
