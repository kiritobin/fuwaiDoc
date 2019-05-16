using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// map 的摘要说明
    /// </summary>
    public class map : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];
            if (op == "search")
            {
                patientAbout(context);
            }
        }

        TPatientBLL tpb = new TPatientBLL();
        VMedicalHistoryBLL vmh = new VMedicalHistoryBLL();
        VPatientTreatmentBLL vpt = new VPatientTreatmentBLL();
        VPatientCheckBLL vpc = new VPatientCheckBLL();
        VGContactBLL vgcb = new VGContactBLL();
        private void patientAbout(HttpContext context)
        {
            String pid = context.Request["patientid"];

            String pinfo = tpb.getinfobydroneid(pid);
            String phisty = vmh.getinfobypatientid(pid);
            String pvptt = vpt.SelectTreatmentByPatientID(pid);
            String pvpc = vpc.selectCheckByPatientId(pid);
            String pvgcb = vgcb.selectVGContactByPatientId(pid);

            context.Response.Write(pinfo + "|-|" + phisty + "|-|" + pvptt+ "|-|" + pvpc + "|-|" + pvgcb);
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