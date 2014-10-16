<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgetpwd.aspx.cs" Inherits="starWeibo.forgetpwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/forgetpwd.css" rel="stylesheet" />
    <title>找回密码</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="getpwd">
		<div class="registerTop">用户找回密码</div>
		<div class="zhaohui">
			<ul>
				<li>
					<div class="zhaohuiyouxiang">登陆原邮箱：</div>
					<input class="zhaohui_input" type="text"  name="uername"/>
				</li>
				<li>
					<div class="zhaohuiyouxiang">验 证 码：&nbsp &nbsp</div>
					<input class="validate_code" type="text"  name="uername"/>
					<a href="#"  class="image_code"></a> 
					<a href="#" class="link_notice">看不清？</a> 
				</li>
			</ul>
			<div class="btn_sub">
				<a href="#">发送验证邮件</a>
			</div>
		</div>
	</div>
    </form>
</body>
</html>
