function updateProgress(percentage) {
    if (percentage >= 100) {
        percentage = 100;
        $("#progressBar").attr("class", "progress-bar progress-bar-success");
    }
    if (percentage > 60 && percentage < 100) {
        console.log("Warning");
        $("#progressBar").attr("class", "progress-bar progress-bar-warning");
    }
    $("#progressBar").css("width", percentage + "%");
    $("#progressBar").html(percentage + "%");
}