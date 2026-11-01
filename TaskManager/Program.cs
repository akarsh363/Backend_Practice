
namespace TaskManager
{
	public class Program
	{
		public static void Main(string[] args)
		{
		    Student s1 = new Student(1,"Rahul",21);

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

			app.MapGet("/students/{id}", (int id) =>
			{
			    foreach(var item in students)
				{
	                if (item.Id == id)
					{
	                   return Results.Ok(item);
					}
				}
				return Results.NotFound("No Student Found with this ID " + id);
			});

			app.Run();
		}
	}
}
