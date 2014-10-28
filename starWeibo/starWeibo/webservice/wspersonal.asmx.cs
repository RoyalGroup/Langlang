using System;
using System.Collections.Generic;
using System.Drawing;
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

        [WebMethod]
        //更新用户联系信息
        public string updateUserCominfo(string id, string userMail, string QQnumber, string userTell)
        {
            curUser = user.GetModel(Convert.ToInt32(id));
            curUser.userMail = userMail;
            curUser.QQnumber = QQnumber;
            curUser.userTell = userTell;
            return user.Update(curUser).ToString();
        }

        [WebMethod]
        //更新用户教育信息
        public string updateUserEduinfo(string id, string userEdu)
        {
            curUser = user.GetModel(Convert.ToInt32(id));
            curUser.userEdu = userEdu;
            return user.Update(curUser).ToString();
        }
        [WebMethod]
        //更新用户头像
        public string updateUserHeadImg(string id, string headImg)
        {
            curUser = user.GetModel(Convert.ToInt32(id));
            curUser.userHeadimage = headImg;
            return user.Update(curUser).ToString();
        }
        [WebMethod]
        //修改用户密码
        public string updateUserPwd(string id, string newpwd)
        {
            curUser = user.GetModel(Convert.ToInt32(id));
            curUser.userPwd = newpwd;
            return user.Update(curUser).ToString();
        }
        [WebMethod]
        //验证用户密码
        public string checkUserPwd(string id, string inputPwd)
        {
            curUser = user.GetModel(Convert.ToInt32(id));
            if(curUser.userPwd == inputPwd)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }
        /// <summary>
        /// 保存截图
        /// </summary>
        /// <param name="originalImagePath">原始图片路径</param>
        /// <param name="x1">图片裁剪区域的左上角X坐标</param>
        /// <param name="x2">图片裁剪区域的左上角Y坐标</param>
        /// <param name="selectwidth">图片裁剪区域的宽度</param>
        /// <param name="selectheight">图片区裁剪区域的高度</param>
        /// <param name="width">欲生成的图片的宽度</param>
        /// <param name="height">欲生成的图片的宽度</param>
        [WebMethod]
        public string MakeThumbnail(string originalImagePath,int x1,int y1,int selectwidth,int selectheight, int width, int height)
        {
            originalImagePath = Server.MapPath(originalImagePath);
            originalImagePath = originalImagePath.Replace("\\webservice", "");
            System.Drawing.Image originalImage = System.Drawing.Image.FromFile(originalImagePath);
            int towidth = width;
            int toheight = height;
            int x = x1;
            int y = y1;
            int ow = originalImage.Width;
            int oh = originalImage.Height;
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);
            //新建一个画板
            Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            //设置高质量插值法
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //清空画布并以透明背景色填充
            g.Clear(Color.Transparent);
            //在指定位置并且按指定大小绘制原图片的指定部分
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight), new Rectangle(x, y, selectwidth, selectheight), GraphicsUnit.Pixel);
            try
            {
                string Path = "images/photos/" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".jpg";
                string savePath = Server.MapPath(Path);
                savePath = savePath.Replace("\\webservice", "");
                //以jpg格式保存缩略图
                bitmap.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                return Path;
            }
            catch (System.Exception e)
            {
                return e.ToString();
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }
        }
    }
}
