
function clearform() {
    $('#asynctagform').each(function () {
        this.reset();
        showform();
    })
    

}

function clearform2() {
    $('#asynccategoryform').each(function () {
        this.reset();
        showform2();
    })


}


function hideform2() {
    $("#addcategory").hide();
}

function showform2() {
    $("#addcategory").show();
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


