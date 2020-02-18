using Model.DotNetCore.Entities;

namespace Data_Access_EF_Core.Entities
{
    public class Attachment : AuditableEntityBase, IAttachment
    {
        public int TaskId { get; set; }
        public ITask Task { get; set; }

        public string FileName { get; set; }
    }
}
