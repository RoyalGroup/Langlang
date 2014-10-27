using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace starWeibo.webservice
{
    /// <summary>
    /// wsfocus 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class wsfocus : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod(EnableSession=true)]
        public bool getgroupId(int friendid, int newgroupId)
        {
            string userid = Session["userid"].ToString();
            //int userid = 2;
            starweibo.BLL.relationInfo bgroupid = new starweibo.BLL.relationInfo();
            List<starweibo.Model.relationInfo> mgroupid = new List<starweibo.Model.relationInfo>();
            mgroupid = bgroupid.GetModelList("friendId="+friendid+" and userId=" + userid);
            mgroupid[0].groupId = newgroupId;
            return bgroupid.Update(mgroupid[0]);
        }

        //修改备注
        [WebMethod(EnableSession = true)]
        public bool ChangeNoteName(int friendId, string friendNoteName)
        {
            string userid = Session["userid"].ToString();
            
            starweibo.BLL.relationInfo BNoteName = new starweibo.BLL.relationInfo();
            List <starweibo.Model.relationInfo> MNoteName = new List<starweibo.Model.relationInfo>();

            MNoteName = BNoteName.GetModelList("friendId=" + friendId + " and userId=" + userid);
            MNoteName[0].friendNoteName=friendNoteName;
            return BNoteName.Update(MNoteName[0]);
        }

        //取消关注
        [WebMethod(EnableSession = true)]
        public bool quxiaoguanzhu(int friendId)
        {
            string userid = Session["userid"].ToString();

            starweibo.BLL.relationInfo BNoteName = new starweibo.BLL.relationInfo();
            List<starweibo.Model.relationInfo> MNoteName = new List<starweibo.Model.relationInfo>();

            MNoteName = BNoteName.GetModelList("friendId=" + friendId + " and userId=" + userid);
            int id=MNoteName[0].id;
            return BNoteName.Delete(id);
        }

        //关注
        [WebMethod(EnableSession = true)]
        public int guanzhu(int friendId)
        {
            string userid = Session["userid"].ToString();
            starweibo.BLL.relationInfo Bguanzhu = new starweibo.BLL.relationInfo();
            starweibo.Model.relationInfo Mguanzhu = new starweibo.Model.relationInfo();
            List<starweibo.Model.relationInfo> MfriendId = new List<starweibo.Model.relationInfo>();

            MfriendId = Bguanzhu.GetModelList("friendId=" + friendId + " and userId=" + userid);
            if (MfriendId == null)
            {
                Mguanzhu.userId = Convert.ToInt32(userid);
                Mguanzhu.friendId = friendId;
                Mguanzhu.groupId = 6;

                return Bguanzhu.Add(Mguanzhu);
            }
            else
            {
                return -1;
            }
        }

        //移除粉丝
        [WebMethod(EnableSession = true)]
        public bool yichufensi(int friendId)
        {
            string userid = Session["userid"].ToString();

            starweibo.BLL.relationInfo BNoteName = new starweibo.BLL.relationInfo();
            List<starweibo.Model.relationInfo> MNoteName = new List<starweibo.Model.relationInfo>();

            MNoteName = BNoteName.GetModelList("friendId=" + userid + " and userId=" + friendId);
            int id = MNoteName[0].id;
            return BNoteName.Delete(id);
        }
    }
}
