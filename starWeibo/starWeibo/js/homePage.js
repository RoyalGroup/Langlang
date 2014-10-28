$(function () {
    //发布微博
    $("#fabu").click(function () {
        var content = $("#fabu_input").val();
        var userid = $("#info").attr("userid");
        var parentid = 0;
        var btnActive = $(this).parent().attr("class");
        if (btnActive == "wbtnvactive") {
            $.ajax({
                type: "POST",   //访问WebService使用Post方式请求
                contentType: "application/json", //WebService 会返回Json类型
                url: "webservice/wshomepage.asmx/publishBlog", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                data: "{userId:" + userid + ",content:'" + content + "',parentid:" + parentid + "}",         //这里是要传递的参数，格式为 data: "{paraName:paraValue}",下面将会看到       
                dataType: 'json',
                success: function (result) {     //回调函数，result，返回值
                    if (result.d != null) {
                        $.ajax({
                            type: "POST",   
                            contentType: "application/json", 
                            url: "webservice/wshomepage.asmx/getPublishBlogId", 
                            data: "{userid:" + userid + "}",
                            dataType: 'json',
                            success: function (res) {
                                var blogid = res.d;
                                var html = "";
                                html += '<div class="wbfeedtype swfun line2">';
                                html += '<div class="wbfeeddetail line2 clearfix" blogid="' + blogid + '">';
                                html += '<div class="wbface">';
                                html += '<a  class="wfaceradius userMp">';
                                html += '<img src="' + $("#info").attr("headimg") + '" />';
                                html += '</a>';
                                html += '</div>';
                                html += '<div class="wbdetail">';
                                html += '<div class="wbinfo">';
                                html += '<a class="wbname userMp func1">' + $("#info").attr("name") + '</a>';
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
                                html += '<a class="wbcollect" ifcollect="0">收藏</a>';
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
                                html += '</div></div></div>';
                                $(".wbfeed").prepend(html);
                                $("#fabu_input").val("");
                                $("#fabu").parent().removeClass("wbtnvactive");
                                $("#fabu").parent().addClass("wbtnvdisable");
                                $("#fabu_input").parent().parent().find(".num").find("span").html(140);
                            },
                            error: function () {
                                alert("fail");
                            }
                        });
                    }
                }
            });
        }
        
    });
    //检测微博长度
    $("#fabu_input").keyup(function () {
        var wbContent = $(this).val();
        var wbLength=wbContent.length ;
        if (wbLength > 0 && wbLength <= 140) {
            $("#fabu").parent().removeClass("wbtnvdisable");
            $("#fabu").parent().addClass("wbtnvactive");
            $(this).parent().parent().find(".num").find("c").html("还可以输入");
            $(this).parent().parent().find(".num").find("span").html(140 - wbLength * 1);
            if ($(this).parent().parent().find(".num").find(".S_error").length > 0) {
                $(this).parent().parent().find(".num").find("span").removeClass("S_error");
            }
        } else {
            $("#fabu").parent().removeClass("wbtnvactive");
            $("#fabu").parent().addClass("wbtnvdisable");
            if (wbLength > 0) {
                $(this).parent().parent().find(".num").find("c").html("已经超过");
                $(this).parent().parent().find(".num").find("span").html(wbLength * 1 - 140);
                if ($(this).parent().parent().find(".num").find(".S_error").length <= 0) {
                    $(this).parent().parent().find(".num").find("span").addClass("S_error");
                }
            } else {
                $(this).parent().parent().find(".num").find("span").html(140);
            }
            
        }   
        
    });
    //赞和取消赞
    $(document).on("click", ".zan", function () {
        var that = $(this);
        var content = "";
        var parentid = 0;
        var blogid = that.parent().parent().parent().parent().attr("blogId");
        var ifzan = that.attr("ifzan");
        var zannum = that.find("span").html();
        if (ifzan == 0) {
            var content = "";
            var parentid = 0;
            var typeid = 1;
            var d = "{blogid:" + blogid + ",content:'" + content + "',typeid:" + typeid + ",parentid:" + parentid + "}";
            zannum=zannum*1+1;
            var d1 = "{blogid:" + blogid + ",zannum:" + zannum + "}";
            $.ajax({
                url: "webservice/wshomepage.asmx/updateBlogZan",
                type: "POST",
                contentType: "application/json",
                data: d1,
                dataType: "json",
                success: function (res) {
                    if (res.d == true) {
                    }
                }
            });
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
            zannum = zannum * 1-1;
            var d1 = "{blogid:" + blogid + ",zannum:" + zannum + "}";
            $.ajax({
                url: "webservice/wshomepage.asmx/updateBlogZan",
                type: "POST",
                contentType: "application/json",
                data: d1,
                dataType: "json",
                success: function (res) {
                    if (res.d == true) {
                    }
                }
            });
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
            });
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
    //弹出对微博评论的窗口
    $(document).on("click", ".pl", function () {
        var that = $(this);
       
        if (that.parent().parent().parent().parent().find(".huifu").length > 0) {
            that.parent().parent().parent().parent().find(".huifu").remove();
        } else {
            var blogid = that.parent().parent().parent().parent().attr("blogId");
            var typeid = 2;
            var replyList = '';
            var d = "{blogid:" + blogid + ",msgType:"+typeid+"}";
            $.ajax({
                url: "webservice/wshomepage.asmx/getReplyMsg",
                type: "POST",
                contentType: "application/json",
                data: d,
                dataType: "json",
                success: function (res) {
                    $(res.d).each(function () {       
                        replyList+='<dl class="commentlist line1">';
                        replyList+='<dt>';
                        replyList+='<a href="personalCenter.aspx?Userid='+this.userId+'" class="userMp">';
                        replyList+='<img src="'+this.userHeadimage+'">';
                        replyList+='</a>';
                        replyList+='</dt>';
                        replyList += '<dd>';
                        replyList += '<span class="replyContent">';
                        replyList+='<a class="userName userMp">';
                        replyList+=this.userName;
                        replyList+='</a>';
                        replyList += '：'
                        replyList += this.msgContent;
                        replyList += '&nbsp;&nbsp;&nbsp;&nbsp;(' + eval('new ' + (this.pubTime.replace(/\//g, ''))).Format("yyyy-MM-dd hh:mm:ss") + ')';
                        replyList += '</span>';
                        replyList += '<div class="info">';
                        replyList+='<span class="wlinkb">	';
                        replyList+='<a class="hh" rindex="1">回复</a>';
                        replyList+='</span>';
                        replyList+='</div>';
                        replyList+='</dd>';
                        replyList+='<dd class="clear"></dd>';
                        replyList+='</dl>';								
                    });
                },
                error: function () {
                    alert("fail");
                },
                complete: function () {
                    var html = '';
                    html += '<div class="huifu">';
                    html += '<div class="replyexpand line1 bg4">';
                    html += ' <div class="wbarrow">';
                    html += '	<em class="line1c">◆</em>';
                    html += '<span class="bg4c">◆</span>';
                    html += '</div>';
                    html += '	<div class="line1 input clearfix">';
                    html += '<div>';
                    html += '<textarea class="winput">';
                    html += '</textarea>';
                    html += '</div>';
                    html += '<p class="btn">';
                    html += '<a class="wbtna" replybtn="h">';
                    html += '<span class="btn30px wfl4">';
                    html += '<b></b>';
                    html += '<em class="btntext" bindex="1">';
                    html += '	评论</em>';
                    html += '</span>';
                    html += '</a>';
                    html += '</p>';
                    html += '</div>';
                    html += '<div id="ccru1">';
                    html += '<div class="commentlists1">';
                    html += replyList;
                    html += '</div>';
                    html += '</div>';
                    html += '</div>';
                    html += '</div>';
                    that.parent().parent().parent().parent().append(html);
                }
            });
        }
    });
    //发表评论
    $(document).on("click", ".wbtna", function () {
        var that = $(this);
        var replyTo = that.attr("replybtn");
        var replyContent = that.parent().parent().find(".winput").val();
        var replyList = '';
        var blogid;
        if (replyTo == "h") {
             blogid = that.parent().parent().parent().parent().parent().attr("blogId");
        } else if (replyTo == "hh") {
             blogid = that.parent().parent().parent().parent().parent().parent().parent().parent().parent().parent().parent().attr("blogId");
        }
        var parentid = 0;
        var typeid = 2;
        var d = "{blogid:" + blogid + ",content:'" + replyContent + "',typeid:" + typeid + ",parentid:" + parentid + "}";

        var plnum = $(".wbfeeddetail[blogid='" + blogid + "']").find(".pl span").html();
        plnum = plnum * 1 + 1;
        var d1 = "{blogid:" + blogid + ",plnum:" + plnum + "}";
        if (replyContent.length > 0 && replyContent.length < 141) {
            $.ajax({
                url: "webservice/wshomepage.asmx/updateBlogpl",
                type: "POST",
                contentType: "application/json",
                data: d1,
                dataType: "json",
                success: function (res) {
                    if (res.d == true) {
                        $(".wbfeeddetail[blogid='" + blogid + "']").find(".pl span").html(plnum);
                    }
                }
            });
            $.ajax({
                url: "webservice/wshomepage.asmx/publishMessage",
                type: "POST",
                contentType: "application/json",
                data: d,
                dataType: "json",
                success: function (res) {
                    if (res.d != null) {
                        replyList += '<dl class="commentlist line1">';
                        replyList += '<dt>';
                        replyList += '<a href="personalCenter.aspx?Userid=' + $("#info").attr("userid") + '" class="userMp">';
                        replyList += '<img src="' + $("#info").attr("headimg") + '">';
                        replyList += '</a>';
                        replyList += '</dt>';
                        replyList += '<dd>';
                        replyList += '<span class="replyContent">';
                        replyList += '<a class="userName userMp">';
                        replyList += $("#info").attr("name");
                        replyList += '</a>';
                        replyList += '：'
                        replyList += replyContent;
                        replyList += '&nbsp;&nbsp;&nbsp;&nbsp;(一分钟前)';
                        replyList += '</span>';
                        replyList += '<div class="info">';
                        replyList += '<span class="wlinkb">	';
                        replyList += '<a class="hh" rindex="1">回复</a>';
                        replyList += '</span>';
                        replyList += '</div>';
                        replyList += '</dd>';
                        replyList += '<dd class="clear"></dd>';
                        replyList += '</dl>';
                        if (replyTo == "h") {
                            that.parent().parent().parent().find(".commentlists1").prepend(replyList);
                            that.parent().parent().find(".winput").val("");
                        } else if (replyTo == "hh") {
                            that.parent().parent().parent().parent().parent().parent().parent().parent().find(".commentlists1").prepend(replyList);
                            that.parent().parent().parent().parent().remove();
                        }

                    }
                },
                error: function () {
                    alert("fail");
                }
            });
        } else if (replyContent.length == 0) {
            alert("评论内容不可为空！");
        } else {
            alert("评论内容请保持在140字以内！");
        }
    });
    //弹出对评论的评论对话框
    $(document).on("click", ".hh", function () {
        var that = $(this);
        if (that.parent().parent().parent().find(".rereply1").length > 0) {
            that.parent().parent().parent().find(".rereply1").remove();
        } else {
            var html = '';
            var userName = that.parent().parent().parent().find(".userName").html();
            html += '<div class="rereply1">';
            html += ' <div class="wbmediaexpand repeat line1 bg1">';
            html += ' <div class="wbarrow">';
            html += '<em class="line1c">◆</em>';
            html += '<span class="bg4c">◆</span>';
            html += '</div>';
            html += '<div class="line1 input clearfix">	<div>';
            html += '<textarea class="winput"></textarea>';
            html += '</div>';	
            html += '<p class="btn">	';
            html += '<a class="wbtna" replybtn="hh">';
            html += '<span class="btn30px wfl4">';
            html += '<b></b>';
            html += '<em class="btntext" bindex="1">评论</em>';
            html += '</span>';
            html += '</a>';
            html += '</p>';
            html += '</div>';
            html += '</div>';
            html += '</div>';
            that.parent().parent().parent().append(html);
            that.parent().parent().parent().find(".winput").val("回复@" + userName + "：");
        }
    });
    //弹出转发窗口
    $(document).on("click", ".zf", function () {
        var that = $(this);
        $(".mengban").show();
        $(".contrans").show();
        if (that.parent().parent().parent().find(".zfdisable").length > 0) {
            var blogid = that.parent().parent().parent().parent().attr("blogid");
            var blogAuthor = that.parent().parent().parent().find(".wbname userMp").html();
            var blogContent = that.parent().parent().parent().find(".wbtext").html();
            var blogAuthorUrl = that.parent().parent().parent().find(".wbname userMp").attr("href");
            $(".contrans").find(".contmyan a.conttxtlink").attr("href", blogAuthorUrl);
            $(".contrans").find(".contmyan a.conttxtlink").html("@" + blogAuthor);
            $(".contrans").find(".contmyan span.contgeyan").html(blogContent);
            $(".contrans").find(".contranstop .conttxt ").html("转发微博");
            $(".contrans").find(".concwbrzfbtn").html("转发");
            $(".contrans").find("textarea").attr("placeHolder", "说点什么吧……");
            $(".contrans").attr("blogid", blogid);
            $(".contrans").find(".contte").val("");
        } else {
            var blogid = that.parent().parent().parent().find(".wbmediaexpand").attr("blogid");
            var blogAuthor = that.parent().parent().parent().find(".wbmediaexpand .wbname userMp").html();
            var blogContent = that.parent().parent().parent().find(".wbmediaexpand .wbtext em").html();
            var blogAuthorUrl = that.parent().parent().parent().find(".wbmediaexpand .wbname userMp").attr("href");
            $(".contrans").find(".contmyan a.conttxtlink").attr("href", blogAuthorUrl);
            $(".contrans").find(".contmyan a.conttxtlink").html("@" + blogAuthor);
            $(".contrans").find(".contmyan span.contgeyan").html(blogContent);
            $(".contrans").find(".contranstop .conttxt ").html("转发微博");
            $(".contrans").find(".concwbrzfbtn").html("转发");
            $(".contrans").find("textarea").attr("placeHolder", "说点什么吧……");
            $(".contrans").attr("blogid", blogid);
            $(".contrans").find(".contte").val("");
        }
        
        
    });
    //关闭转发窗口
    $(".contclose").click(function () {
        $(".mengban").hide();
        $(".contrans").hide();
    });
    //转发/举报消息
    $(".concwbrzfbtn").click(function () {
        var that = $(this);
        var blogid = $(".contrans").attr("blogid");
        var content = that.parent().parent().find(".contte").val();
        var parentid = 0;
        var userid = $("#info").attr("userid");
        var thatType = that.parent().parent().parent().find(".contranstop .conttxt").html();
        if (thatType == "举报") {
            var typeid = 5;
            var d = "{blogid:" + blogid + ",content:'" + content + "',typeid:" + typeid + ",parentid:" + parentid + "}";
            if (content.length == 0) {
                alert("举报理由不可为空！");
            } else if (content.length > 141) {
                alert("举报理由请保持在140字以内！");
            } else {
                $.ajax({
                    url: "webservice/wshomepage.asmx/publishMessage",
                    type: "POST",
                    contentType: "application/json",
                    data: d,
                    dataType: "json",
                    success: function (res) {
                        if (res.d != null) {
                            that.parent().parent().find(".contte").val("举报成功！");
                            that.parent().parent().find(".contte").animate({ "opacity": "0.9" }, 500, function () {
                                $(".mengban").hide();
                                $(".contrans").hide();
                            });
                        }
                    }
                });
            }
        } else {
            if (content.length == 0) {
                content = "转发微博";
            }
            var typeid = 6;
            var d = "{blogid:" + blogid + ",content:'" + content + "',typeid:" + typeid + ",parentid:" + parentid + "}";
            var d1 = "{userId:" + userid + ",content:'" + content + "',parentid:" + blogid + "}";
            if (content.length < 141) {
                $.ajax({
                    type: "POST",   //访问WebService使用Post方式请求
                    contentType: "application/json", //WebService 会返回Json类型
                    url: "webservice/wshomepage.asmx/publishBlog", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                    data: d1,         //这里是要传递的参数，格式为 data: "{paraName:paraValue}",下面将会看到       
                    dataType: 'json',
                    success: function (result) {     //回调函数，result，返回值
                        if (res.d != null) {
                            alert("fasdf asdfasdfasdfasd");
                        }
                    }
                });
                $.ajax({
                    url: "webservice/wshomepage.asmx/publishMessage",
                    type: "POST",
                    contentType: "application/json",
                    data: d,
                    dataType: "json",
                    success: function (res) {
                        if (res.d != null) {
                            that.parent().parent().find(".contte").val("转发成功！");
                            that.parent().parent().find(".contte").animate({ "opacity": "0.9" }, 500, function () {
                                $(".mengban").hide();
                                $(".contrans").hide();
                            });
                            var html = '';
                            var blogAuthorUrl = that.parent().parent().find(".contmyan a.conttxtlink").attr("href");
                            var blogAuthorName = that.parent().parent().find(".contmyan a.conttxtlink").html().split("@")[1];
                            var blogContent = that.parent().parent().find(".contgeyan").html();
                            html += '<div class="wbfeedtype swfun line2">';
                            html += '<div class="wbscreen">';
                            html += '<a class="wico12 iconchoose"></a>';
                            html += '</div>';
                            html += '<div class="wbfeeddetail line2 clearfix">';
                            html += '<div class="wbface">';
                            html += '<a href="' + blogAuthorUrl + '" class="wfaceradius userMp">';
                            html += '<img src="' + $("#info").attr("headimg") + '" />';
                            html += '</a>';
                            html += '</div>';
                            html += '<div class="wbdetail">';
                            html += '<div class="wbinfo">';
                            html += '<a class="wbname userMp func1">' + $("#info").attr("name") + '</a>	';
                            html += '</div>';
                            html += '	<div class="wbtext">';
                            html += content;
                            html += '</div>';
                            html += '<div class="wbmediaexpand swfun2 line1 bg1">';
                            html += '<div class="wbarrow">';
                            html += '<em class="line1c">◆</em>';
                            html += '<span class="bg4c">◆</span>';
                            html += '</div>';
                            html += '<div class="listcontent">';
                            html += '<div class="wbinfo">';
                            html += '<a href=' + blogAuthorUrl + ' class="wbname userMp func3">' + blogAuthorName + '</a>';
                            html += '</div>	';
                            html += '<div class="wbtext">';
                            html += '<em>';
                            html += blogContent;
                            html += '</em>';
                            html += '</div>';
                            html += '</div>';
                            html += '</div>';
                            html += '<div class="wbfunc clearfix">';
                            html += '<div class="wbhandle">	';
                            html += '<a class="zan" ifzan="0">';
                            html += '<em class="wico20 iconpraised"></em>';
                            html += '(<span>';
                            html += '0';
                            html += '</span>)';
                            html += '</a>';
                            html += '<i class="txt3">|</i>';
                            html += '<a class="zf">转发</a>';
                            html += '<i class="txt3">|</i>';
                            html += '<a class="wbcollect">收藏</a>';
                            html += '<i class="txt3">|</i>';
                            html += '<a class="pl" pindex="20" isopen="no" ifc="0">评论(0)</a>';
                            html += '</div>';
                            html += '<div class="wbfrom">';
                            html += '<a  class="link2 wbtime">一分钟前</a>';
                            html += '<em class="txt2">来自</em>';
                            html += '<a  class="link2">weibo</a>';
                            html += '<span class="hoverr">';
                            html += '<em class="txt2">|</em>&nbsp;';
                            html += '<a class="jubao">举报</a>';
                            html += '</span>';
                            html += '</div>';
                            html += '</div>';
                            html += '<div class="dahuifu20"></div>';
                            html += '</div>';
                            html += '</div>';
                            html += '</div>';
                            $(".wbfeed").prepend(html);
                        }

                    }
                });
            } else {
                alert("转发内容请保持在140字以内！");
            }
        }
    });
    //弹出举报微博窗口
    $(document).on("click", ".jubao", function () {
        var that = $(this);
        $(".mengban").show();
        $(".contrans").show();
        if (that.parent().parent().parent().parent().find(".zfdisable").length > 0) {
            var blogid = that.parent().parent().parent().parent().parent().attr("blogid");
            var blogAuthor = that.parent().parent().parent().parent().find(".wbname userMp").html();
            var blogContent = that.parent().parent().parent().parent().find(".wbtext").html();
            var blogAuthorUrl = that.parent().parent().parent().parent().find(".wbname userMp").attr("href");
            $(".contrans").find(".contmyan a.conttxtlink").attr("href", blogAuthorUrl);
            $(".contrans").find(".contmyan a.conttxtlink").html("@" + blogAuthor);
            $(".contrans").find(".contmyan span.contgeyan").html(blogContent);
            $(".contrans").find(".contranstop .conttxt ").html("举报");
            $(".contrans").find(".concwbrzfbtn").html("提交");
            $(".contrans").find("textarea").attr("placeHolder", "请填写举报理由……");
            $(".contrans").attr("blogid", blogid);
            $(".contrans").find(".contte").val("");
        } else {
            var blogid = that.parent().parent().parent().parent().find(".wbmediaexpand").attr("blogid");
            var blogAuthor = that.parent().parent().parent().parent().find(".wbmediaexpand .wbname userMp").html();
            var blogContent = that.parent().parent().parent().parent().find(".wbmediaexpand .wbtext em").html();
            var blogAuthorUrl = that.parent().parent().parent().parent().find(".wbmediaexpand .wbname userMp").attr("href");
            $(".contrans").find(".contmyan a.conttxtlink").attr("href", blogAuthorUrl);
            $(".contrans").find(".contmyan a.conttxtlink").html("@" + blogAuthor);
            $(".contrans").find(".contmyan span.contgeyan").html(blogContent);
            $(".contrans").find(".contranstop .conttxt ").html("举报");
            $(".contrans").find(".concwbrzfbtn").html("提交");
            $(".contrans").find("textarea").attr("placeHolder","请填写举报理由……");
            $(".contrans").attr("blogid", blogid);
            $(".contrans").find(".contte").val("");
        }
    });
    //显示用户名片
    $(document).on("mouseover", ".userMp", function () {
        var that = $(this);
        var userid = that.attr("href").split("personalCenter.aspx?Userid=")[1];
        $.ajax({
            url: "webservice/wshomepage.asmx/getUserInfo",
            type: "POST",
            contentType: "application/json",
            data: "{userid:'" + userid + "'}",
            dataType: "json",
            success: function (res) {
                var html = '';
                html += '<div class="mpWrapper">';
                html += '<div class="mpWrapperUp">';
                html += '<a href="" class="mpHeadimage">';
                html += '<img src="'+res.d["userHeadimage"]+'">';
                html += '</a>';
                html += '<a href="personalCenter.aspx?Userid=' + res.d["id"] + '" class="mpUsername">';
                html += res.d["userName"];
                html += '</a>';
                html += '</div>';
                html += '<div class="mpWrapperDown">';
                html += '<div class="numCount">';
                html += '<span class="c_focus">';
                html += '关注';
                html += '<a href="">' + res.d["userPwd"] + '</a>';
                html += '</span>';
                html += '<span class="c_fans">';
                html += '粉丝';
                html += '<a href="">' + res.d["userMail"] + '</a>';
                html += '</span>';
                html += '<span class="c_weibo">';
                html += '微博';
                html += '<a href="">' + res.d["userBirthday"] + '</a>';
                html += '</span>';
                html += '</div>';
                html += '<div class="btnbox">';
                html += '<div class="btnStyle focusBtn">';
                if (res.d["userBirthday"] >= "1") {
                    html += '已关注';
                } else {
                    html += '未关注';
                }
                html+='</div>';
                html += '<div class="btnStyle sixinBtn">私信</div>';
                html += '</div>';
                html += '</div>';
                html += '</div>';
                if (that.parent().find(".mpWrapper").length == 0) {
                    that.parent().append(html);
                    var thiswidth = that.css("width");
                    that.parent().find(".mpWrapper").css("left", thiswidth);
                } else {
                    that.parent().find(".mpWrapper").show();
                }
            }
        });
    });
    $(document).on("mouseout", ".wbinfo,.wbface", function () {
        var that = $(this);
        if (that.find(".mpWrapper").length > 0) {
           // that.find(".mpWrapper").animate({ "top": "1px" }, 1000, function () {
                that.find(".mpWrapper").hide();
           // })
            
        }
    });
    //页面加载时检测用户收藏或赞的微博
    loadingZanSc();

    //分页与加载相关
    fenye();
    //loading();
    //$(document).ajaxStart(function () {
     //   $("#loading").show();
    //});
    //$(document).ajaxStop(function () {
     //   $("#loading").hide();
    //});

});

var flag = true;
function loading() {
    $(window).scroll(function () {
        var scrolls = $(this).scrollTop();
        if (scrolls > 1700) {
            if (flag == true) {
                var pages = $(".curpage").attr("num");
                var startIndex = (pages-1)*40+21;
                var endIndex = startIndex + 19;
                $.ajax({
                    type: "POST",   //访问WebService使用Post方式请求
                    contentType: "application/json", //WebService 会返回Json类型
                    url: "webservice/wshomepage.asmx/fengye", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                    //data: "{startIndex:" + "11" + ",endIndex:'" + "20" + "'}",         //这里是要传递的参数，格式为 data: "{paraName:paraValue}",下面将会看到       
                    data: "{startIndex:'" + startIndex + "',endIndex:'" + endIndex + "'}",
                    dataType: 'json',
                    success: function (result) {     //回调函数，result，返回值
                        var a = result;
                        //alert(result.d);
                        $(result.d).each(function () {
                            //alert(this.bloguserName);
                            fabu(this.blogAuthorHeadimage, this.blogAuthorName, this.blogContent, this.blogpubtime, "loading");
                        });
                    }
                });
                $(".W_pages").show();
                flag = false;
            }
        }

    });
}

function fabu(headimg, name, content,pubtime ,type) {
    var html = "";
    html += '<div class="wbfeedtype swfun line2">';
    html += '<div class="wbscreen">';
    html += '<a class="wico12 iconchoose"></a>';
    html += '</div>';
    html += '<div class="wbfeeddetail line2 clearfix">';
    html += '<div class="wbface">';
    html += '<a  class="wfaceradius userMp">';
    html += '<img src="' + headimg + '" />';
    html += '</a>';
    html += '</div>';
    html += '<div class="wbdetail">';
    html += '<div class="wbinfo">';
    html += '<a class="wbname userMp func1">' + name + '</a>';
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
    html += '<a class="wbcollect">收藏</a>';
    html += '<i class="txt3">|</i>';
    html += '<a class="pl" pindex="1" isopen="no" ifc="0">评论(0)</a>';
    html += '</div>';
    html += '<div class="wbfrom">';
    html += '<a  class="link2 wbtime">' + eval('new ' + (pubtime.replace(/\//g, ''))).Format("yyyy-MM-dd hh:mm:ss") + '</a>';
    html += '<em class="txt2">来自</em>';
    html += '<a  class="link2">360安全浏览器</a>';
    html += '<span class="hoverr">';
    html += '<em class="txt2">|</em>&nbsp;';
    html += '<a  class="jubao">举报</a>';
    html += '</span>';
    html += '</div>';
    html += '</div>';
    html += '</div></div>';
    if (type == "fabu") {
        $(".wbfeed").prepend(html);
    }
    if (type == "loading") {
        $(".wbfeed").append(html);
    }
}

function fenye() {
    if ($(".W_pages").attr("num") == $(".curpage").attr("num")) {
        $(".W_pages").show();
    }

    $(".pagebox").hover(function () {
        $(".pages").show();
    }, function () {
        $(".pages").hide();
    });
}

Date.prototype.Format = function (fmt) { //author: meizz 
    var o = {
        "M+": this.getMonth() + 1, //月份 
        "d+": this.getDate(), //日 
        "h+": this.getHours(), //小时 
        "m+": this.getMinutes(), //分 
        "s+": this.getSeconds(), //秒 
        "q+": Math.floor((this.getMonth() + 3) / 3), //季度 
        "S": this.getMilliseconds() //毫秒 
    };
    if (/(y+)/.test(fmt)) fmt = fmt.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    for (var k in o)
        if (new RegExp("(" + k + ")").test(fmt)) fmt = fmt.replace(RegExp.$1, (RegExp.$1.length == 1) ? (o[k]) : (("00" + o[k]).substr(("" + o[k]).length)));
    return fmt;
}

function loadingZanSc() {
    $.ajax({
        url: "webservice/wshomepage.asmx/loadingZanSc",
        type: "POST",
        contentType: "application/json",
        data: "{typeid:1}",
        dataType: "json",
        success: function (res) {
            $(res.d).each(function () {
                $(".wbfeeddetail[blogid='" + this.blogId + "']").find(".zan").attr("ifzan","1");
            });
        }
    });
    $.ajax({
        url: "webservice/wshomepage.asmx/loadingZanSc",
        type: "POST",
        contentType: "application/json",
        data: "{typeid:7}",
        dataType: "json",
        success: function (res) {
            $(res.d).each(function () {
                $(".wbfeeddetail[blogid='" + this.blogId + "']").find(".wbcollect").html("取消收藏");
            });
        }
    });
}