using Microsoft.EntityFrameworkCore;
using ToDoApp.Data;
using ToDoApp.Data.Models;

namespace ToDoApp.Services
{
	public class KanBanSectionService
	{
		private IDbContextFactory<ToDoDbContext> _dbContextFactory;
		
		public KanBanSectionService(IDbContextFactory<ToDoDbContext> dbContextFactory)
		{
			_dbContextFactory = dbContextFactory;
		}
		
		public void AddKanBanSection(KanBanSection kanbansection)
		{
			using( var context = _dbContextFactory.CreateDbContext())
			{
				context.KanBanSections.Add(kanbansection);
				context.SaveChanges();
			}
		}

		public List<KanBanSection> GetAllKanBanSections()
		{
			using (var context = _dbContextFactory.CreateDbContext())
			{
				var kanBanSections = context.KanBanSections.ToList();

				return kanBanSections;
			}
		}
		public void DeleteKanbanKanBanSection(long taskId)
		{
			using (var context = _dbContextFactory.CreateDbContext())
			{
				var SectionToRemove = context.KanBanSections.Find(taskId);

				if (SectionToRemove != null)
				{
					context.KanBanSections.Remove(SectionToRemove);
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
