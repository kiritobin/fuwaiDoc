using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// VCheck 的摘要说明
    /// </summary>
    public class VCheck : IHttpHandler
    {
        VCheckBLL cbll = new VCheckBLL();
        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];
            if (op == "all")
            {
                selectVCheck(context);
            }
            else if (op == "bypatientid")
            {
                selectByPatientId(context);
            }
        }
        private void selectVCheck(HttpContext context)
        {
            String json = cbll.selectVCheck();
            context.Response.Write(json);
            context.Response.End();
        }
        private void selectByPatientId(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = cbll.selectByPatientId(patientid);
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