var Type;
var Url;
var Data;
var ContentType;
var DataType;
var ProcessData;
var method;
//Generic function to call WCF  Service

function CallService() {
    $.ajax({
        type: Type, //GET or POST or PUT or DELETE verb
        url: Url, // Location of the service
        data: Data, //Data sent to server
        contentType: ContentType, // content type sent to server
        dataType: DataType, //Expected data format from server
        processdata: ProcessData, //True or False
        success: function (msg) {//On Successfull service call
            ServiceSucceeded(msg);
        },
        error: ServiceFailed// When Service call fails
    });
}

function ServiceFailed(result) {
    alert('Service call failed: ' + result.status + '' + result.statusText);
    Type = null;
    Url = null;
    Data = null;
    ContentType = null;
    DataType = null;
    ProcessData = null;
}

function ServiceFailed(xhr) {
    if ($("#progressBar").length > 0) {
        $("#progressBar").attr("class", "progress-bar progress-bar-danger");
    }
    alert("<bold>Problem calling URL: " + Url + " </bold>" + xhr.responseText);

    //if (xhr.responseText) {
    //    var err = xhr.responseText;
    //    if (err)
    //        error(err);
    //    else
    //        error({ Message: "Unknown server error." })
    //}
    //return;
}
