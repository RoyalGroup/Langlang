using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using starweibo.Model;
using starweibo.BLL;

namespace starWeibo.webservice
{
    /// <summary>
    /// wshomepage 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class wshomepage : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string publish(int userId, string content)
        {
            starweibo.Model.blogInfo oneblog = new starweibo.Model.blogInfo();
            starweibo.BLL.blogInfo bllblog = new starweibo.BLL.blogInfo();
            oneblog.blogAuthorId = userId;
            oneblog.blogContent = content;
            return bllblog.Add(oneblog).ToString();
        }
    }
}
