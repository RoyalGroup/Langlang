using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using starweibo.BLL;

namespace starWeibo
{
    public partial class playstar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null || Session["userid"].ToString() == "")
            {
                Response.Redirect("login.aspx");
            }
            starweibo.BLL.userInfo blluserInfo = new userInfo();
            List<starweibo.Model.userInfo> userInfos = blluserInfo.GetModelList("id!=44");

            this.focusInfo.DataSource = userInfos;
            this.focusInfo.DataBind();

        }
    }
}