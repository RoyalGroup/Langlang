<%@ Page Title="" Language="C#" MasterPageFile="~/starweiboM.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="starWeibo.homePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="css/homePage.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="wmaina">
	    <div id="boxcenter" class="wmainc">
		    <div id="pltoprecom"></div>
		    <div id="plpublishertop">
			    <div class="sendweibo clearfix">
				    <div class="titlearea clearfix">
					    <div class="title">有什么新鲜事想告诉大家？</div>
					    <div class="num txt2" style="display: none;">
						    <a   class="txt2">微博社区委会员启动招募</a>
						    ，还可以输入
						    <span>140</span>字
					    </div>
					    <div class="key textb" style="display: block;">
						    <a  >国安1-3客场负富力，中超积分榜格局微妙</a>
						    <a  >热门微博</a>
					    </div>
				    </div>
				    <div class="input">
					    <textarea phototag="1" class="inputdetail"></textarea>
					    <span class="arrow"></span>
				     </div>
				    <div class="funcarea clearfix">
					    <div class="func">
						    <div class="limits">
							    <a  >
								    <span class="wautocut">公开</span>
								    <span class="warrow">
									    <em>◆</em>
								    </span>
							    </a>
						    </div>
						    <a   class="wbtnvdisable">
							    <span class="btn30px" id="fabu">发布</span>
						    </a>
					    </div>

					    <div class="kindv2 txt3">
						    <span class="kinddetail">
							    <a   class="func1">
								    <i class="wico16 icoswface"></i>表情
							    </a>
							    <a   class="func1">
								    <i class="wico16 icoswimg"></i>图片
							    </a>
							    <a   class="func1">
								    <i class="wico16 icoswmovie"></i>视频
							    </a>
							    <a   class="func1">
								    <i class="wico16 icoswqing"></i>话题
							    </a>
							    <a   class="func1">
								    <i class="wico16 icoswchang"></i>长微博
							    </a>
						    </span>
						    <i class="txt2">|</i>
						    <div class="more">
							    <a  >
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
								<a  class="itemlink func1">微博</a>
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
								<a >
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
												<a  class="btnsearch wico20 iconsearch"></a>
												<span class="wvline">|</span>
												<a  class="btnarr">
													<span class="warrow">
														<em class="down">◆</em>
													</span>
												</a>
											</div>
											<input class="noborder inputdefault" type="text" value="查找我关注人的微博">
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
								<a class="tlk txt1 bg2" >全部</a>
							</li>
							<li class="titm">
								<a class="tlk" >原创</a>
							</li>
							<li class="titm">
								<a class="tlk" >图片</a>
							</li>
							<li class="titm">
								<a class="tlk" >视频</a>
							</li>
							<li class="titm">
								<a class="tlk" >音乐</a>
							</li>
						</ul>
					</div>
				</div>
				<div class="wbfeed">
					<div class="wbfeedtype swfun line2">
						<div class="wbscreen">
							<a class="wico12 iconchoose"></a>
						</div>
						<div class="wbfeeddetail line2 clearfix">
							<div class="wbface">
								<a href="#" class="wfaceradius">
									<img src="C:\Users\just\Desktop\手机壁纸\1.jpg" />
								</a>
							</div>
							<div class="wbdetail">
								<div class="wbinfo">
									<a class="wbname func1">平安荆楚</a>
									<a href="#">
										<i class="wico16 approveco"></i>
									</a>
								</div>
								<div class="wbtext">
									【英山“记仇大妈”雇凶伤人落法网】8月4日，英山城区农发行门口发生一起故意伤害案，一中年妇女被戴口罩的两名男子持钢管打伤。案发后，警方展开侦查发现，这几名男子是该县福利院一名大妈花8万元雇来的，雇凶伤人的原因，竟是因她20年前到银行取钱未果，一直记恨当时的营业员进而采取偏激措施。
								</div>
								<div class="wbfunc clearfix">
									<div class="wbhandle">
										<a class="zan" ifzan="0">
											<em class="wico20 iconpraised"></em>(<span>3</span>)
										</a>
										<i class="txt3">|</i>
										<a class="zf">转发</a>
										<i class="txt3">|</i>
										<a href="#">收藏</a>
										<i class="txt3">|</i>
										<a class="pl" pindex="1" isopen="no" ifc="0">评论(2)</a>
									</div>
									<div class="wbfrom">
										<a href="#" class="link2 wbtime">55分钟前</a>
										<em class="txt2">来自</em>
										<a href="#" class="link2">360安全浏览器</a>
										<span class="hoverr">
											<em class="txt2">|</em>&nbsp;
											<a href="#" class="jubao">举报</a>
										</span>
									</div>
								</div>

								<div class="dahuifu1"></div>
							
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
					</div>
				</div>
		    </div>
	       
        </div>
    </div>
</asp:Content>
