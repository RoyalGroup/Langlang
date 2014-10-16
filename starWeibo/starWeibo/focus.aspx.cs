using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace starWeibo
{
    public partial class focus : System.Web.UI.Page
    {
        public List<starweibo.Model.relationGroupInfo> MgroupInfo = new List<starweibo.Model.relationGroupInfo>();
        public int focuscount = 0;
        public int[] groupcount =new int[50];
        public int notgroupcount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 0;
            starweibo.BLL.relationGroupInfo BLLgroupInfo = new starweibo.BLL.relationGroupInfo();
            MgroupInfo = BLLgroupInfo.GetModelList("userId=2");//把表relationGroupInfo里userId=2的行输出
            starweibo.BLL.focusV BLLfocusInfo = new starweibo.BLL.focusV();
            foreach (starweibo.Model.relationGroupInfo groupinfon in MgroupInfo)
            {
                groupcount[i] = BLLfocusInfo.GetRecordCount("userId=2 and groupName='" + groupinfon.groupName + "'");
                i++;
            }
            focuscount = BLLfocusInfo.GetRecordCount("userId=2");
            notgroupcount = BLLfocusInfo.GetRecordCount("userId=2 and groupName=''");
        }

    }
}