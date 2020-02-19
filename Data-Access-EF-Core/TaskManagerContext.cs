using Microsoft.EntityFrameworkCore;
using Model.DotNetCore.Entities;
using System;
using System.Linq;

namespace Data_Access_EF_Core
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions<TaskManagerContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountProject> AccountProjects { get; set; }
        public DbSet<AccountTask> AccountTasks { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Model.DotNetCore.Entities.Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(schema: DBGlobals.SchemaName);
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            AddAuitInfo();
            return base.SaveChanges();
        }

        public async System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            AddAuitInfo();
            return await base.SaveChangesAsync();
        }

        private void AddAuitInfo()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(x => x.Entity is AuditableEntityBase && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((AuditableEntityBase)entry.Entity).CreatedOnUTC = DateTime.UtcNow;
                }

                ((AuditableEntityBase)entry.Entity).LastModifiedOnUTC = DateTime.UtcNow;
            }
        }

        // TODO: Get connection string from appSettings
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite("Data Source=taskManager.db");
    }
}