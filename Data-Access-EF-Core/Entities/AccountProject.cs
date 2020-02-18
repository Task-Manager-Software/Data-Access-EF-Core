using Model.DotNetCore.Entities;

namespace Data_Access_EF_Core.Entities
{
    public class AccountProject : EntityBase, IAccountProject
    {
        public int AccountId { get; set; }
        public IAccount Account { get; set; }

        public int ProjectId { get; set; }
        public IProject Project { get; set; }

        public bool IsOwner { get; set; }
        public bool IsAccepted { get; set; }
    }
}
