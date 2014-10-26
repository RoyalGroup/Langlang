$(function () {
    send();
})


function send() {
    $(".btnsend").click(function () {
        var value = $(".dmsgtextarea").val();
        alert(value);
    });
}