using System.ComponentModel;

namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student();
			s1.Name = "Akarsh";
			s1.Age = 24;

			Student s2 = new Student();
			s2.Name = "Adarsh";
			s2.Age = 25;

			// Printing ... 
			Console.WriteLine("Student 1 Details");
			Console.WriteLine("Name : " +  s1.Name);
			Console.WriteLine("Age : " + s1.Age);

			Console.WriteLine();

			Console.WriteLine("Student 2 Details");
			Console.WriteLine("Name : " + s2.Name);
			Console.WriteLine("Age : " + s2.Age);
		}
	}
}