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
        /// <summary>
        /// 发表微博
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        [WebMethod (EnableSession = true)]
        public int publishBlog(int userId, string content,int parentid)
        {
            starweibo.Model.blogInfo oneblog = new starweibo.Model.blogInfo();
            starweibo.BLL.blogInfo bllblog = new starweibo.BLL.blogInfo();
            oneblog.blogAuthorId = userId;
            oneblog.blogContent = content;
            if (parentid != 0) {
                oneblog.parentId = parentid;
            }
            return bllblog.Add(oneblog);
        }
        /// <summary>
        /// 对微博的各种操作，如收藏，赞，评论等
        /// </summary>
        /// <param name="blogid"></param>
        /// <param name="content"></param>
        /// <param name="typeid"></param>
        /// <param name="parentid"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 获取最新发表的微博ID
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        [WebMethod(EnableSession = true)]
        public int getPublishBlogId(int userid)
        {
            starweibo.BLL.blogInfo bllBlog = new starweibo.BLL.blogInfo();
            DataSet ds = bllBlog.GetList(1, "blogAuthorId='" + userid + "'", "BlogId DESC");
            int blogid= Convert.ToInt32(ds.Tables[0].Rows[0]["BlogId"]);
            return blogid;
        }

        /// <summary>
        /// 点击微博下的评论后，显示当前微博的评论列表
        /// </summary>
        /// <param name="blogid"></param>
        /// <param name="msgType"></param>
        /// <returns></returns>
        [WebMethod(EnableSession = true)]
        public List<starweibo.Model.messageV> getReplyMsg(int blogid,int msgType)
        {
            starweibo.BLL.messageV bllMsgV = new starweibo.BLL.messageV();
            List<starweibo.Model.messageV> MsgV = new List<starweibo.Model.messageV>();
            DataSet ds=bllMsgV.GetListByPage("msgTypeId='"+msgType+"' and blogId='"+blogid+"'","pubTime desc",0,10);
            //foreach (DataRow row in ds.Tables[0].Rows)
            MsgV=bllMsgV.DataTableToList(ds.Tables[0]);
            return MsgV;

        }
        /// <summary>
        /// 加载更多
        /// </summary>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        [WebMethod(EnableSession = true)]
        public List<starweibo.Model.fullblogInfoV> fengye(int startIndex, int endIndex)
        {
            starweibo.BLL.fullblogInfoV bllmnblog = new starweibo.BLL.fullblogInfoV();
            List<starweibo.Model.fullblogInfoV> bloginfon = new List<starweibo.Model.fullblogInfoV>();
            DataSet dbloginfon = bllmnblog.GetListByPage("blogAuthorId in (select friendId from relationInfo where userId=" + Convert.ToInt32(Session["userid"]) + ")or blogAuthorId=" + Convert.ToInt32(Session["userid"]), "blogPubTime desc", startIndex, endIndex);
            List<starweibo.Model.fullblogInfoV> blogsn = bllmnblog.DataTableToList(dbloginfon.Tables[0]);
            return blogsn;
        }
        /// <summary>
        /// 更新赞的数据
        /// </summary>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        [WebMethod(EnableSession = true)]
        public bool updateBlogZan(int blogid, int zannum)
        {
            starweibo.Model.blogInfo model = new starweibo.Model.blogInfo();
            starweibo.BLL.blogInfo bllmnblog = new starweibo.BLL.blogInfo();
            model.blogId = blogid;
            model.zanNum = zannum;
            return bllmnblog.UpdateZan(model);
        }
        /// <summary>
        /// 更新评论数据
        /// </summary>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        [WebMethod(EnableSession = true)]
        public bool updateBlogpl(int blogid, int plnum)
        {
            starweibo.Model.blogInfo model = new starweibo.Model.blogInfo();
            starweibo.BLL.blogInfo bllmnblog = new starweibo.BLL.blogInfo();
            model.blogId = blogid;
            model.plNum = plnum;
            return bllmnblog.Updatepl(model);
        }

        /// <summary>
        /// 获取赞和收藏的微博
        /// </summary>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        [WebMethod(EnableSession = true)]
        public List<starweibo.Model.messageInfo> loadingZanSc(int typeid)
        {
            starweibo.BLL.messageInfo bllmnblog = new starweibo.BLL.messageInfo();
            List<starweibo.Model.messageInfo> model = new List<starweibo.Model.messageInfo>();
            DataSet ds = bllmnblog.GetList("userId='"+Convert.ToInt32(Session["userid"])+"' and msgTypeId='"+typeid+"'");
            model = bllmnblog.DataTableToList(ds.Tables[0]);
            return model;
        }
    }
}
