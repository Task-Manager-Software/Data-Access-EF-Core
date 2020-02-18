using Data_Access_EF_Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
    public class TaskManagerContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountProject> AccountProjects { get; set; }
        public DbSet<AccountTask> AccountTasks { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Task> Tasks { get; set; }

        // TODO: Get connection string from appSettings
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=taskManager.db");
    }
}