using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// VPatientCheck 的摘要说明
    /// </summary>
    public class VPatientCheck : IHttpHandler
    {
        VPatientCheckBLL cbll = new VPatientCheckBLL();

        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];
            if (op == "all")
            {
                selectVPatientCheck(context);
            }
            else if (op == "patientid")
            {
                selectCheckByPatientId(context);
            }
        }

        private void selectVPatientCheck(HttpContext context)
        {
            String json = cbll.selectVPatientCheck();
            context.Response.Write(json);
            context.Response.End();
        }
        private void selectCheckByPatientId(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = cbll.selectCheckByPatientId(patientid);
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