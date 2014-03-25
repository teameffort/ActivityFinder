using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TE.ActivityFinder.BLL;
using TE.ActivityFinder.DAL;

namespace TE.ActivityFinder.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ActivityService : IActivityService
    {
        public List<act_GetActivitiesResult> act_GetActivities()
        {
            return new ActivityBLL().act_GetActivities();
        }
    }
}
