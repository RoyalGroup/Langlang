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
    addressInit('cmbProvince', 'cmbCity', 'cmbArea', '未设置', '未设置', '未设置');
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
		}
		if(state=='保存'){
			$("div[node-type='base_view']").css("display","block");
			$("div[node-type='base']").css("display","none");
			$(this).text("编辑");
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
			$.ajax({
			    type: "POST",   //访问WebService使用Post方式请求
			    contentType: "application/json", //WebService 会返回Json类型
			    url: "webservice/wspersonal.asmx/HelloWorld", //调用WebService的地址和方法名称组合 ---- WsURL/方法名
			    data: "{}",         //这里是要传递的参数，格式为 data: "{paraName:paraValue}",下面将会看到       
			    dataType: 'json',
			    success: function (result) {     //回调函数，result，返回值
			        alert(result.d);
			    }
			});
		}
	});
	//快速编辑
	$(document).on("click","[action-type='quickedit']",function(){
		var belong = $(this).attr("belong");
		$("#"+belong).find(".editBtn").click();
	});
});