using System.ComponentModel;

namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student("Akarsh",24,01);
			s1.age = -2;

			Student s2 = new Student("Adarsh",25,02);

			// Printing ... 
			Console.WriteLine("Student 1 Details");
			Console.WriteLine("Name : " +  s1.Name);
			Console.WriteLine("Age : " + s1.age);
			Console.WriteLine("Id : " + s1.ID);

			Console.WriteLine();

			Console.WriteLine("Student 2 Details");
			Console.WriteLine("Name : " + s2.Name);
			Console.WriteLine("Age : " + s2.age);
			Console.WriteLine("Id : " + s2.ID);
		}
	}
}