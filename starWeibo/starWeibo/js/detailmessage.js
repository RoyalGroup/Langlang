$(function () {
    send();
})


function send() {
    $(".btnsend").click(function () {
        var value = $(".dmsgtextarea").val();
        if (value!=null && value != "")
        {
            var msgid = $(".msgname").attr("msgid");
            $.ajax({
                type: "POST",
                contentType: "application/json",
                data: "{msgid:" + msgid + ",content:'" + value + "'}",
                dataType: 'json',
                url: "webservice/wsdetailmessage.asmx/dtmessage",
                success: function () {
                },
                fail:function(){
            }
            });
        }
    });
}