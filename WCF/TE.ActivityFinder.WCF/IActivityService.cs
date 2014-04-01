using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TE.ActivityFinder.BLL;
using TE.ActivityFinder.DAL;
using TE.ActivityFinder.Lib.CodeGen.Common;

namespace TE.ActivityFinder.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IActivityService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "act_GetActivities")]
        List<act_Activity> act_GetActivities();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "act_GetActivityById/{ActivityId}")]
        act_Activity act_GetActivityById(string ActivityId);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "loc_InsertLocation/{Name}/{Longitude}/{Latitude}")]
        bool loc_InsertLocation(string Name, string Longitude, string Latitude);
    }
}
