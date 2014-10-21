$(function () {
    
	//个人中心头部封面图hover事件
	$(".headerPic").hover(function(){
		$(".pf_use_num").addClass("pf_use_num_display");
	},function(){
		$(".pf_use_num").removeClass("pf_use_num_display");
	});

    //修改头像
	$(".pf_head_pic").hover(function () {
	    $(".change_btn_div").css("display","block");
	}, function () {
	    $(".change_btn_div").css("display", "none");
	});

	//内容区导航栏切换
	$(".pftb_itm").click(function(){
		$(".pftb_itm").removeClass("pftb_itm_A");
		$(".pftb_itm").find(".S_bg1").removeClass("S_bg1_A");
		$(this).addClass("pftb_itm_A");
		$(this).find(".S_bg1").addClass("S_bg1_A");
	});

	//文本框获得焦点和失去焦点的事件
	$(".W_input").focus(function(){
		$(this).css({"border-color":"#ff4a00","color":"#333"})
	});
	$(".W_input").blur(function(){
		$(this).css({"border-color":"","color":""})
	});
	
	//初始化所在地区
	addressInit('cmbProvince', 'cmbCity', 'cmbArea', $("#Province").text(), $("#City").text(), $("#Area").text());
	//应用方法
	$("input.birth_date").jSelectDate({
		css:"birth_date",
		yearBeign: 1995,
		disabled : false,
		showLabel : false
	});

	
	//编辑保存基本信息
	$("#baseInfo .editBtn").click(function(){
		var state = $(this).text();
		if(state=='编辑'){
			$("div[node-type='base_view']").css("display","none");
			$("div[node-type='base']").css("display","block");
			$(this).text("保存");
			getUsersex();
			getUserLove();
		}
		if(state=='保存'){
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
			            $(".saveInfo").fadeIn(1000).fadeOut(1000);
			        }
			    }
			});
		}
	});
	//编辑保存联系信息
	$("#comInfo .editBtn").click(function(){
		var state = $(this).text();
		if(state=='编辑'){
			$("div[node-type='com_view']").css("display","none");
			$("div[node-type='com']").css("display","block");
			$(this).text("保存");
		}
		if(state=='保存'){
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
			                    $(".saveInfo").fadeIn(1000).fadeOut(1000);
			                }
			            }
			        });
			    } else {
			        alert("手机号输入不合法，请重试！")
			    }
			} else {
                alert("QQ号输入不合法，请重试！")
			}
		}
	});
	//编辑保存教育信息
	$("#eduInfo .editBtn").click(function(){
		var state = $(this).text();
		if(state=='编辑'){
			$("div[node-type='edu_view']").css("display","none");
			$("div[node-type='edu']").css("display","block");
			$(this).text("保存");
		}
		if(state=='保存'){
			$("div[node-type='edu_view']").css("display","block");
			$("div[node-type='edu']").css("display","none");
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
			            $(".saveInfo").fadeIn(1000).fadeOut(1000);
			        }
			    }
			});
		}
	});
	//快速编辑
	$(document).on("click","[action-type='quickedit']",function(){
		var belong = $(this).attr("belong");
		$("#"+belong).find(".editBtn").click();
	});

    //选择性别
	$(".W_radio").click(function () {
	    $(".W_radio").attr('state', '0');
	    $(this).attr('state', '1');
	});

    //输入QQ号时检测其合法性
	$("input[node-type='qq']").keyup(function(){
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
});
//定义变量
var id, userName, userAddress, userSex, userMarry, userBirthday, userDes;
var qqIsRight = true, telIsRight = true;
//同步用户基本信息
function syncUserBaseInfo() {
    $(".name").text(userName);
    $(".con[node-type='username_view']").text(userName);
    $(".con[node-type='nickname_view']").text(userName);
    $(".con[node-type='city_view']").text(cityinfo);
    $(".con[node-type='sex_view']").text(userSex);
    $(".con[node-type='love_view']").text(userMarry);
    $(".con[node-type='birth_view']").text(userBirthday);
    $(".con[node-type='desc_view']").text(userDes);
    $(".pf_intro a").text(userDes);
    $(".city").text(cityinfo);
    $(".city").attr("title", cityinfo);
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
        var patt1 = /^[1-9]\d{5,12}$/;;
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