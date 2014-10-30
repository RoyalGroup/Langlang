$(function () {
    send();
    setInterval("poll()", 3000);
})

//发私信（数据库）
function send() {
    $(".btnsend").click(function () {
        var value = $(".dmsgtextarea").val();
        var headimg = $("#info").attr("headimg");
        if (value != null && value != "") {
            var msgid = $(".msgname").attr("msgid");
            $.ajax({
                type: "POST",
                contentType: "application/json",
                url: "webservice/wsdetailmessage.asmx/dtmessage",
                data: "{receiveId:" + msgid + ",content:'" + value + "'}",
                dataType: 'json',
                success: function (res) {
                    $(".dmsgtextarea").val("");
                    chatmsg("l", "10秒钟前", headimg, value);
                },
                error: function () {
                    alert("fail");
                }
            });
        }
    });
}

//发私信（前台）
function chatmsg(who, time, headimg, content) {
    if (time != "10秒钟前") {
        time = eval('new ' + (time.replace(/\//g, ''))).Format("yyyy-MM-dd hh:mm:ss");
    }
    var html = '';
    html += '                                        <div class="S_line2 msg_time_line">';
    html += '                                            <div class="time_tit">' + time + '</div>';
    html += '                                        </div>';
    html += '                                        <div class="msg_dialogue_list msg_dialist_' + who + ' clearfix ">';
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

//轮询未读消息
function poll() {
    var sendid = $(".msgname").attr("msgid");
    $.ajax({
        type: "POST",
        contentType: "application/json",
        url: "webservice/wsdetailmessage.asmx/dtnoreadmessage",
        data: "{sendId:" + sendid + "}",
        dataType: 'json',
        success: function (res) {
            $(res.d).each(function () {
                //alert(this.bloguserName);
                chatmsg("r", this.pubTime, this.userHeadimage, this.msgContent);
            });
        },
        fail: function () { },
        complete: function () { }
    });
}


Date.prototype.Format = function (fmt) { //author: meizz 
    var o = {
        "M+": this.getMonth() + 1, //月份 
        "d+": this.getDate(), //日 
        "h+": this.getHours(), //小时 
        "m+": this.getMinutes(), //分 
        "s+": this.getSeconds(), //秒 
        "q+": Math.floor((this.getMonth() + 3) / 3), //季度 
        "S": this.getMilliseconds() //毫秒 
    };
    if (/(y+)/.test(fmt)) fmt = fmt.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    for (var k in o)
        if (new RegExp("(" + k + ")").test(fmt)) fmt = fmt.replace(RegExp.$1, (RegExp.$1.length == 1) ? (o[k]) : (("00" + o[k]).substr(("" + o[k]).length)));
    return fmt;
}