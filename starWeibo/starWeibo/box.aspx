<%@ Page Title="" Language="C#" MasterPageFile="~/starweiboM.Master" AutoEventWireup="true" CodeBehind="box.aspx.cs" Inherits="starWeibo.box" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/box.css" rel="stylesheet"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main_inner">
    <div class="W_main_l">
			<div class="left_commen">
				<div class="lev">
					<a href="playstar.aspx">
						<i class="ico20 ico_guide"></i>
						新手指南
					</a>
				</div>
				<div class="lev">
					<a href="homePage.aspx">
						<i class="ico20 ico_home"></i>
						首页
					</a>
				</div>
				<div class="lev lev-curr">
					<a href="box.aspx">
						<i class="ico20 ico_msg"></i>
						消息
					</a>
				</div>
				<div class="lev2">
					<a href="weibo.aspx">
						<i class="ico20 ico_at"></i>
						提到我的
					</a>
				</div>
				<div class="lev2">
					<a href="comment.aspx">
						<i class="ico20 ico_comment"></i>
						评论
					</a>
				</div>
				<div class="lev2">
					<a href="zan.aspx">
						<i class="ico20 ico_zan"></i>
						赞
					</a>
				</div>
				<div class="lev2">
					<a href="message.aspx">
						<i class="ico20 ico_letter"></i>
						私信
					</a>
				</div>
				<div class="lev2">
					<a href="#">
						<i class="ico20 ico_leave"></i>
						未关注人私信
					</a>
				</div>
				<div class="lev">
					<a href="#">
						<i class="ico20 ico_collect"></i>
						收藏
					</a>
				</div>
			</div>
			<div class="left_group"></div>
		</div>
	<div class="W_main_a">
			<div class="plc_main">
				<div class="W_main_c">
					<div class="pl_content_box">
						<div class="group_read">消息</div>
						<div class="tab_normal">
							<div class="tab_normal_l">
								<a href="javascript:void(0);" class="W_btn_a">
									<span>
										<em class="icon_mes"></em>
										发私信
									</span>
								</a>
								<a href="javascript:void(0);" class="W_btn_b">
									<span>全部设为已读</span>
								</a>
							</div>
							<div class="tab_normal_r"></div>
						</div>
						<div class="all_msg_list">
							<div class="WB_msg_type">
								<div class="msg_list_node clearfix">
									<div class="id_avatar">
										<img src="images/type/pic_at.png">
									</div>
									<div class="msg_main">
										<div class="msg_title">提到我的</div>
										<div class="msg_detail">
										沈亚洲大神：符合萨芬和@小跳蚤ding
										</div>
									</div>
									<div class="msg_ctrls">
										<span class="S_txt2">10月10日 09:43</span>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
				<div class="W_main_r">
					<div class="helpbox">
						<h3>消息箱使用小帮助</h3>
						<p>Q:什么是消息箱？</p>
						<p>A:是将@我的，评论，赞，私信等消息相关类服务综合在一起的消息中心，在这里可以看到所有的消息提示。</p>
					</div>
				</div>
			</div>
		</div>
    </div>
</asp:Content>
