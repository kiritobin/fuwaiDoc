using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// VDronePatient 的摘要说明
    /// </summary>
    public class VDronePatient : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["load"];
            if (op == "all")
            {
                selectVDronePatient(context);
            }
            else if (op == "droneid")
            {
                selectVDronePatientBydroneid(context);
            }
           
        }

        VDronePatientBLL vt = new VDronePatientBLL();

        private void selectVDronePatient(HttpContext context)
        {
            String json = vt.selectVDronePatient();
            context.Response.Write(json);
            context.Response.End();

        }

        private void selectVDronePatientBydroneid(HttpContext context)
        {
            String droneid = context.Request["droneid"];
            String json = vt.selectVDronePatientBydroneid(droneid);
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