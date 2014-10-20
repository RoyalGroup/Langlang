using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace starWeibo
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
    //public static void Sends(string email) 
    //    {
    //        string formto = "发件箱地址";
    //        string to = email;   //接收邮箱
    //        string content = "";
    //        string body = "";
    //        string name = "发件箱";
    //        string upass = "密码";
    //        string smtp = "smtp地址";
    //        SmtpClient _smtpClient = new SmtpClient();            
    //        _smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
    //        _smtpClient.Host = smtp; //指定SMTP服务器
    //        _smtpClient.Credentials = new System.Net.NetworkCredential(name, upass);//用户名和密码
    //        MailMessage _mailMessage = new MailMessage();
    //        //发件人，发件人名 
    //        _mailMessage.From = new MailAddress(formto, "别名");
    //        //收件人 
    //        _mailMessage.To.Add(to);
    //        _mailMessage.SubjectEncoding = System.Text.Encoding.GetEncoding("gb2312");
    //        _mailMessage.Subject = content;//主题
 
    //        _mailMessage.Body = body;//内容
    //        _mailMessage.BodyEncoding = System.Text.Encoding.GetEncoding("gb2312");//正文编码
    //        _mailMessage.IsBodyHtml = true;//设置为HTML格式
    //        _mailMessage.Priority = MailPriority.High;//优先级   
    //        try
    //        {
    //            _smtpClient.Send(_mailMessage);
    //        }
    //        catch (Exception)
    //        {
                                 
    //        }
             
    //    }
}