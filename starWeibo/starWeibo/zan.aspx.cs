using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace starWeibo
{
    public partial class zan : System.Web.UI.Page
    {
        starweibo.BLL.zanV zans = new starweibo.BLL.zanV();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null || Session["userid"].ToString() == "")
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                int userid = (int)Session["userid"];
                this.zanDL.DataSource = zans.GetListByPage("blogAuthorId = "+userid+"","PubTime",0,10);
                this.zanDL.DataBind();
            }

        }
    }
}