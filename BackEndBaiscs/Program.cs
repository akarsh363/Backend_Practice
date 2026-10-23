namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Conditions
			int marks;
			Console.WriteLine("Enter your Marks : ");
			marks = int.Parse(Console.ReadLine());
			if ((marks > 100) || (marks < 0))
			{
				Console.WriteLine("Invalid Marks, Marks should be in the rage of (0-100)");
			}
			else if (marks >= 35)
			{
				Console.WriteLine("Pass");
			}
			else
			{
				Console.WriteLine("Fail");
			}
		}
	}
}
