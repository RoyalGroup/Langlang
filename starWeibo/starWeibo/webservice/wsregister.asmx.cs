using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Services;

namespace starWeibo.webservice
{
    /// <summary>
    /// wsregister 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class wsregister : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string shenqing(string userName, string userPwd, string userMail)
        {
            starweibo.Model.userInfo shengqing = new starweibo.Model.userInfo();
            starweibo.BLL.userInfo oneshenqing = new starweibo.BLL.userInfo();
            shengqing.userName = userName;
            shengqing.userPwd = userPwd;
            shengqing.userMail = userMail;
            shengqing.userHeadimage = "css/images/personalCenterimages/headimage.jpg";
            return oneshenqing.Add(shengqing).ToString();

        }
        [WebMethod]
        public string Sendyanzheng(string email)
        {
            //系统生成随机验证码
            Random rad = new Random();
            int value = rad.Next(100000, 999999);
            //将生成的验证码通过邮件形式发送给用户
            string formto = "xgjcsyx@126.com";
            string to = email;   //接收邮箱
            string content = "验证码";
            string body = "验证码为：" + value.ToString();
            string name = "xgjcsyx@126.com";
            string upass = "mima12345678";
            string smtp = "smtp.126.com";
            SmtpClient _smtpClient = new SmtpClient();
            _smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
            _smtpClient.Host = smtp; //指定SMTP服务器
            _smtpClient.Credentials = new System.Net.NetworkCredential(name, upass);//用户名和密码
            MailMessage _mailMessage = new MailMessage();
            //发件人，发件人名 
            _mailMessage.From = new MailAddress(formto, "浪浪微博官方");
            //收件人 
            _mailMessage.To.Add(to);
            _mailMessage.SubjectEncoding = System.Text.Encoding.GetEncoding("gb2312");
            _mailMessage.Subject = content;//主题

            _mailMessage.Body = body;//内容
            _mailMessage.BodyEncoding = System.Text.Encoding.GetEncoding("gb2312");//正文编码
            _mailMessage.IsBodyHtml = true;//设置为HTML格式
            _mailMessage.Priority = MailPriority.High;//优先级   
            try
            {
                _smtpClient.Send(_mailMessage);
                return value.ToString();
            }
            catch (Exception error)
            {
                return error.ToString();
            }
        }

    }
}
