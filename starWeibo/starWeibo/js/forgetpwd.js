$(function () {
    $(".pass-button-submit").click(function () {
        var a = $("#account").val();
        if (a != null) {
            $(".forgotse1").hide();
            $(".forgotse2").show();
            $(".mod-sub-list1").removeClass("list1-active");
            $(".mod-sub-list2").addClass("list2-active");
        }
        else {
            $(".tanchu1").fadeIn();
            $(".tanchu1").fadeOut();
        }
    });
   
    $(".pass-button-submit1").click(function () {
        var a = $("#account").val();
        var b = $("#account1").val();
        $.ajax({
            type: "POST",   //访问WebService使用Post方式请求
            contentType: "application/json", //WebService 会返回Json类型
            url: "webservice/forgetpwd.asmx/check", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
            data: "{userName:'" + a + "'}",         //这里是要传递的参数，格式为 data: "{paraName:'paraValue'}",下面将会看到       
            dataType: 'json',
            success: function (result) {
                //alert(result);
                //回调函数，result，返回值
                //alert(result.d);
                if (result.d != b) {
                    $(".tanchu1").fadeIn();
                    $(".tanchu1").fadeOut();
                }
                if(result.d == b)
                {
                    $(".forgotse2").hide();
                    $(".forgotse3").show();
                    $(".mod-sub-list2").removeClass("list2-active");
                    $(".mod-sub-list3").addClass("list3-active");
                }
            }
        });
    });
    $(".pass-button-submit2").click(function () {
        var a = $(".T1R").val();
        var b = $(".T2R").val();
        var c = $("#account").val();
        if (a == b) {
            $.ajax({
                type: "POST",   //访问WebService使用Post方式请求
                contentType: "application/json", //WebService 会返回Json类型
                url: "webservice/forgetpwd.asmx/chongzhi", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                data: "{userPwd:'" + a + "',userName:'"+c+"'}",         //这里是要传递的参数，格式为 data: "{paraName:'paraValue'}",下面将会看到       
                dataType: 'json',
                success: function (result) {
                    //alert(result);
                    //回调函数，result，返回值
                    if (result.d == true){
                        $(".tanchu").fadeIn();
                        $(".tanchu").fadeOut();
                        window.location.href = "login.aspx";             
                    }
                }
            });
        }
        else {
            $(".tanchu2").fadeIn();
            $(".tanchu2").fadeOut();
        }    
    });

});
//function checkmima (){
//    var a = new RegExp("^[0-9A-z_]{1,20}$");//密码为1到20位的数字或字母;
//    if (!f.test(control))
//        $(".tanchu3").fadeIn();
//        $(".tanchu3").fadeOut();
//}
