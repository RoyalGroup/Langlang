$(function () {
    //发布微博
    $("#fabu").click(function () {
        var content = $("#fabu_input").val();
        var html = "";
        html += '<div class="wbfeedtype swfun line2">';
        html += '<div class="wbfeeddetail line2 clearfix">';
        html += '<div class="wbface">';
        html += '<a  class="wfaceradius">';
        html += '<img src="' + $("#info").attr("headimg") + '" />';
        html += '</a>';
        html += '</div>';
        html += '<div class="wbdetail">';
        html += '<div class="wbinfo">';
        html += '<a class="wbname func1">'+$("#info").attr("name")+'</a>';
        html += '<a >';
        html += '<i class="wico16 approveco"></i>';
        html += '</a>';
        html += '</div>';
        html += '<div class="wbtext">';
        html += content;
        html += '</div>';
        html += '<div class="wbfunc clearfix">';
        html += '<div class="wbhandle">';
        html += '<a class="zan" ifzan="0">';
        html += '<em class="wico20 iconpraised"></em>(<span>0</span>)';
        html += '</a>';
        html += '<i class="txt3">|</i>';
        html += '<a class="zf">转发</a>';
        html += '<i class="txt3">|</i>';
        html += '<a>收藏</a>';
        html += '<i class="txt3">|</i>';
        html += '<a class="pl" pindex="1" isopen="no" ifc="0">评论(0)</a>';
        html += '</div>';
        html += '<div class="wbfrom">';
        html += '<a  class="link2 wbtime">1分钟前</a>';
        html += '<em class="txt2">来自</em>';
        html += '<a  class="link2">weibo</a>';
        html += '<span class="hoverr">';
        html += '<em class="txt2">|</em>&nbsp;';
        html += '<a  class="jubao">举报</a>';
        html += '</span>';
        html += '</div>';
        html += '</div>';
        html += '<div class="dahuifu1"></div>';
        html += '<div class="contrans">';
        html += '<div class="contranstop">';
        html += '<span class="conttxt ">转发微博</span>';
        html += '<span class="contclose"></span>';
        html += '</div>';
        html += '<div class="contransbom">';
        html += '<div class="contmyan">';
        html += '<a href="" class="conttxt conttxtlink"></a>';
        html += '<span class="contgeyan"></span>';
        html += '</div>';
        html += '<div class="conttebox">';
        html += '<textarea class="contte"></textarea>';
        html += '</div>';
        html += '<div class="contbom">';
        html += '<div class="concwbrplbleft">';
        html += '<span class="concwbrplbbq"></span>';
        html += '<input type="checkbox" class="concwbrplbcheck" />';
        html += '<span class="concwbrplbtxt">同时转发到我的微博  ';
        html += '</span>';
        html += '</div>';
        html += '<div class="concwbrzfbtn">转发</div>';
        html += '</div></div></div></div></div></div>';

        var userid = $("#info").attr("userid");
        $.ajax({
            type: "POST",   //访问WebService使用Post方式请求
            contentType: "application/json", //WebService 会返回Json类型
            url: "webservice/wshomepage.asmx/publishBlog", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
            data: "{userId:" + userid + ",content:'" + content + "'}",         //这里是要传递的参数，格式为 data: "{paraName:paraValue}",下面将会看到       
            dataType: 'json',
            success: function (result) {     //回调函数，result，返回值
                if (result.d != null) {
                    //alert("发布成功！");
                }
            }
        });
        $(".wbfeed").prepend(html);
    });
    //赞和取消赞
    $(document).on("click", ".zan", function () {
        var that = $(this);
        var content = "";
        var parentid = 0;
        var blogid = that.parent().parent().parent().parent().attr("blogId");
        var ifzan = that.attr("ifzan");
        if (ifzan == 0) {
            var content = "";
            var parentid = 0;
            var typeid = 1;
            var d = "{blogid:" + blogid + ",content:'" + content + "',typeid:" + typeid + ",parentid:" + parentid + "}";
            $.ajax({
                url: "webservice/wshomepage.asmx/publishMessage",
                type: "POST",
                contentType: "application/json",
                data: d,
                dataType: "json",
                success: function (res) {
                    if (res.d != null) {
                        var zanNum = that.find("span").html();
                        zanNum++;
                        that.attr("ifzan", "1");
                        that.find("span").html(zanNum);
                    }
                },
                error: function () {
                    alert("fail");
                }
            })
        } else if (ifzan == 1) {
            var typeid = 9;
            var d = "{blogid:" + blogid + ",content:'" + content + "',typeid:" + typeid + ",parentid:" + parentid + "}";
            $.ajax({
                url: "webservice/wshomepage.asmx/publishMessage",
                type: "POST",
                contentType: "application/json",
                data: d,
                dataType: "json",
                success: function (res) {
                    if (res.d != null) {
                        var zanNum = that.find("span").html();
                        zanNum--;
                        that.attr("ifzan", "0");
                        that.find("span").html(zanNum);
                    }
                },
                error: function () {
                    alert("fail");
                }
            })
        }
       
    });
    //收藏与取消收藏
    $(document).on("click", ".wbcollect", function () {
        var that = $(this);
        var content = "";
        var parentid = 0;
        var blogid = that.parent().parent().parent().parent().attr("blogId");
        var ifcollect = that.attr("ifcollect");
        if (ifcollect == 0) {
            var content = "";
            var parentid = 0;
            var typeid = 7;
            var d = "{blogid:" + blogid + ",content:'" + content + "',typeid:" + typeid + ",parentid:" + parentid + "}";
            $.ajax({
                url: "webservice/wshomepage.asmx/publishMessage",
                type: "POST",
                contentType: "application/json",
                data: d,
                dataType: "json",
                success: function (res) {
                    if (res.d != null) {
                        that.attr("ifcollect", "1");
                        that.html("取消收藏");
                    }
                },
                error: function () {
                    alert("fail");
                }
            })
        } else if (ifcollect == 1) {
            var typeid = 10;
            var d = "{blogid:" + blogid + ",content:'" + content + "',typeid:" + typeid + ",parentid:" + parentid + "}";
            $.ajax({
                url: "webservice/wshomepage.asmx/publishMessage",
                type: "POST",
                contentType: "application/json",
                data: d,
                dataType: "json",
                success: function (res) {
                    if (res.d != null) {
                        that.attr("ifcollect", "0");
                        that.html("收藏");
                    }
                },
                error: function () {
                    alert("fail");
                }
            })
        }

    });
});