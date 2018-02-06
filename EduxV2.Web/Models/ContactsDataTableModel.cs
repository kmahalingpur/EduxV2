using EduxV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduxV2.Web.Models
{
    public class ContactsDataTableModel
    {
        public ContactsDataTableModel()
        {
            Meta = new Meta();
            Data = new HashSet<CandidateContactModel>();
        }
        public Meta Meta { get; set; }
        public IEnumerable<CandidateContactModel> Data { get; set; }
    }
}
