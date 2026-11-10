
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TaskManager.Data
{
	public class TaskDbContextFactory :
		IDesignTimeDbContextFactory<TaskDBContext>
	{
		public TaskDBContext CreateDbContext(string[] args)
		{
			var optionsBuilder =
				new DbContextOptionsBuilder<TaskDBContext>();

			optionsBuilder.UseSqlServer(
				"Server=AKARSH\\SQLEXPRESS;Database=TaskManagerDB;Trusted_Connection=True;TrustServerCertificate=True;");

			return new TaskDBContext(optionsBuilder.Options);
		}
	}
}
