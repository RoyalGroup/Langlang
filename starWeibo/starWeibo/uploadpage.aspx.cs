using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace starWeibo
{
    public partial class uploadpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpPostedFile file = Request.Files["FileData"];
            string uploadpath = Server.MapPath(Request["folder"] + "\\");
            if (file != null)
            {
                if (!Directory.Exists(uploadpath))
                {
                    Directory.CreateDirectory(uploadpath);
                }
                if (file.ContentLength > 1048576)
                {
                    Response.Write("图片不能大于1MB!");
                    return;
                }
                string extname = file.FileName.Substring(file.FileName.LastIndexOf('.')).ToLower();
                string ext = ".jpg|.png|.gif";
                if (!ext.Contains(extname))
                {
                    Response.Write("请选择[gif,jpg,png]格式图片!"); 
                    return;
                }
                string newname = DateTime.Now.ToString("yyyyMMddHHmmssffff") + extname;
                file.SaveAs(uploadpath + file.FileName);
                Response.Write("1");
            }
            else
            {
                Response.Write("0");
            }
        }
    }
}