using System.ComponentModel;

namespace BackEndBaiscs
{
	internal class Program
	{
		static List<Student> students = new List<Student>();
		private static int res;

		static void Main(string[] args)
		{
			string choice;
			while (true)
			{
				Console.WriteLine("=========Student Manager===========");
				Console.WriteLine("1. Add Student");
				Console.WriteLine("2. List Students");
				Console.WriteLine("3. Search Student by Id");
				Console.WriteLine("4. Exit");
				Console.WriteLine();
				Console.WriteLine("Enter your choice : ");
				choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						AddStudent();
						break;
					case "2":
						ListStudents();
						break;
					case "3":
						SearchStudentById();
						break;
					case "4":
						Console.WriteLine("Exiting Student Manager!");
						Console.WriteLine();
						return;
					default:
						Console.WriteLine("Enter a Valid Input!");
						Console.WriteLine();
						break;
				}
			}
		}

		private static void SearchStudentById()
		{
			int ip;
			Console.WriteLine("Enter the Sudent's ID which you are looking for : ");
			try
			{
				ip = int.Parse(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return;
			}

			foreach (var item in students)
			{
				if (ip == item.ID)
				{
					Console.WriteLine("Student Found!");
					Console.Write("ID : " + item.ID + " | ");
					Console.Write("Name : " + item.Name + " | ");
					Console.Write("Age : " + item.Age + " | ");
					Console.WriteLine();
					Console.WriteLine();
					return;
				}
			}
			Console.WriteLine("No Matching student found!");
			Console.WriteLine();
		}

		private static void ListStudents()
		{
			if (students.Count > 0)
			{
				Console.WriteLine("Student's List : ");
				foreach (var item in students)
				{
					Console.Write("ID : " + item.ID + " | ");
					Console.Write("Name : " + item.Name + " | ");
					Console.Write("Age : " + item.Age + " | ");
					Console.WriteLine();
				}
			}
			else
			{
				Console.WriteLine("There are No Students to display!");
				Console.WriteLine();
			}
		}

		private static void AddStudent()
		{
			Student student = new Student();
			Console.WriteLine("Enter the Student's ID : ");
			string input = Console.ReadLine();
			if (int.TryParse(input, out int result))
			{
				foreach (var item in students)
				{
					if (result == item.ID)
					{
						Console.WriteLine("Student ID Cannot be Same, Choose a different ID : ");
						Console.WriteLine();
						return;
					}
				}
				student.ID = result;
			}
			else
			{
				Console.WriteLine("Please enter a Valid Student Id!");
				Console.WriteLine();
				return;
			}

			Console.WriteLine("Enter the Student's Name : ");
			student.Name = Console.ReadLine();

			if (string.IsNullOrWhiteSpace(student.Name))
			{
				Console.WriteLine("Name Cannot be Empty!");
				return;
			}

			Console.WriteLine("Enter the Student's Age : ");

			try
			{
				student.Age = int.Parse(Console.ReadLine());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine();
				return;
			}


			if (student.Age <= 0)
			{
				Console.WriteLine("Age should be more than 0");
				Console.WriteLine();
				return;
			}

			students.Add(student);
			Console.WriteLine("Student Added Successfully!");
			Console.WriteLine();
		}
	}
}