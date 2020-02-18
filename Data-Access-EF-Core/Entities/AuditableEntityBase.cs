using System;

namespace Data_Access_EF_Core.Entities
{
    public class AuditableEntityBase : EntityBase
    {
        public DateTime CreatedOnUTC { get; set; }

        public int CreatedById { get; set; }
        public Account CreatedBy { get; set; }

        public bool ModifiedFlag { get; set; }
        public DateTime? LastModifiedOnUTC { get; set; }

        public int? LastModifiedById { get; set; }
        public Account LastModifiedBy { get; set; }

        public bool? ArchivedFlag { get; set; }
        public DateTime? ArchivedOnUTC { get; set; }

        public int? ArchivedById { get; set; }
        public Account ArchivedBy { get; set; }

        public bool? DeletedFlag { get; set; }
        public DateTime? DeletedOnUTC { get; set; }

        public int? DeletedById { get; set; }
        public Account DeletedBy { get; set; }

        public bool? InactiveFlag { get; set; }
        public DateTime? InactiveOnUTC { get; set; }

        public int? InactiveById { get; set; }
        public Account InactiveBy { get; set; }
    }
}
