namespace PersonalTaskManager
{
	public class TaskItem
	{
	   public int Id { get; set; }

	   public string Title { get; set; }

	   public string Description { get; set; }

	   public bool isCompleted { get; set; }

	   public DateTime CreatedDate { get; set; }

		public TaskItem(int id, string title, string description, bool iscompleted, DateTime createddate) 
		{ 
		   Id = id;
		   Title = title;
		   Description = description;
		   isCompleted = iscompleted;
		   CreatedDate = createddate;
		}
	}
}
