using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// VPatientOperation 的摘要说明
    /// </summary>
    public class VPatientOperation : IHttpHandler
    {

        VPatientOperationBLL poll = new VPatientOperationBLL();

        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];
            if (op == "all")
            {
                selectVPatientOperation(context);
            }
            else if (op == "patientid")
            {
                selectVPatientOperationById(context);
            }
        }

        private void selectVPatientOperation(HttpContext context)
        {
            String json = poll.selectVPatientOperation();
            context.Response.Write(json);
            context.Response.End();
        }
        private void selectVPatientOperationById(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = poll.selectVPatientOperationById(patientid);
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