namespace Data_Access_EF_Core.Entities
{
    public class AccountTask : EntityBase
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }

        public int TaskId { get; set; }
        public Task Task { get; set; }

        public bool IsAccepted { get; set; }
    }
}
