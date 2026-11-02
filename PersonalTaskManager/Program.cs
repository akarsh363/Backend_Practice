
namespace PersonalTaskManager
{
	public class Program
	{
		public static void Main(string[] args)
		{
			TaskItem t1 = new TaskItem(1, "Learn C#", "Practice OOP Concepts", false, DateTime.Now);
			TaskItem t2 = new TaskItem(2, "Learn APIs", "Understand RestApi", true, DateTime.Now);
			TaskItem t3 = new TaskItem(3, "Learn SQL", "Study Database basics", false, DateTime.Now);

			List<TaskItem> tasks = new List<TaskItem>();
			tasks.Add(t1);
			tasks.Add(t2);
			tasks.Add(t3);

			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
			builder.Services.AddOpenApi();

			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.MapOpenApi();

				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			// Retrieve All Tasks... 
			app.MapGet("/tasks", () =>
			{
				if (tasks.Count == 0)
				{
					return Results.NotFound("No Tasks are present!");
				}

				return Results.Ok(tasks);
			});

			// Retrieve Task by Id...
			app.MapGet("/tasks/{id}", (int id) =>
			{
				foreach (var task in tasks)
				{
					if (task.Id == id)
					{
						return Results.Ok(task);
					}
				}
				return Results.NotFound("Task with Id : " + id + " not found");
			});

			// Add Task...
			app.MapPost("/tasks", (TaskItem task) =>
			{
			    if (task.Id < 0)
				{
					return Results.BadRequest("Id cannot be negative");
				}
				foreach (var item in tasks)
				{
	               if (item.Id == task.Id)
				   {
						return Results.BadRequest("Id already exists!, use other Id");
				   }
				}

				if (string.IsNullOrWhiteSpace(task.Title))
				{
					return Results.BadRequest("Title cannot be blank");
				}

				if (string.IsNullOrWhiteSpace(task.Description))
				{
					return Results.BadRequest("Description cannot be blank");
				}
				tasks.Add(task);
				return Results.Ok("Task added sucessfully!");
			});

			// Update Task...
			app.MapPut("/tasks/{id}", (TaskItem task) =>
			{
				if (task.Id < 0)
				{
					return Results.BadRequest("Id cannot be negative");
				}

				foreach (var item in tasks)
				{
					if (item.Id == task.Id)
					{
						return Results.BadRequest("Id already exists!, use other Id");
					}
				}

				if (string.IsNullOrWhiteSpace(task.Title))
				{
					return Results.BadRequest("Title cannot be blank");
				}

				if (string.IsNullOrWhiteSpace(task.Description))
				{
					return Results.BadRequest("Description cannot be blank");
				}

				foreach (var item in tasks)
				{
					if (item.Id == task.Id)
					{
						item.Title = task.Title;
						item.Description = task.Description;
						return Results.Ok("Task updated sucessfully!");
					}
				}
				return Results.NotFound("Task with Id : " + task.Id + " not found!");
			});

			// Complete a Task...
			app.MapPut("/tasks/{id}/complete", (int id) =>
			{
				foreach (var task in tasks)
				{
					if (task.Id == id)
					{
						if (task.isCompleted)
						{
							return Results.Ok("Task is already completed!");
						}
						task.isCompleted = true;
						return Results.Ok("Task marked as Completed!");
					}
				}
				return Results.NotFound("Task with Id : " + id + " not found!");
			});

			// Delete a Task...
			app.MapDelete("/tasks/{id}", (int id) =>
			{
				foreach (var item in tasks)
				{
					if (item.Id == id)
					{
						tasks.Remove(item);
						return Results.Ok("Task Deleted Sucessfully!");
					}
				}
				return Results.NotFound("Task with id : " + id + " not found to delete!");
			});

			// Task Summary...
			app.MapGet("tasks/summary", () =>
			{
				if (tasks.Count == 0)
				{
					return Results.NotFound("No Tasks are present!");
				}

				int isCompleted = 0, isPending = 0;
				Dictionary<string, int> status = new Dictionary<string, int>();
				{
					foreach (var item in tasks)
					{
						if (item.isCompleted)
						{
							isCompleted++;
						}
						else
						{
							isPending++;
						}
					}
				}
				status.Add("totalTasks", tasks.Count);
				status.Add("isCompleted", isCompleted);
				status.Add("isPending", isPending);
				return Results.Ok(status);
			});

			// Filter Tasks... 
			app.MapGet("/tasks/status/{status}", (string status) =>
			{
				int isCompletedCount = 0, isPendingCount = 0;
				switch (status)
				{
					case "Completed":
						foreach (var item in tasks)
						{
							if (item.isCompleted)
							{
								isCompletedCount++;
							}
						}
						return Results.Ok("Completed Tasks are : " + isCompletedCount);

					case "Pending":
						foreach (var item in tasks)
						{
							if (!item.isCompleted)
							{
								isPendingCount++;
							}
						}
						return Results.Ok("Pending Tasks are : " + isPendingCount);

					case "All":
						return Results.Ok("Total Tasks are : " + tasks.Count);

					default: return Results.NotFound("Please Enter a valid Status from these (Completed, Pending, All)");
				}
			});

			app.Run();
		}
	}
}
