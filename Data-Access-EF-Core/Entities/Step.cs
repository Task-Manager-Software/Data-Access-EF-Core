namespace Data_Access_EF_Core.Entities
{
    public class Step : EntityBase
    {
        public int TaskId { get; set; }
        public Task Task { get; set; }

        public string Title { get; set; }
    }
}
