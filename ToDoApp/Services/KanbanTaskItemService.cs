using Microsoft.EntityFrameworkCore;
using ToDoApp.Data.Models;
using ToDoApp.Data;

namespace ToDoApp.Services
{
	public class KanbanTaskItemService
	{


		private IDbContextFactory<ToDoDbContext> _dbContextFactory;

		public KanbanTaskItemService(IDbContextFactory<ToDoDbContext> dbContextFactory)
		{
			_dbContextFactory = dbContextFactory;
		}

		public void AddKanbanTaskItem(KanbanTaskItem kanbantaskitem)
		{
			using (var context = _dbContextFactory.CreateDbContext())
			{
				context.KanbanTaskItems.Add(kanbantaskitem);
				context.SaveChanges();
			}
		}

		public List<KanbanTaskItem> GetAllKanbanTaskItems()
		{
			using (var context = _dbContextFactory.CreateDbContext())
			{
				var KanbanTaskItems = context.KanbanTaskItems.ToList();

				return KanbanTaskItems;
			}
		}
		public void RemoveKanbanTaskItem(long taskId)
		{
			using (var context = _dbContextFactory.CreateDbContext())
			{
				var taskToRemove = context.KanbanTaskItems.Find(taskId);

				if (taskToRemove != null)
				{
					context.KanbanTaskItems.Remove(taskToRemove);
					context.SaveChanges();
				}
				else
				{
					Console.WriteLine($"Task with ID {taskId} not found.");
				}
			}
		}

		
	}
}
