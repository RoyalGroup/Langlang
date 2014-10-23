<%@ Page Title="" Language="C#" MasterPageFile="~/starweiboM.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="starWeibo.homePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="css/homePage.css" />
    <script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
    <script type="text/javascript" src="js/homePage.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                                <div class="num txt2" style="display: none;">
                                    <a class="txt2">微博社区委会员启动招募</a>
                                    ，还可以输入
						    <span>140</span>字
                                </div>
                                <div class="key textb" style="display: block;">
                                    <a>国安1-3客场负富力，中超积分榜格局微妙</a>
                                    <a>热门微博</a>
                                </div>
                            </div>
                            <div class="input">
                                <textarea phototag="1" class="inputdetail" id="fabu_input"></textarea>
                                <span class="arrow"></span>
                            </div>
                            <div class="funcarea clearfix">
                                <div class="func">
                                    <div class="limits">
                                        <a>
                                            <span class="wautocut">公开</span>
                                            <span class="warrow">
                                                <em>◆</em>
                                            </span>
                                        </a>
                                    </div>
                                    <a class="wbtnvdisable">
                                        <span class="btn30px" id="fabu">发布</span>
                                    </a>
                                </div>

                                <div class="kindv2 txt3">
                                    <span class="kinddetail">
                                        <a class="func1">
                                            <i class="wico16 icoswface"></i>表情
                                        </a>
                                        <a class="func1">
                                            <i class="wico16 icoswimg"></i>图片
                                        </a>
                                        <a class="func1">
                                            <i class="wico16 icoswmovie"></i>视频
                                        </a>
                                        <a class="func1">
                                            <i class="wico16 icoswqing"></i>话题
                                        </a>
                                        <a class="func1">
                                            <i class="wico16 icoswchang"></i>长微博
                                        </a>
                                    </span>
                                    <i class="txt2">|</i>
                                    <div class="more">
                                        <a>
                                            <span class="wautocut">更多</span>
                                            <span class="warrow">
                                                <em class="down">◆</em>
                                            </span>
                                        </a>
                                    </div>
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

                                <div class="rightitem">
                                    <div class="smartsort">
                                        <a class="wbtnround2">
                                            <span>
                                                <i class="wico16 iconbytime"></i>时间排序
										<em class="warrow">
                                            <em>◆</em>
                                        </em>
                                            </span>
                                        </a>
                                    </div>
                                    <div class="groupreadlayer groupsort" style="display: none;">
                                        <a>
                                            <i class="wico16 icobypopular"></i>智能排序
                                        </a>
                                    </div>
                                </div>

                                <div class="rightbar">
                                    <div class="rightitem1">
                                        <div class="inputsearch">
                                            <div class="inner">
                                                <form method="get">
                                                    <div class="btns1">
                                                        <a class="btnsearch wico20 iconsearch"></a>
                                                        <span class="wvline">|</span>
                                                        <a class="btnarr">
                                                            <span class="warrow">
                                                                <em class="down">◆</em>
                                                            </span>
                                                        </a>
                                                    </div>
                                                    <input class="noborder inputdefault" type="text" value="查找我关注人的微博"/>
                                                    <a class="btn"></a>
                                                </form>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="tabnosep">
                                <ul class="tul clearfix">
                                    <li class="titm current1">
                                        <a class="tlk txt1 bg2">全部</a>
                                    </li>
                                    <li class="titm">
                                        <a class="tlk">原创</a>
                                    </li>
                                    <li class="titm">
                                        <a class="tlk">图片</a>
                                    </li>
                                    <li class="titm">
                                        <a class="tlk">视频</a>
                                    </li>
                                    <li class="titm">
                                        <a class="tlk">音乐</a>
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
                                                    <a class="wbname func1 userName"><%# Eval("userName") %></a>
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
                                                            <div class="concwbrplbleft">
                                                                <span class="concwbrplbbq"></span>
                                                                <input type="checkbox" class="concwbrplbcheck" />
                                                                <span class="concwbrplbtxt">同时转发到我的微博                
                                                                </span>
                                                            </div>
                                                            <div class="concwbrzfbtn">转发</div>
                                                        </div>
                                                    </div>
                                                </div>
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
                        <h3>消息箱使用小帮助</h3>
                        <p>Q:什么是消息箱？</p>
                        <p>A:是将@我的，评论，赞，私信等消息相关类服务综合在一起的消息中心，在这里可以看到所有的消息提示。</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
