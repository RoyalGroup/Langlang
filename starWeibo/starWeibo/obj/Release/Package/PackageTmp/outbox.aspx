<%@ Page Title="" Language="C#" MasterPageFile="~/starweiboM.Master" AutoEventWireup="true" CodeBehind="outbox.aspx.cs" Inherits="starWeibo.comment.outBox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/outbox.css" rel="stylesheet" />
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
                <div class="lev2 lev2-curr">
                    <a href="#">
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
                        <div class="group_read">
                            <a href="message.aspx" >收到的私信</a>
                            <span>|</span>
                            <a href="outbox.aspx"class="currA">发出的私信</a>                       
                        </div>
                        <div class="comment_list">
                            <asp:DataList runat="server" ID="chatDL">
                                <ItemTemplate>
                                    <div class="comment_feed clearfix">
                                        <div class="face">
                                            <a href="detailmessage.aspx?sendname=<%# Eval("userName") %>&sendid=<%# Eval("id") %>">
                                                <img src="<%# Eval("userHeadimage") %>" />
                                            </a>
                                        </div>
                                        <div class="comment">
                                            <div class="comm_box">
                                                <p>                                                  
                                                    <span>正在和</span>
                                                    <a href="detailmessage.aspx?sendname=<%# Eval("userName") %>&sendid=<%# Eval("id") %>"><%# Eval("userName") %></a>
                                                    <span>火热聊天中</span>
                                                </p>
                                                <p>                                                  
                                                    <%--<a href="#"><%# Eval("msgContent") %></a>--%>
                                                </p>
                                                <p style="margin-top: 6px;">
                                                    <%--<span><%# Eval("pubTime") %></span>--%>
                                                    <a href="detailmessage.aspx?sendname=<%# Eval("userName") %>&sendid=<%# Eval("id") %>" style="float: right">展开</a>
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:DataList>
                        </div>
                    </div>
                </div>
                <div class="W_main_r">
                    <div class="helpbox">
                        <h3>私信使用小帮助</h3>
                        <p>Q:怎么设置私信收发？</p>
                        <p>A:你可以设置是所有人还是只有我关注的人可以给我发私信？</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
