namespace BackEndBaiscs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Switch 
			int choice;
			Console.WriteLine("Enter your choice (1,2 or 3) : ");
			choice = int.Parse(Console.ReadLine());
			switch (choice)
			{
				case 1:
					Console.WriteLine("Hello");
					break;
				case 2:
					Console.WriteLine(DateTime.Now.ToString());
					break;
				case 3:
					Console.WriteLine("Exit");
					break;
				default:
					Console.WriteLine("Please Enter a valid input");
					break;
			}
		}
	}
}
