<%@ Page Title="" Language="C#" MasterPageFile="~/starweiboM.Master" AutoEventWireup="true" CodeBehind="zan.aspx.cs" Inherits="starWeibo.zan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/zan.css" rel="stylesheet" />
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
                <div class="lev2">
                    <a href="comment.aspx">
                        <i class="ico20 ico_comment"></i>
                        评论
                    </a>
                </div>
                <div class="lev2 lev2-curr">
                    <a href="#">
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
                            <a href="#" class="currA">收到的赞</a>
                        </div>
                        <div class="all_zan_list">
                            <div class="zan_list">
                                <asp:DataList runat="server" ID="zanDL">
                                    <ItemTemplate>
                                        <div class="zan_feed_detail clearfix">
                                            <div class="zan_face">
                                                <a href="#">
                                                    <img src="<%# Eval("userHeadimage") %>" />
                                                </a>
                                            </div>
                                            <div class="zan_detail clearfix">
                                                <p>
                                                    <a href="#" style="font-weight: bold;"><%# Eval("userName") %>:</a>
                                                    赞了你的微博
                                                    <i class="zan_icon"></i>
                                                </p>
                                                <p>
                                                    <span>对我的微博：</span>
                                                    <a href="#">"<%# Eval("blogContent") %>"</a>
                                                </p>
                                                <p>
                                                    <span><%# Eval("pubTime") %></span>
                                                    <span>来自</span>
                                                    <a href="#">微博weibo.com</a>
                                                    <a href="#" style="float: right;">回复</a>
                                                </p>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:DataList>

                            </div>
                        </div>
                    </div>
                </div>
                <div class="W_main_r">
                    <div class="helpbox">
                        <h3>赞使用小帮助</h3>
                        <p>Q:什么是赞</p>
                        <p>A:通过点亮图标的方式来表达用户对于一条微博信息的喜爱情感。</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
