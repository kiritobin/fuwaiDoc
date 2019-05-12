using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            String op = context.Request["op"];
            if (op=="login")
            {
                userLogin(context);
            }
        }
        LoginBLL login = new LoginBLL();
        private void userLogin(HttpContext context)
        {
            String user = context.Request["user"];
            String pwd = context.Request["pwd"];
            if (login.userLogin(user,pwd))
            {
                context.Response.Write("登录成功");
                context.Response.End();

            }
            else
            {
                context.Response.Write("登录失败");
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