using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using starweibo.Model;

namespace starWeibo.webservice
{
    /// <summary>
    /// wsadmin 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class wsadmin : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        //忽略举报信息
        public bool hulueReport(int messageId)
        {
            starweibo.Model.messageInfo onemsg = new messageInfo();
            starweibo.BLL.messageInfo bllmsg = new starweibo.BLL.messageInfo();
            onemsg = bllmsg.GetModel(messageId);
            onemsg.msgState = "read";
            return bllmsg.Update(onemsg);
        }

        
        [WebMethod]
        //被举报微博删除
        public bool Delete(int messageId, int blogId)
        {
            starweibo.Model.messageInfo onemsg = new messageInfo();
            starweibo.BLL.messageInfo bllmsg = new starweibo.BLL.messageInfo();
            onemsg = bllmsg.GetModel(messageId);
            onemsg.msgState = "read";
            bllmsg.Update(onemsg);

            starweibo.Model.blogInfo oneblog = new blogInfo();
            starweibo.BLL.blogInfo bllmsgP = new starweibo.BLL.blogInfo();
            oneblog = bllmsgP.GetModel(blogId);
            oneblog.blogState = "1";

            return bllmsgP.Update(oneblog);
        }

        
        [WebMethod]
        //被举报用户禁言
        public bool jinyan(int messageId, int userId)
        {
            starweibo.Model.messageInfo onemsg = new messageInfo();
            starweibo.BLL.messageInfo bllmsg = new starweibo.BLL.messageInfo();
            onemsg = bllmsg.GetModel(messageId);
            onemsg.msgState = "read";
            bllmsg.Update(onemsg);

            starweibo.Model.powerInfo onemsgP = new powerInfo();
            starweibo.BLL.powerInfo bllmsgP = new starweibo.BLL.powerInfo();
            onemsgP = bllmsgP.GetModel(userId);
            onemsgP.fasong = "0";

            return bllmsgP.Update(onemsgP);
        }


        [WebMethod]
        //发送公告
        public void SendSysMsg(string msgContent)
        {
            starweibo.BLL.chatInfo SysMsg = new starweibo.BLL.chatInfo();
            starweibo.Model.chatInfo molMsg = new starweibo.Model.chatInfo();

            List<starweibo.Model.userInfo> SSM = new List<starweibo.Model.userInfo>();
            starweibo.BLL.userInfo bllSSM = new starweibo.BLL.userInfo();
            SSM = bllSSM.GetModelList("1=1");
            foreach (starweibo.Model.userInfo onessm in SSM)
            {
                if (onessm.id!=44)
                {
                    molMsg.receiverId = onessm.id;
                    molMsg.msgContent = msgContent;
                    molMsg.senderId = 44;
                    molMsg.msgState = "noread";
                    SysMsg.Add(molMsg);
                }
                
            }        
        }

        //用户权限
        [WebMethod]
        //用户权限更改
        public bool quanxian(int userId, string type, string fuzhi)
        {
            starweibo.Model.powerInfo usp = new powerInfo();
            starweibo.BLL.powerInfo bllusp = new starweibo.BLL.powerInfo();
            usp = bllusp.GetModel(userId);
            switch (type)
            {
                case "zan":
                    usp.zan = fuzhi;
                    break;
                case "pinglun":
                    usp.pinglun = fuzhi;
                    break;
                case "at":
                    usp.at = fuzhi;
                    break;
                case "guanzhu":
                    usp.guanzhu = fuzhi;
                    break;
                case "jubao":
                    usp.jubao = fuzhi;
                    break;
                case "zhuanfa":
                    usp.zhuanfa = fuzhi;
                    break;
                case "shoucang":
                    usp.shoucang = fuzhi;
                    break;
                case "fasong":
                    usp.fasong = fuzhi;
                    break;
            }
            return bllusp.Update(usp);
        }

        //用户权限全禁
        [WebMethod]
        //用户权限全禁
        public bool quan(int userId)
        {
            starweibo.Model.powerInfo usp = new powerInfo();
            starweibo.BLL.powerInfo bllusp = new starweibo.BLL.powerInfo();
            usp = bllusp.GetModel(userId);

            usp.zan = "0";
            usp.pinglun = "0";
            usp.at = "0";
            usp.guanzhu = "0";
            usp.jubao = "0";
            usp.zhuanfa = "0";
            usp.shoucang = "0";
            usp.fasong = "0";

            return bllusp.Update(usp);
        }

        [WebMethod]
        //用户权限全解
        public bool kquan(int userId)
        {
            starweibo.Model.powerInfo usp = new powerInfo();
            starweibo.BLL.powerInfo bllusp = new starweibo.BLL.powerInfo();
            usp = bllusp.GetModel(userId);

            usp.zan = "1";
            usp.pinglun = "1";
            usp.at = "1";
            usp.guanzhu = "1";
            usp.jubao = "1";
            usp.zhuanfa = "1";
            usp.shoucang = "1";
            usp.fasong = "1";

            return bllusp.Update(usp);
        }

        [WebMethod]
        //用户权选择更改
        public bool xuanze(int userId, string type)
        {
            starweibo.Model.powerInfo usp = new powerInfo();
            starweibo.BLL.powerInfo bllusp = new starweibo.BLL.powerInfo();
            usp = bllusp.GetModel(userId);
            switch (type)
            {
                case "zan":
                    usp.zan = "0";
                    break;
                case "pinglun":
                    usp.pinglun = "0";
                    break;
                case "at":
                    usp.at = "0";
                    break;
                case "guanzhu":
                    usp.guanzhu = "0";
                    break;
                case "jubao":
                    usp.jubao = "0";
                    break;
                case "zhuanfa":
                    usp.zhuanfa = "0";
                    break;
                case "shoucang":
                    usp.shoucang = "0";
                    break;
                case "fasong":
                    usp.fasong = "0";
                    break;
            }
            return bllusp.Update(usp);
        }
        [WebMethod]
        //用户权选择更改
        public bool xuanzek(int userId, string type)
        {
            starweibo.Model.powerInfo usp = new powerInfo();
            starweibo.BLL.powerInfo bllusp = new starweibo.BLL.powerInfo();
            usp = bllusp.GetModel(userId);
            switch (type)
            {
                case "zan":
                    usp.zan = "1";
                    break;
                case "pinglun":
                    usp.pinglun = "1";
                    break;
                case "at":
                    usp.at = "1";
                    break;
                case "guanzhu":
                    usp.guanzhu = "1";
                    break;
                case "jubao":
                    usp.jubao = "1";
                    break;
                case "zhuanfa":
                    usp.zhuanfa = "1";
                    break;
                case "shoucang":
                    usp.shoucang = "1";
                    break;
                case "fasong":
                    usp.fasong = "1";
                    break;
            }
            return bllusp.Update(usp);
        }
    }
}
