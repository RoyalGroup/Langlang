$(function () {
    $("#originalImg").imgAreaSelect({
        aspectRatio: '1:1',
        handles: true,
        onSelectChange: preview,
        onSelectEnd: function (img, selection) {
            var originalImg = new Image();
            originalImg.src = $("#originalImg").attr("src");//定义一个和原图一样image对象，以此获取原图的真实宽高
            var scaleX = originalImg.width / img.width;
            var scaleY = originalImg.height / img.height;
            x1 = Math.round(scaleX * selection.x1);
            y1 = Math.round(scaleY * selection.y1);
            selectwidth = Math.round(scaleX * selection.width);
            selectheight = Math.round(scaleY * selection.height);
        }
    });
    //个人中心头部封面图hover事件
    $(".headerPic").hover(function () {
        $(".pf_use_num").addClass("pf_use_num_display");
    }, function () {
        $(".pf_use_num").removeClass("pf_use_num_display");
    });

    //修改头像
    $(".pf_head_pic").hover(function () {
        $(".change_btn_div").css("display", "block");
    }, function () {
        $(".change_btn_div").css("display", "none");
    });

    //内容区导航栏切换
    $(".pftb_itm").click(function () {
        $(".pftb_itm").removeClass("pftb_itm_A");
        $(".pftb_itm").find(".S_bg1").removeClass("S_bg1_A");
        $(this).addClass("pftb_itm_A");
        $(this).find(".S_bg1").addClass("S_bg1_A");
    });

    //文本框获得焦点和失去焦点的事件
    $(".W_input").focus(function () {
        $(this).css({ "border-color": "#ff4a00", "color": "#333" })
    });
    $(".W_input").blur(function () {
        $(this).css({ "border-color": "", "color": "" })
    });

    //初始化所在地区
    addressInit('cmbProvince', 'cmbCity', 'cmbArea', $("#Province").text(), $("#City").text(), $("#Area").text());
    //应用方法
    $("input.birth_date").jSelectDate({
        css: "birth_date",
        yearBeign: 1995,
        disabled: false,
        showLabel: false
    });

    $("#uploadify").uploadify({
        'uploader': 'js/uploadify.swf',
        'script': 'uploadpage.aspx',
        'cancelImg': 'js/cancel.png',
        'folder': 'images/photos',
        'queueID': 'fileQueue',
        'fileTypeExts': '*.gif;*.jpg;*.png',
        'auto': false,
        'multi': false,
        onComplete: function (event, ID, fileObj, response, data) {
            var ext = fileObj.filePath.substring(fileObj.filePath.lastIndexOf('.')).toLowerCase();
            var extname = ".jpg|.png|.gif";
            if (extname.search(ext) != -1) {
                $("#originalImg").attr("src", fileObj.filePath);
                $("#previewImg").attr("src", fileObj.filePath);
            } else {
                alert("请上传[.jpg|.png|.gif]格式图片！");
            }
        }
    });

    $(".change_btn_div").click(function () {
        $(".menban").show();
    });
    $(".exitBtn").click(function () {
        $(".menban").hide();
    });

    /*******************修改密码******************/
    $(document).on("click", ".updatePwd", function () {
        $(".menban2").show();
    });
    //用户名错误提醒
    $("#oldPwd").focus(function () {
        $(".remindInfo").html("请输入原密码");
    });
    $("#oldPwd").blur(function () {
        var id = $("#userid").text();
        var inputPwd = $("#oldPwd").val();
        $.ajax({
            type: "POST", 
            contentType: "application/json", 
            url: "webservice/wspersonal.asmx/checkUserPwd",
            data: "{ id:'" + id + "',inputPwd:'" + inputPwd + "'}",
            dataType: 'json',
            success: function (result) { 
                if (result.d == 'true') {
                    oldPwdCheck = true;
                    $(".oldPwdRemind").show();
                } else {
                    oldPwdCheck = false;
                    $(".remindInfo").html("原密码输入不正确，请重试！");
                    $(".oldPwdRemind").hide();
                    $("#oldPwd").val("");
                }
            }
        });
    });
    //密码错误提醒
    $("#newPwd").focus(function () {
        $(".remindInfo").html("密码由20位以内的数字、字母、下划线组成。");
    });
    $("#newPwd").blur(function () {
        var patt2 = new RegExp("^[0-9A-z_]{1,20}$");
        if (patt2.test($("#newPwd").val()) == true) {
            newPwdCheck = true;
            $(".newPwdRemind").show();
        } else {
            newPwdCheck = false;
            $(".remindInfo").html("密码输入不符合要求，请重试！");
            $(".newPwdRemind").hide();
            $("#newPwd").val("");
        }
    });
    //确认密码错误提醒
    $("#inputAgain").focus(function () {
        $(".remindInfo").html("请再次输入密码，保持两次密码输入一致。");
    });
    $("#inputAgain").blur(function () {
        if ($("#inputAgain").val().toString() == $("#newPwd").val().toString() && $("#inputAgain").val().toString() != "") {
            inputAgainCheck = true;
            $(".inputAgainRemind").show();
        } else {
            inputAgainCheck = false;
            $(".remindInfo").html("两次密码输入不一致，请重试！");
            $(".inputAgainRemind").hide();
            $("#inputAgain").val("");
        }
    });
    $("#ensure").click(function () {
        if (oldPwdCheck == true && newPwdCheck == true && inputAgainCheck == true) {
            var id = $("#userid").text();
            var newpwd = $("#newPwd").val();
            $.ajax({
                type: "POST",
                contentType: "application/json",
                url: "webservice/wspersonal.asmx/updateUserPwd",
                data: "{ id:'" + id + "',newpwd:'" + newpwd + "'}",
                dataType: 'json',
                success: function (result) {
                    if (result.d == 'True') {
                        clearInputInfo();
                        $(".updateInfo").find(".icon_succS").removeClass("icon_delS");
                        $(".updateInfo").find(".txt").text("修改成功");
                        $(".updateInfo").fadeIn(1000).fadeOut(1000);
                    } 
                }
            });
        } else {
            clearInputInfo(); 
            $(".updateInfo").find(".icon_succS").addClass("icon_delS");
            $(".updateInfo").find(".txt").text("修改失败");
            $(".updateInfo").fadeIn(1000).fadeOut(1000);
        }
    });
    $("#cancel").click(function () {
        clearInputInfo();
        $(".menban2").hide();
    });
    /******************修改密码*********************/

    //编辑保存基本信息
    $("#baseInfo .editBtn").click(function () {
        var state = $(this).text();
        if (state == '编辑') {
            $("div[node-type='base_view']").css("display", "none");
            $("div[node-type='base']").css("display", "block");
            $(this).text("保存");
            getUsersex();
            getUserLove();
        }
        if (state == '保存') {
            id = $("#userid").text();
            userName = $("input[node-type='nickname']").val();
            userAddress = $("#cmbProvince").val() + '-' + $("#cmbCity").val() + '-' + $("#cmbArea").val();
            userSex = $(".W_radio[state='1']").parent().text();
            userMarry = $("select[node-type='love']").val();
            userBirthday = $("#birth_sel").val();
            userDes = $("textarea[name='mydesc']").val();
            cityinfo = $("#cmbProvince").val() + ' ' + $("#cmbCity").val() + ' ' + $("#cmbArea").val();
            $.ajax({
                type: "POST",   //访问WebService使用Post方式请求
                contentType: "application/json", //WebService 会返回Json类型
                url: "webservice/wspersonal.asmx/updateUserBaseinfo", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                data: "{ id:'" + id + "',userName:'" + userName + "',userAddress:'" + userAddress + "',userSex:'" + userSex + "',userMarry:'" + userMarry + "',userBirthday:'" + userBirthday + "',userDes:'" + userDes + "'}",
                dataType: 'json',
                success: function (result) {     //回调函数，result，返回值
                    if (result.d == 'True') {
                        //基本信息资料同步
                        syncUserBaseInfo();
                        //状态切换，从保存状态变为编辑状态
                        $("div[node-type='base_view']").css("display", "block");
                        $("div[node-type='base']").css("display", "none");
                        $("#baseInfo .editBtn").text("编辑");
                        $(".saveInfo").find(".icon_succS").removeClass("icon_delS");
                        $(".saveInfo").find(".txt").text("保存成功");
                        $(".saveInfo").fadeIn(1000).fadeOut(1000);
                    }
                }
            });
        }
    });
    //编辑保存联系信息
    $("#comInfo .editBtn").click(function () {
        var state = $(this).text();
        if (state == '编辑') {
            $("div[node-type='com_view']").css("display", "none");
            $("div[node-type='com']").css("display", "block");
            $(this).text("保存");
        }
        if (state == '保存') {
            var id, userMail, QQnumber, userTell;
            id = $("#userid").text();
            userMail = $("input[node-type='email']").val();
            QQnumber = $("input[node-type='qq']").val();
            userTell = $("input[node-type='tel']").val();
            if (qqIsRight) {
                if (telIsRight) {
                    $.ajax({
                        type: "POST",   //访问WebService使用Post方式请求
                        contentType: "application/json", //WebService 会返回Json类型
                        url: "webservice/wspersonal.asmx/updateUserCominfo", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                        data: "{ id:'" + id + "',userMail:'" + userMail + "',QQnumber:'" + QQnumber + "',userTell:'" + userTell + "'}",
                        dataType: 'json',
                        success: function (result) {     //回调函数，result，返回值
                            if (result.d == 'True') {
                                //联系信息资料同步
                                $(".con[node-type='email_view']").text(userMail);
                                $(".con[node-type='qq_view']").text(QQnumber);
                                $(".con[node-type='Tel_view']").text(userTell);
                                //状态切换，从保存状态变为编辑状态
                                $("div[node-type='com_view']").css("display", "block");
                                $("div[node-type='com']").css("display", "none");
                                $("#comInfo .editBtn").text("编辑");
                                $(".saveInfo").find(".icon_succS").removeClass("icon_delS");
                                $(".saveInfo").find(".txt").text("保存成功");
                                $(".saveInfo").fadeIn(1000).fadeOut(1000);
                            }
                        }
                    });
                } else {
                    $(".saveInfo").find(".icon_succS").addClass("icon_delS");
                    $(".saveInfo").find(".txt").text("保存失败");
                    $(".saveInfo").fadeIn(1000).fadeOut(1000);
                }
            } else {
                $(".saveInfo").find(".icon_succS").addClass("icon_delS");
                $(".saveInfo").find(".txt").text("保存失败")
                $(".saveInfo").fadeIn(1000).fadeOut(1000);
            }
        }
    });
    //编辑保存教育信息
    $("#eduInfo .editBtn").click(function () {
        var state = $(this).text();
        if (state == '编辑') {
            $("div[node-type='edu_view']").css("display", "none");
            $("div[node-type='edu']").css("display", "block");
            $(this).text("保存");
        }
        if (state == '保存') {
            $("div[node-type='edu_view']").css("display", "block");
            $("div[node-type='edu']").css("display", "none");
            $(this).text("编辑");

            var id, userEdu;
            id = $("#userid").text();
            userEdu = $("input[node-type='school']").val();
            $.ajax({
                type: "POST",   //访问WebService使用Post方式请求
                contentType: "application/json", //WebService 会返回Json类型
                url: "webservice/wspersonal.asmx/updateUserEduinfo", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
                data: "{ id:'" + id + "',userEdu:'" + userEdu + "'}",
                dataType: 'json',
                success: function (result) {     //回调函数，result，返回值
                    if (result.d == 'True') {
                        $(".con[node-type='school_view']").text(userEdu);
                        $(".saveInfo").find(".icon_succS").removeClass("icon_delS");
                        $(".saveInfo").find(".txt").text("保存成功");
                        $(".saveInfo").fadeIn(1000).fadeOut(1000);
                    }
                }
            });
        }
    });
    //快速编辑
    $(document).on("click", "[action-type='quickedit']", function () {
        var belong = $(this).attr("belong");
        $("#" + belong).find(".editBtn").click();
    });

    //选择性别
    $(".W_radio").click(function () {
        $(".W_radio").attr('state', '0');
        $(this).attr('state', '1');
    });

    //输入QQ号时检测其合法性
    $("input[node-type='qq']").keyup(function () {
        qqIsRight = checkQQNumber($(this).val());
        if (qqIsRight) {
            $("[node-type='qq_tip']").html("<div class='W_tips clearfix'><p class='icon'><span class='icon_succS'></span></p></div>");
        } else {
            $("[node-type='qq_tip']").html("<div class='W_tips tips_del clearfix'><p class='icon'><span class='icon_delS'></span></p><span class='txt'>请输入正确的QQ号</span></div>");
        }
    });
    //输入手机号时检测其合法性
    $("input[node-type='tel']").keyup(function () {
        telIsRight = checkTelNumber($(this).val());
        if (telIsRight) {
            $("[node-type='tel_tip']").html("<div class='W_tips clearfix'><p class='icon'><span class='icon_succS'></span></p></div>");
        } else {
            $("[node-type='tel_tip']").html("<div class='W_tips tips_del clearfix'><p class='icon'><span class='icon_delS'></span></p><span class='txt'>请输入正确的手机号</span></div>");
        }
    });
    //确认裁剪头像，提交上传请求
    $(".ensureBtn").click(function () {
        var originalImagePath = $("#originalImg").attr("src");
        var width = 150, height = 150;
        $.ajax({
            type: "POST",   //访问WebService使用Post方式请求
            contentType: "application/json", //WebService 会返回Json类型
            url: "webservice/wspersonal.asmx/MakeThumbnail", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
            data: "{ originalImagePath:'" + originalImagePath + "',x1:'" + x1 + "',y1:'" + y1 + "',selectwidth:'" + selectwidth + "',selectheight:'" + selectheight + "',width:'" + width + "',height:'" + height + "'}",
            dataType: 'json',
            success: function (result) {     //上传成功则将新的头像更新至数据库
                if (result.d != "") {
                    var id = $("#userid").text();
                    var headImg = result.d;
                    //alert(headImg);
                    $.ajax({
                        type: "POST",
                        contentType: "application/json",
                        url: "webservice/wspersonal.asmx/updateUserHeadImg",
                        data: "{ id:'" + id + "',headImg:'" + headImg + "'}",
                        dataType: 'json',
                        success: function (result) {
                            location.reload();
                        }
                    });
                }
            },
            error: function () {
                alert("操作出现异常！");
            }
        });
    });
    showQSuserinfo();
});
//定义变量
var id, userName, userAddress, userSex, userMarry, userBirthday, userDes;
var qqIsRight = true, telIsRight = true;
var oldPwdCheck = false, newPwdCheck = false, inputAgainCheck = false;

//同步用户基本信息
function syncUserBaseInfo() {
    $(".name").text(userName);
    $(".con[node-type='username_view']").html(userName+'<a href="javascript:void(0);" class="updatePwd">&nbsp;&nbsp;修改密码</a>');
    $(".con[node-type='nickname_view']").text(userName);
    $(".con[node-type='city_view']").text(cityinfo);
    $(".con[node-type='sex_view']").text(userSex);
    $("#userSex").text(userSex);
    $(".con[node-type='love_view']").text(userMarry);
    $(".con[node-type='birth_view']").text(userBirthday);
    $(".con[node-type='desc_view']").text(userDes);
    $(".pf_intro a").text(userDes);
    $(".city").text(cityinfo);
    $(".city").attr("title", cityinfo);
    $("#usersex").html(userSex == "男" ? "<em class='W_ico12 male' title='男'></em>" : "<em class='W_ico12 female' title='女'></em>");
}

function getUsersex() {
    if ($("#man_radio").attr("value") == $("#userSex").text()) {
        $("#man_radio").prop('checked', true);
        $("#woman_radio").prop('checked', false);
        $(".man_radio").attr('state', '1');
        $("#woman_radio").attr('state', '0');
    }
    if ($("#woman_radio").attr("value") == $("#userSex").text()) {
        $("#man_radio").prop('checked', false);
        $("#woman_radio").prop('checked', true);
        $(".man_radio").attr('state', '0');
        $("#woman_radio").attr('state', '1');
    }
}
function getUserLove() {
    $("select[node-type='love']").val($("#userLove").text());
}
//验证QQ号码输入的合法性
function checkQQNumber(qqnumber) {
    if (qqnumber.length == 0) {
        return true;
    } else {
        var patt1 = /^[1-9]\d{5,12}$/;
        return patt1.test(qqnumber);
    }
}
//验证手机号码输入的合法性
function checkTelNumber(telnumber) {
    if (telnumber.length == 0) {
        return true;
    } else {
        var patt2 = /^1[3|4|5|8][0-9]\d{8}$/;
        return patt2.test(telnumber);
    }
}
//如果个人中心页不是当前登陆用户的个人中心页，则按照另一种方式显示
function showQSuserinfo() {
    var loginUserid = $("#loginUserid").text();
    var qsuserid = $("#userid").text();
    if (loginUserid != qsuserid) {
        $(".change_btn_div").remove();
        $(".editBtn").remove();
        $(".updatePwd").remove();
        $(".btn_bed").css("visibility", "hidden");
        $("[action-type='quickedit']").parent().html("<a>该用户尚未填写此信息！</>");
        if ($(".pf_intro a").text() == "一句话介绍一下自己吧，让别人更了解你") {
            $(".pf_intro").html("<a style='color:#ccc'>这个人很懒，还没有填写个人简介</>");
        }
        $(".user_atten").find("a").attr("href", "javascript:void(0);");
    }
}
//清除修改秘密区的输入信息
function clearInputInfo() {
    $(".remindInfo").html("");
    $(".inputContainer input").val("");
    $(".row span").hide();
}
//裁剪图片预览
function preview(img, selection) {
    var scaleX = 150 / (selection.width || 1);
    var scaleY = 150 / (selection.height || 1);
    $("#previewImg").css({
        "width": Math.round(scaleX * img.width) + 'px',
        "height": Math.round(scaleY * img.height) + 'px',
        "left": '-' + Math.round(scaleX * selection.x1) + 'px',
        "top": '-' + Math.round(scaleY * selection.y1) + 'px'
    });
}
//定义全局变量，保存真实裁剪的图片信息
var x1 = 0, y1 = 0, selectwidth = 150, selectheight = 150;