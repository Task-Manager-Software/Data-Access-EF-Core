using System.Collections.Generic;

namespace Data_Access_EF_Core.Entities
{
    public class Project : EntityBase
    {
        public string Title { get; set; }
        public bool ShowCompletedTasks { get; set; }

        public List<AccountProject> AccountProjects { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
