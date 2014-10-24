using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace starWeibo
{
    public partial class personalCenter : System.Web.UI.Page
    {
        private string userid;
        private starweibo.BLL.userInfo user = new starweibo.BLL.userInfo();
        private starweibo.BLL.blogInfo blog = new starweibo.BLL.blogInfo();
        private starweibo.BLL.relationInfo relation = new starweibo.BLL.relationInfo();
        public starweibo.Model.userInfo curUser = new starweibo.Model.userInfo();
        public int focusCountd = 0;//用户关注的个数
        public int fansCount = 0;//用户的粉丝数
        public int blogCount = 0;//用户的博客数
        public string[] userAddress = new string[3];//用户所在地
        protected void Page_Load(object sender, EventArgs e)
        {
            userid = Session["userid"].ToString();
            curUser = user.GetModel(Convert.ToInt32(userid));//获得当前用户对象
            if (curUser.userAddress != null && curUser.userAddress != "")
            {
                userAddress = curUser.userAddress.Split('-');
            }
            else
            {
                userAddress = new string[] { "未设置", "未设置", "未设置" };
            }
            focusCountd = relation.GetRecordCount("userId=" + curUser.id.ToString());
            fansCount = relation.GetRecordCount("friendId=" + curUser.id.ToString());
            blogCount = blog.GetRecordCount("blogAuthorId=" + curUser.id.ToString());

        }
       
        public string getshortTime(DateTime dt)
        {
            return dt.ToShortDateString();
        }

        //获取用户简介，des为简介的内容,isheader是简介是否显示在header区
        public string getUserDes(string des, bool isheader)
        {
            if (isheader == true)
                return des == null || des == "" ? "一句话介绍一下自己吧，让别人更了解你" : des;
            else
            {
                string html = "";
                html += "<a href='javascript:void(0)' action-data='type=desc' action-type='quickedit' belong='baseInfo'>";
                html += "    <i class='W_ico16 icon_edit'></i>";
                html += "马上填写</a>自己的个人介绍,让大家快速了解真实的你";
                return des == null || des == "" ? html : des;
            }
        }

        //获取用户所在地，address为简介的内容,isheader是简介是否显示在header区
        public string getUserAddress(string address, bool isheader)
        {
            if (isheader == true)
                return address == "" || address == "未设置-未设置-未设置" ? "未设置所在地" : address.Replace("-", " ");
            else
            {
                string html = "";
                html += "<a href='javascript:void(0)' action-data='type=address' action-type='quickedit' belong='baseInfo'>";
                html += "    <i class='W_ico16 icon_edit'></i>";
                html += "马上填写</a>自己的所在地,让大家快速了解你不是老乡";
                return address == null || address == "" ? html : address.Replace("-", " ");
            }
        }

        //获取用户邮箱
        public string getUserEmail(string email)
        {
            string html = "";
            html += "<a href='javascript:void(0)' action-data='type=email' action-type='quickedit' belong='comInfo'>";
            html += "    <i class='W_ico16 icon_edit'></i>";
            html += "马上填写</a>你的电子邮箱";
            return email == null || email == "" ? html : email;
        }

        //获取用户电话号码
        public string getUserTel(string tel)
        {
            string html = "";
            html += "<a href='javascript:void(0)' action-data='type=tel' action-type='quickedit' belong='comInfo'>";
            html += "    <i class='W_ico16 icon_edit'></i>";
            html += "马上填写</a>你的电话号码";
            return tel == null || tel == "" ? html : tel;
        }

        //获取用户QQ号码
        public string getUserQQ(string qq)
        {
            string html = "";
            html += "<a href='javascript:void(0)' action-data='type=qq' action-type='quickedit' belong='comInfo'>";
            html += "    <i class='W_ico16 icon_edit'></i>";
            html += "马上填写</a>你的QQ信息";
            return qq == null || qq == "" ? html : qq;
        }

        //获取用户教育信息
        public string getUserEduinfo(string edu)
        {
            string html = "";
            html += "<a href='javascript:void(0)' action-data='type=qq' action-type='quickedit' belong='eduInfo'>";
            html += "    <i class='W_ico16 icon_edit'></i>";
            html += "马上填写</a>你的学校信息";
            return edu == null || edu == "" ? html : edu;
        }

        //获取用户教育信息
        public string getUserBirthday(string birthday)
        {
            string html = "";
            html += "<a href='javascript:void(0)' action-data='type=birth' action-type='quickedit' belong='baseInfo'>";
            html += "    <i class='W_ico16 icon_edit'></i>";
            html += "马上填写</a>自己的生日,可以收到更多的生日祝福哦";
            return birthday == null || birthday == "" ? html : birthday;
        }

        //获取用户感情状况
        public string getUserLoveInfo(string love)
        {
            string html = "";
            html += "<a href='javascript:void(0)' action-data='type=love' action-type='quickedit' belong='baseInfo'>";
            html += "    <i class='W_ico16 icon_edit'></i>";
            html += "马上填写</a>自己的感情状况,让更多的人了解你";
            return love == null || love == "" ? html : love;
        }

        //获取用户性别
        public string getUserSex(string sex,bool isheader)
        {
            if (isheader == true)
            {
                return sex == null || sex == "" ? "性别保密" : "<em class='W_ico12 male' title='"+sex+"'></em>";
            }
            else
            {
                string html = "";
                html += "<a href='javascript:void(0)' action-data='type=sex' action-type='quickedit' belong='baseInfo'>";
                html += "    <i class='W_ico16 icon_edit'></i>";
                html += "马上填写</a>自己的性别,让更多的人了解你";
                return sex == null || sex == "" ? html : sex;
            }
        }
       
    }
}