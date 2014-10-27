using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.ComponentModel;

namespace starWeibo
{
    public partial class detailmessage : System.Web.UI.Page
    {
        public starweibo.Model.userInfo curuser;
        public int curid;
        public string sendname="11";
        public string sendid = "2";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null || Session["userid"].ToString() == "")
            {
                Response.Redirect("login.aspx");
            }
            curuser = (starweibo.Model.userInfo)Session["user"];
            sendname = Request.QueryString["sendname"].ToString();
            sendid = Request.QueryString["sendid"].ToString();
            
            curid = Convert.ToInt32(Session["userid"]);
            
            starweibo.BLL.chatV bllchatv = new starweibo.BLL.chatV();
            List<starweibo.Model.chatV> modchatV = new List<starweibo.Model.chatV>();
            modchatV = bllchatv.GetModelList("(senderId="+curid+" and receiverId="+sendid+") or (senderId="+sendid+" and receiverId="+curid+") order by pubTime desc");
            this.msgdialogue.DataSource = modchatV;
            this.msgdialogue.DataBind();
        }

        //protected string check(int id)
        //{
        //    if (id == curid)
        //        return "l";
        //    else
        //        return "r";
        //}
    }
}