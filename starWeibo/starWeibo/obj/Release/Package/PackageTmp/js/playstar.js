$(function () {
    $(".SetNote").click(function () {
        var friendId = $(this).attr("friendId");
        //$(this).parent().parent().parent().parent().remove();
        var guanzhu = $(this).attr("guanzhu");
        if (guanzhu == 1) {
            $(this).text("已关注");
            $.ajax({
                type: "POST",   //访问WebService使用Post方式请求
                contentType: "application/json", //WebService 会返回Json类型
                url: "webservice/wsfocus.asmx/guanzhu", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                data: "{friendId:" + friendId + "}",
                dataType: 'json',
                success: function (result) {     //回调函数，result，返回值
                    //alert(result.d);
                    if (result.d == -1) {
                        $(".Tanchu1").fadeIn(1000).fadeOut(1000);
                    }
                    else {
                        $(".Tanchu").fadeIn(1000).fadeOut(1000);
                    }
                }
            });
        } else {
            $(this).attr("guanzhu",1);
        }
        $(this).attr("guanzhu",0);
    });
});