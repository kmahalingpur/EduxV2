using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduxV2.Data;
using EduxV2.Service;
using EduxV2.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduxV2.Web.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly IContactService contactService;
        public ContactsController(IContactService contactService)
        {
            this.contactService = contactService;
        }
        // GET api/values
        [HttpGet]
        public ContactsDataTableModel Get()
        {
            var model = new ContactsDataTableModel();
            var contacts = contactService.GetCandidateContacts();
            var contactmodels = new HashSet<CandidateContactModel>();
            foreach (var contact in contacts)
            {
                var candidate = new CandidateContactModel();
                candidate.Id = contact.Id;
                candidate.FullName = contact.FullName;
                candidate.ActivityCount = contact.Activities.Count();
                var lastActivity = contact.Activities.OrderByDescending(o => o.ActivityDate).FirstOrDefault();
                if (lastActivity!= null)
                {
                    candidate.Staff = lastActivity.Staff.FullName;
                    candidate.LastActivityDate = lastActivity.ActivityDate;
                    candidate.NextStep = lastActivity.ActivityNextStep.Name;
                }
                contactmodels.Add(candidate);
            }
            model.Meta.Total = model.Data.Count();
            model.Meta.Field = "fullName";
            model.Data = contactmodels;
            return model;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
