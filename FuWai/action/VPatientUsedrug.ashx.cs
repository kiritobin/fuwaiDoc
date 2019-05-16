using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// VPatientUsedrug 的摘要说明
    /// </summary>
    public class VPatientUsedrug : IHttpHandler
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
            else if (op == "byusedrugid")
            {
                SelectPatientByUsedrugID(context);
            }
        }

        VPatientUsedrugBLL vb = new VPatientUsedrugBLL();

        /// <summary>
        /// 查询所有用药记录
        /// </summary>
        private void SelectAllPatient(HttpContext context)
        {
            String json = vb.SelectAllPatient();
            context.Response.Write(json);
            context.Response.End();

        }


        /// <summary>
        /// 根据病人id查询用药信息
        /// </summary>
        private void SelectPatientByPatientID(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = vb.SelectPatientByPatientID(patientid);
            context.Response.Write(json);
            context.Response.End();

        }

        /// <summary>
        /// 根据用药记录id查询用药信息
        /// </summary>
        private void SelectPatientByUsedrugID(HttpContext context)
        {
            String usedrugid = context.Request["usedrugid"];
            String json = vb.SelectPatientByUsedrugID(usedrugid);
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