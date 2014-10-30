using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace starWeibo.webservice
{
    /// <summary>
    /// wsdetailmessage 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class wsdetailmessage : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(EnableSession = true)]
        public int dtmessage(int receiveId, string content)
        {
            int sendid = Convert.ToInt32(Session["userid"]);
            //int sendid = 1;
            starweibo.Model.chatInfo onechat = new starweibo.Model.chatInfo();
            starweibo.BLL.chatInfo bllchat = new starweibo.BLL.chatInfo();
            onechat.senderId = sendid;
            onechat.receiverId = receiveId;
            onechat.msgContent = content;    
            onechat.msgState = "noread";
            return bllchat.Add(onechat);
        }


        [WebMethod(EnableSession = true)]
        public List<starweibo.Model.chatV> dtnoreadmessage(int sendId)
        {
            int receiveId = Convert.ToInt32(Session["userid"]);
            starweibo.BLL.chatInfo bllchatInfo = new starweibo.BLL.chatInfo();
            //int receiveId = 1;
            starweibo.BLL.chatV bllchatV = new starweibo.BLL.chatV();
            List<starweibo.Model.chatV> mochatV = new List<starweibo.Model.chatV>();
            mochatV = bllchatV.GetModelList("senderId=" + sendId + " and receiverId=" + receiveId + " and msgState='noread'");

            foreach (starweibo.Model.chatV onechatV in mochatV)
            {
                bllchatInfo.myUpdate("read", onechatV.shortMsgId.ToString());
            }

            return mochatV;
        }
    }
}
