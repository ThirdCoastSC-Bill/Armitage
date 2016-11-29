
function clearform() {
    $('#asynctagform').each(function () {
        this.reset();
        showform();
    })
    

}

function hideform() {
    $("#addtag").hide();
}

function showform() {
    $("#addtag").show();
}

$("h2").click(function () {
    $(this).next().toggle();
})