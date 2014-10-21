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

        private starweibo.BLL.messageInfo Msg = new starweibo.BLL.messageInfo();
        [WebMethod]
        //忽略举报信息
        public bool hulueReport(int messageId)
        {
            starweibo.Model.messageInfo onemsg = new messageInfo();
            starweibo.BLL.messageInfo bllmsg = new starweibo.BLL.messageInfo();
            onemsg = bllmsg.GetModel(messageId);
            onemsg.msgState = "read";
            return Msg.Update(onemsg);
        }

        //private starweibo.BLL.blogInfo blog = new starweibo.BLL.blogInfo();
        //[WebMethod]
        ////被举报微博删除
        //public bool Delete(int messageId, int blogId)
        //{
        //    starweibo.Model.messageInfo onemsg = new messageInfo();
        //    starweibo.BLL.messageInfo bllmsg = new starweibo.BLL.messageInfo();
        //    onemsg = bllmsg.GetModel(messageId);
        //    onemsg.msgState = "read";
        //    Msg.Update(onemsg);

        //    starweibo.Model.blogInfo oneblog = new blogInfo();
        //    starweibo.BLL.blogInfo bllmsgP = new starweibo.BLL.blogInfo();
        //    oneblog = bllmsgP.GetModel(blogId);
        //    oneblog.blogState = "delete";

        //    return blog.Update(oneblog);
        //}

        private starweibo.BLL.powerInfo pow = new starweibo.BLL.powerInfo();
        [WebMethod]
        //被举报用户禁言
        public bool jinyan(int messageId, int userId)
        {
            starweibo.Model.messageInfo onemsg = new messageInfo();
            starweibo.BLL.messageInfo bllmsg = new starweibo.BLL.messageInfo();
            onemsg = bllmsg.GetModel(messageId);
            onemsg.msgState = "read";
            Msg.Update(onemsg);

            starweibo.Model.powerInfo onemsgP = new powerInfo();
            starweibo.BLL.powerInfo bllmsgP = new starweibo.BLL.powerInfo();
            onemsgP = bllmsgP.GetModel(userId);
            onemsgP.fasong = "0";

            return pow.Update(onemsgP);
        }

        //private starweibo.BLL.chatInfo SysMsg = new starweibo.BLL.chatInfo();
        //[WebMethod]
        ////发送公告
        //public string SendSysMsg(string msgContent)
        //{
        //    starweibo.Model.userInfo SSM = new userInfo();
        //    starweibo.BLL.userInfo bllSSM = new starweibo.BLL.userInfo();
        //    SSM = bllSSM.GetList();

        //    return SysMsg.Add(msgContent);
        //}

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
            return pow.Update(usp);
        }
    }
}
