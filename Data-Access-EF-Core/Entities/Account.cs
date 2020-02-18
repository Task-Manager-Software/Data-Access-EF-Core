using Model.DotNetCore.Entities;
using System.Collections.Generic;

namespace Data_Access_EF_Core.Entities
{
    public class Account : EntityBase, IAccount
    {
        public string FullName { get; set; }

        public List<IAccountProject> AccountProjects { get; set; }
        public List<IAccountTask> AccountTasks { get; set; }
    }
}