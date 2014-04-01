using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TE.ActivityFinder.DAL;

namespace TE.ActivityFinder.BLL
{
    public class ActivityBLL
    {
        public List<act_Activity> act_GetActivities()
        {
            var context = new Context().Activity;
            var activities = from a in context.act_Activities
                             select a;
            return activities.ToList();
        }

        public act_Activity act_GetActivityById(int activityId)
        {

            var context = new Context().Activity;
            var activity = from a in context.act_Activities
                           where a.ActivityId == activityId
                           select a;

            return activity.FirstOrDefault();
        }

        public bool loc_InsertLocation(string Name, string Longitude, string Latitude)
        {
            using (var context = new Context().Activity)
            {
                int result;
                result = context.loc_InsLocation(Name, Longitude, Latitude);
                return result == 0 ? true : false;
            }
        }
    }
}
