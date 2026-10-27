using System.ComponentModel;

namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Number Checker!");

			// Try Parse ...
			Console.WriteLine("Enter the Number : ");
			string input = Console.ReadLine();
			if (int.TryParse(input, out int result))
			{
				Console.WriteLine("Input is : " + input);
			}
			else
			{
				Console.WriteLine("Invalid Input!");
			}

			// Try Catch 
			try
			{
				int ip = int.Parse(Console.ReadLine());
				Console.WriteLine("Input is : " + ip);
			}
			catch (FormatException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}