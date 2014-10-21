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
            if (Session["userid"]==null||Session["userid"].ToString()=="")
            {
                Response.Redirect("login.aspx"); 
            }
            else
            {
                int userid = (int)Session["userid"]; 
                this.weiboDL.DataSource = atInfo.GetListByPage("atId = "+userid+"","blogPubTime",0,10);
                this.weiboDL.DataBind();
            }
           
        }
    }
}