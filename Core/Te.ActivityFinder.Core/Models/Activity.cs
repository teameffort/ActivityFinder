using System;
using System.Linq;

namespace Te.ActivityFinder.Core.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public int ActivityTypeId { get; set; }
        public int ActivityCategoryId { get; set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public DateTime StartDT { get; set; }
        public DateTime EndDT { get; set; }
        public bool IsActive { get; set; }
    }
}