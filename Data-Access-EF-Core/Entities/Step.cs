using Model.DotNetCore.Entities;

namespace Data_Access_EF_Core.Entities
{
    public class Step : AuditableEntityBase, IStep
    {
        public int TaskId { get; set; }
        public ITask Task { get; set; }

        public string Title { get; set; }
    }
}
