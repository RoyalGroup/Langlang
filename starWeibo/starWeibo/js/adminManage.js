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
            url: "webservice/wsadmin.asmx/hulueReport", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
            data: "{messageId:" + messageID + "}",
            dataType: 'json',
            success: function (result) {     //回调函数，result，返回值
                if (result.d == true) {
                    //alert("忽略成功！");
                }
            }
        });
    });

    $(".Delete").click(function () {
        var messageID = $(this).prev().attr("msgID");
        var blogID = $(this).attr("blogID");
        $(this).parent().parent().remove();
        $.ajax({
            type: "POST",   //访问WebService使用Post方式请求
            contentType: "application/json", //WebService 会返回Json类型
            url: "webservice/wsadmin.asmx/Delete", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
            data: "{blogId:" + blogID + ",messageId:" + messageID + "}",
            dataType: 'json',
            success: function (result) {     //回调函数，result，返回值
                if (result.d == true) {
                    //alert("删除成功！");
                }
            }
        });
    });

    $(".jinyan").click(function () {
        var messageID = $(this).prev().prev().attr("msgID");
        var userID = $(this).attr("userID");
        $(this).parent().parent().remove();
        $.ajax({
            type: "POST",   //访问WebService使用Post方式请求
            contentType: "application/json", //WebService 会返回Json类型
            url: "webservice/wsadmin.asmx/jinyan", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
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
            url: "webservice/wsadmin.asmx/SendSysMsg", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
            data: "{msgContent:'" + msgContent + "'}",
            dataType: 'json',
            success: function (result) {     //回调函数，result，返回值
                alert("发送成功！");
                //if (result.d == "true") {
                //    alert("发送成功！");
                //}
            }
        });
    });

    //用户权限管理
    $(".select").click(function () {
        var con = $(this).parent().parent().attr("id");
        var userID = con.substring(1);
        var id = $(this).attr("id");
        //var fuzhi = $(this).attr("fuzhi");
        //if (fuzhi == "0") {
        //    $(this).attr("fuzhi", "1");
        //} else {
        //    $(this).attr("fuzhi", "0");
        //}
        //fuzhi = $(this).attr("fuzhi");
        var fuzhi = ($(this).prop("checked") == false) ? 1 : 0;
        $.ajax({
            type: "POST",   //访问WebService使用Post方式请求
            contentType: "application/json", //WebService 会返回Json类型
            url: "webservice/wsadmin.asmx/quanxian", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
            data: "{userId:" + userID + ",type:'" + id + "',fuzhi:'" + fuzhi + "'}",
            dataType: 'json',
            success: function (result) {     //回调函数，result，返回值
                if (result.d == true) {
                    //alert("操作成功！");
                }
            }
        });
    });

    $(".quan").click(function () {
        //var userID = $(".selectOne:checked").parent().parent().attr("id");
        $(".selectOne:checked").parent().nextAll().find("input").prop("checked", true);
        
        var a = new Array();

        var checkBoxes = document.getElementsByName("selectO");
        for (var i = 1; i <=checkBoxes.length+1; i++) {
            if ($("#s" + i).find(".selectOne").prop("checked") == true)
            {
                a[i] = i;
            }
            
        };
        
        for (var i = 1; i <= checkBoxes.length+1; i++) {
            if (a[i] != null);
            {
                $.ajax({
                    type: "POST",   //访问WebService使用Post方式请求
                    contentType: "application/json", //WebService 会返回Json类型
                    url: "webservice/wsadmin.asmx/quan", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                    data: "{userId:" + a[i] + "}",
                    dataType: 'json',
                    success: function (result) {     //回调函数，result，返回值
                        if (result.d == true) {
                            //alert("操作成功！");
                        }
                    }
                });
            }
        };
        
    });
    $(".kquan").click(function () {
        //var userID = $(".selectOne:checked").parent().parent().attr("id");
        $(".selectOne:checked").parent().nextAll().find("input").prop("checked", false);
        var a = new Array();

        var checkBoxes = document.getElementsByName("selectO");
        for (var i = 1; i <= checkBoxes.length + 1; i++) {
            if ($("#s" + i).find(".selectOne").prop("checked") == true) {
                a[i] = i;
            }

        };

        for (var i = 1; i <= checkBoxes.length + 1; i++) {
            if (a[i] != null);
            {
                $.ajax({
                    type: "POST",   //访问WebService使用Post方式请求
                    contentType: "application/json", //WebService 会返回Json类型
                    url: "webservice/wsadmin.asmx/kquan", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                    data: "{userId:" + a[i] + "}",
                    dataType: 'json',
                    success: function (result) {     //回调函数，result，返回值
                        if (result.d == true) {
                            //alert("操作成功！");
                        }
                    }
                });
            }
        };
    });

    //quanxian
    $(".fa").click(function () {
        var type = $(this).attr("id");
        $(".selectOne:checked").parent().nextAll().find('input[id="' + type + '"]').prop("checked", true);

        var a = new Array();

        var checkBoxes = document.getElementsByName("selectO");
        for (var i = 1; i <= checkBoxes.length + 1; i++) {
            if ($("#s" + i).find(".selectOne").prop("checked") == true) {
                a[i] = i;
            }

        };

        for (var i = 1; i <= checkBoxes.length + 1; i++) {
            if (a[i] != null);
            {
                $.ajax({
                    type: "POST",   //访问WebService使用Post方式请求
                    contentType: "application/json", //WebService 会返回Json类型
                    url: "webservice/wsadmin.asmx/xuanze", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                    data: "{userId:" + a[i] + ",type:'"+ type +"'}",
                    dataType: 'json',
                    success: function (result) {     //回调函数，result，返回值
                        if (result.d == true) {
                            //alert("操作成功！");
                        }
                    }
                });
            }
        };
    });

    $(".jie").click(function () {
        var con = $(this).attr("id");
        var type = con.substring(1);
        $(".selectOne:checked").parent().nextAll().find('input[id="' + type + '"]').prop("checked", false);
        var a = new Array();

        var checkBoxes = document.getElementsByName("selectO");
        for (var i = 1; i <= checkBoxes.length + 1; i++) {
            if ($("#s" + i).find(".selectOne").prop("checked") == true) {
                a[i] = i;
            }

        };

        for (var i = 1; i <= checkBoxes.length + 1; i++) {
            if (a[i] != null);
            {
                $.ajax({
                    type: "POST",   //访问WebService使用Post方式请求
                    contentType: "application/json", //WebService 会返回Json类型
                    url: "webservice/wsadmin.asmx/xuanzek", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                    data: "{userId:" + a[i] + ",type:'" + type + "'}",
                    dataType: 'json',
                    success: function (result) {     //回调函数，result，返回值
                        if (result.d == true) {
                            alert("操作成功！");
                        }
                    }
                });
            }
        };
    });

    //搜索
    $(".buttonS").click(function () {
        $(".UserManagesContent").show();
        $(".UserManagesContentS").hide();
    });
    $(".button").click(function () {
        $(".UserManagesContentS").show();
        $(".UserManagesContent").hide();        
    });
});