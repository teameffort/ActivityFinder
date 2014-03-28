function GetActivities() {
    Type = "GET";
    Url = "http://10.211.55.3/TE.ActivityFinder.WCF/ActivityService.svc/act_GetActivities";
    ContentType = "application/json; charset=utf-8";
    DataType = "json";
    ProcessData = false;
    method = "act_GetActivities";
    CallService();
}