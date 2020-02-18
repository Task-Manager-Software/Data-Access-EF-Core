namespace Data_Access_EF_Core.Entities
{
    public class AccountProject : EntityBase
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public bool IsOwner { get; set; }
        public bool IsAccepted { get; set; }
    }
}
