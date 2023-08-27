using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Data.Models
{
	public class KanbanTaskItem
	{


		[Key]
		public long ID { get; set; }
		public string Name { get; init; }
		public string Status { get; set; }
		public long KanBanSectionFK { get; set; }
		//KanBanSection kanbansectionFK;
		public KanbanTaskItem(string name, string status)
		{
			Name = name;
			Status = status;
			//KanBanSectionFK = kanbansectionFK;
		}
	}
}
