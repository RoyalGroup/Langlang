$(function () {
    $("#fabu").click(function () {
        var content = $("#fabu_input").val();
        var html = "";
        html += '<div class="wbfeedtype swfun line2">';
        html += '<div class="wbscreen">';
        html += '<a class="wico12 iconchoose"></a>';
        html += '</div>';
        html += '<div class="wbfeeddetail line2 clearfix">';
        html += '<div class="wbface">';
        html += '<a href="#" class="wfaceradius">';
        html += '<img src="' + $("#info").attr("headimg") + '" />';
        html += '</a>';
        html += '</div>';
        html += '<div class="wbdetail">';
        html += '<div class="wbinfo">';
        html += '<a class="wbname func1">'+$("#info").attr("name")+'</a>';
        html += '<a href="#">';
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
        html += '<a href="#">收藏</a>';
        html += '<i class="txt3">|</i>';
        html += '<a class="pl" pindex="1" isopen="no" ifc="0">评论(0)</a>';
        html += '</div>';
        html += '<div class="wbfrom">';
        html += '<a href="#" class="link2 wbtime">1分钟前</a>';
        html += '<em class="txt2">来自</em>';
        html += '<a href="#" class="link2">360安全浏览器</a>';
        html += '<span class="hoverr">';
        html += '<em class="txt2">|</em>&nbsp;';
        html += '<a href="#" class="jubao">举报</a>';
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
            url: "webservice/wshomepage.asmx/publish", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
            data: "{userId:" + userid + ",content:'" + content + "'}",         //这里是要传递的参数，格式为 data: "{paraName:paraValue}",下面将会看到       
            dataType: 'json',
            success: function (result) {     //回调函数，result，返回值
                if (result.d != null) {
                    alert("发布成功！");
                }
            }
        });
        $(".wbfeed").prepend(html);
    });
});