using Model.DotNetCore.Entities;
using System.Collections.Generic;

namespace Data_Access_EF_Core.Entities
{
    public interface IProject<out Project> where Project : IProject
    {
        public string Title { get; set; }
        public bool ShowCompletedTasks { get; set; }

        public List<IAccountProject> AccountProjects { get; set; }
        public List<ITask> Tasks { get; set; }
    }
}
