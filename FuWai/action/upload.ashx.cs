using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// upload 的摘要说明
    /// </summary>
    public class upload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            uploadfile(context);
        }

        private void uploadfile(HttpContext context)
        {
            HttpFileCollection files = context.Request.Files;
            string msg = string.Empty;
            string error = string.Empty;
            string filepath = string.Empty;
            if (files.Count > 0)
            {
                string director = context.Server.MapPath("../user/"); //上传目录
                if (!Directory.Exists(director))
                {
                    Directory.CreateDirectory(director);
                }
                string absPath = "../user/";
                string now = DateTime.Now.ToString("yyyyMMddHHmmss");
                string path = director + System.IO.Path.GetFileName(now + "-" + files[0].FileName);
                string fileName = absPath + now + "-" + files[0].FileName;
                if (File.Exists(path))
                {
                    msg = "上传失败，文件存在";
                }
                if ((files[0].ContentLength / 1000) > 1024000)
                {
                    msg = "文件大小超过限制";
                }

                else
                {
                    files[0].SaveAs(path);
                    //返回json数据
                    msg = "上传成功";
                    filepath = fileName;
                }
                string res = "{ error:'" + error + "', msg:'" + msg + "',filepath:'"+filepath+"'}";
                context.Response.Write(res);
                context.Response.End();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}