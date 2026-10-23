namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name;
			int age;
			bool isStudent;
			Console.WriteLine("Please Enter Your Name : ");
			name = Console.ReadLine();
			Console.WriteLine("Please Enter your Age : ");
			age = int.Parse(Console.ReadLine());
			Console.WriteLine("Are you a Student ? (True or False)");
			isStudent = bool.Parse(Console.ReadLine());
			Console.WriteLine("Name : " + name);
			Console.WriteLine("Age : " + age);
			Console.WriteLine("IsStudent : " + isStudent);
		}
	}
}
