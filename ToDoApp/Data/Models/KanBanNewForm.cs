using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Data.Models
{
	public class KanBanNewForm
	{
		[Key]
		public long ID { get; set; }

		[Required]
		[StringLength(10, ErrorMessage = "Name length can't be more than 10.")]
		public string Name { get; set; }
		public string Descirption { get; set; }
		public DateTime? Date { get; set; }
		

	}
}
