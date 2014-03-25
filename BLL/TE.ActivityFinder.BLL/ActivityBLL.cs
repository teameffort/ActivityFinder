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
        public List<act_GetActivitiesResult> act_GetActivities()
        {
            using (var context = new Context().Activity)
            {
                return context.act_GetActivities().ToList();               
            }
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
