using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using starweibo.BLL;
namespace starweibo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            starweibo.BLL.adminInfo bllAdmin = new adminInfo();
            List<starweibo.Model.adminInfo> admins = bllAdmin.GetModelList("1=1");
            this.rtpadminList.DataSource = admins;
            this.rtpadminList.DataBind();

            starweibo.BLL.blogInfo bllblogInfo = new blogInfo();
            List<starweibo.Model.blogInfo> blogInfos = bllblogInfo.GetModelList("1=1");
            this.rptblogInfoList.DataSource = blogInfos;
            this.rptblogInfoList.DataBind();

            starweibo.BLL.chatInfo bllchatInfo = new chatInfo();
            List<starweibo.Model.chatInfo> chatInfos = bllchatInfo.GetModelList("1=1");
            this.rptchatInfoList.DataSource = chatInfos;
            this.rptchatInfoList.DataBind();

            starweibo.BLL.messageInfo bllmessageInfo = new messageInfo();
            List<starweibo.Model.messageInfo> messageInfos = bllmessageInfo.GetModelList("1=1");
            this.rptmessageInfoList.DataSource = messageInfos;
            this.rptmessageInfoList.DataBind();

            starweibo.BLL.photoGroupInfo bllphotoGroupInfo = new photoGroupInfo();
            List<starweibo.Model.photoGroupInfo> photoGroupInfos = bllphotoGroupInfo.GetModelList("1=1");
            this.rptphotoGroupInfoList.DataSource = photoGroupInfos;
            this.rptphotoGroupInfoList.DataBind();

            starweibo.BLL.photos bllphotos = new photos();
            List<starweibo.Model.photos> photoss = bllphotos.GetModelList("1=1");
            this.rptphotosList.DataSource = photoss;
            this.rptphotosList.DataBind();

            starweibo.BLL.powerInfo bllpowerInfo = new powerInfo();
            List<starweibo.Model.powerInfo> powerInfos = bllpowerInfo.GetModelList("1=1");
            this.rptpowerInfoList.DataSource = powerInfos;
            this.rptpowerInfoList.DataBind();

            starweibo.BLL.relationGroupInfo bllrelationGroupInfo = new relationGroupInfo();
            List<starweibo.Model.relationGroupInfo> relationGroupInfos = bllrelationGroupInfo.GetModelList("1=1");
            this.rptrelationGroupInfoList.DataSource = relationGroupInfos;
            this.rptrelationGroupInfoList.DataBind();

            starweibo.BLL.relationInfo bllrelationInfo = new relationInfo();
            List<starweibo.Model.relationInfo> relationInfos = bllrelationInfo.GetModelList("1=1");
            this.rptrelationInfoList.DataSource = relationInfos;
            this.rptrelationInfoList.DataBind();

            starweibo.BLL.typeDic blltypeDic = new typeDic();
            List<starweibo.Model.typeDic> typeDics = blltypeDic.GetModelList("1=1");
            this.rpttypeDicList.DataSource = typeDics;
            this.rpttypeDicList.DataBind();

            starweibo.BLL.userInfo blluserInfo = new userInfo();
            List<starweibo.Model.userInfo> userInfos = blluserInfo.GetModelList("1=1");
            this.rptuserInfoList.DataSource = userInfos;
            this.rptuserInfoList.DataBind();


            starweibo.BLL.atV bllAtV = new atV();
            List<starweibo.Model.atV> atVs = bllAtV.GetModelList("1=1");
            this.rtpatVList.DataSource = atVs;
            this.rtpatVList.DataBind();

            starweibo.BLL.chatV bllchatV = new chatV();
            List<starweibo.Model.chatV> chatVs = bllchatV.GetModelList("1=1");
            this.rtpchatVList.DataSource = chatVs;
            this.rtpchatVList.DataBind();

            starweibo.BLL.CollectionV bllCollectionV = new CollectionV();
            List<starweibo.Model.CollectionV> CollectionVs = bllCollectionV.GetModelList("1=1");
            this.rtpCollectionVList.DataSource = CollectionVs;
            this.rtpCollectionVList.DataBind();

            starweibo.BLL.focusV bllfocusV = new focusV();
            List<starweibo.Model.focusV> focusVs = bllfocusV.GetModelList("1=1");
            this.rtpfocusVList.DataSource = focusVs;
            this.rtpfocusVList.DataBind();

            starweibo.BLL.replyV bllreplyV = new replyV();
            List<starweibo.Model.replyV> replyVs = bllreplyV.GetModelList("1=1");
            this.rtpreplyVList.DataSource = replyVs;
            this.rtpreplyVList.DataBind();

            starweibo.BLL.reportV bllreportV = new reportV();
            List<starweibo.Model.reportV> reportVs = bllreportV.GetModelList("1=1");
            this.rtpreportVList.DataSource = reportVs;
            this.rtpreportVList.DataBind();

            starweibo.BLL.zanV bllzanV = new zanV();
            List<starweibo.Model.zanV> zanVs = bllzanV.GetModelList("1=1");
            this.rtpzanVList.DataSource = zanVs;
            this.rtpzanVList.DataBind();

        }
    }
}