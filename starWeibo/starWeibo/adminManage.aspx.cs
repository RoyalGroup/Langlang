﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using starweibo.BLL;

namespace starWeibo
{
    public partial class adminManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["adminName"] == null || Session["adminName"].ToString()=="")
            {
                Response.Redirect("adminLogin.aspx");
            }
            //starweibo.BLL.userInfo blluserInfo = new userInfo();
            //List<starweibo.Model.userInfo> userInfos = blluserInfo.GetModelList("1=1");
            //this.rptuserInfoList.DataSource = userInfos;
            //this.rptuserInfoList.DataBind();

            //starweibo.BLL.powerInfo bllpowerInfo = new powerInfo();
            //List<starweibo.Model.powerInfo> powerInfos = bllpowerInfo.GetModelList("1=1");
            //this.rptpowerInfoList.DataSource = powerInfos;
            //this.rptpowerInfoList.DataBind();
            
            starweibo.BLL.powerV bllpowerV = new powerV();
            List<starweibo.Model.powerV> powerVs = bllpowerV.GetModelList("1=1");
            this.rptpowerInfoList.DataSource = powerVs;
            this.rptpowerInfoList.DataBind();

            starweibo.BLL.reportV bllreportV = new reportV();
            List<starweibo.Model.reportV> reportVs = bllreportV.GetModelList("msgState='noread'");
            this.rtpreportVList.DataSource = reportVs;
            this.rtpreportVList.DataBind();            
        }

        protected void btnadminzhuxiao_Click(object sender, EventArgs e)
        {
            Session["adminName"] = "";
            Response.Redirect("adminLogin.aspx");
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            //SearchButton.Attributes.Add("onClick", "return false");
            starweibo.BLL.powerV bllpowerV = new powerV();
            List<starweibo.Model.powerV> spVs = bllpowerV.GetModelList("userName like '%" + this.searchContent.Value + "%'");
            this.rptspInfoList.DataSource = spVs;
            this.rptspInfoList.DataBind();
        }
    }
}