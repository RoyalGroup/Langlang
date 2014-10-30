$(function () {
    $(".sendselfbtn").click(function () {
        $(".send_private_msgbox").toggle();
        $(".btnsendan").click(function () {
            //验证是否存在该用户
            var name = $(".selfname").val();
            var content = $(".dmsgtextarea").val();
            if (name != "" && content != "") {
                check(name, content);
            }

        });
    });
});

function check(name, content) {
    $.ajax({
        type: "POST",
        contentType: "application/json",
        url: "webservice/wsmessage.asmx/checkname",
        data: "{name:'" + name + "'}",
        dataType: 'json',
        success: function (res) {
            if (res.d == -1) {
                $(".selferror").fadeIn(500);
                $(".selferror").fadeOut(2000);
            }
            else {

                $.ajax({
                    type: "POST",
                    contentType: "application/json",
                    url: "webservice/wsdetailmessage.asmx/dtmessage",
                    data: "{receiveId:" + res.d + ",content:'" + content + "'}",
                    dataType: 'json',
                    success: function (res) {
                        $(".send_private_msgbox").hide();
                    },
                    error: function () {
                        //alert("fail");
                    }
                });
            }
        },
        error: function () {
            alert("fail");
        }
    });
}