using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace starWeibo
{
    public partial class homePage : System.Web.UI.Page
    {
        starweibo.BLL.fullblogInfoV bll = new starweibo.BLL.fullblogInfoV();
        public starweibo.Model.userInfo curuser;
        public int pages;
        public int curpre;
        private starweibo.BLL.userInfo user = new starweibo.BLL.userInfo();
        private starweibo.BLL.blogInfo blog = new starweibo.BLL.blogInfo();
        private starweibo.BLL.relationInfo relation = new starweibo.BLL.relationInfo();
        public starweibo.Model.userInfo curUser = new starweibo.Model.userInfo();
        public int focusCountd = 0;//用户关注的个数
        public int fansCount = 0;//用户的粉丝数
        public int blogCount = 0;//用户的博客数
        protected void Page_Load(object sender, EventArgs e)
        {
            string pre = Request.QueryString["pre"] != "" ? Request.QueryString["pre"] : "0";
            //string next = Request.QueryString["next"] != "" ? Request.QueryString["next"] : "2"; 
            curuser = (starweibo.Model.userInfo)Session["user"];
            if (Session["username"] == null || Session["username"].ToString() == "")
            {
                Response.Redirect("login.aspx");
            }
            //查询个人信息
            focusCountd = relation.GetRecordCount("userId=" + Session["userid"].ToString());
            fansCount = relation.GetRecordCount("friendId=" + Session["userid"].ToString());
            blogCount = blog.GetRecordCount("blogAuthorId=" + Session["userid"].ToString());
            //分页显示微博
            List<starweibo.Model.fullblogInfoV> bloginfo = new List<starweibo.Model.fullblogInfoV>();
            int count = bll.GetRecordCount("blogAuthorId in (select friendId from relationInfo where userId=" + Convert.ToInt32(Session["userid"]) + ") or blogAuthorId=" + Convert.ToInt32(Session["userid"]));
            int countyushu = count % 40;
            pages = count / 40;
            if (countyushu > 0) {
                pages++;
            }
            pages = (pages <= 10) ? pages : 10;
            curpre = Convert.ToInt32(pre);
            int startindex = curpre * 40 + 1;
            int endindex = curpre * 40 + 40;
            string sql="T.blogAuthorId in (select friendId from relationInfo where userId="+ Convert.ToInt32(Session["userid"]) + ")";
            sql+=" or T.blogAuthorId=" + Convert.ToInt32(Session["userid"]) + "";
            this.wbList.DataSource = bll.GetListByPage(sql, "blogPubTime desc", startindex, endindex);
            this.wbList.DataBind();

        }
    }
}