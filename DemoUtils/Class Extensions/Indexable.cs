using System.Reflection;

namespace DemoUtils
{
	public abstract class Indexable : object
	{
		public int KeyID { get; set; }
		public int PropCount
		{
			get => GetType().GetProperties().Length - 3;
		}
		public PropertyInfo this[int index]
		{
			get => GetType().GetProperties()[index];
			set => GetType().GetProperties()[index].SetValue(this, value);
		}
	}
}
