<%@ Page Title="" Language="C#" MasterPageFile="~/starweiboM.Master" AutoEventWireup="true" CodeBehind="playstar.aspx.cs" Inherits="starWeibo.playstar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/playstar.css" rel="stylesheet" />
    <script src="js/jquery-1.9.1.min.js"></script>
    <script src="js/playstar.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Tanchu">
        <span>关注成功</span>
    </div>
    <div class="Tanchu1">
        <span>您已关注</span>
    </div>
    <div class="main_inner">
        <div class="W_main_l">
            <div class="left_commen">
                <div class="lev lev-curr">
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
                <div class="lev">
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
                <div class="lev2 lev2-curr">
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
            <div class="MainRight clearfix">
		        <div class="FocusArea">
			        <div class="RightTop">
				        <div class="RTopLeft">玩转微博</div>
			        </div>
			        <div class="RTopMenu">
				        <div class=""></div>
			        </div>
			        <div class="FocusList">
                        <asp:DataList runat="server" ID="focusInfo" RepeatColumns ="3" RepeatLayout ="Table" RepeatDirection ="Horizontal">
                        <ItemTemplate>
					        <div class="FocusCard">
						        <div class="FocusCardS">
							        <div class="HeadImg">
								        <img src="<%# Eval("userHeadimage") %>" class="fanimg"/>
							        </div>
							        <div class="FCardinfo">
                                        <span class="FCardName"><%# Eval("userName") %></span>
                                        <span class="FCardRelation"><%# Eval("userMarry") %>  <%# Eval("userSex") %></span>
                                        <span class="SetNote" friendId="<%# Eval("id") %>" guanzhu="1">关注</span>
							        </div>
						        </div>
						        <div class="FocusCardX">
							        <div class="personalInfo"><%# Eval("userDes") %></div>
						        </div>
					        </div>
                        </ItemTemplate>
                        </asp:DataList>
			        </div>
		        </div>
	        </div>
        </div>
    </div>

</asp:Content>
