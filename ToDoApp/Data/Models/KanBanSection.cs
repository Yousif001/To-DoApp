using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;


namespace ToDoApp.Data.Models
{
	public class KanBanSection
	{
		[Key]
		public long ID { get; set; }
		public string Name { get; init; }
		public string? Descirption { get; set; }
		public DateTime? Date { get; set; }
		public bool NewTaskOpen { get; set; }
		public string NewTaskName { get; set; }



		public KanBanSection(string name, string descirption, DateTime? date, bool newTaskOpen, string newTaskName)
		{
			Name = name;
			Descirption = descirption;
			Date = date;
			NewTaskOpen = newTaskOpen;
			NewTaskName = newTaskName;

		}
	}
}
