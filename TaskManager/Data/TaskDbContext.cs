using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Data
{
	public class TaskDBContext : DbContext
	{
		public TaskDBContext(DbContextOptions<TaskDBContext> options)
		   : base(options)
		{
		}

		public DbSet<TaskItem> Tasks { get; set; }
	}
}
