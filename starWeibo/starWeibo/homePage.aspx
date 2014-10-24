<%@ Page Title="" Language="C#" MasterPageFile="~/starweiboM.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="starWeibo.homePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="css/homePage.css" />
    <script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
    <script type="text/javascript" src="js/homePage.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="mengban"></div>
    <div class="contrans">
        <div class="contranstop">
            <span class="conttxt ">转发微博</span>
            <span class="contclose"></span>
        </div>
        <div class="contransbom">
            <div class="contmyan">
                <a href="" class="conttxt conttxtlink"></a>
                <span class="contgeyan"></span>
            </div>
            <div class="conttebox">
                <textarea class="contte"></textarea>
            </div>
            <div class="contbom">
                <div class="concwbrzfbtn">转发</div>
            </div>
        </div>
    </div>
    <div style="display:none" id="info" userid="<%=curuser.id %>" name="<%=curuser.userName %>" headimg="<%= curuser.userHeadimage %>"></div>
    <div class="main_inner">
        <div class="W_main_l">
            <div class="left_commen">
                <div class="lev">
                    <a href="#">
                        <i class="ico20 ico_guide"></i>
                        新手指南
                    </a>
                </div>
                <div class="lev lev-curr">
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
            <div class="plc_main clearfix">
                <div id="boxcenter" class="wmainc">
                    <div id="pltoprecom"></div>
                    <div id="plpublishertop">
                        <div class="sendweibo clearfix">
                            <div class="titlearea clearfix">
                                <div class="title">有什么新鲜事想告诉大家？</div>
                                <div class="num txt2"  style="display: block;">
                                    <a class="txt2">发言请遵守社区公约</a>
                                    ，<c>还可以输入</c>
						            <span>140</span>字
                                </div>
                               
                            </div>
                            <div class="input">
                                <textarea phototag="1" class="inputdetail" id="fabu_input"></textarea>
                                <span class="arrow"></span>
                            </div>
                            <div class="funcarea clearfix">
                                <div class="func">
                                    <a class="wbtnvdisable">
                                        <span class="btn30px" id="fabu">发布</span>
                                    </a>
                                </div>
                            </div>

                            <div class="layertips"></div>
                        </div>
                    </div>
                    <div id="plcontenthomefeed">
                        <div class="groupread clearfix">
                            <div class="clearfix">
                                <ul class="sort clearfix">
                                    <li class="item homePageCurrent">
                                        <a class="itemlink func1">微博</a>
                                        <div class="wtabarrow bg4"></div>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class="wbfeed">
                            <div class="wbfeedtype swfun line2">
                                <asp:DataList runat="server" ID="wbList">
                                    <ItemTemplate>
                                        <div class="wbfeeddetail line2 clearfix" blogid="<%# Eval("blogId") %>">
                                            <div class="wbface">
                                                <a href="#" class="wfaceradius">
                                                    <img src="<%# Eval("userHeadimage") %>" />
                                                </a>
                                            </div>
                                            <div class="wbdetail">
                                                <div class="wbinfo">
                                                    <a class="wbname func1 " href="personalCenter.aspx?Userid=<%#Eval("blogAuthorId") %>"><%# Eval("userName") %></a>
                                                    <a href="#">
                                                        <i class="wico16 approveco"></i>
                                                    </a>
                                                </div>
                                                <div class="wbtext">
                                                    <%# Eval("blogContent") %>
                                                </div>
                                                <div class="wbfunc clearfix">
                                                    <div class="wbhandle">
                                                        <a class="zan" ifzan="0">
                                                            <em class="wico20 iconpraised"></em>(<span>0</span>)
                                                        </a>
                                                        <i class="txt3">|</i>
                                                        <a class="zf">转发</a>
                                                        <i class="txt3">|</i>
                                                        <a class="wbcollect" ifcollect="0">收藏</a>
                                                        <i class="txt3">|</i>
                                                        <a class="pl" pindex="1" isopen="no" ifc="0">评论(0)</a>
                                                    </div>
                                                    <div class="wbfrom">
                                                        <a href="#" class="link2 wbtime"><%# Eval("blogPubTime") %></a>
                                                        <em class="txt2">来自</em>
                                                        <a href="#" class="link2">weibo</a>
                                                        <span class="hoverr">
                                                            <em class="txt2">|</em>&nbsp;
											            <a href="#" class="jubao">举报</a>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:DataList>
                            </div>
                        </div>
                        <div id="loading" style=" display:none">
                             <span>正在加载中，请稍候...</span>
                        </div>
                        <div class="W_pages" num="<%= pages %>">
                            <%--<asp:Button ID="btnpre" runat="server" Text="上一页" />--%>
                            <%if (curpre >= 1)
                              {
                                  %>
                                <a href="homePage.aspx?pre=<%= curpre-1%>" class="pre">上一页</a><%--&next=<%= curpre+1%>--%>
                            <% 
                              }
                                 %>         
                            <div class="pagebox">
                                <div class="pages">
                                    <%for (int i = 1; i <=pages; i++)
                                      {
                                          //string html = "<a href='homePage.aspx?pre=" + (i - 1) + "&next=" + (i + 1) + "' class='everypages' num='" + i + "'>第&nbsp;" + i + "&nbsp;页</a>";
                                          string html = "<a href='homePage.aspx?pre=" + (i - 1) + "' class='everypages' num='" + i + "'>第&nbsp;" + i + "&nbsp;页</a>";
                                          Response.Write(html);
                                      }
                                         %>
                                </div>
                                <div class="curpage" num="<%= curpre+1 %>">第&nbsp;<%= curpre+1 %>&nbsp;页</div>
                            </div>
                            <%if (curpre < (pages - 1))
                              {
                                  %>
                                <a href="homePage.aspx?pre=<%= curpre+1%>" class="next">下一页</a><%--&next=<%= curpre+3%>--%>
                            <% 
                              }
                                 %>
                            
                            <%--<asp:Button ID="btnnext" runat="server" Text="下一页" />--%>
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
