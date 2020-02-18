using Model.DotNetCore.Entities;
using Model.DotNetCore.Enums;
using System;
using System.Collections.Generic;

namespace Data_Access_EF_Core.Entities
{
    public class Task : AuditableEntityBase, ITask
    {
        public int ProjectId { get; set; }
        public IProject Project { get; set; }

        public string Title { get; set; }
        public bool IsMyDay { get; set; }
        public bool IsImportant { get; set; }
        public DateTime? RemindDateUTC { get; set; }
        public DateTime? DueDateUTC { get; set; }
        public RepeatType RepeatType { get; set; }
        public byte? SelectedWeekDays { get; set; }
        public string Note { get; set; }

        public List<IAccountTask> AccountTasks { get; set; }
        public List<IStep> Steps { get; set; }
        public List<IAttachment> Attachments { get; set; }
    }
}
