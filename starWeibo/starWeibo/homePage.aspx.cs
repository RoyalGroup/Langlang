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
        starweibo.BLL.blogInfo bll = new starweibo.BLL.blogInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<starweibo.Model.blogInfo> bloginfo = new List<starweibo.Model.blogInfo>();
            this.wbList.DataSource = bll.GetListByPage("T.blogAuthorId=U.id", "blogPubTime", 0, 20);
            this.wbList.DataBind();
        }
    }
}