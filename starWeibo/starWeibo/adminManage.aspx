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
<div class="Content">
		<div class="ContentT">
			<span class="welcome">欢迎您：</span>
			<span class="user">Admin1</span>
			<span class="zhuxiao">注销</span>
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
					<div class="ReportOne">
						<div class="ReportTitle">
							<div class="Reporter">
								<span>举报人：</span>
								<span>hello</span>
							</div>
							<div class="BReporter">
								<span>被举报人：</span>
								<span>haha</span>
							</div>
							<div class="ReportTime">
								<span>举报时间：</span>
								<span>2014-10-13 11:26</span>
							</div>
							<div class="Reason">
								<span>举报原因：</span>
								<span>不健康。</span>
							</div>
						</div>
						<div class="ReportContent"></div>
						<div class="ReportManage">
							<div class="hulue">忽略</div>
							<div class="Delete">删除</div>
							<div class="jinyan">禁言</div>
						</div>
					</div>
					<div class="ReportOne">
						<div class="ReportTitle">
							<div class="Reporter">
								<span>举报人：</span>
								<span>hello</span>
							</div>
							<div class="BReporter">
								<span>被举报人：</span>
								<span>haha</span>
							</div>
							<div class="ReportTime">
								<span>举报时间：</span>
								<span>2014-10-13 11:26</span>
							</div>
							<div class="Reason">
								<span>举报原因：</span>
								<span>不健康。</span>
							</div>
						</div>
						<div class="ReportContent"></div>
						<div class="ReportManage">
							<div class="hulue">忽略</div>
							<div class="Delete">删除</div>
							<div class="jinyan">禁言</div>
						</div>
					</div>
					<div class="ReportOne">
						<div class="ReportTitle">
							<div class="Reporter">
								<span>举报人：</span>
								<span>hello</span>
							</div>
							<div class="BReporter">
								<span>被举报人：</span>
								<span>haha</span>
							</div>
							<div class="ReportTime">
								<span>举报时间：</span>
								<span>2014-10-13 11:26</span>
							</div>
							<div class="Reason">
								<span>举报原因：</span>
								<span>不健康。</span>
							</div>
						</div>
						<div class="ReportContent"></div>
						<div class="ReportManage">
							<div class="hulue">忽略</div>
							<div class="Delete">删除</div>
							<div class="jinyan">禁言</div>
						</div>
					</div>
					<div class="ReportOne">
						<div class="ReportTitle">
							<div class="Reporter">
								<span>举报人：</span>
								<span>hello</span>
							</div>
							<div class="BReporter">
								<span>被举报人：</span>
								<span>haha</span>
							</div>
							<div class="ReportTime">
								<span>举报时间：</span>
								<span>2014-10-13 11:26</span>
							</div>
							<div class="Reason">
								<span>举报原因：</span>
								<span>不健康。</span>
							</div>
						</div>
						<div class="ReportContent"></div>
						<div class="ReportManage">
							<div class="hulue">忽略</div>
							<div class="Delete">删除</div>
							<div class="jinyan">禁言</div>
						</div>
					</div>
					<div class="ReportOne">
						<div class="ReportTitle">
							<div class="Reporter">
								<span>举报人：</span>
								<span>hello</span>
							</div>
							<div class="BReporter">
								<span>被举报人：</span>
								<span>haha</span>
							</div>
							<div class="ReportTime">
								<span>举报时间：</span>
								<span>2014-10-13 11:26</span>
							</div>
							<div class="Reason">
								<span>举报原因：</span>
								<span>不健康。</span>
							</div>
						</div>
						<div class="ReportContent"></div>
						<div class="ReportManage">
							<div class="hulue">忽略</div>
							<div class="Delete">删除</div>
							<div class="jinyan">禁言</div>
						</div>
					</div>
				</div>
			</div>
			<div class="Right2">
				<div class="Title">用户权限管理</div>
				<div class="UserManagesMain">
					<div class="tool">
						<div class="tool_left">
							<a href="###" class="quan">全禁</a>
							<a href="###" class="fasong">发微博</a>
							<a href="###" class="zan">赞</a>
							<a href="###" class="pinglun">评论</a>
							<a href="###" class="at">@</a>
							<a href="###" class="guanzhu">关注</a>
							<a href="###" class="jubao">举报</a>
							<a href="###" class="zhuanfa">转发</a>
							<a href="###" class="shoucang">收藏</a>
						</div>
						<div class="tool_center">
							<a href="###" class="kquan">全解</a>
							<a href="###" class="kfasong">解发微博</a>
							<a href="###" class="kzan">解赞</a>
							<a href="###" class="kpinglun">评论</a>
							<a href="###" class="kat">解@</a>
							<a href="###" class="kguanzhu">解关注</a>
							<a href="###" class="kjubao">解举报</a>
							<a href="###" class="kzhuanfa">解转发</a>
							<a href="###" class="kshoucang">解收藏</a>
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
						<table cellspaceing="0" cellpadding="0" class="t">
							<tr>
								<td class="t1">
									<input type="checkbox" title="选中/取消选中"class="selectOne"/>
								</td>
								<td class="t2">
									<a href="###">张三</a>
								</td>
								<td class="t3">
									<a href="###">1635232389@qq.com</a>
								</td>
								<td class="t4">
									<input type="checkbox" title="选中/取消选中"class="select"/>
								</td>
								<td class="t5">
									<input type="checkbox" title="选中/取消选中"class="select"/>
								</td>
								<td class="t6">
									<input type="checkbox" title="选中/取消选中"class="select"/>
								</td>
								<td class="t7">
									<input type="checkbox" title="选中/取消选中"class="select"/>
								</td>
								<td class="t8">
									<input type="checkbox" title="选中/取消选中"class="select"/>
								</td>
								<td class="t9">
									<input type="checkbox" title="选中/取消选中"class="select"/>
								</td>
								<td class="t10">
									<input type="checkbox" title="选中/取消选中"class="select"/>
								</td>
								<td class="t11">
									<input type="checkbox" title="选中/取消选中"class="select"/>
								</td>
							</tr>
						</table>
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
				<a href="###" class="S_func1"></a>　
				<a class="S_func1" href="###">友情链接</a>　
				<a class="S_func1" href="###">网站地图</a>　
				<a class="S_func1" href="###">京ICP备12002058号</a>　
				<a class="S_func1" href="###">京网文[2011]0398-130号</a>　
				<a class="S_func1" href="###">ROYAL小组</a>　
			</div>
		</div>
	</div>
</body>
</html>
