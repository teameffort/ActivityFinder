function act_GetActivities(){
	Type = "GET";
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/ActivityService.svc/act_GetActivities";
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "act_GetActivities";
	CallService();
}
function act_GetActivityById(ActivityId){
	Type = "GET";
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/ActivityService.svc/act_GetActivityById/"+ActivityId;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "act_GetActivityById";
	CallService();
}
function loc_InsertLocation(Name,Longitude,Latitude){
	Type = "GET";
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/ActivityService.svc/loc_InsertLocation/"+Name+"/"+Longitude+"/"+Latitude;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "loc_InsertLocation";
	CallService();
}
