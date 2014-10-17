<%@ Page Title="" Language="C#" MasterPageFile="~/starweiboM.Master" AutoEventWireup="true" CodeBehind="weibo.aspx.cs" Inherits="starWeibo.at.weibo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/weibo.css" rel="stylesheet" />
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
                <div class="lev2 lev2-curr">
                    <a href="weibo.aspx">
                        <i class="ico20 ico_at"></i>
                        提到我的
                    </a>
                </div>
                <div class="lev2">
                    <a href="#">
                        <i class="ico20 ico_comment"></i>
                        评论
                    </a>
                </div>
                <div class="lev2">
                    <a href="#">
                        <i class="ico20 ico_zan"></i>
                        赞
                    </a>
                </div>
                <div class="lev2">
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
                            <a href="#" class="currA">@我的微博</a>
                            <span>|</span>
                            <a href="#">@我的评论</a>
                        </div>
                        <asp:DataList runat="server" ID="weiboDL">
                            <ItemTemplate>
                                <div class="all_msg_list">
                                    <div class="wb_list">
                                        <div class="wb_feed_detail">
                                            <div class="wb_face">
                                                <a href="#">
                                                    <img src="<%# Eval("userHeadimage") %>">
                                                </a>
                                            </div>
                                            <div class="wb_detail">
                                                <div class="wb_info">
                                                    <a href="#" class="wb_name"><%# Eval("userName") %></a>
                                                </div>
                                                <div class="wb_txt">
                                                    <%# Eval("blogContent") %>
											        <a href="#" class="atname">@<%# Eval("atuserName") %></a>
                                                </div>
                                                <div class="wb_func">
                                                    <div class="wb_handle">
                                                        <a href="#">
                                                            <em class="icon_zan"></em>
                                                        </a>
                                                        <i class="S_txt3">|</i>
                                                        <a href="#">转发</a>
                                                        <i class="S_txt3">|</i>
                                                        <a href="#">收藏</a>
                                                        <i class="S_txt3">|</i>
                                                        <a href="#">评论</a>
                                                    </div>
                                                    <div class="wb_form">
                                                        <a href="#"><%# Eval("blogPubTime") %></a>
                                                        <em class="S_txt2">来自</em>
                                                        <a href="#">微博 weibo.com</a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>

                    </div>
                </div>
                <div class="W_main_r">
                    <div class="helpbox">
                        <h3>@使用小帮助</h3>
                        <p>Q:什么是@提醒</p>
                        <p>A:在微博中@他人的昵称，如"@微博小秘书"，他就会收到你@他的提醒。</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
