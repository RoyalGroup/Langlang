using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using starweibo.Model;
using starweibo.BLL;
using System.Data;

namespace starWeibo.webservice
{
    /// <summary>
    /// wshomepage 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class wshomepage : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod (EnableSession = true)]
        public int publishBlog(int userId, string content)
        {
            starweibo.Model.blogInfo oneblog = new starweibo.Model.blogInfo();
            starweibo.BLL.blogInfo bllblog = new starweibo.BLL.blogInfo();
            oneblog.blogAuthorId = userId;
            oneblog.blogContent = content;
            return bllblog.Add(oneblog);
        }

        [WebMethod (EnableSession = true)]
        public int publishMessage(int blogid, string content, int typeid, int parentid)
        {
            starweibo.Model.messageInfo oneMsg = new starweibo.Model.messageInfo();
            starweibo.BLL.messageInfo bllMsg = new starweibo.BLL.messageInfo();
            oneMsg.userId = Convert.ToInt32(Session["userid"]);
            oneMsg.blogId = blogid;
            oneMsg.msgContent = content;
            oneMsg.msgTypeId = typeid;
            oneMsg.parentId = parentid;
            return bllMsg.Add(oneMsg);
        }

        [WebMethod(EnableSession = true)]
        public int getPublishBlogId(int userid)
        {
            starweibo.BLL.blogInfo bllBlog = new starweibo.BLL.blogInfo();
            DataSet ds = bllBlog.GetList(1, "blogAuthorId='" + userid + "'", "BlogId DESC");
            int blogid= Convert.ToInt32(ds.Tables[0].Rows[0]["BlogId"]);
            return blogid;
        }
        
    }
}
