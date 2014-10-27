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
        starweibo.BLL.blogInfoV bll = new starweibo.BLL.blogInfoV();
        public starweibo.Model.userInfo curuser;
        public int pages;
        public int curpre;
        protected void Page_Load(object sender, EventArgs e)
        {
            string pre = Request.QueryString["pre"] != "" ? Request.QueryString["pre"] : "0";
            //string next = Request.QueryString["next"] != "" ? Request.QueryString["next"] : "2"; 
            curuser = (starweibo.Model.userInfo)Session["user"];
            if (Session["username"] == null || Session["username"].ToString() == "")
            {
                Response.Redirect("login.aspx");
            }
            List<starweibo.Model.blogInfoV> bloginfo = new List<starweibo.Model.blogInfoV>();
            int count = bll.GetRecordCount("blogAuthorId in (select friendId from relationInfo where userId=" + Convert.ToInt32(Session["userid"]) + ") or blogAuthorId=" + Convert.ToInt32(Session["userid"]));
            pages = count / 40 + 1;
            pages = (pages <= 10) ? pages : 10;
            curpre = Convert.ToInt32(pre);
            int startindex = curpre * 40 + 1;
            int endindex = curpre * 40 + 20;
            string sql="T.blogAuthorId in (select friendId from relationInfo where userId="+ Convert.ToInt32(Session["userid"]) + ")";
            sql+=" or T.blogAuthorId=" + Convert.ToInt32(Session["userid"]) + "";
            this.wbList.DataSource = bll.GetListByPage(sql, "blogPubTime desc", startindex, endindex);
            this.wbList.DataBind();

        }
    }
}