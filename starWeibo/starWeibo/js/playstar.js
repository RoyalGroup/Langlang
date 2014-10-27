$(function () {
    $(".SetNote").click(function () {
        var friendId = $(this).attr("friendId");
        $.ajax({
            type: "POST",   //访问WebService使用Post方式请求
            contentType: "application/json", //WebService 会返回Json类型
            url: "webservice/wsfocus.asmx/guanzhu", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
            data: "{friendId:" + friendId + "}",
            dataType: 'json',
            success: function (result) {     //回调函数，result，返回值
                //alert(result.d);
                if (result.d == -1) {
                    alert("您已关注");
                }
                else {
                    alert("关注成功");
                }
            }
        });
    });
});