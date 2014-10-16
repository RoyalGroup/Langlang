﻿<%@ Page Title="" Language="C#" MasterPageFile="~/starweiboM.Master" AutoEventWireup="true" CodeBehind="focus.aspx.cs" Inherits="starWeibo.focus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="css/focus.css" />
	<script type="text/javascript" src="js/focus.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <!-- 主体 -->
	<div class="MainBody">
		<div class="MainBodyIn">
			<div class="MainLeft">
				<div class="LeftTop">
					<div class="LeftTopIn">关注中心</div>
				</div>
				<div class="Focus">
					<ul class="FocusIn">
						<li class="FocusLi Fotitle">关注</li>
						<li class="FocusLi FoAll">
							<div class="FoAllL">全部关注</div>
							<div class="FoAllR">
                                <%
                                    string FocusAllCount="("+focuscount.ToString()+")";
                                    Response.Write(FocusAllCount);
                                     %>
							</div>
						</li>
                           <%
                               int i = 0;
                               foreach (starweibo.Model.relationGroupInfo groupinfo in MgroupInfo)
                               {
                                    string html = "<li class='FocusLi'> <div class='FocusLiL'>" + groupinfo.groupName + "</div> <div class='FocusLiR'>(" + groupcount[i] + ")</div></li>";
                                    Response.Write(html);
                                    i++;
                                }
                                    %>
						<li class="FocusLi">
							<div class="FocusLiL">未分组</div>
							<div class="FocusLiR">
                                <%
                                    Response.Write("("+notgroupcount+")");
                                    %>
							</div>
						</li>
					</ul>
						<div class="CreateGroup">创建分组</div>
				</div>
				<ul class="Fans">
					<li class="FocusLi  Fanstitle">粉丝</li>
					<li class="FocusLi FoAll">
						<div class="FoAllL">全部粉丝</div>
						<div class="FoAllR">
						</div>
					</li>
				</ul>
			</div>
			<div class="MainRight">
		<!-- 关注 -->
			<div class="FocusArea">
				<div class="RightTop">
					<div class="RTopLeft">全部关注</div>
					<div class="RTopRight">
                        <% Response.Write(FocusAllCount); %>
					</div>
				</div>
				<div class="RTopMenu">
					<div class=""></div>
				</div>
				<div class="FocusList">
					<div class="FocusCard">
						<div class="FocusCardS">
							<div class="HeadImg">
								<img src="images/focusimg/headpic/1.jpg" />
							</div>
							<div class="FCardinfo">
								<span class="FCardName">hollis</span>
								<span class="FCardRelation">已关注</span>
								<span class="FCardGroup">未分组</span>
								<div class="GroupCard">
									<div class="GroupCardT">请选择分组:</div>
									<ul class="GroupCardM">
										<li class="GroupCardMLi">
											<input type="checkbox" class="GroupCheck"/>
											<div class="GroupName">特别关注</div>
										</li>
										<li class="GroupCardMLi">
											<input type="checkbox" class="GroupCheck"/>
											<div class="GroupName">同学</div>
										</li>
										<li class="GroupCardMLi">
											<input type="checkbox" class="GroupCheck"/>
											<div class="GroupName">家人</div>
										</li>
									</ul>
                                    <div class="BtnSureGroup">
                                        <div class="BtnSureGroupIn">确定</div>
                                    </div>
									<div class="GroupCardB">创建新分组</div>
								</div>
							</div>
						</div>
						<div class="FocusCardX">
							<div class="OwnActions">
								<span class="SetNote">设置备注</span>
								<span>|</span>
								<span class="CancelFocus">取消关注</span>
							</div>
							<div class="personalInfo">暂无个人简介。</div>
						</div>
					</div>
				</div>
			</div>
		<!-- 粉丝 -->
			<div class="FansArea">
				<div class="FansRightTop">已有3人关注了你</div>
				<div class="RTopMenu"></div>
				<div class="FansList">
					<div class="FansLi">
						<div class="FansLiL">
							<div class="FansHeadImg">
							    <img src="images/focusimg/headpic/2.jpg" />
							</div>
						</div>
						<div class="FansLiR">
							<div class="FansLiRTop">
								<div class="FansLiRTopL">
									<span class="FansName">萝莉蓓蓓你啊</span>
									<span class="FansAddress">河南</span>
								</div>
								<div class="FansLiRTopR">
									<span class="BtnFocusFans">关注</span>
                                    <span class="DeleFans">移除粉丝 </span>
                                    <span class="ReportFans">举报</span>
                                    <div class="EnsureDeleFans">
                                        <div class="EnsDeleFansTop">确认要移除萝莉蓓蓓啊?</div>
                                        <div class="EnsDeleFansBot">
					                        <div class="EnsDeleFansBotBtn1">确定</div>
					                        <div class="EnsDeleFansBotBtn2">取消</div>
				                        </div>
                                    </div>
								</div>
							</div>
							<ul class="FansLiRMid">
								<li class="FansInfoli">
									<span class="FansInfoliL">关注</span>
									<span class="FansInfoliR">14</span>
								</li>
								<li class="FansInfoli">
									<span class="FansInfoliL">粉丝</span>
									<span class="FansInfoliR">36</span>
								</li>
							</ul>
							<div class="FansLiRBot">更多</div>
						</div>
					</div>
				</div>
			</div>
			</div>
		</div>
	</div>
	<div class="SetNoteMeng">
			<div class="SetNoteCard">
				<div class="SetNoteCardTop">设置备注名</div>
				<div class="SetNoteCardMid">
					<div class="SetNoteCardMidL">备注名：</div>
					<input type="text" class="SetNoteCardMidR" value="请输入备注名" />
				</div>
				<div class="SetNoteCardBot">
					<div class="SetNoteCardBtn1">确定</div>
					<div class="SetNoteCardBtn2">取消</div>
				</div>
			</div>
	</div>
	<div class="CancelFocusMeng">
			<div class="CancelFocusCard">
				<div class="CancelFocusCardTop">取消关注</div>
				<div class="CancelFocusCardMid">确认要取消对华晨宇yu的关注吗？</div>
				<div class="CancelFocusCardBot">
					<div class="CancelFocusCardBtn1">确定</div>
					<div class="CancelFocusCardBtn2">取消</div>
				</div>
			</div>
	</div>
</asp:Content>
