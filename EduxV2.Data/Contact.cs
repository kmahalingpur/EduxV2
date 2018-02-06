using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EduxV2.Data
{
    public class Contact:BaseEntity
    {
        public Contact()
        {
            Activities = new HashSet<Activity>();
        }
        [StringLength(200)]
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        [StringLength(11)]
        public string IdentityNumber { get; set; }
        public ClassLevel ClassLevel { get; set; }
        public DateTime BirthDate { get; set; }
        public string MotherId { get; set; }
        [ForeignKey("MotherId")]
        public Contact Mother { get; set; }
        public string FatherId { get; set; }
        [ForeignKey("FatherId")]
        public Contact Father { get; set; }
        public string ParentId { get; set; }
        [ForeignKey("Parent")]
        public Contact Parent { get; set; }
        public string OccupationId { get; set; }
        public Occupation Occupation { get; set; }
        public ParentRole ParentRole { get; set; }
        public ContactType ContactType { get; set; }
        public ContactStatus ContactStatus { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
