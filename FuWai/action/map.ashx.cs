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
            else if (op == "load") {
                patientandDroneAbout(context);
            }
        }

        TPatientBLL tpb = new TPatientBLL();
        VMedicalHistoryBLL vmh = new VMedicalHistoryBLL();
        TDiagnoseBLL tdb = new TDiagnoseBLL();
        TUsedrugBLL tub = new TUsedrugBLL();
        TOperationBLL tob = new TOperationBLL();
        VGContactBLL vgcb = new VGContactBLL();
        private void patientAbout(HttpContext context)
        {
            String pid = context.Request["patientid"];

            String pinfo = tpb.getinfobypatientid(pid);
            String phisty = vmh.getinfobypatientid(pid);
            String pvptt = tdb.SelectDiagnoseBypatientid(pid);
            String ptub = tub.selectByPatientId(pid);
            String ptob = tob.selectByPatientId(pid);
            String pvgcb = vgcb.selectVGContactByPatientId(pid);

            context.Response.Write(pinfo + "|-|" + phisty + "|-|" + pvptt+ "|-|" + ptub + "|-|" + ptob + "|-|" + pvgcb);
            context.Response.End();
        }

        TDroneBLL tdreb = new TDroneBLL();
        private void patientandDroneAbout(HttpContext context)
        {

            String pinfo = tpb.getPatient();
            String dinfo = tdreb.getDroneinfo();

            context.Response.Write(pinfo + "|-|" + dinfo);
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