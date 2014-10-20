$(function () {
    
	//个人中心头部封面图hover事件
	$(".headerPic").hover(function(){
		$(".pf_use_num").addClass("pf_use_num_display");
	},function(){
		$(".pf_use_num").removeClass("pf_use_num_display");
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
			$("div[node-type='base_view']").css("display","block");
			$("div[node-type='base']").css("display","none");
			$(this).text("编辑");
			
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
			            syncUserBaseInfo();
			            alert("保存成功");
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
			$("div[node-type='com_view']").css("display","block");
			$("div[node-type='com']").css("display","none");
			$(this).text("编辑");

			var id, userMail, QQnumber, userTell;
			id = $("#userid").text();
			userMail = $("input[node-type='email']").val();
			QQnumber = $("input[node-type='qq']").val();
			userTell = $("input[node-type='tel']").val();
			$.ajax({
			    type: "POST",   //访问WebService使用Post方式请求
			    contentType: "application/json", //WebService 会返回Json类型
			    url: "webservice/wspersonal.asmx/updateUserCominfo", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
			    data: "{ id:'" + id + "',userMail:'" + userMail + "',QQnumber:'" + QQnumber + "',userTell:'" + userTell + "'}",
			    dataType: 'json',
			    success: function (result) {     //回调函数，result，返回值
			        if (result.d == 'True') {
			            $(".con[node-type='email_view']").text(userMail);
			            $(".con[node-type='qq_view']").text(QQnumber);
			            $(".con[node-type='Tel_view']").text(userTell);
			            alert("保存成功");
			        }
			    }
			});
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
			            alert("保存成功");
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
});

var id, userName, userAddress, userSex, userMarry, userBirthday, userDes;
function syncUserBaseInfo() {
    $(".name").text(userName);
    $(".con[node-type='username_view']").text(userName);
    $(".con[node-type='nickname_view']").text(userName);
    $(".con[node-type='city_view']").text(cityinfo);
    $(".con[node-type='sex_view']").text(userSex);
    $(".con[node-type='love_view']").text(userMarry);
    $(".con[node-type='birth_view']").text(userBirthday);
    $(".con[node-type='desc_view']").text(userDes);
    $(".pf_intro").text(userDes);
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
    $("select[name='love']").val() = $("#userLove").text();
}

function checkQQNumber(qqnumber) {
    var patt1 = new RegExp("[0-9]{6,13}|''");
    return patt1.test(qqnumber);
}