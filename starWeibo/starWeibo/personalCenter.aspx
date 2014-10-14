﻿<%@ Page Title="" Language="C#" MasterPageFile="~/starweiboM.Master" AutoEventWireup="true" CodeBehind="personalCenter.aspx.cs" Inherits="starWeibo.personalCenter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>个人中心</title>
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<meta name="keywords" content="个人中心、资料、动态、相册"/>
	<meta name="description" content="他的微博，他会在这里发布自己的心情、动态、照片，你可以与ta实时互动，给ta留言。快来加入微博，关注喜欢的明星，第一时间知道网络热点，随时随地分享身边的新鲜事儿。"/>
	<link rel="stylesheet" type="text/css" href="css/personalCenter.css"/>
	<script type="text/javascript" src="js/jsAddress.js"></script>
	<script type="text/javascript" src="js/jquery.jSelectDate.js"></script>
	<script type="text/javascript" src="js/personalCenter.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="main">
		<!-- 头部区 -->
		<div class="header">
			<div class="headerPic">
				<div class="pf_use_num" node-type="use_num">
					超过<span class="W_Tahoma W_fb">2000</span>万人正在使用此封面图
				</div>
				<div class="templete_enter">
					<a class="enter" href="javascript:void(0);" title="模板设置"></a>
				</div>
			</div>
			<div class="profile_top">
				<div class="pf_info clearfix">
					<div class="pf_info_left">
						<div>
							<div class="pf_name bsp">
								<span class="name">子胥吾有</span>
							</div>
							<div class="pf_intro bsp">
								<a href="javascript:void(0);">一句话介绍一下自己吧，让别人更了解你</a>
							</div>
							<div class="pf_tags bsp" node-type="info" style="position:relative">
								<div class="tags">
									<a href="javascript:void(0);"><em class="W_ico12 male" title="男"></em></a>
									<span class="W_vline S_line1_c">|</span>
									<a href="javascript:void(0);" class="city" title="江苏 淮安">江苏 淮安</a>
									<span class="W_vline S_line1_c">|</span>
								</div>
							</div>
							<div class="pf_do">
								<div class="btn_bed">
									<a href="javascript:void(0);" class="W_btn_c">
										<span>编辑个人资料</span>
									</a>
								</div>
							</div>
						</div>
					</div>
				</div>
				<div class="pf_head S_bg4 S_line1">
					<div>
						<div class="pf_head_pic">
							<img src="css/images/headimage.jpg">
						</div>
						<ul class="user_atten clearfix user_atten_l">
							<li class="S_line1">
								<a class="S_func1" href="javascript:void(0);">
									<strong node-type="follow">2</strong>
									<span>关注 </span>
								</a>
							</li>
							<li class="follower S_line1">
								<a class="S_func1" name="place" href="javascript:void(0);">
									<strong node-type="fans">16</strong>
									<span>粉丝</span>
								</a>
							</li>
							<li class="W_no_border">
								<a class="S_func1" name="profile_tab" href="javascript:void(0);">
									<strong node-type="weibo">1</strong>
									<span>微博</span>
								</a>
							</li>
						</ul>
					</div>
				</div>
			</div>
		</div>
		<!-- 导航区 -->
		<div id="daohangqu">
			<div class="navTabList S_line5">
				<ul class="pftb_ul S_line1">
					<li class="pftb_itm S_line1">
						<a href="javascript:void(0);" node-type="nav_link" class="pftb_lk S_line5 S_txt1 S_bg1">我的主页</a>
					</li>
					<li class="pftb_itm S_line1">
						<a href="javascript:void(0);" node-type="nav_link" class="pftb_lk S_line5 S_txt1 S_bg1">微博</a>
					</li>
					<li class="pftb_itm S_line1 pftb_itm_A">
						<a href="javascript:void(0);" node-type="nav_link" class="pftb_lk S_line5 S_txt1 S_bg1 S_bg1_A">个人资料</a>
					</li>
					<li class="pftb_itm S_line1">
						<a href="javascript:void(0);" node-type="nav_link" class="pftb_lk S_line5 S_txt1 S_bg1">相册</a>
					</li>
					<li class="pftb_itm S_line1">
						<a href="javascript:void(0);" node-type="nav_link" class="pftb_lk S_line5 S_txt1 S_bg1">我的关注</a>
					</li>
					<li class="pftb_itm pftb_itm_lst S_line1">
						<a href="javascript:void(0);" node-type="nav_link" class="pftb_lk S_line5 S_txt1 S_bg1">更多</a>
					</li>
				</ul>
			</div>
			<!-- 内容区 -->
			<div class="W_profile_main clearfix">
				<div id="personalInfo  clearfix">
					<div class="pIleft">
						<div id="baseInfo">
							<div class="info_title clearfix">
								<span class="midleLine"></span>
								<span class="info_title_name">基本信息</span>
								<span class="editBtn">编辑</span>
							</div>
							<div node-type="base_view" >
								<div class="pf_item clearfix">
									<div class="label S_txt2">登录名</div>
									<div class="con">10***42@qq.com <a href="javascript:void(0);">修改密码</a></div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2">昵&nbsp;&nbsp;称</div>
									<div class="con" node-type="nickname_view">吾有子胥</div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2">所在地</div>
									<div class="con" node-type="city_view">江苏 淮安</div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2"> 性&nbsp;&nbsp;别</div>
									<div class="con" node-type="sex_view">男</div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2">感情状况</div>
									<div class="con" node-type="love_view">
										<a href="javascript:void(0)" action-data="type=love" action-type="quickedit" belong="baseInfo"><i class="W_ico16 icon_edit"></i>马上填写</a>自己的感情状况,让更多的人了解你	 		 
									</div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2">生日</div>
									<div class="con" node-type="birth_view"><a href="javascript:void(0)" action-data="type=birth" action-type="quickedit" belong="baseInfo"><i class="W_ico16 icon_edit"></i>马上填写</a>自己的生日,可以收到更多的生日祝福哦</div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2">简介</div>
									<div class="con" node-type="desc_view"><a href="javascript:void(0)" action-data="type=desc" action-type="quickedit" belong="baseInfo"><i class="W_ico16 icon_edit"></i>马上填写</a>自己的个人介绍,让大家快速了解真实的你</div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2">注册时间</div>
									<div class="con" node-type="desc_view">2014-10-10</div>
								</div>
							</div>
							<div node-type="base" style="display:none">
								<div class="pf_item clearfix">
									<div class="label S_txt2">登录名</div>
									<div class="con">10***42@qq.com <a href="javascript:void(0);">修改密码</a></div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2"><span class="W_error">*</span>昵&nbsp;&nbsp;称</div>
									<div class="con"><input node-type="nickname" action-type="text_copy" action-data="text=请输入昵称" name="nickname" class="W_input " value="吾有子胥"></div>
									<div class="status" node-type="nickname_tip">
										<div style="display:none" class="W_tips clearfix">
											<p class="icon"><span class="icon_succS"></span></p>
										</div>
									</div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2"><span class="W_error">*</span>所在地</div>
									<div class="con">
										<div class="input_sel" node-type="cityselector">
											<select id="cmbProvince"></select>
											<select id="cmbCity"></select>
											<select id="cmbArea"></select>
										</div>
									</div>
									<div class="status" node-type="city_tip">
										<div style="display:none" class="W_tips clearfix">
											<p class="icon"><span class="icon_succS"></span></p>
										</div>
									</div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2"><span class="W_error">*</span>性&nbsp;&nbsp;别</div>
									<div class="con"><div class="input_check"><span class="rsp"><label for="man_radio"><input id="man_radio" name="gender" type="radio" value="m" class="W_radio" checked="checked">男</label></span><span class="rsp"><label for="woman_radio"><input id="woman_radio" name="gender" type="radio" value="f" class="W_radio">女</label></span></div></div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2" node-type="love_label">感情状况</div>
									<div class="con">
										<div class="input_sel">
											<select name="love" node-type="love" init_value="0">
												<option selected value="0">保密</option>
												<option value="1">单身</option>
												<option value="2">求交往</option>
												<option value="3">暗恋中</option>
												<option value="4">暧昧中</option>
												<option value="5">恋爱中</option>
												<option value="6">订婚</option>
												<option value="7">已婚</option>
												<option value="8">分居</option>
												<option value="9">离异</option>
												<option value="10">丧偶</option>
											</select>&nbsp;
										</div>
									</div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2" node-type="birth_label">生日</div>
									<div class="con">
										<div class="input_sel">
											<input type="text" id="birth_sel" class="birth_date" value="1992-1-1" />
										</div>
									</div>
									<div class="status" node-type="birthday_tip">
										<div style="display:none" class="W_tips clearfix">
											<p class="icon"><span class="icon_succS"></span></p>
										</div>
									</div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2" node-type="desc_label">简介</div>
									<div class="con"><textarea name="mydesc" node-type="desc" action-type="text_copy" placeHolder="请输入个人简介" action-data="text=请输入个人简介&amp;must=false" cols="30" rows="10" class="W_input"></textarea></div>
									<div class="status" node-type="desc_tip"><div class="W_tips tips_del clearfix" style="display: none;"></div></div>
								</div>
							</div>
						</div>
					</div>

					<div class="pIright">
						<div id="comInfo">
							<div class="info_title clearfix">
								<span class="midleLine"></span>
								<span class="info_title_name">联系信息</span>
								<span class="editBtn">编辑</span>
							</div>
							<div node-type="com_view">
								<div class="pf_item clearfix">
									<div class="label S_txt2">邮箱</div>
									<div class="con" node-type="email_view">1075737942@qq.com</div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2">QQ</div>
									<div class="con" node-type="qq_view">
									<p><a href="javascript:void(0)" action-type="quickedit" belong="comInfo" action-data="type=qq"><i class="W_ico16 icon_edit"></i>马上填写</a>你的QQ信息</p>
									</div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2">Tel</div>
									<div class="con" node-type="Tel_view">
									<p><a href="javascript:void(0)" action-type="quickedit" belong="comInfo" action-data="type=tel"><i class="W_ico16 icon_edit"></i>马上填写</a>你的电话号码</p>
									</div>
								</div>
							</div>
							<div node-type="com" style="display:none">
								<div class="pf_item clearfix">
									<div class="label S_txt2">邮箱</div>
									<div class="con" node-type="email_view">
										<input type="" name="email" node-type="email" action-type="text_copy" placeHoleder="请输入邮箱地址" action-data="text=请输入邮箱地址&amp;must=false" class="W_input" value="1075737942@qq.com">
									</div>
									<div class="status" node-type="email_tip"><div style="display:none" class="W_tips tips_del clearfix"></div></div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2">QQ</div>
									<div class="con"><input type="" name="qq" node-type="qq" action-type="text_copy" placeHolder="请输入QQ号" action-data="text=请输入QQ号&amp;must=false" class="W_input" value=""></div>
									<div class="status" node-type="qq_tip"><div style="display:none" class="W_tips tips_del clearfix"></div></div>
								</div>
								<div class="pf_item clearfix">
									<div class="label S_txt2">Tel</div>
									<div class="con"><input name="tel" node-type="tel" action-type="text_copy" placeHolder="请输入手机号码" action-data="text=请输入手机号码&amp;must=false" class="W_input " value=""></div>
									<div class="status" node-type="tel_tip"><div style="display:none" class="W_tips tips_del clearfix"></div></div>
								</div>
							</div>
						</div>
						<div id="eduInfo">
							<div class="info_title clearfix">
								<span class="midleLine"></span>
								<span class="info_title_name">教育信息</span>
								<span class="editBtn">编辑</span>
							</div>
							<div node-type="edu_view">
								<div class="pf_item clearfix">
									<div class="label S_txt2">学校</div>
									<div class="con" node-type="school_view">
									<p><a href="javascript:void(0)" action-type="quickedit" belong="eduInfo" action-data="type=msn"><i class="W_ico16 icon_edit"></i>马上填写</a>你的学校信息</p>
									</div>
								</div>
							</div>
							<div node-type="edu" style="display:none">
								<div class="pf_item clearfix">
									<div class="label S_txt2">学校</div>
									<div class="con"><input name="school" node-type="school" action-type="text_copy" placeHolder="请输入您毕业的院校" action-data="text=请输入您毕业的院校&amp;must=false" class="W_input " value=""></div>
									<div class="status" node-type="school_tip"><div style="display:none" class="W_tips tips_del clearfix"></div></div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
</asp:Content>
