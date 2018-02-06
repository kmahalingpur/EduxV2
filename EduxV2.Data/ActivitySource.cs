using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EduxV2.Data
{
    public class ActivitySource:BaseEntity
    {
        public string Name { get; set; }
        public string ParentActivitySourceId { get; set; }
        [ForeignKey("ParentActivitySourceId")]
        public ActivitySource ParentActivitySource { get; set; }
        public virtual ICollection<ActivitySource> ChildActivitySources { get; set; }
    }
}
