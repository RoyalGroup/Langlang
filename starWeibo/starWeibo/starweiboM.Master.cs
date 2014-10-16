using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace starWeibo
{
    public partial class starweiboM : System.Web.UI.MasterPage
    {
        public int unreadCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            starweibo.BLL.messageInfo wrwe = new starweibo.BLL.messageInfo();
            unreadCount = wrwe.GetRecordCount("userId=1 and msgState='noread'");
        }
    }
}