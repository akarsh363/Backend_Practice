using System;
using System.Collections.Generic;
using System.Text;

namespace BackEndBaiscs
{
	internal class Student
	{
		public string Name { get; set; }

		private int Age { get; set; }

		public int age
		{
			get { return Age; }
			set
			{
				if (value > 0)
				{
					Age = value;
				}
				else
				{
					Console.WriteLine("Age cannot be less than 0");
				}
			}
		}

		public int ID { get; set; }

		public Student(string Name, int Age, int Id)
		{
			this.Name = Name;
			age = Age;
			this.ID = Id;
		}
	}
}
