$(function () {
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
    $(document).on("click", ".yanzheng", function () {
        var email = $(".youxiang").val();
        var d = new RegExp("^[\\w-]+(\\.[\\w-]+)*@[\\w-]+(\\.[\\w-]+)+$");
        if (!d.test(email)) {
            $(".tanchu5").fadeIn();
            $(".tanchu5").fadeOut();
        } else {
            $.ajax({
                type: "POST",   //访问WebService使用Post方式请求
                contentType: "application/json", //WebService 会返回Json类型
                url: "webservice/wsregister.asmx/Sendyanzheng", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                data: "{email:'" + email + "'}",         //这里是要传递的参数，格式为 data: "{paraName:'paraValue'}",下面将会看到       
                dataType: 'json',
                success: function (result) {
                    $(".yanzhengma").attr("yanzhengnum", result.d);
                    $(".tanchu").fadeIn();
                    $(".tanchu").fadeOut();
                }
            });
        }
    });

    $(".finishzhuce").click(function () {
        var d = new RegExp("^[\u4E00-\u9FA5A-Za-z0-9_]{2,16}$");//汉字可以为1-8位，字母或数字可以为2-16位;
        var e = new RegExp("^[\\w-]+(\\.[\\w-]+)*@[\\w-]+(\\.[\\w-]+)+$");//邮箱的正则表达式
        var f = new RegExp("^[0-9A-z_]{1,20}$"); //密码为1到20位的数字或字母;
        var nicheng = $(".nicheng").val();
        var youxiang = $(".youxiang").val();
        var mima = $(".mima").val();
        var queren = $(".queren").val();
        var yanzhengma = $(".yanzhengma").val();
        var yanzhengnum = $(".yanzhengma").attr("yanzhengnum");
        if (mima == queren && d.test(nicheng) && e.test(youxiang) && yanzhengma == yanzhengnum && f.test(mima)) {
            $.ajax({
                type: "POST",   //访问WebService使用Post方式请求
                contentType: "application/json", //WebService 会返回Json类型
                url: "webservice/wsregister.asmx/shenqing", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                data: "{userName:'" + nicheng + "',userMail:'" + youxiang + "',userPwd:'" + mima + "'}",         //这里是要传递的参数，格式为 data: "{paraName:'paraValue'}",下面将会看到       
                dataType: 'json',
                success: function (result) {
                    //回调函数，result，返回值
                    //alert(result.d);
                    if (result.d != null) {
                        $(".tanchu1").fadeIn();
                        $(".tanchu1").fadeOut();
                        window.location.href = "login.aspx";
                    }
                }
            });
        }
        else {
            $(".tanchu2").fadeIn();
            $(".tanchu2").fadeOut();
        }

        //权限插入
        $.ajax({
            type: "POST",   //访问WebService使用Post方式请求
            contentType: "application/json", //WebService 会返回Json类型
            url: "webservice/wsregister.asmx/charuP", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
            data: "{userName:'" + nicheng + "'}",         //这里是要传递的参数，格式为 data: "{paraName:'paraValue'}",下面将会看到       
            dataType: 'json',
            success: function (result) {
                
            }
        });
    });
 
});
function checkmail(control)
{
    var d=new RegExp("^[\\w-]+(\\.[\\w-]+)*@[\\w-]+(\\.[\\w-]+)+$");//邮箱的正则表达式;
    if(!d.test(control))
        $(".tanchu3").fadeIn();
        $(".tanchu3").fadeOut();
};

function checknicheng(control) {
    var d = new RegExp("^[\u4E00-\u9FA5A-Za-z0-9_]{2,16}$");//汉字可以为1-8位，字母或数字可以为2-16位;
    if (!d.test(control))
        $(".tanchu4").fadeIn();
        $(".tanchu4").fadeOut();
};


function checkmima() {
    var f = new RegExp("^[0-9A-z_]{1,20}$");//密码为1到20位的数字或字母;
    if (!f.test(control))
        $(".tanchu6").fadeIn();
        $(".tanchu6").fadeOut();
};