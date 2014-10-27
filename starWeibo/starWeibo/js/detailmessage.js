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
                url: "webservice/wsdetailmessage.asmx/dtmessage",
                data: "{receiveId:" + msgid + ",content:'"+value+"'}",
                dataType: 'json',
                success: function (res) {
                    $(".dmsgtextarea").val("");
                    chatmsg("10秒钟前", 1, value);
                },
                error: function () {
                    alert("fail");
                }
            });
        }
    });
}

function chatmsg(time,headimg,content) {
    var html = '';
    html += '                                        <div class="S_line2 msg_time_line">';
    html += '                                            <div class="time_tit">' + time + '</div>';
    html += '                                        </div>';
    html += '                                        <div class="msg_dialogue_list msg_dialist_l clearfix ">';
    html += '                                            <div class="msg_dialist_box clearfix">';
    html += '                                                <div class="msg_dialist_pic">';
    html += '                                                    <a class="dialist_pic_box">';
    html += '                                                        <img src="' + headimg + '" alt="" height="50" width="50"/>';
    html += '                                                    </a>';
    html += '                                                </div>';
    html += '                                                <div class="msg_dialist_content S_line2 S_bg5">';
    html += '                                                    <div class="msg_arrow"></div>';
    html += '                                                    <div class="msg_dialist_main">';
    html += '                                                        <div class="msg_diamain_box">';
    html += '                                                            <p class="msg_dia_txt">' + content + '</p>';
    html += '                                                        </div>';
    html += '                                                    </div>';
    html += '                                                    <div class="msg_ctrl hover"></div>';
    html += '                                                </div>';
    html += '                                            </div>';
    html += '                                        </div>';
    $(".msg_dialogue").prepend(html);
}