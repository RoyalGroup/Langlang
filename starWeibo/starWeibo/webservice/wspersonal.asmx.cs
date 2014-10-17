using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace starWeibo.webservice
{
    /// <summary>
    /// wspersonal 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class wspersonal : System.Web.Services.WebService
    {
        private starweibo.BLL.userInfo user = new starweibo.BLL.userInfo();
        public starweibo.Model.userInfo curUser = new starweibo.Model.userInfo();
        
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        //更新用户基本信息
        public string updateUserBaseinfo(string id, string userName, string userAddress, string userSex, string userMarry, string userBirthday, string userDes)
        {
            curUser = user.GetModel(Convert.ToInt32(id));
            curUser.userName=userName;
            curUser.userAddress = userAddress;
            curUser.userSex = userSex;
            curUser.userMarry = userMarry;
            curUser.userBirthday = userBirthday;
            curUser.userDes = userDes;
            return user.Update(curUser).ToString();
        }
        
    }
}
