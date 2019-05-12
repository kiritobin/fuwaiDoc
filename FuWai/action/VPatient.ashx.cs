using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// VPatient 的摘要说明
    /// </summary>
    public class VPatient : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];
            if (op == "all")
            {
                SelectAllPatient(context);
            }
            else if (op == "bypatientid")
            {
                SelectPatientByPatientID(context);
            }
            else if (op == "byguardianid")
            {
                SelectPatientByGuardianID(context);
            }
            else if (op == "bydiseasestatusid")
            {
                SelectPatientByDiseasestatusID(context);
            }
            else if (op == "bydroneid")
            {
                SelectPatientByDroneID(context);
            }
        }
        VPatientBLL vp = new VPatientBLL();

        /// <summary>
        /// 查询所有病人信息
        /// </summary>
        /// <param name="context"></param>
        private void SelectAllPatient(HttpContext context)
        {
            String json = vp.SelectAllPatient();
            context.Response.Write(json);
            context.Response.End();

        }

        /// <summary>
        /// 根据病人id查询病人信息
        /// </summary>
        /// <param name="context"></param>
        private void SelectPatientByPatientID(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = vp.SelectPatientByPatientID(patientid);
            context.Response.Write(json);
            context.Response.End();
        }

        /// <summary>
        /// 根据监护人id查询病人信息
        /// </summary>
        private void SelectPatientByGuardianID(HttpContext context)
        {
            String guardianid = context.Request["guardianid"];
            String json = vp.SelectPatientByGuardianID(guardianid);
            context.Response.Write(json);
            context.Response.End();

        }

        /// <summary>
        /// 根据病情等级id查询病人信息
        /// </summary>
        private void SelectPatientByDiseasestatusID(HttpContext context)
        {
            String diseasestatusid = context.Request["diseasestatusid"];
            String json = vp.SelectPatientByDiseasestatusID(diseasestatusid);
            context.Response.Write(json);
            context.Response.End();

        }

        /// <summary>
        /// 根据无人机id查询病人信息
        /// </summary>
        private void SelectPatientByDroneID(HttpContext context)
        {
            String droneid = context.Request["droneid"];
            String json = vp.SelectPatientByDroneID(droneid);
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