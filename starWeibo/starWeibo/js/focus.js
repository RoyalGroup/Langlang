$(function () {
    //关注
    $(".Fotitle").click(function () {
        $(".FocusArea").show();
        $(".FansArea").hide();
        $(".FocusCard").show();
    });
    // 分组
    $(".GroupCard").attr("isclick", "no");
    $(".FCardGroup").click(function () {
        if ($(this).parent().find(".GroupCard").attr("isclick") == "no") {
            $(".GroupCard").hide();
            $(".GroupCard").attr("isclick", "no");
            $($(this).parent().find(".GroupCard")).show();
            $($(this).parent().find(".GroupCard")).attr("isclick", "yes");
        }
        else {
            $($(this).parent().find(".GroupCard")).hide();
            $($(this).parent().find(".GroupCard")).attr("isclick", "no");
        }
    });

    $(".GroupCheck").attr("ischeck", "false");
    $(".GroupCheck").click(function () {
        $(".GroupCheck").prop("checked", false);
        if ($(this).attr("ischeck") == "false") {
            $(".GroupCheck").attr("ischeck", "false");
            $(this).attr("ischeck", "true");
            $(this).prop("checked", true);
        }
        else {
            $(this).attr("ischeck", "false");
            $(this).prop("checked", false);
        }
    });
    //分组
    $(".BtnSureGroupIn").click(function () {
        $(this).parent().parent().hide();
        $(this).parent().parent().attr("isclick", "no");
        var addfgroup = null;
        addfgroup = $(this).parent().parent().find(".GroupCardM").find(".GroupCardMLi").find(".GroupCheck[ischeck='true']").parent().find(".GroupName").html();
        var friendId = $(this).parent().parent().parent().parent().parent().attr("friendId");
        var newgroupId = $(this).parent().parent().find(".GroupCardM").find(".GroupCardMLi").find(".GroupCheck[ischeck='true']").attr("groupid");
        if (addfgroup != null) {
            $.ajax({
                url: "webservice/wsfocus.asmx/getgroupId",
                type: "POST",
                contentType:"application/json",
                dataType:'json',
                data: "{ friendid:'" + friendId + "',newgroupId:'" + newgroupId + "'}",
                success: function (res) {
                    if (res.d == true)
                    {
                        location.reload();
                    }
                    
                }
            });
        }
    });
    //创建新分组
    $(".GroupCardB").click(function () {
        //alert("1");
    });
    //设置备注
    $(".SetNote").click(function () {
        $(".SetNoteMeng").show();
        var friendId = $(this).parent().parent().parent().attr("friendid");
        $(".SetNoteCardBtn1").click(function () {
            $(".SetNoteMeng").hide();
            var friendNoteName = $("*").find(".SetNoteCardMidR").val();
            $.ajax({
                type: "POST",   //访问WebService使用Post方式请求
                contentType: "application/json", //WebService 会返回Json类型
                url: "webservice/wsfocus.asmx/ChangeNoteName", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                data: "{friendId:" + friendId + ",friendNoteName:'" + friendNoteName + "'}",
                dataType: 'json',
                success: function (result) {     //回调函数，result，返回值
                    if (result.d == true) {
                        //alert("修改成功！");
                    }
                }
            });
        });
    });
    //$(".SetNoteCardBtn1").click(function () {
    //    $(".SetNoteMeng").hide();
    //    var friendNoteName = $("*").find(".SetNoteCardMidR").val();
    //    alert(friendNoteName);
    //});
    $(".SetNoteCardBtn2").click(function () {
        $(".SetNoteMeng").hide();
    });
    $(".SetNoteCardMidR").focus(function () {
        $(this).val("");
        $(this).css("color", "#222");
    });
    $(".SetNoteCardMidR").blur(function () {
        //$(this).val("请输入备注名");
        $(this).css("color", "#ccc");
    });
    //取消关注
    $(".CancelFocus").click(function () {
        $(".CancelFocusMeng").show();
        var friendId = $(this).parent().parent().parent().attr("friendid");
        var name = $(this).parent().parent().parent().attr("name");
        $("*").find(".CancelFocusCardMid").val("确定取消对"+name+"的关注？");
        $(".CancelFocusCardBtn1").click(function () {
            $(".CancelFocusMeng").hide();
            $.ajax({
                type: "POST",   //访问WebService使用Post方式请求
                contentType: "application/json", //WebService 会返回Json类型
                url: "webservice/wsfocus.asmx/quxiaoguanzhu", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                data: "{friendId:" + friendId + "}",
                dataType: 'json',
                success: function (result) {     //回调函数，result，返回值
                    if (result.d == true) {
                        location.reload();
                    }
                }
            });
        });
    });
    //$(".CancelFocusCardBtn1").click(function () {
    //    $(".CancelFocusMeng").hide();
    //});
    $(".CancelFocusCardBtn2").click(function () {
        $(".CancelFocusMeng").hide();
    });
    //粉丝
    $(".Fanstitle").click(function () {
        $(".FocusArea").hide();
        $(".FansArea").show();
    });
    
    $(".EnsDeleFansBotBtn2").click(function () {
        $(this).parent().parent().hide();
    });
    
    $(".FocusLi").click(function(){
        var groupname = $(this).attr("groupname");
        $(".FocusCard").show();
        $(".FocusCard[fcardname!=" + groupname + "]").hide();

    });

    $(".FocusIn").click(function () {
        $(".FocusArea").show();
        $(".FansArea").hide();
    });

    $(".FoAll").click(function () {
        $(".FocusArea").show();
        $(".FansArea").hide();
        $(".FocusCard").show();
    });

    $(".leftbtn").click(function () {
        $(".leftbtn").css("box-shadow", "");
        $(this).css("box-shadow", "1px 2px 2px 1px #ccc");
        $(".leftbtn").css("color", "");
        $(this).css("color","#000");
    });

    //关注
    $(".BtnFocusFans").click(function () {
        var friendId = $(this).attr("userId");
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
    });

    //移除粉丝
    $(".DeleFans").click(function () {
        $(this).parent().find(".EnsureDeleFans").show();
        var friendId = $(this).attr("userId");
        $(".EnsDeleFansBotBtn1").click(function () {
            $(this).parent().parent().parent().parent().parent().parent().parent().parent().remove();
            $(this).parent().parent().hide();
            $.ajax({
                type: "POST",   //访问WebService使用Post方式请求
                contentType: "application/json", //WebService 会返回Json类型
                url: "webservice/wsfocus.asmx/yichufensi", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                data: "{friendId:" + friendId + "}",
                dataType: 'json',
                success: function (result) {     //回调函数，result，返回值
                    if (result.d == true) {
                        //alert("移除成功！");
                    }
                }
            });
        });
    });
});
