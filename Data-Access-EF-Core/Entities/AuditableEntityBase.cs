using Model.DotNetCore.Entities;
using System;

namespace Data_Access_EF_Core.Entities
{
    public class AuditableEntityBase : EntityBase, IAuditableEntityBase
    {
        public DateTime CreatedOnUTC { get; set; }

        public int CreatedById { get; set; }
        public IAccount CreatedBy { get; set; }

        public bool ModifiedFlag { get; set; }
        public DateTime? LastModifiedOnUTC { get; set; }

        public int? LastModifiedById { get; set; }
        public IAccount LastModifiedBy { get; set; }

        public bool? ArchivedFlag { get; set; }
        public DateTime? ArchivedOnUTC { get; set; }

        public int? ArchivedById { get; set; }
        public IAccount ArchivedBy { get; set; }

        public bool? DeletedFlag { get; set; }
        public DateTime? DeletedOnUTC { get; set; }

        public int? DeletedById { get; set; }
        public IAccount DeletedBy { get; set; }

        public bool? InactiveFlag { get; set; }
        public DateTime? InactiveOnUTC { get; set; }

        public int? InactiveById { get; set; }
        public IAccount InactiveBy { get; set; }
    }
}
