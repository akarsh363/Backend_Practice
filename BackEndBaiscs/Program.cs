using System.ComponentModel;

namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int totalSubjects, marks;
			int totalMarks = 0;
			Console.WriteLine("WelCome!, This Program helps you calculate Total Marks, Average Marks, Pass/Fail Status");
			Console.WriteLine();
			Console.WriteLine("Enter the Total Number of Subjects : ");
			Console.WriteLine();
			totalSubjects = int.Parse(Console.ReadLine());

			if ((totalSubjects <= 0) || (totalSubjects > 10))
			{
				Console.WriteLine("Please Enter the total Number of Subjects in the range of (1-10) : ");
				return;
			}

			Console.WriteLine();
			for (int i = 1; i <= totalSubjects; i++)
			{
				Console.WriteLine("Enter the Marks of Subject out of 100 :  " + i + " : ");
				marks = int.Parse(Console.ReadLine());
				if ((marks < 0) || (marks > 100))
				{
					Console.WriteLine("Marks should be between 0 to 100");
					return;
				}
				totalMarks += marks;
			}
			double avg = (double)totalMarks / totalSubjects;
			Console.WriteLine();
			Console.WriteLine("-------RESULT-------");
			Console.WriteLine("Total Marks is : " + totalMarks);
			Console.WriteLine("Average Marks is : " + avg);
			if (avg >= 35)
			{
				Console.WriteLine("Result : Pass");
			}
			else
			{
				Console.WriteLine("Result : Fail");
			}
		}
	}
}