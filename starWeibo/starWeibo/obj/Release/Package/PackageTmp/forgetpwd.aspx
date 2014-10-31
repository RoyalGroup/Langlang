<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgetpwd.aspx.cs" Inherits="starWeibo.forgetpwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>忘记密码</title>
    <link href="css/forgetpwd.css" rel="stylesheet" />
    <script src="js/jquery-1.9.1.min.js"></script>
    <script src="js/forgetpwd.js"></script>
</head>
<body>
    <div class="tubiao"></div>
    <div class="tanchu">
        <div class="tanchuTop"></div>
        <div class="tanchuBtm">
            <a>重置成功!</a>
        </div>
    </div>
    <div class="tanchu1">
        <div class="tanchu1Top"></div>
        <div class="tanchu1Btm">
            <a>请输入您注册时的信息!</a>
        </div>
    </div>
    <div class="tanchu2">
        <div class="tanchu2Top"></div>
        <div class="tanchu2Btm">
            <a>请输入同样的密码!</a>
        </div>
    </div>
    <div class="tanchu3">
        <div class="tanchu3Top"></div>
        <div class="tanchu3Btm">
            <a>请输入正确密码格式!</a>
        </div>
    </div>
    <div class="form">
    	<div class="title">找回密码</div>
    	<ul class="mod-sub-nav">
    		<li class="mod-sub-list1 list1-active">确定账号</li>
    		<li class="mod-sub-list2 ">安全验证</li>
    		<li class="mod-sub-list3 ">重置密码</li>
    	</ul>
    	<div class="forgotse1">
    		<p class="step-email-info">请填写您需要找回的帐号:</p>
    		<div id="pass-auth-select" class="pass-input-container clearfix">
    			<input id="account" type="text" value="" name="username" placeholder="请输入您用户名"/>
    		</div>
    		<input class="pass-button-submit" type="submit" value="确认账号" name=""/>
    	</div>
    	<div class="forgotse2">
    		<p class="step-email-info">请填写您注册时的邮箱:</p>
    		<div id="pass-auth-select1" class="pass-input-container clearfix">
    			<input id="account1" type="text" value="" name="username" placeholder="请输入您注册时的邮箱"/>
    		</div>
    		<input class="pass-button-submit1" type="submit" value="安全验证" name=""/>
    	</div>
    	<div class="forgotse3">
    		<div class="T1">
    			<a>请输入您的密码：</a>
    			<input class="T1R" type="password" placeholder="请输入您的密码"/>
    		</div>
    		<div class="T2">
    			<a>请重新输入您的密码：</a>
    			<input class="T2R" type="password" placeholder="请重新输入您的密码"/>
    		</div>
            <input class="pass-button-submit2" type="submit" value="重置密码" name=""/>
    	</div>
    </div>
</body>
</html>
