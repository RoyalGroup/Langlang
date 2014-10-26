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
        public int curid;
        public int checkid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null || Session["userid"].ToString() == "")
            {
                //Response.Redirect("login.aspx");
            }
            //curid = Convert.ToInt32(Session["userid"]);
            curid = 1;
            //Request.QueryString[""]
            starweibo.BLL.chatV bllchatv = new starweibo.BLL.chatV();
            List<starweibo.Model.chatV> modchatV = new List<starweibo.Model.chatV>();
            modchatV = bllchatv.GetModelList("(senderId=1 and receiverId=2) or (senderId=2 and receiverId=1) order by pubTime desc");
            this.msgdialogue.DataSource = modchatV;
            this.msgdialogue.DataBind();
        }

        protected bool check(int id)
        {
            if (id == curid)
                return true;
            else
                return false;
        }
    }
}