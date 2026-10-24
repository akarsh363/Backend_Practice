namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Loops 
			int num;
			Console.WriteLine("Enter the Number : ");
			num = int.Parse(Console.ReadLine());
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine(num + " * " + i + " = " + (num * i));
			}
		}
	}
}
