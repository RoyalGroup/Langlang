<%@ Page Title="" Language="C#" MasterPageFile="~/starweibo.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="starWeibo.homePage" %>
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
						    <a href="#" class="txt2">微博社区委会员启动招募</a>
						    ，还可以输入
						    <span>140</span>字
					    </div>
					    <div class="key textb" style="display: block;">
						    <a href="#">国安1-3客场负富力，中超积分榜格局微妙</a>
						    <a href="#">热门微博</a>
					    </div>
				    </div>

				    <div class="input">
					    <textarea phototag="1" class="inputdetail"></textarea>
					    <!-- <div class="sendsuccpic">
						    <p class="iconsuccb"></p>
						    <p class="txt">发布成功</p>
					    </div> -->
					    <span class="arrow"></span>
				    </div>

				    <div class="funcarea clearfix">
					    <div class="func">
						    <div class="limits">
							    <a href="#">
								    <span class="wautocut">公开</span>
								    <span class="warrow">
									    <em>◆</em>
								    </span>
							    </a>
						    </div>
						    <a href="#" class="wbtnvdisable">
							    <span class="btn30px" id="fabu">发布</span>
						    </a>
					    </div>

					    <div class="kindv2 txt3">
						    <span class="kinddetail">
							    <a href="#" class="func1">
								    <i class="wico16 icoswface"></i>表情
							    </a>
							    <a href="#" class="func1">
								    <i class="wico16 icoswimg"></i>图片
							    </a>
							    <a href="#" class="func1">
								    <i class="wico16 icoswmovie"></i>视频
							    </a>
							    <a href="#" class="func1">
								    <i class="wico16 icoswqing"></i>话题
							    </a>
							    <a href="#" class="func1">
								    <i class="wico16 icoswchang"></i>长微博
							    </a>
						    </span>
						    <i class="txt2">|</i>
						    <div class="more">
							    <a href="#">
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
						    <li class="item current">
							    <a href="#" class="itemlink func1">微博</a>
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
							    <a href="#">
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
											    <a href="#" class="btnsearch wico20 iconsearch"></a>
											    <span class="wvline">|</span>
											    <a href="#" class="btnarr">
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
							    <a class="tlk txt1 bg2" href="#">全部</a>
						    </li>
						    <li class="titm">
							    <a class="tlk" href="#">原创</a>
						    </li>
						    <li class="titm">
							    <a class="tlk" href="#">图片</a>
						    </li>
						    <li class="titm">
							    <a class="tlk" href="#">视频</a>
						    </li>
						    <li class="titm">
							    <a class="tlk" href="#">音乐</a>
						    </li>
					    </ul>
				    </div>
			    </div>

			    <div class="wbfeed">
				    <div id="gfb"></div>
				    <div class="wbfeedtype swfun line2">
					    <div class="wbscreen">
						    <a class="wico12 iconchoose"></a>
					    </div>
					    <div class="wbfeeddetail line2 clearfix">
						    <div class="wbface">
							    <a href="#" class="wfaceradius">
								    <img src="images/t1.jpg">
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
								    <img src="images/han.gif">
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
							    <!-- <div class="replyexpand line1 bg4">
								    <div class="wbarrow">
									    <em class="line1c">◆</em>
									    <span class="bg4c">◆</span>
								    </div>

								    <div class="line1 input clearfix">
									    <div>
										    <textarea class="winput"></textarea>
									    </div>
									    <div class="action">
										    <span class="wico16 icofaces"></span>
										    <ul class="commonedlist">
											    <li>
												    <label>
													    <input class="wcheckbox" type="checkbox">同时转发到我的微博                
												    </label>
											    </li>
										    </ul>
									    </div>			
									    <p class="btn">
										    <a class="wbtna">
											    <span class="btn30px wfl4">
												    <b></b>
												    <em class="	btntext" bindex="1">评论</em>
											    </span>
										    </a>
									    </p>
								    </div>

								    <div id="ccru"></div>
								    <div class="tabb txt3 line1">
									    <span class="txt2">共2条</span>
									    <a class="currenta txt1">全部</a>
									    <i class="wvline">|</i>
									    <a class="func1">热门</a>
									    <i class="wvline">|</i>
									    <a class="func1">认证用户</a>
									    <i class="wvline">|</i>
									    <a class="func1">关注的人</a>
								    </div>

								    <div class="commentlists1">
									    <dl class="commentlist line1">
										    <dt>
											    <a href="#">
												    <img src="images/p1.jpg">
											    </a>
										    </dt>
										    <dd>
											    <a href="#">沫迹Sissi</a>：加油！ (8月20日 19:01)        
											    <div class="info">
												    <span class="wlinkb">
													    <em class="hover">
														    <a href="#">举报</a>
														    <em class="txt3">|</em>
													    </em>
													    <a href="#" class="zan1">
														    <em class="wico20 iconpraisedb"></em>
														    (<span>6</span>)
													    </a>
													    <i class="txt3">|</i>
													    <a class="hh" href="#" rindex="1">回复</a>
												    </span>
											    </div>
																	
											    <div class="rereply1"></div>
																	
										    </dd>
										    <dd class="clear"></dd>
									    </dl>

									    <dl class="commentlist line1">
										    <dt>
											    <a href="#">
												    <img src="images/p2.jpg">
											    </a>
										    </dt>
										    <dd>
											    <a href="#">Sissi</a>：加油!!!!!!!!！ (8月21日 12:32)        
											    <div class="info">
												    <span class="wlinkb">
													    <em class="hover">
														    <a href="#">举报</a>
														    <em class="txt3">|</em>
													    </em>
													    <a href="#" class="zan1">
														    <em class="wico20 iconpraisedb"></em>
														    (<span>2</span>)
													    </a>
													    <i class="txt3">|</i>
													    <a class="hh" href="#" rindex="2">回复</a>
												    </span>
											    </div>
											    <div class="rereply2"></div>
										    </dd>
										    <dd class="clear"></dd>
									    </dl>
								    </div>

							    </div> -->
							    <!-- 转发 -->
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
											    <input type="checkbox" class="concwbrplbcheck">
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

	    <div id="boxright" class="wmainr">
		    <div id="plcontentsetskin">
			    <div class="templeteenter">
				    <a href="#" class="enter"></a>
			    </div>
		    </div>

		    <div id="plrightmodmyinfo">
			    <dl class="wpersoninfo clearfix">
				    <dt>
					    <a href="#">
						    <img class="line5" src="images/user.jpg">
					    </a>
				    </dt>
				    <dd class="namebox">
					    <a href="#" class="name func1">Wing_yk</a>
					    <div class="iconbed">
						    <a href="#">
							    <span class="wlevelico color1">
								    <span class="wlevelnum"></span>
							    </span>
						    </a>
					    </div>
				    </dd>
			    </dl>

			    <ul class="useratten clearfix useratten1">
				    <li class="line2">
					    <a href="#" class="func1">
						    <strong>5</strong>
						    <span>关注</span>
					    </a>
				    </li>
				    <li class="line2">
					    <a href="#" class="func1">
						    <strong>2</strong>
						    <span>粉丝</span>
					    </a>
				    </li>
				    <li class="wnoborder">
					    <a href="#" class="func1">
						    <strong>0</strong>
						    <span>微博</span>
					    </a>
				    </li>
			    </ul>
		    </div>

		    <div id="trustpageletchexkinlotteryv5">
			    <div class="wbrightmodule">
				    <form class="righttitle">
					    <fieldset class="line2">
						    <legend class="tit txt1">
							    <a href="#" class="func1">登录赢会员</a>
						    </legend>
						    <div class="btns3">
							    <a href="#" class="wbtnround">
								    <span>活动规则</span>
							    </a>
						    </div>
					    </fieldset>
				    </form>
				    <div class="rightcontent winmember">
					    <div class="win5 wtc">
						    <div class="pro">
							    <div class="day day3">
								    <i></i>
							    </div>
						    </div>
						    <p>再登录
							    <span class="num1">2</span>天，免费得7天会员！
						    </p>
					    </div>
				    </div>
				    <div class="keycheckin"></div>
			    </div>
		    </div>

		    <div id="plrightmoduserguide"></div>

		    <div id="trustpageletindexrightrecom">
			    <div class="wbrightmodule"></div>
			    <div class="ucard">
				    <div class="rightmoudlefixed">
					    <div class="wbrightmodule">
						    <form class="righttitle">
							    <fieldset class="line2">
								    <legend class="tit txt1">
									    <a href="#" class="func1">可能感兴趣的人</a>
								    </legend>
								    <div class="btns3">
									    <a href="#" class="wbtnround">
										    <span>换一换</span>
									    </a>
								    </div>
							    </fieldset>
						    </form>
						    <div class="rightcontent personlist">
							    <dl class="namelist swfun clearfix">
								    <dt class="pic">
									    <a href="#"><img src="images/r1.jpg"></a>
								    </dt>
								    <dd class="con">
									    <p class="name">
										    <a href="#">CelineDion...</a>
										    <a href="#">
											    <em class="wico16 approveco"></em>
										    </a>
									    </p>
									    <a href="#" class="wbtnb">
										    <span>
											    <em class="addicon">+</em> 关注
										    </span>
									    </a>
								    </dd>
								    <dd class="change">
									    <a href="#" class="wico16 iconclose"></a>
								    </dd>
								    <dd class="rightexpand line2 bg1">
									    <div class="arrow">
										    <em class="line2c">◆</em>
										    <span class="bg1c">◆</span>
									    </div>
									    <p class="txt2">
										    <span>CelineDion席琳迪翁中...</span>
									    </p>
									    <p class="txt2">24小时热点</p>
								    </dd>
							    </dl>
													
							    <dl class="namelist swfun clearfix">
								    <dt class="pic">
									    <a href="#"><img src="images/r2.jpg"></a>
								    </dt>
								    <dd class="con">
									    <p class="name">
										    <a href="#">我早已迷失...</a>
										    <a href="#">
											    <em class="wico16 approveco"></em>
										    </a>
									    </p>
									    <a href="#" class="wbtnb">
										    <span>
											    <em class="addicon">+</em> 关注
										    </span>
									    </a>
								    </dd>
								    <dd class="change">
									    <a href="#" class="wico16 iconclose"></a>
								    </dd>
								    <dd class="rightexpand line2 bg1">
									    <div class="arrow">
										    <em class="line2c">◆</em>
										    <span class="bg1c">◆</span>
									    </div>
									    <p class="txt2">24小时热点</p>
								    </dd>
							    </dl>
						    </div>
						    <div class="btmrt">
							    <a href="#" class="left link1">找人</a>
							    <a href="#" class="more link2">更多»</a>
						    </div>
					    </div>

					    <div class="ucardconf">
						    <div class="wbrightmodule">
							    <div class="mactivities mabverarea clearfix">
								    <form class="righttitle">
									    <fieldset class="line2"></fieldset>
								    </form>
								    <div class="content advercontb">
									    <div class="bao">
										    <img src="images/picc.jpg">
									    </div>
								    </div>
							    </div>
						    </div>
					    </div>

					    <div class="wbrightmodule">
						    <form class="righttitle">
							    <fieldset class="line2">
								    <legend class="tit txt1">
									    <a href="#" class="func1">热门话题</a>
								    </legend>
								    <div class="btns3">
									    <a href="#" class="wbtnround">
										    <span>换一换</span>
									    </a>
								    </div>
							    </fieldset>
						    </form>
						    <div id="topicad" class="rightcontent hottopic hottopicad1"></div>
						    <div class="rightcontent hottopic">
							    <ul>
								    <li>
									    <p>
										    <span class="total txt2">1055万</span>
										    <a href="#">#脸基尼走入国际#</a>
									    </p>
									    <div class="rightexpand line2 bg1">
										    <div class="arrow">
											    <em class="line2c">◆</em>
											    <span class="bg1c">◆</span>
										    </div>
										    <p class="txt2">青岛脸基尼大妈成功打入时尚圈，大片来袭</p>
									    </div>
								    </li>

								    <li>
									    <p>
										    <span class="total txt2">759万</span>
										    <a href="#">#羊水栓塞#</a>
									    </p>
								    </li>

								    <li>
									    <p>
										    <span class="total txt2">6853万</span>
										    <a href="#">#产妇丧命医护失踪#</a>
									    </p>
								    </li>

								    <li>
									    <p>
										    <span class="total txt2">6万</span>
										    <a href="#">#刘健案#</a>
									    </p>
								    </li>

								    <li>
									    <p>
										    <span class="total txt2">65万</span>
										    <a href="#">#日本推出男士胸罩#</a>
									    </p>
								    </li>

							    </ul>
						    </div>
						    <div class="btmrt">
							    <a href="#" class="left link1">24小时热点</a>
							    <a href="#" class="more link2">更多»</a>
						    </div>
					    </div>
				    </div>

				    <div class="wbrightmodule"></div>

				    <div id="plcorethirdhtmldata" class="wbrightmodule"></div>

				    <div class="wbrightmodule"></div>
			    </div>
		    </div>

		    <div id="plrightmodads36"></div>

		    <div id="trustpageletrecommemberv5">
			    <div class="wbrightmodule">
				    <div class="righttab line2">
					    <ul>
						    <li class="rli1 currentli">
							    <a href="#" class="title1 func1">会员专区</a>
							    <div class="wtabarrow bg4"></div>
						    </li>
						    <li>
							    <span class="line line2c">|</span>
						    </li>
						    <li class="rli2">
							    <a href="#" class="title1 func1">会员动态</a>
							    <div class="wtabarrow bg4" style="display:none;"></div>
						    </li>
					    </ul>

					    <div class="btns4">
						    <a href="#" class="wbtnroundico">
							    <span>
								    <em class="wico12 iconrefresh"></em>
							    </span>
						    </a>
					    </div>

				    </div>
				    <div class="content personlist vipshowspecial">
					    <div class="interesttab">
						    <div class="rightcontent personlist">
							    <dl class="pic30 swfun clearfix">
								    <dt class="pic">
									    <a href="#"><img src="images/h1.jpg"></a>
								    </dt>
								    <dd class="con">
									    <div class="btn">
										    <a href="#" class="wbtnb">
											    <span>
												    <em class="addicon">+</em>关注
											    </span>
										    </a>
									    </div>
									    <p class="name">
										    <a href="#" class="func1">基调临渊</a>
										    <a href="#">
											    <i class="wico16 icoclub"></i>
										    </a>
										    <a href="#">
											    <em class="wico16 icomember4"></em>
										    </a>
									    </p>
								    </dd>
								    <dd class="change">
									    <a href="#" class="wico16 iconclose"></a>
								    </dd>
							    </dl>

							    <dl class="pic30 swfun clearfix">
								    <dt class="pic">
									    <a href="#"><img src="images/h2.jpg"></a>
								    </dt>
								    <dd class="con">
									    <div class="btn">
										    <a href="#" class="wbtnb">
											    <span>
												    <em class="addicon">+</em>关注
											    </span>
										    </a>
									    </div>
									    <p class="name">
										    <a href="#" class="func1">最后一...</a>
										    <a href="#">
											    <i class="wico16 icoclub"></i>
										    </a>
										    <a href="#">
											    <em class="wico16 icomember4"></em>
										    </a>
									    </p>
								    </dd>
								    <dd class="change">
									    <a href="#" class="wico16 iconclose"></a>
								    </dd>
							    </dl>
						    </div>
						    <p class="menbernote txt1">
							    <a href="#" class="link1">开通微博会员</a>就有机会在这出现       
						    </p>
					    </div>

					    <div class="memberdynamic">
						    <p class="menbernote txt1">亲爱的
							    <a href="#">Wing_yk</a>：
						    </p>
						    <p class="menbernote txt1">快来申请微博信用卡！</p>
						    <div class="menbersms">
							    <a href="#"><img src="images/hy.jpg"></a>
						    </div>
						    <p class="menbernote">
							    <a href="#" class="wbtnb">
								    <span>立即体验</span>
							    </a>
							    <a href="#" class="wbtnb">
								    <span>开通会员</span>
							    </a>
						    </p>
					    </div>
				    </div>
			    </div>
		    </div>

		    <div id="plrightmodvservice"></div>

		    <div id="plrightmodnoticeboard">
			    <div class="wbrightmodule">
				    <form class="righttitle">
					    <fieldset class="line2">
						    <legend class="tit txt1">公告栏</legend>
					    </fieldset>
				    </form>
				    <div class="rightcontent feedback">
					    <div>申请加入微博社区委员会，可通过手机客户端便捷报名。
						    <a href="#">查看详情»</a>
					    </div>
					    <p class="dotpart">
						    <span class="info">
								    <a href="#">微博社区公约</a>
						    </span>
					    </p>
					    <p class="dotpart">
						    <span class="info">
								    <a href="#">微博举报处理中心</a>
						    </span>
					    </p>
					    <p class="dotpart">
						    <span class="info">
								    <a href="#">微博帮助</a>
						    </span>
					    </p>
					    <p class="dotpart">
						    <span class="info">
								    <a href="#">《首都互联网协会发布坚守七条底线倡议书》</a>
						    </span>
					    </p>
				    </div>
			    </div>
		    </div>

		    <div id="plcontentbubbox"></div>
	    </div>
    </div>
</asp:Content>
