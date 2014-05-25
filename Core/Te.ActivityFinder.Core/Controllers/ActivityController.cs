using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Te.ActivityFinder.Dal;

namespace Te.ActivityFinder.Core.Controllers
{
    public class ActivityController : ApiController
    {
        readonly ActivityDataContext context = new ActivityDataContext();

        // GET api/<controller>
        public List<Models.Activity> Get()
        {
            var activities = from a in context.Activities
                             select new Models.Activity
                             {
                                 ActivityId = a.ActivityId,
                                 ActivityCategoryId = a.ActivityCategoryId,
                                 ActivityTypeId = a.ActivityTypeId,
                                 LocationId = a.LocationId,
                                 Name = a.Name,
                                 StartDT = a.StartDT,
                                 EndDT = a.EndDT,
                                 IsActive = a.IsActive
                             };

            return activities.ToList();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}