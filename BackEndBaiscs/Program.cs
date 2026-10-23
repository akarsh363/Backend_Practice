namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Input and Output 
			string name, subject;
			Console.WriteLine("Enter your Name : ");
			name = Console.ReadLine();
			Console.WriteLine("Enter your favourite Subject : ");
			subject = Console.ReadLine();

			Console.WriteLine($"Hi {name}, your favourite Subject is : {subject}");
			Console.WriteLine("Hi {0}, your favourite Subject is : {1}",name,subject);
			Console.WriteLine("Hi " + name + ", your favourite Subject is : " + subject);
		}
	}
}
