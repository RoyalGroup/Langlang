using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace starWeibo.webservice
{
    /// <summary>
    /// forgetpwd 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class forgetpwd : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        //验证邮箱
        [WebMethod]
        public string check(string userName)
        {
            starweibo.BLL.userInfo findmail = new starweibo.BLL.userInfo();
            List<starweibo.Model.userInfo> MNoteName = new List<starweibo.Model.userInfo>();
            MNoteName = findmail.GetModelList("userName='" + userName + "'");
            return MNoteName[0].userMail;  
        }
        //重置密码
        [WebMethod]
        public bool chongzhi(string userPwd,string userName)
        {
            List<starweibo.Model.userInfo> shengqing = new List<starweibo.Model.userInfo>();
            starweibo.BLL.userInfo oneshenqing = new starweibo.BLL.userInfo();
            shengqing= oneshenqing.GetModelList("userName='" + userName + "'");
            shengqing[0].userPwd = userPwd;
            return oneshenqing.Update(shengqing[0]);
        }
    }
}
