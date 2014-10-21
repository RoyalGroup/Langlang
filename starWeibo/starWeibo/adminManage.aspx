<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminManage.aspx.cs" Inherits="starWeibo.adminManage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>星空微博后台管理</title>
    <link rel="stylesheet" type="text/css" href="css/adminManage.css"/>
	<script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
	<script type="text/javascript" src="js/adminManage.js"></script>
	<meta charset="utf-8"/>
</head>
<body>
<form runat="server">
<div class="Content">
		<div class="ContentT">
			<span class="welcome">欢迎您：</span>
			<span class="user"><%=Session["adminName"].ToString() %></span>
            <asp:Button ID="btnadminzhuxiao" runat="server" Text="注销" class="zhuxiao" Onclick="btnadminzhuxiao_Click"/>
			<span></span>
		</div>
		<div class="ContentD">
			<div class="Left">
				<div class="Report">举报</div>
				<div class="UserManages">用户权限管理</div>
				<div class="Send">发送公告</div>
			</div>
			<div class="Right1">
				<div class="Title">举报列表</div>
				<div class="ReportMain">
					<asp:Repeater runat="server" ID="rtpreportVList">
                        <ItemTemplate>
					        <div class="ReportOne">
                                <%--<span runat="server" class="yincang"><%#Eval("messageId") %></span>--%>
						        <div class="ReportTitle">
							        <div class="Reporter">
								        <span>举报人：</span>
								        <span><%#Eval("userName") %></span>
							        </div>
							        <div class="BReporter">
								        <span>被举报人：</span>
								        <span><%#Eval("bloguserName") %></span>
							        </div>
							        <div class="ReportTime">
								        <span>举报时间：</span>
								        <span><%#Eval("pubTime") %></span>
							        </div>
							        <div class="Reason">
								        <span>举报原因：</span>
								        <span><%#Eval("msgContent") %></span>
							        </div>
						        </div>
						        <div class="ReportContent"><%#Eval("blogContent") %></div>
						        <div class="ReportManage">
                                    <%--<asp:Button ID="btnHulue" runat="server" Text="忽略" class="hulue" OnClick="btnHulue_Click"/>
                                    <asp:Button ID="btnDelete" runat="server" Text="删除" class="Delete" OnClick="btnDelete_Click"/>
                                    <asp:Button ID="btnJinyan" runat="server" Text="禁言" class="jinyan" OnClick="btnJinyan_Click"/>--%>
                                    <div class="hulue" msgID="<%#Eval("messageId") %>">忽略</div>
							        <div class="Delete" blogID="<%#Eval("blogId") %>">删除</div>
							        <div class="jinyan" userID="<%#Eval("blogAuthorId") %>">禁言</div>
						        </div>
					        </div>
                        </ItemTemplate>
                    </asp:Repeater>
				</div>
			</div>
			<div class="Right2">
				<div class="Title">用户权限管理</div>
				<div class="UserManagesMain">
					<div class="tool">
						<div class="tool_left">
							<a href="###" class="quan">全禁</a>
							<a href="###" id="fasong" class="fa">发微博</a>
							<a href="###" id="zan" class="fa">赞</a>
							<a href="###" id="pinglun" class="fa">评论</a>
							<a href="###" id="at" class="fa">@</a>
							<a href="###" id="guanzhu" class="fa">关注</a>
							<a href="###" id="jubao" class="fa">举报</a>
							<a href="###" id="zhuanfa" class="fa">转发</a>
							<a href="###" id="shoucang" class="fa">收藏</a>
						</div>
						<div class="tool_center">
							<a href="###" class="kquan">全解</a>
							<a href="###" id="kfasong" class="jie">解发微博</a>
							<a href="###" id="kzan" class="jie">解赞</a>
							<a href="###" id="kpinglun" class="jie">评论</a>
							<a href="###" id="kat" class="jie">解@</a>
							<a href="###" id="kguanzhu" class="jie">解关注</a>
							<a href="###" id="kjubao" class="jie">解举报</a>
							<a href="###" id="kzhuanfa" class="jie">解转发</a>
							<a href="###" id="kshoucang" class="jie">解收藏</a>
						</div>
						<div class="tool_right">
							<div class="button">搜索</div>
							<input class="searchInput" type="text" placeholder="用户名"/>
						</div>
					</div>
					<table cellspaceing="0" cellpadding="0" class="t">
						<tr>
							<td class="t1">
								<input type="checkbox" title="选中/取消选中" class="selectAll"/>
							</td>
							<td class="t2">
								<a href="###">用户名</a>
							</td>
							<td class="t3">
								<a href="###">邮箱</a>
							</td>
							<td class="t4">
								<a href="###">赞</a>
							</td>
							<td class="t5">
								<a href="###">评论</a>
							</td>
							<td class="t6">
								<a href="###">@</a>
							</td>
							<td class="t7">
								<a href="###">关注</a>
							</td>
							<td class="t8">
								<a href="###">举报</a>
							</td>
							<td class="t9">
								<a href="###">转发</a>
							</td>
							<td class="t10">
								<a href="###">收藏</a>
							</td>
							<td class="t11">
								<a href="###">发微博</a>
							</td>
						</tr>
					</table>
					<div class="UserManagesContent">
						<asp:Repeater runat="server" ID="rptpowerInfoList" >
                            <ItemTemplate>
						        <table cellspacing="0" cellpadding="0" class="t">
							        <tr id="s<%# Eval("userId") %>">
								        <td class="t1">
									        <input type="checkbox" title="选中/取消选中"class="selectOne" name="selectO"/>
								        </td>
								        <td class="t2">
							                <a href="###"><%# Eval("userName") %></a>
								        </td>
								        <td class="t3">
									        <a href="###"><%# Eval("userMail") %></a>
								        </td>
								        <td class="t4">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("zan") %>" id="zan"/>
								        </td>
								        <td class="t5">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("pinglun") %>" id="pinglun"/>
								        </td>
								        <td class="t6">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("at") %>" id="at"/>
								        </td>
								        <td class="t7">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("guanzhu") %>" id="guanzhu"/>
								        </td>
								        <td class="t8">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("jubao") %>" id="jubao"/>
								        </td>
								        <td class="t9">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("zhuanfa") %>" id="zhuanfa"/>
								        </td>
								        <td class="t10">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("shoucang") %>" id="shoucang"/>
								        </td>
								        <td class="t11">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("fasong") %>" id="fasong"/>
								        </td>     
							        </tr>
						        </table>
                            </ItemTemplate>
                        </asp:Repeater>
					</div>
                    <div class="UserManagesContentS">
						<asp:Repeater runat="server" ID="Repeater1" >
                            <ItemTemplate>
						        <table cellspacing="0" cellpadding="0" class="t">
							        <tr id="s<%# Eval("userId") %>">
								        <td class="t1">
									        <input type="checkbox" title="选中/取消选中"class="selectOne" name="selectO"/>
								        </td>
								        <td class="t2">
							                <a href="###"><%# Eval("userName") %></a>
								        </td>
								        <td class="t3">
									        <a href="###"><%# Eval("userMail") %></a>
								        </td>
								        <td class="t4">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("zan") %>" id="zan"/>
								        </td>
								        <td class="t5">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("pinglun") %>" id="pinglun"/>
								        </td>
								        <td class="t6">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("at") %>" id="at"/>
								        </td>
								        <td class="t7">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("guanzhu") %>" id="guanzhu"/>
								        </td>
								        <td class="t8">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("jubao") %>" id="jubao"/>
								        </td>
								        <td class="t9">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("zhuanfa") %>" id="zhuanfa"/>
								        </td>
								        <td class="t10">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("shoucang") %>" id="shoucang"/>
								        </td>
								        <td class="t11">
									        <input type="checkbox" title="选中/取消选中"class="select" fuzhi="<%#Eval("fasong") %>" id="fasong"/>
								        </td>     
							        </tr>
						        </table>
                            </ItemTemplate>
                        </asp:Repeater>
					</div>
				</div>
			</div>
			<div class="Right3">
				<div class="Title">发送公告</div>
				<div class="SendMain">
					<textarea class="SendContent"  style= "overflow:hidden; resize:none;" placeholder="请输入公告内容"></textarea>
					<div class="SendButton">发送</div>
				</div>
			</div>
		</div>
		<div class="footer">
			<div class="help_link">　
				<a class="S_func1" href="###">友情链接</a>　
				<a class="S_func1" href="###">网站地图</a>　
				<a class="S_func1" href="###">京ICP备12002058号</a>　
				<a class="S_func1" href="###">京网文[2011]0398-130号</a>　
				<a class="S_func1" href="###">ROYAL小组</a>　
			</div>
		</div>
	</div>
</form>
</body>
</html>
