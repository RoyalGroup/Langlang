﻿$(function () {
    //alert("dws");
    $(".nicheng").click(function () {
        $(".ts1").show();
        $(".ts2").hide();
        $(".ts3").hide();
        $(".ts4").hide();
        $(".ts5").hide();
        return false;
    });
    $(".ts1").click(function () {
        return false;
    });
    $(document).click(function () {
        $(".ts1").hide();
    });
    $(".youxiang").click(function () {
        $(".ts2").show();
        $(".ts1").hide();
        $(".ts3").hide();
        $(".ts4").hide();
        $(".ts5").hide();
        return false;
    });
    $(".ts2").click(function () {
        return false;
    });
    $(document).click(function () {
        $(".ts2").hide();
    });
    $(".mima").click(function () {
        $(".ts3").show();
        $(".ts2").hide();
        $(".ts1").hide();
        $(".ts4").hide();
        $(".ts5").hide();
        return false;
    });
    $(".ts3").click(function () {
        return false;
    });
    $(document).click(function () {
        $(".ts3").hide();
    });
    $(".queren").click(function () {
        $(".ts4").show();
        $(".ts2").hide();
        $(".ts3").hide();
        $(".ts1").hide();
        $(".ts5").hide();
        return false;
    });
    $(".ts4").click(function () {
        return false;
    });
    $(document).click(function () {
        $(".ts4").hide();
    });
    $(".yanzhengma").click(function () {
        $(".ts5").show();
        $(".ts2").hide();
        $(".ts3").hide();
        $(".ts4").hide();
        $(".ts1").hide();
        return false;
    });
    $(".ts5").click(function () {
        return false;
    });
    $(document).click(function () {
        $(".ts5").hide();
    });
    $(".finishzhuce").click(function () {
        var nicheng = $(".nicheng").val();
        var youxiang = $(".youxiang").val();
        var mima = $(".mima").val();
        var queren = $(".queren").val();
        if (mima == queren) {
            $.ajax({
                type: "POST",   //访问WebService使用Post方式请求
                contentType: "application/json", //WebService 会返回Json类型
                url: "webservice/wsregister.asmx/shenqing", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                data: "{userName:'" + nicheng + "',userMail:'" + youxiang + "',userPwd:'" + mima + "'}",         //这里是要传递的参数，格式为 data: "{paraName:'paraValue'}",下面将会看到       
                dataType: 'json',
                success: function (result) {
                    //回调函数，result，返回值
                    if (result.d == 'true') {
                        alert("注册成功！");
                    }
                }
            });
        }
        else {
            alert("请重新确认密码");
        }


    });
    $(".youxiang").click(function () {
        var b = $(this).attr("a")
        if (b == 1) {
            $(".yincang").css("display", "block");
            $(this).attr("a", "0");
        }
        else {
            $(".yincang").css("display", "none");
            $(this).attr("a", "1");
        }
    });
});