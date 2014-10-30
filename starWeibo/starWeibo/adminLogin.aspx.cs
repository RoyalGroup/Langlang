using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using starweibo.BLL;



namespace starWeibo
{
    public partial class adminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public int i=-1;
        public int cadmincount;
        public string cusername;
        public string cuserpwd;
        public List<starweibo.Model.adminInfo> cadminInfo;
        protected void btnadminLogin_Click(object sender, EventArgs e)
        {
            cusername = (this.adminName.Value == "用户名" ? null : this.adminName.Value);
            cuserpwd = (this.adminPwd.Value == "请输入密码" ? null : this.adminPwd.Value);
            if (cusername != null && cuserpwd != null)
            {
                starweibo.BLL.adminInfo curuser = new adminInfo();
                cadminInfo = curuser.GetModelList("adminName='" + cusername + "'");
                cadmincount = curuser.GetRecordCount("adminName='" + cusername + "'");
                if (cadmincount == 0)
                {
                    i = 0;
                }
                else
                {
                    if (cadminInfo[0].adminPwd == adminPwd.Value)
                    {
                        Session["adminName"] = cusername;
                        Session["adminPwd"] = cuserpwd;
                        Response.Redirect("~/adminManage.aspx");
                    }
                    else
                    {
                        i = 1;
                    }
                }
            }
        }
    }
}