using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// VGContact 的摘要说明
    /// </summary>
    public class VGContact : IHttpHandler
    {
        VGContactBLL vgcb = new VGContactBLL();
        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];
            if (op == "all")
            {
                selectVGContact(context);
            }
            else if (op == "bypatientid")
            {
                selectVGContactByPatientId(context);
            }
        }
        private void selectVGContact(HttpContext context)
        {
            String json = vgcb.selectVGContact();
            context.Response.Write(json);
            context.Response.End();
        }
        private void selectVGContactByPatientId(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = vgcb.selectVGContactByPatientId(patientid);
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