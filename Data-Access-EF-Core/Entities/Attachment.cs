namespace Data_Access_EF_Core.Entities
{
    public class Attachment : EntityBase
    {
        public int TaskId { get; set; }
        public Task Task { get; set; }

        public string FileName { get; set; }
    }
}
