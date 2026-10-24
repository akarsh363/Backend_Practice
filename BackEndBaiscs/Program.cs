using System.ComponentModel;

namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
		    // Methods


		    // add
			int a, b;
			Console.WriteLine("Enter the first Number : ");
			a = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the second Number : ");
			b = int.Parse(Console.ReadLine());
			add(a, b);

			// isPass
			int marks;
			Console.WriteLine("Enter your marks : ");
			marks = int.Parse(Console.ReadLine());
			if (isPass(marks))
			{
				Console.WriteLine("Pass");
			}
			else
			{
				Console.WriteLine("Fail");
			}
		}

		private static bool isPass(int marks)
		{
			if (marks >= 35)
			{
				return true;
			}
			return false;
		}

		private static void add(int a, int b)
		{
			int sum = a + b;
			Console.WriteLine("The Sum of the 2 numbers is : " + sum);
		}
	}
}
