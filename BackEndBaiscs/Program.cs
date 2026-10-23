namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// DataTypes and Parsing 
			int marks1, marks2;
			double average;

			Console.WriteLine("Enter the Marks of Subject 1 : ");
			marks1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter the Marks of Subject 2 : ");
			marks2 = int.Parse(Console.ReadLine());

			average = (marks1 + marks2) / 2.0;

			Console.WriteLine("Total Marks is : " + (marks1 + marks2));
			Console.WriteLine("Average Marks is : " + average);
		}
	}
}
