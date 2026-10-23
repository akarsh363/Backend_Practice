namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Operators 
			int num1, num2;
			Console.WriteLine("Enter the First Number : ");
			num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the Second Number : ");
			num2 = int.Parse(Console.ReadLine());
			Console.WriteLine("The Sum of the 2 Numbers is : " +  (num1 + num2));
			Console.WriteLine("The difference of the 2 Numbers is : " + (num1 - num2));
			Console.WriteLine("The product of the 2 Numbers is : " + (num1 * num2));
		}
	}
}
