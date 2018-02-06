using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EduxV2.Data
{
    public class Activity : BaseEntity
    {
        public string StaffId { get; set; }
        [ForeignKey("StaffId")]
        public Contact Staff { get; set; }
        public DateTime ActivityDate { get; set; }
        [StringLength(200)]
        public string OldSchool { get; set; }
        public string SchoolTypeId { get; set; }
        [ForeignKey("SchoolTypeId")]
        public SchoolType SchoolType { get; set; }
        public string CampusId { get; set; }
        [ForeignKey("CampusId")]
        public Campus Campus { get; set; }
        public string ClassLevelId { get; set; }
        [ForeignKey("ClassLevelId")]
        public ClassLevel ClassLevel { get; set; }
        public string ActivityTypeId { get; set; }
        [ForeignKey("ActivityTypeId")]
        public ActivityType ActivityType { get; set; }
        public string ActivitySourceId { get; set; }
        [ForeignKey("ActivitySourceId")]
        public ActivitySource ActivitySource { get; set; }

        public string ActivityStatusId { get; set; }
        [ForeignKey("ActivityStatusId")]
        public ActivityStatus ActivityStatus { get; set; }
        public string PositivenessId { get; set; }
        [ForeignKey("PositivenessId")]
        public Positiveness Positiveness { get; set; }
        public string ActivityNextStepId { get; set; }
        [ForeignKey("ActivityNextStepId")]
        public ActivityNextStep ActivityNextStep { get; set; }
        public DateTime? AppointmentDate { get; set; }

    }
}
    
