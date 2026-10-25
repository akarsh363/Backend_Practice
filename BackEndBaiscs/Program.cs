using System.ComponentModel;

namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
		    // Arrays... 
			int totalSubjects, sum = 0; ;
			Console.WriteLine("Enter the Total Number of Subjects : ");
			totalSubjects = int.Parse(Console.ReadLine());

			int[] marks = new int[totalSubjects];

			Console.WriteLine("Enter Each Subjects Marks : ");
			for (int i=0; i<marks.Length; i++)
			{
				marks[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine("Printing Marks : ");
			for (int i=0; i< marks.Length; i++) 
			{
               Console.WriteLine(marks[i]);
				sum += marks[i];
			}
			Console.WriteLine("Total Sum of marks is : " + sum);
		}
	}
}