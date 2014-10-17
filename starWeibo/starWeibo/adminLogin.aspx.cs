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

        protected void btnadminLogin_Click(object sender, EventArgs e)
        {
            string cusername = (this.adminName.Value == "用户名" ? null : this.adminName.Value);
            string cuserpwd = (this.adminPwd.Value == "请输入密码" ? null : this.adminPwd.Value);
            if (cusername != null && cuserpwd != null)
            {
                starweibo.BLL.adminInfo curuser = new adminInfo();
                List<starweibo.Model.adminInfo> cadminInfo = curuser.GetModelList("adminName='" + cusername + "'");
                int cadmincount = curuser.GetRecordCount("adminName='" + cusername + "'");
                if (cadmincount ==0)
                {
                    Response.Write ("<script>alert('您输入的用户名不存在请重新输入！')</script>");
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
                        Response.Write ("<script>alert('您输入的用户名或密码不正确请重新输入！')</script>");
                    }
                }
            }
        }
    }
}