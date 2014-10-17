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
        alert(messageID);
    //    $.ajax({
    //        type: "POST",
    //        url: "webservice/wspersonal.asmx",
    //        data: { flag: '' },
    //        success: function () {
               
    //        }
    //    });
    });

    $(".Delete").click(function () {
        var blogID = $(this).attr("blogID");
        alert(blogID);
    });

    $(".jinyan").click(function () {
        var userID = $(this).attr("userID");
        alert(userID);
    });
});