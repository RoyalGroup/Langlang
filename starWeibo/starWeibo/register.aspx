﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="starWeibo.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/register.css" rel="stylesheet" />
    <script src="js/jquery-1.9.1.min.js"></script>
    <script src="js/register.js"></script>
    <title>星空注册</title>
</head>
<body>
    <div class="tanchu">
        <div class="tanchuTop"></div>
        <div class="tanchuBtm">
            <a>验证码已发送到您的邮箱，请查看您的邮件！</a>
        </div>
    </div>
    <div class="tanchu1">
        <div class="tanchu1Top"></div>
        <div class="tanchu1Btm">
            <a>注册成功！</a>
        </div>
    </div>
    <div class="tanchu2">
        <div class="tanchu2Top"></div>
        <div class="tanchu2Btm">
            <a>请重新输入正确的注册资料！</a>
        </div>
    </div>
    <div class="tanchu3">
        <div class="tanchu3Top"></div>
        <div class="tanchu3Btm">
            <a>请输入正确邮箱！</a>
        </div>
    </div>
    <div class="tanchu4">
        <div class="tanchu4Top"></div>
        <div class="tanchu4Btm">
            <a>请输入正确的昵称！</a>
        </div>
    </div>
    <div class="tanchu5">
        <div class="tanchu5Top"></div>
        <div class="tanchu5Btm">
            <a>请输入正确邮箱！</a>
        </div>
    </div>
    <div class="tanchu6">
        <div class="tanchu6Top"></div>
        <div class="tanchu6Btm">
            <a>请输入正确密码！</a>
        </div>
    </div>
     <div class="registerA">
		<div class="registerTop">新用户注册</div>
		<div class="register-form">
					<ul>
						<li>
							    <div class="name1">昵称：</div>
								<input class="text_input nicheng" type="text"  name="uername" />
								<div class="tishi ts1">请输入2到16位字符的用户名</div>
						</li>
						<li>
								<div class="name1">安全邮箱：</div>
								<input class="text_input youxiang" type="text"  name="uername" a="1"/>
								<div class="tishi ts2">请输入常用邮箱名</div>
						</li>
                        <li class="yincang">
								<div class="yanzheng">进行邮箱验证</div>
						</li>
						<li>
								<div class="name1">密码：</div>
								<input class="text_input mima" type="password"  name="uername"  autocomplete="off"/>
								<div class="tishi ts3">请输入1到20位密码，区分大小写</div>
						</li>
						<li>
								<div class="name1">确认密码：</div>
								<input class="text_input queren" type="password"  name="uername"  autocomplete="off"/>
								<div class="tishi ts4">请输入与上面一致的密码</div>
						</li>
						<li>
								<div class="name1">验证码：</div>								
								<input class="text_input yanzhengma" type="text" yanzhengnum=""  name="uername"  autocomplete="off"/>
								<div class="tishi ts5">请输入邮箱收到的验证码</div>
						</li>
					</ul>
					<div class="check">
							<input type="checkbox" checked="checked"  name="use_active_code"/>
							<span>我阅读并接受《星空微博服务协议条款》</span>
					</div>
					<div class="finishzhuce">
						<a>立即注册并登录</a>
					</div>
		</div>
		<div class="register-know">
			<div class="direct-login">已有账号，<a href="login.aspx">直接登录>></a></div>
			<p>微博注册帮助</p>
			<div class="reg_help">
			<ul>
				<li>
					<span>1.</span>
					<a href="#">微博注册操作指南</a>
				</li>
				<li>
					<span>2.</span>
					<a href="#">注册时提示"你所使用的IP地址异常",该怎么办？</a>
				</li>
				<li>
					<span>3.</span>
					<a href="#">企业用户希望使用的微博昵称不能注册怎么办？</a>
				</li>
				<li>
					<span>4.</span>
					<a href="#">注册后，是否可以找回被其他人占用的企业昵称？</a>
				</li>
			</ul>
			<a href="#" class="help_more">更多帮助»</a>
		</div>
		</div>
	</div>
</body>
</html>
