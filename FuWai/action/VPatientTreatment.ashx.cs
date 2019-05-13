using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// VPatientTreatment 的摘要说明
    /// </summary>
    public class VPatientTreatment : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];
            if (op == "all")
            {
                SelectAllTreatment(context);
            }
            else if (op == "patientid")
            {
                SelectTreatmentByPatientID(context);
            }
            else if (op == "treatmentid")
            {
                SelectTreatmentByTreatmentID(context);
            }
        }

        VPatientTreatmentBLL vt = new VPatientTreatmentBLL();

        /// <summary>
        /// 查询所有治疗记录
        /// </summary>
        private void SelectAllTreatment(HttpContext context)
        {
            String json = vt.SelectAllTreatment();
            context.Response.Write(json);
            context.Response.End();

        }

        /// <summary>
        /// 根据病人编号id所有治疗记录
        /// </summary>
        private void SelectTreatmentByPatientID(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = vt.SelectTreatmentByPatientID(patientid);
            context.Response.Write(json);
            context.Response.End();

        }

        /// <summary>
        /// 根据治疗记录编号id查询所有治疗记录
        /// </summary>
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