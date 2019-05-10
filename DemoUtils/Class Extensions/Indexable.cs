using System.Reflection;

namespace DemoUtils
{
	public abstract class Indexable
	{
		public int KeyID { get; set; }
		public object this[int index]
		{
			get => GetType().GetProperties()[index].GetValue(this);
			set => GetType().GetProperties()[index].SetValue(this, value);
		}
	}
}
