using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// VMedicalHistory 的摘要说明
    /// </summary>
    public class VMedicalHistory : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["load"];
            if (op == "load")
            {
                loadDrop(context);
            }
        }

        VMedicalHistoryBLL vmh = new VMedicalHistoryBLL();

        private void loadDrop(HttpContext context)
        {
            String json = vmh.getDroneinfo();
            context.Response.Write(json);
            context.Response.End();

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