using Microsoft.EntityFrameworkCore;
using TaskManager.Data;

namespace TaskManager
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Student s1 = new Student(1, "Rahul", 21);

			Student s2 = new Student(2, "Priya", 22);

			Student s3 = new Student(3, "Amit", 20);

			List<Student> students = new List<Student>();
			students.Add(s1);
			students.Add(s2);
			students.Add(s3);

			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllers();

			// OpenAPI document generation
			builder.Services.AddOpenApi();

			// Swagger services
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

			builder.Services.AddDbContext<TaskDBContext>(options => options.UseSqlServer(connectionString));

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.MapOpenApi();

				// Enable Swagger
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();

			app.MapControllers();

			// Get 1 Student by Id... 
			app.MapGet("/students/{id}", (int id) =>
			{
				foreach (var item in students)
				{
					if (item.Id == id)
					{
						return Results.Ok(item);
					}
				}
				return Results.NotFound("No Student Found with this ID " + id);
			});

			// Get All Students...
			app.MapGet("/students", () =>
			{
				if (students.Count == 0)
				{
					return Results.NotFound("No Students are present");
				}
				return Results.Ok(students);
			});


			// Add a Student (POST)...
			app.MapPost("/students", (Student request) =>
			{
				students.Add(request);
				return Results.Ok("Student Added Successfully!");
			});

			// Delete a Student (DELETE)...
			app.MapDelete("/students/{id}", (int id) =>
			{
				var stu = students.FirstOrDefault(s => s.Id == id);

				if (stu == null)
				{
					return Results.NotFound("No Student found with this ID : " + id);
				}

				students.Remove(stu);
				return Results.Ok("Student Deleted Successfully!");
			});

			// Update a Student...
			app.MapPut("/students/{id}", (int id, Student stud) =>
			{
				var stu = students.FirstOrDefault((s) => s.Id == id);

				if (stu == null)
				{
					return Results.NotFound("No Student found with this Id : " + id);
				}

				stu.Id = id;
				stu.Age = stud.Age;
				stu.Name = stud.Name;
				return Results.Ok("Updated Student Successfully!");
			});

			app.Run();
		}
	}
}
