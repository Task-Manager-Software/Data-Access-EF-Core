using Model.DotNetCore.Entities;

namespace Data_Access_EF_Core.Entities
{
    public class EntityBase : IEntityBase
    {
        public int Id { get; set; }
    }
}
