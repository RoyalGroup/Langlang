<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="starWeibo.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/login.css" rel="stylesheet" />
    <title>星空登录</title>
</head>
<body>
    <form id="form1" runat="server">
     <div id="login">
        <div class="logo">
            <img src="images/login/shoulashou.jpg" />
        </div>
        <div class="loginleft">
            <div class="llTop">还没有星空账号？现在加入
                <a href="register.aspx" class="btn-red">立即注册</a>
            </div>
            <div class="show-img"><img src="images/login/sdnkfdsajff.png"/></div>
        </div>
	    <div class="loginright">
            <div class="header">
                <div class="left">用户登录</div>
                <div class="right"><a href="#">管理员登录>></a></div>
            </div>
            <div class="user">
               <div class="userName">用户名：</div>
               <input runat="server" id="username" type="text" value="用户名/邮箱" onfocus="if(this.value=='用户名/邮箱') {this.value=''}" onblur="if(this.value=='') {this.value='用户名/邮箱'}" class="user-input" />
            </div>
             <div class="password">
               <div class="pwd">密 &nbsp 码：</div>
               <input runat="server" id="userpwd" type="text" value="请输入密码" onfocus="if(this.value=='请输入密码') {this.value=''}" onblur="if(this.value=='') {this.value='请输入密码'}" class="pwd-input"/>
            </div>
            <div class="rem-for">
                <div class="remember-pwd">
                    <input type="checkbox" />
                    <span>记住密码</span>
                </div>
                <div class="forget-pwd">
                    <a href="get-pwd.html">忘记密码？</a>
                </div>
            </div>
            <%--<div class="denglu-but">
                <a href="#">登录</a>
            </div>--%>
            <asp:Button ID="btnlogin" runat="server" Text="登录" class="denglu-but" ForeColor="White" Font-Size="15px" Font-Names="微软雅黑" OnClick="btnlogin_Click" />
            <div class="register">
                <span>还没有账号?</span>
                <a href="register.aspx">立即注册！</a>
            </div>
        </div>
       <!--  <div class="footer">
            <div class="help-link">
                <a href="#">关于微博</a>
                <span>|</span>
                <a href="#">关于微博</a>
                <span>|</span>
                <a href="#">关于微博</a>
                <span>|</span>
                <a href="#">关于微博</a>
                <span>|</span>
                <a href="#">关于微博</a>
                <span>|</span>
                <a href="#">关于微博</a>
                <span>|</span>
                <a href="#">关于微博</a>
            </div>
        </div> -->
    </div>
    </form>
</body>
</html>
