using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace starWeibo.at
{
    public partial class comment : System.Web.UI.Page
    {
        starweibo.BLL.replyV comments = new starweibo.BLL.replyV();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null || Session["userid"].ToString() == "")
            {
                Response.Redirect("login.aspx");
            }
            else
            { 
                int userid = (int)Session["userid"];
                this.commentDL.DataSource = comments.GetListByPage("blogAuthorId = "+userid+"","pubTime",0,10);
                this.commentDL.DataBind();
            }
        }
    }
}