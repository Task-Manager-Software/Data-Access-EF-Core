using Model.DotNetCore.Entities;

namespace Data_Access_EF_Core.Entities
{
    public class AccountTask : EntityBase, IAccountTask
    {
        public int AccountId { get; set; }
        public IAccount Account { get; set; }

        public int TaskId { get; set; }
        public ITask Task { get; set; }

        public bool IsAccepted { get; set; }
    }
}
