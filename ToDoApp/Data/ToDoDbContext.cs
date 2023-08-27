using Microsoft.EntityFrameworkCore;
using ToDoApp.Data.Models;

namespace ToDoApp.Data
{
	public class ToDoDbContext : DbContext
	{
		public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
			: base(options)
		{

		}
		public DbSet<KanbanTaskItem> KanbanTaskItems { get; set; }
		public DbSet<KanBanSection> KanBanSections { get; set; }
		public DbSet<KanBanNewForm> KanBanNewForms { get; set; }


	}
}