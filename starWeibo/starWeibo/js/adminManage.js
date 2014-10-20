$(function () {
    //基础模块控制
    $(".Report").click(function () {
        $(".Right1").show();
        $(".Right2").hide();
        $(".Right3").hide();
    });
    $(".UserManages").click(function () {
        $(".Right2").show();
        $(".Right1").hide();
        $(".Right3").hide();
    });
    $(".Send").click(function () {
        $(".Right3").show();
        $(".Right1").hide();
        $(".Right2").hide();
    });
    //读取用户权限
    $(".select[fuzhi='0']").prop("checked", true);


    //全选
    $(".selectAll").click(function () {
        if ($(".selectAll").prop("checked") == true) {
            $(".selectOne").prop("checked", true);
        } else {
            $(".selectOne").prop("checked", false);
        }
    });

    //举报管理
    $(".hulue").click(function () {
        var messageID = $(this).attr("msgID");
        $(this).parent().parent().remove();
        $.ajax({
            type: "POST",   //访问WebService使用Post方式请求
            contentType: "application/json", //WebService 会返回Json类型
            url: "webservice/adminWS.asmx/hulueReport", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
            data: "{messageId:" + messageID + "}",
            dataType: 'json',
            success: function (result) {     //回调函数，result，返回值
                if (result.d == true) {
                    alert("忽略成功！");
                }
            }
        });
    });

    $(".Delete").click(function () {
        var messageID = $(this).prev().prev().attr("msgID");
        var blogID = $(this).attr("blogID");
        $(this).parent().parent().remove();
        //$.ajax({
        //    type: "POST",   //访问WebService使用Post方式请求
        //    contentType: "application/json", //WebService 会返回Json类型
        //    url: "webservice/adminWS.asmx/Delete", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
        //    data: "{blogId:" + blogID + "}",
        //    dataType: 'json',
        //    success: function (result) {     //回调函数，result，返回值
        //        if (result.d == true) {
        //            alert("删除成功！");
        //        }
        //    }
        //});
    });

    $(".jinyan").click(function () {
        var messageID = $(this).prev().prev().attr("msgID");
        var userID = $(this).attr("userID");
        $(this).parent().parent().remove();
        $.ajax({
            type: "POST",   //访问WebService使用Post方式请求
            contentType: "application/json", //WebService 会返回Json类型
            url: "webservice/adminWS.asmx/jinyan", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
            data: "{userId:" + userID + ",messageId:" + messageID + "}",
            dataType: 'json',
            success: function (result) {     //回调函数，result，返回值
                if (result.d == true) {
                    alert("禁言成功！");
                }
            }
        });
    });

    //发送公告
    $(".SendButton").click(function () {
        var msgContent = $(this).prev().val();
        $(this).prev().val("");
        $.ajax({
            type: "POST",   //访问WebService使用Post方式请求
            contentType: "application/json", //WebService 会返回Json类型
            url: "webservice/adminWS.asmx/SendSysMsg", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
            data: "{msgContent:" + msgContent + "}",
            dataType: 'json',
            success: function (result) {     //回调函数，result，返回值
                if (result.d == "true") {
                    alert("发送成功！");
                }
            }
        });
    });
});