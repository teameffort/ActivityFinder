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
function get_Context(){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/get_Context";
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "get_Context";
	CallService();
}
function add_Disposed(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_Disposed/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_Disposed";
	CallService();
}
function remove_Disposed(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_Disposed/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_Disposed";
	CallService();
}
function get_Request(){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/get_Request";
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "get_Request";
	CallService();
}
function get_Response(){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/get_Response";
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "get_Response";
	CallService();
}
function get_Session(){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/get_Session";
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "get_Session";
	CallService();
}
function get_Application(){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/get_Application";
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "get_Application";
	CallService();
}
function get_Server(){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/get_Server";
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "get_Server";
	CallService();
}
function get_User(){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/get_User";
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "get_User";
	CallService();
}
function get_Modules(){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/get_Modules";
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "get_Modules";
	CallService();
}
function CompleteRequest(){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/CompleteRequest";
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "CompleteRequest";
	CallService();
}
function add_BeginRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_BeginRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_BeginRequest";
	CallService();
}
function remove_BeginRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_BeginRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_BeginRequest";
	CallService();
}
function add_AuthenticateRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_AuthenticateRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_AuthenticateRequest";
	CallService();
}
function remove_AuthenticateRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_AuthenticateRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_AuthenticateRequest";
	CallService();
}
function add_PostAuthenticateRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_PostAuthenticateRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_PostAuthenticateRequest";
	CallService();
}
function remove_PostAuthenticateRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_PostAuthenticateRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_PostAuthenticateRequest";
	CallService();
}
function add_AuthorizeRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_AuthorizeRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_AuthorizeRequest";
	CallService();
}
function remove_AuthorizeRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_AuthorizeRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_AuthorizeRequest";
	CallService();
}
function add_PostAuthorizeRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_PostAuthorizeRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_PostAuthorizeRequest";
	CallService();
}
function remove_PostAuthorizeRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_PostAuthorizeRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_PostAuthorizeRequest";
	CallService();
}
function add_ResolveRequestCache(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_ResolveRequestCache/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_ResolveRequestCache";
	CallService();
}
function remove_ResolveRequestCache(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_ResolveRequestCache/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_ResolveRequestCache";
	CallService();
}
function add_PostResolveRequestCache(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_PostResolveRequestCache/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_PostResolveRequestCache";
	CallService();
}
function remove_PostResolveRequestCache(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_PostResolveRequestCache/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_PostResolveRequestCache";
	CallService();
}
function add_MapRequestHandler(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_MapRequestHandler/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_MapRequestHandler";
	CallService();
}
function remove_MapRequestHandler(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_MapRequestHandler/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_MapRequestHandler";
	CallService();
}
function add_PostMapRequestHandler(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_PostMapRequestHandler/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_PostMapRequestHandler";
	CallService();
}
function remove_PostMapRequestHandler(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_PostMapRequestHandler/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_PostMapRequestHandler";
	CallService();
}
function add_AcquireRequestState(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_AcquireRequestState/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_AcquireRequestState";
	CallService();
}
function remove_AcquireRequestState(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_AcquireRequestState/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_AcquireRequestState";
	CallService();
}
function add_PostAcquireRequestState(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_PostAcquireRequestState/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_PostAcquireRequestState";
	CallService();
}
function remove_PostAcquireRequestState(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_PostAcquireRequestState/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_PostAcquireRequestState";
	CallService();
}
function add_PreRequestHandlerExecute(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_PreRequestHandlerExecute/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_PreRequestHandlerExecute";
	CallService();
}
function remove_PreRequestHandlerExecute(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_PreRequestHandlerExecute/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_PreRequestHandlerExecute";
	CallService();
}
function add_PostRequestHandlerExecute(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_PostRequestHandlerExecute/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_PostRequestHandlerExecute";
	CallService();
}
function remove_PostRequestHandlerExecute(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_PostRequestHandlerExecute/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_PostRequestHandlerExecute";
	CallService();
}
function add_ReleaseRequestState(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_ReleaseRequestState/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_ReleaseRequestState";
	CallService();
}
function remove_ReleaseRequestState(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_ReleaseRequestState/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_ReleaseRequestState";
	CallService();
}
function add_PostReleaseRequestState(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_PostReleaseRequestState/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_PostReleaseRequestState";
	CallService();
}
function remove_PostReleaseRequestState(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_PostReleaseRequestState/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_PostReleaseRequestState";
	CallService();
}
function add_UpdateRequestCache(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_UpdateRequestCache/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_UpdateRequestCache";
	CallService();
}
function remove_UpdateRequestCache(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_UpdateRequestCache/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_UpdateRequestCache";
	CallService();
}
function add_PostUpdateRequestCache(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_PostUpdateRequestCache/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_PostUpdateRequestCache";
	CallService();
}
function remove_PostUpdateRequestCache(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_PostUpdateRequestCache/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_PostUpdateRequestCache";
	CallService();
}
function add_LogRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_LogRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_LogRequest";
	CallService();
}
function remove_LogRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_LogRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_LogRequest";
	CallService();
}
function add_PostLogRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_PostLogRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_PostLogRequest";
	CallService();
}
function remove_PostLogRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_PostLogRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_PostLogRequest";
	CallService();
}
function add_EndRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_EndRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_EndRequest";
	CallService();
}
function remove_EndRequest(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_EndRequest/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_EndRequest";
	CallService();
}
function add_Error(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_Error/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_Error";
	CallService();
}
function remove_Error(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_Error/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_Error";
	CallService();
}
function add_RequestCompleted(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_RequestCompleted/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_RequestCompleted";
	CallService();
}
function remove_RequestCompleted(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_RequestCompleted/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_RequestCompleted";
	CallService();
}
function add_PreSendRequestHeaders(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_PreSendRequestHeaders/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_PreSendRequestHeaders";
	CallService();
}
function remove_PreSendRequestHeaders(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_PreSendRequestHeaders/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_PreSendRequestHeaders";
	CallService();
}
function add_PreSendRequestContent(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/add_PreSendRequestContent/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "add_PreSendRequestContent";
	CallService();
}
function remove_PreSendRequestContent(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/remove_PreSendRequestContent/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "remove_PreSendRequestContent";
	CallService();
}
function AddOnBeginRequestAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnBeginRequestAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnBeginRequestAsync";
	CallService();
}
function AddOnBeginRequestAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnBeginRequestAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnBeginRequestAsync";
	CallService();
}
function AddOnAuthenticateRequestAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnAuthenticateRequestAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnAuthenticateRequestAsync";
	CallService();
}
function AddOnAuthenticateRequestAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnAuthenticateRequestAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnAuthenticateRequestAsync";
	CallService();
}
function AddOnPostAuthenticateRequestAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostAuthenticateRequestAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostAuthenticateRequestAsync";
	CallService();
}
function AddOnPostAuthenticateRequestAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostAuthenticateRequestAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostAuthenticateRequestAsync";
	CallService();
}
function AddOnAuthorizeRequestAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnAuthorizeRequestAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnAuthorizeRequestAsync";
	CallService();
}
function AddOnAuthorizeRequestAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnAuthorizeRequestAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnAuthorizeRequestAsync";
	CallService();
}
function AddOnPostAuthorizeRequestAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostAuthorizeRequestAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostAuthorizeRequestAsync";
	CallService();
}
function AddOnPostAuthorizeRequestAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostAuthorizeRequestAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostAuthorizeRequestAsync";
	CallService();
}
function AddOnResolveRequestCacheAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnResolveRequestCacheAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnResolveRequestCacheAsync";
	CallService();
}
function AddOnResolveRequestCacheAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnResolveRequestCacheAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnResolveRequestCacheAsync";
	CallService();
}
function AddOnPostResolveRequestCacheAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostResolveRequestCacheAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostResolveRequestCacheAsync";
	CallService();
}
function AddOnPostResolveRequestCacheAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostResolveRequestCacheAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostResolveRequestCacheAsync";
	CallService();
}
function AddOnMapRequestHandlerAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnMapRequestHandlerAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnMapRequestHandlerAsync";
	CallService();
}
function AddOnMapRequestHandlerAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnMapRequestHandlerAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnMapRequestHandlerAsync";
	CallService();
}
function AddOnPostMapRequestHandlerAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostMapRequestHandlerAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostMapRequestHandlerAsync";
	CallService();
}
function AddOnPostMapRequestHandlerAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostMapRequestHandlerAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostMapRequestHandlerAsync";
	CallService();
}
function AddOnAcquireRequestStateAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnAcquireRequestStateAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnAcquireRequestStateAsync";
	CallService();
}
function AddOnAcquireRequestStateAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnAcquireRequestStateAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnAcquireRequestStateAsync";
	CallService();
}
function AddOnPostAcquireRequestStateAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostAcquireRequestStateAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostAcquireRequestStateAsync";
	CallService();
}
function AddOnPostAcquireRequestStateAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostAcquireRequestStateAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostAcquireRequestStateAsync";
	CallService();
}
function AddOnPreRequestHandlerExecuteAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPreRequestHandlerExecuteAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPreRequestHandlerExecuteAsync";
	CallService();
}
function AddOnPreRequestHandlerExecuteAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPreRequestHandlerExecuteAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPreRequestHandlerExecuteAsync";
	CallService();
}
function AddOnPostRequestHandlerExecuteAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostRequestHandlerExecuteAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostRequestHandlerExecuteAsync";
	CallService();
}
function AddOnPostRequestHandlerExecuteAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostRequestHandlerExecuteAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostRequestHandlerExecuteAsync";
	CallService();
}
function AddOnReleaseRequestStateAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnReleaseRequestStateAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnReleaseRequestStateAsync";
	CallService();
}
function AddOnReleaseRequestStateAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnReleaseRequestStateAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnReleaseRequestStateAsync";
	CallService();
}
function AddOnPostReleaseRequestStateAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostReleaseRequestStateAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostReleaseRequestStateAsync";
	CallService();
}
function AddOnPostReleaseRequestStateAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostReleaseRequestStateAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostReleaseRequestStateAsync";
	CallService();
}
function AddOnUpdateRequestCacheAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnUpdateRequestCacheAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnUpdateRequestCacheAsync";
	CallService();
}
function AddOnUpdateRequestCacheAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnUpdateRequestCacheAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnUpdateRequestCacheAsync";
	CallService();
}
function AddOnPostUpdateRequestCacheAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostUpdateRequestCacheAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostUpdateRequestCacheAsync";
	CallService();
}
function AddOnPostUpdateRequestCacheAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostUpdateRequestCacheAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostUpdateRequestCacheAsync";
	CallService();
}
function AddOnLogRequestAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnLogRequestAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnLogRequestAsync";
	CallService();
}
function AddOnLogRequestAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnLogRequestAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnLogRequestAsync";
	CallService();
}
function AddOnPostLogRequestAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostLogRequestAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostLogRequestAsync";
	CallService();
}
function AddOnPostLogRequestAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnPostLogRequestAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnPostLogRequestAsync";
	CallService();
}
function AddOnEndRequestAsync(bh,eh){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnEndRequestAsync/"+bh+"/"+eh;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnEndRequestAsync";
	CallService();
}
function AddOnEndRequestAsync(beginHandler,endHandler,state){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/AddOnEndRequestAsync/"+beginHandler+"/"+endHandler+"/"+state;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "AddOnEndRequestAsync";
	CallService();
}
function Init(){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/Init";
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "Init";
	CallService();
}
function Dispose(){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/Dispose";
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "Dispose";
	CallService();
}
function GetVaryByCustomString(context,custom){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/GetVaryByCustomString/"+context+"/"+custom;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "GetVaryByCustomString";
	CallService();
}
function GetOutputCacheProviderName(context){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/GetOutputCacheProviderName/"+context;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "GetOutputCacheProviderName";
	CallService();
}
function get_Site(){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/get_Site";
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "get_Site";
	CallService();
}
function set_Site(value){
	
	Url = "http://10.211.55.3/TE.ActivityFinder.WCF/Global.svc/set_Site/"+value;
	ContentType = "application/json; charset=utf-8";
	DataType = "json";
	ProcessData = false;
	method = "set_Site";
	CallService();
}
