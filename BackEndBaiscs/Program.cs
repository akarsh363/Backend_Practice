using System.ComponentModel;

namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// String... 
			string name;
			Console.WriteLine("Enter your Name : ");
			name = Console.ReadLine() ?? string.Empty;

			// ToUpper 
			Console.WriteLine("Upper Case : " + name.ToUpper());

			// ToLower
			Console.WriteLine("Lower Case : " + name.ToLower());

			// Contains 
			if (name.Contains('d'))
			{
				Console.WriteLine("Contains d");
			}
			else
			{
				Console.WriteLine("Does not Contains d");
			}

			// Trim 
			name = name.Trim();

			// Interpolation 
			Console.WriteLine($"Your Name is : {name}");
		}
	}
}