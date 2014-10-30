using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace starWeibo.webservice
{
    /// <summary>
    /// wsmessage 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class wsmessage : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int checkname(string name)
        {
            starweibo.BLL.userInfo blluser = new starweibo.BLL.userInfo();
            List<starweibo.Model.userInfo> moduser = new List<starweibo.Model.userInfo>();
            moduser = blluser.GetModelList("userName='" + name + "'");
            if (moduser.Count == 0)
            {
                return -1;
            }
            else
            {
                return moduser[0].id;
            }
        }
    }
}
