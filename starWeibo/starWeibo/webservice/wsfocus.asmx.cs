using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace starWeibo.webservice
{
    /// <summary>
    /// wsfocus 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
   [System.Web.Script.Services.ScriptService]
    public class wsfocus : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
         [WebMethod(EnableSession=true)]
        public bool getgroupId(int friendid, int newgroupId)
        {
            //string userid = Session["userid"].ToString();
            int userid = 2;
            starweibo.BLL.relationInfo bgroupid = new starweibo.BLL.relationInfo();
            List<starweibo.Model.relationInfo> mgroupid = new List<starweibo.Model.relationInfo>();
            mgroupid = bgroupid.GetModelList("friendId="+friendid+" and userId=" + userid);
            mgroupid[0].groupId = newgroupId;
            return bgroupid.Update(mgroupid[0]);
        }
    }
}
