<%@ Page Title="" Language="C#" MasterPageFile="~/starweiboM.Master" AutoEventWireup="true" CodeBehind="focus.aspx.cs" Inherits="starWeibo.focus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="css/focus.css" />
	<script type="text/javascript" src="js/focus.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <!-- 主体 -->
	<div class="MainBody">
        <div class="Tanchu">
            <span>关注成功</span>
        </div>
        <div class="Tanchu1">
            <span>您已关注</span>
        </div>
		<div class="MainBodyIn">
			<div class="MainLeft">
				<div class="LeftTop">
					<div class="LeftTopIn">关注中心</div>
				</div>
				<div class="Focus">
					<ul class="FocusIn">
						<li class="leftbtn Fotitle">关注</li>
						<li class="leftbtn FoAll">
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
                                   string html = "<li class='leftbtn FocusLi' groupname='" +groupinfo.groupName + "'> <div class='FocusLiL'>" + groupinfo.groupName + "</div> <div class='FocusLiR'>(" + groupcount[i] + ")</div></li>";
                                    Response.Write(html);
                                    i++;
                                }
                                    %>
					</ul>
						<div class="CreateGroup">创建分组</div>
				</div>
				<ul class="Fans">
					<li class="leftbtn FocusLi  Fanstitle">粉丝</li>
					<li class="leftbtn FansAll">
						<div class="FoAllL">全部粉丝</div>
						<div class="FoAllR"><% Response.Write("("+fanscount+")"); %></div>
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
                    <asp:DataList runat="server" ID="focusInfo" RepeatColumns ="3" RepeatLayout ="Table" RepeatDirection ="Horizontal">
                    <ItemTemplate>
					    <div class="FocusCard" fcardname="<%# Eval("groupName") %>" friendId="<%# Eval("friendId") %>" name="<%# Eval("FriendNoteName") %>">
						    <div class="FocusCardS">
							    <div class="HeadImg">
								   <img src="<%# Eval("userHeadimage") %>" class="fanimg"/>
							    </div>
							    <div class="FCardinfo">
								    <span class="FCardName"><%# Eval("FriendNoteName") %></span>
								    <span class="FCardRelation">已关注</span>
								    <span class="FCardGroup"><%# Eval("groupName") %></span>
            
								    <div class="GroupCard">
                                       
									    <div class="GroupCardT">请选择分组:</div>
                                        <div class="GroupCardM">
                                            <% foreach (starweibo.Model.relationGroupInfo groupfocus in MgroupInfo) { 
                                                string html="";
                                                html += "<li class='GroupCardMLi'>";
                                                html += "<input type='checkbox' class='GroupCheck'groupid=" + groupfocus.id+ " />";
                                                html += "<div class='GroupName'>"+groupfocus.groupName+"</div>";
                                                html += "</li>";
                                                Response.Write(html);
                                            } %>
                                        </div>
                                        <div class="BtnSureGroup">
                                            <div class="GroupCardB">创建新分组</div>
                                            <div class="BtnSureGroupIn">确定</div>
                                        </div>
									    
								    </div>
							    </div>
						    </div>
						    <div class="FocusCardX">
							    <div class="OwnActions">
								    <span class="SetNote">设置备注</span>
								    <span>|</span>
								    <span class="CancelFocus">取消关注</span>
							    </div>
							    <div class="personalInfo"><%# Eval("userDes") %></div>
						    </div>
					    </div>
                    </ItemTemplate>
                    </asp:DataList>
				</div>
			</div>
		<!-- 粉丝 -->
			<div class="FansArea">
				<div class="FansRightTop">已有3人关注了你</div>
				<div class="RTopMenu"></div>
				<div class="FansList">
                    <asp:DataList runat="server" ID="fansinfomation" RepeatColumns="1" RepeatLayout="table">
                    <ItemTemplate>
					    <div class="FansLi">
						    <div class="FansLiL">
							    <div class="FansHeadImg">
							        <img src="<%# Eval("fansHeadimage") %>" class="fanimg"/>
							    </div>
						    </div>
						    <div class="FansLiR">
							    <div class="FansLiRTop">
								    <div class="FansLiRTopL">
									    <span class="FansName"><%# Eval("fansName") %></span>
									    <span class="FansAddress"><%# Eval("fansAddress")%></span>
								    </div>
								    <div class="FansLiRTopR">
									    <span class="BtnFocusFans" userId="<%# Eval("userId") %>">关注</span>
                                        <span class="DeleFans" userId="<%# Eval("userId") %>">移除粉丝 </span>
                                        <span class="ReportFans" userId="<%# Eval("userId") %>">举报</span>
                                        <div class="EnsureDeleFans">
                                            <div class="EnsDeleFansTop">确认要移除<%# Eval("fansName") %>?</div>
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
                   </ItemTemplate>
                   </asp:DataList>
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
                <input class="CancelFocusCardMid" type="text"/>
				<%--<div class="CancelFocusCardMid"></div>--%>
				<div class="CancelFocusCardBot">
					<div class="CancelFocusCardBtn1">确定</div>
					<div class="CancelFocusCardBtn2">取消</div>
				</div>
			</div>
	</div>
</asp:Content>
