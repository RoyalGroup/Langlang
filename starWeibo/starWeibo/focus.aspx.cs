using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace starWeibo
{
    public partial class focus : System.Web.UI.Page
    {
        public List<starweibo.Model.relationGroupInfo> MgroupInfo = new List<starweibo.Model.relationGroupInfo>();
        public List<starweibo.Model.relationGroupInfo> focusgroupname = new List<starweibo.Model.relationGroupInfo>();
        public List<starweibo.Model.focusV> friendInfo = new List<starweibo.Model.focusV>();
        public List<starweibo.Model.focusV> fansInfo = new List<starweibo.Model.focusV>();
        public int focuscount = 0;
        public int fanscount = 0;
        public int[] groupcount = new int[50];
        public int notgroupcount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null || Session["userid"].ToString() == "")
            {
                Response.Redirect("login.aspx");
            }

            int userID = Convert.ToInt32(Session["userid"]);

            int i = 0;
            starweibo.BLL.relationGroupInfo BLLgroupInfo = new starweibo.BLL.relationGroupInfo();
            MgroupInfo = BLLgroupInfo.GetModelList("userId=" + userID);//把表relationGroupInfo里userId=2的行输出
            starweibo.BLL.focusV BLLfocusInfo = new starweibo.BLL.focusV();
            foreach (starweibo.Model.relationGroupInfo groupinfon in MgroupInfo)
            {
                groupcount[i] = BLLfocusInfo.GetRecordCount("userId="+ userID+"and groupName='" + groupinfon.groupName + "'");
                i++;
            }
            focuscount = BLLfocusInfo.GetRecordCount("userId=" + userID);
            friendInfo = BLLfocusInfo.GetModelList("userId=" + userID);
            fanscount = BLLfocusInfo.GetRecordCount("friendId="+ userID);
            fansInfo = BLLfocusInfo.GetModelList("friendId=" + userID);
            notgroupcount = BLLfocusInfo.GetRecordCount("userId="+ userID+" and groupName='未分组'");

            this.focusInfo.DataSource = friendInfo;
            this.focusInfo.DataBind();

            this.fansinfomation.DataSource = fansInfo;
            this.fansinfomation.DataBind();
        }

    }
}