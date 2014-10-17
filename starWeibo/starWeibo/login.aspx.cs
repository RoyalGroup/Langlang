using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using starweibo.BLL;

namespace starWeibo
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string cusername = (this.username.Value == "用户名/邮箱" ? null : this.username.Value);
            string cuserpwd = (this.userpwd.Value == "请输入密码" ? null : this.userpwd.Value);
            if (cusername != null && cuserpwd != null)
            {
                starweibo.BLL.userInfo curuser = new userInfo();
                List<starweibo.Model.userInfo> curuserinfo = curuser.GetModelList("userName='" + cusername + "'");
                //starweibo.Model.userInfo oneuser = curuser.GetModelList("userName='" + cusername + "'")[0];
                //starweibo.Model.userInfo oneusern = curuser.GetModel(2);
                //Response.Write(curuserinfo.Count.ToString());
                if (curuserinfo[0].userPwd == userpwd.Value)
                {
                    Session["userid"] = curuserinfo[0].id;
                    Session["username"] = cusername;
                    Session["userpwd"] = cuserpwd;
                    Response.Redirect("~/homePage.aspx");//~/zhujiemian.aspx
                }
            }
        }
    }
}