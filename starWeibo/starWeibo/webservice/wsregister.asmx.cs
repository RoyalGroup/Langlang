using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace starWeibo.webservice
{
    /// <summary>
    /// wsregister 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class wsregister : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string shenqing(string userName, string userPwd, string userMail)
        {
            starweibo.Model.userInfo shengqing = new starweibo.Model.userInfo();
            starweibo.BLL.userInfo oneshenqing = new starweibo.BLL.userInfo();
            shengqing.userName = userName;
            shengqing.userPwd = userPwd;
            shengqing.userMail = userMail;
            return oneshenqing.Add(shengqing).ToString();

        }
    }
}
