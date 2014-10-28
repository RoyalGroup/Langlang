<%@ Page Title="" Language="C#" MasterPageFile="~/starweiboM.Master" AutoEventWireup="true" CodeBehind="comment.aspx.cs" Inherits="starWeibo.at.comment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/comment.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main_inner">
        <div class="W_main_l">
            <div class="left_commen">
                <div class="lev">
                    <a href="#">
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
                <div class="lev2 lev2-curr">
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
                        <div class="group_read">
                            <a href="#" class="currA">收到的评论</a>
                            <span>|</span>
                            <a href="comment.aspx?type=send" class="comA">发出的评论</a>
                        </div>
                        <div class="comment_list">
                            <asp:DataList runat="server" ID="commentDL">
                                <ItemTemplate>
                                   <div class="comment_feed clearfix">
                                        <div class="face">
                                            <a href="#">
                                                <img src="<%# Eval("userHeadimage") %>" />
                                            </a>
                                        </div>
                                        <div class="comment">
                                            <div class="comm_box">
                                                <p>
                                                    <a href="#"><%# Eval("userName") %></a>
                                                    <span><%# Eval("msgContent") %></span>
                                                </p>
                                                <p>
                                                    <span>评论我的微博:</span>
                                                    <a href="#"><%# Eval("blogContent") %></a>
                                                </p>
                                                <p style="margin-top: 6px;">
                                                    <span><%# Eval("pubTime") %></span>
                                                    <a href="#" style="float: right">回复</a>
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
                        <h3>评论使用小帮助</h3>
                        <p>Q:评论太多，想分类看？</p>
                        <p>A:你可以通过分类筛选，只查看自己关注的人。</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
