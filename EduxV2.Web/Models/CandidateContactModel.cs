using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduxV2.Web.Models
{
    public class CandidateContactModel
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Staff { get; set; }
        public string NextStep { get; set; }
        public int ActivityCount { get; set; }
        public DateTime? LastActivityDate { get; set; }
    }
}
