var Type;
var Url;
var Data;
var ContentType;
var DataType;
var ProcessData;
//Generic function to call WCF  Service

function CallService() {
    $.ajax({
        type: Type, //GET or POST or PUT or DELETE verb
        url: Url, // Location of the service
        data: Data, //Data sent to server
        contentType: ContentType, // content type sent to server
        dataType: DataType, //Expected data format from server
        processdata: ProcessData, //True or False
        success: function (data) {//On Successfull service call
            ServiceSucceeded(data);
        },
        error: function (xhr, status, error) {
            ServiceFailed(xhr, status, error)
        }// When Service call fails
    });
}

function ServiceFailed(xhr, status, error) {
    if (status == "error") {
        console.log("Error: " + error);
        alert("Please check you're connected to the internet and that you can browse to: " + Url);
    }
    else {
        console.log("Error: " + error);
        alert("Please check you're connected to the internet and that you can browse to: " + Url);
    }
}
