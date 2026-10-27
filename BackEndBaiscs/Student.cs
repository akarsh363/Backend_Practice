using System;
using System.Collections.Generic;
using System.Text;

namespace BackEndBaiscs
{
	internal class Student
	{
	    public string Name { get; set; }

		public int Age { get; set; }

		public int ID { get; set; }

		public Student(string Name, int Age, int Id)
		{
			this.Name = Name;
			this.Age = Age;
			this.ID = Id;
		}
	}
}
