using System.ComponentModel;

namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Lists ... 
			List<string> Tasks = ["BreakFast", "Study", "Play", "Exercise", "sleep"];
			Console.WriteLine("Count : " +  Tasks.Count);
			Tasks.Remove("Play");
			Console.WriteLine("Count : " + Tasks.Count);
			Tasks.Add("Drink");
			Console.WriteLine("Count : " + Tasks.Count);
			foreach (var task in Tasks)
			{
				Console.WriteLine(task);
			}
		}
	}
}