<%@ Page Title="" Language="C#" MasterPageFile="~/starweiboM.Master" AutoEventWireup="true" CodeBehind="detailmessage.aspx.cs" Inherits="starWeibo.detailmessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/message.css" rel="stylesheet" />
    <link href="css/detailmessage.css" rel="stylesheet" />
    <script src="js/detailmessage.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%@ Import namespace="System.Data" %> 
    <%--<%@ Import namespace="System.ComponentModel" %> --%>
    <div style="display:none" id="info" userid="<%=curuser.id %>" name="<%=curuser.userName %>" headimg="<%= curuser.userHeadimage %>"></div>
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
                            <div class="title">
                                与
                                <strong class="dia_object"><%=sendname %></strong>
                                的对话
                            </div>                
                        </div>
                        <div class="message_wrap">
                            <div class="send_private_msgbox">
                                <div class="send_private_msg">
                                    <div class="msgtitle">
                                        <em class="icon_mes"></em>
                                        发送私信给:
                                        <span class="msgname" msgid="<%=sendid %>"><%=sendname %></span>
                                    </div>
                                    <div class="msgnum">
                                        <%--还可以输入--%>
                                        <span></span>
                                        <%--字--%>
                                    </div>
                                    <div class="msgcontent">
                                        <div class="msgtextarea">
                                            <textarea class="dmsgtextarea"></textarea>
                                        </div>
                                        <div class="send_handle">
                                            <div class="btnsend">
                                                <a class="btnsenda" href="javascript:void(0);">发送</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="msg_dialogue">
                                <asp:Repeater runat="server" ID="msgdialogue">
                                    <ItemTemplate>
                                        <div class="S_line2 msg_time_line">
                                            <div class="time_tit"><%# Eval("pubTime") %></div>
                                        </div>
                                      <%--  <%# check(Convert.ToInt32(DataBinder.Eval(Container.DataItem, "senderId")))  %>--%>
                                        <div class="msg_dialogue_list msg_dialist_<%# (Convert.ToInt32(Eval("senderId"))==curid)?"l":"r" %> clearfix ">
                                            <div class="msg_dialist_box clearfix">
                                                <div class="msg_dialist_pic">
                                                    <a class="dialist_pic_box">
                                                        <img src="<%# Eval("userHeadimage") %>" alt="" height="50" width="50"/>
                                                    </a>
                                                </div>
                                                <div class="msg_dialist_content S_line2 S_bg5">
                                                    <div class="msg_arrow"></div>
                                                    <div class="msg_dialist_main">
                                                        <div class="msg_diamain_box">
                                                            <p class="msg_dia_txt"><%# Eval("msgContent") %></p>
                                                        </div>
                                                    </div>
                                                    <div class="msg_ctrl hover"></div>
                                                </div>
                                            </div>
                                        </div> 
                                    </ItemTemplate>
                                </asp:Repeater>      
                            </div>
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
