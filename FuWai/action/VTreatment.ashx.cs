using FuWai.BLL;
using FuWai.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// VTreatment 的摘要说明
    /// </summary>
    public class VTreatment : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            string op = context.Request["load"];
            if (op == "all")
            {
                SelectAllTreatment(context);
            }
            else if (op == "bypatientid")
            {
                SelectTreatmentByPatientID(context);
            }
            else if (op == "bytreatmentid")
            {
                SelectTreatmentByTreatmentID(context);
            }
        }

        VTreatmentBLL vt = new VTreatmentBLL();

        private void SelectAllTreatment(HttpContext context)
        {
            String json = vt.SelectAllTreatment();
            context.Response.Write(json);
            context.Response.End();

        }

        private void SelectTreatmentByPatientID(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = vt.SelectTreatmentByPatientID(patientid);
            context.Response.Write(json);
            context.Response.End();

        }

        private void SelectTreatmentByTreatmentID(HttpContext context)
        {
            String treatmentid = context.Request["treatmentid"];
            String json = vt.SelectTreatmentByTreatmentID(treatmentid);
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