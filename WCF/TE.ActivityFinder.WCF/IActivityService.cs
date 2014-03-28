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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IActivityService
    {

        [OperationContract]
        [WebGet(ResponseFormat=WebMessageFormat.Json)]
        List<act_GetActivitiesResult> act_GetActivities();

    }
}
