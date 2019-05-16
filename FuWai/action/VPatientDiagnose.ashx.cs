using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// VPatientDiagnose 的摘要说明
    /// </summary>
    public class VPatientDiagnose : IHttpHandler
    {
        VPatientDiagnoseBLL vpdb = new VPatientDiagnoseBLL();
        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];
            if (op == "all")
            {
                selectVPatientDiagnose(context);
            }
            else if (op == "bydiagnoseid")
            {
                selectVPatientDiagnosebydiagnoseid(context);
            }
            else if (op == "bypatientid")
            {
                selectVPatientDiagnosebypatientid(context);
            }
        }

        private void selectVPatientDiagnose(HttpContext context)
        {
            String json = vpdb.selectVPatientDiagnose();
            context.Response.Write(json);
            context.Response.End();

        }

        private void selectVPatientDiagnosebypatientid(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = vpdb.selectVPatientDiagnosebypatientid(patientid);
            context.Response.Write(json);
            context.Response.End();

        }
        private void selectVPatientDiagnosebydiagnoseid(HttpContext context)
        {
            String diagnoseid = context.Request["diagnoseid"];
            String json = vpdb.selectVPatientDiagnosebydiagnoseid(diagnoseid);
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