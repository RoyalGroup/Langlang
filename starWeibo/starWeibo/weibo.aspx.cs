using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace starWeibo.at
{
    public partial class weibo : System.Web.UI.Page
    {
        starweibo.BLL.atV atInfo = new starweibo.BLL.atV();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"]==null||Session["username"].ToString()=="")
            {
                //Response.Redirect("login.aspx"); 
            }
            this.weiboDL.DataSource = atInfo.GetListByPage("1=1","blogPubTime",0,10);
            this.weiboDL.DataBind();
        }
    }
}