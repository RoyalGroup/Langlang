<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminLogin.aspx.cs" Inherits="starWeibo.adminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>星空微博后台登陆</title>
    <link rel="stylesheet" type="text/css" href="css/adminLogin.css"/>
	<script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
	<script type="text/javascript" src="js/adminLogin.js"></script>
	<meta charset="utf-8" />
</head>
<body>
    <form runat="server">
        <div class="main">
		    <div class="content">
			    <div class="bd">
				    <span>用户名：</span>
                    <input runat="server" id="adminName" type="text" value="用户名" onfocus="if(this.value=='用户名') {this.value=''}" onblur="if(this.value=='') {this.value='用户名'}" class="txtUserid" />
			    </div>
			    <div class="bd">
				    <span>密&nbsp;&nbsp;&nbsp;码：</span>
                    <input runat="server" id="adminPwd" type="password" value="请输入密码" onfocus="if(this.value=='请输入密码') {this.value=''}" onblur="if(this.value=='') {this.value='请输入密码'}" class="txtUserpwd"/>
			    </div>
                <%
                    if (i==0)
                    {
                       %>
                        <div class="YH"><span>*您输入的用户名不存在请重新输入！</span></div>
                <%
                    }
                    else if(i==1)
                    {
                       %>
                    <div class="MM"><span>*您输入的用户名或密码不正确请重新输入！</span></div>
                <% 
                    }
                     %>
                <%--<div class="YH"><span>*您输入的用户名不存在请重新输入！</span></div>--%>
                <%--<div class="MM"><span>*您输入的用户名或密码不正确请重新输入！</span></div>--%>
			    <div class="btn">
                    <asp:Button ID="btnadminLogin" runat="server" Text="登录" class="btnLogin" OnClick="btnadminLogin_Click"/>
                    <div class="btnRegist">注册</div>
			    </div>
		    </div>
	    </div>
    </form>
</body>
</html>
