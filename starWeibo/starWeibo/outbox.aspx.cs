﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace starWeibo.comment
{
    public partial class outBox : System.Web.UI.Page
    {
        starweibo.BLL.chatV chatlist = new starweibo.BLL.chatV();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null || Session["userid"].ToString() == "")
            {
                Response.Redirect("login.aspx");
            }
            else
            {
                int userid = (int)Session["userid"];
                starweibo.BLL.userInfo blluserinfo = new starweibo.BLL.userInfo();
                DataSet ds = blluserinfo.GetList("id in (select receiverId from chatV group by senderId,receiverId having senderId=" + userid + ") ");
                //this.chatDL.DataSource = chatlist.GetListByPage("receiverid = "+userid+"","pubTime",0,10);
                this.chatDL.DataSource = ds;
                this.chatDL.DataBind();
            }
        }
    }
}