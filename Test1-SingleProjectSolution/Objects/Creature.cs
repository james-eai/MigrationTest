using DemoUtils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test1_SingleProjectSolution.Objects
{
	class Creature : Indexable
	{
		public int NumberOfLegs { get; set; }
		public int NumberOfEyes { get; set; }
		public int NumberOfArms { get; set; }
		public int NumberOfEars { get; set; }
		public int NumberOfTeeth { get; set; }
		public string Designation { get; set; }
		public bool HasBrain { get; set; }
		public bool IsAlive { get; set; }
		public bool IsHuman { get; set; }
		public Creature(int NumberOfArms = 0, int NumberOfEars = 0, int NumberOfEyes = 0, int NumberOfLegs = 0, int NumberOfTeeth = 0, bool IsHuman = false, bool HasBrain = false, bool IsAlive = false, string Designation = "Your creature has no designation.")
		{ }
	}
}
