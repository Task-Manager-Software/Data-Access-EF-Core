using System.Collections.Generic;

namespace Data_Access_EF_Core.Entities
{
    public class Account : EntityBase
    {
        public string FullName { get; set; }

        public List<AccountProject> AccountProjects { get; set; }
        public List<AccountTask> AccountTasks { get; set; }
    }
}