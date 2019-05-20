using FuWai.BLL;
using FuWai.DBHelper;
using FuWai.Model;
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
        Data data = new Data();

        private void patientAbout(HttpContext context)
        {
            String pid = context.Request["patientid"];

            String pinfo = tpb.getinfobypatientid(pid);
            String phisty = vmh.getinfobypatientid(pid);
            String pvptt = tdb.SelectDiagnoseBypatientid(pid);
            String ptub = tub.selectByPatientId(pid);
            String ptob = tob.selectByPatientId(pid);
            String pvgcb = vgcb.selectVGContactByPatientId(pid);

            data.Data1 = pinfo;
            data.Data2 = phisty;
            data.Data3 = pvptt;
            data.Data4 = ptub;
            data.Data5 = ptob;
            data.Data6 = pvgcb;
            String json = JsonHelper.ObjectToJson(data);
            context.Response.Write(json);
            //context.Response.Write(pinfo + "|-|" + phisty + "|-|" + pvptt+ "|-|" + ptub + "|-|" + ptob + "|-|" + pvgcb);
            context.Response.End();
        }

        TDroneBLL tdreb = new TDroneBLL();
        private void patientandDroneAbout(HttpContext context)
        {

            String pinfo = tpb.getPatient();
            String dinfo = tdreb.getDroneinfo();

            data.Data1 = pinfo;
            data.Data2 = dinfo;
            String json = JsonHelper.ObjectToJson(data);

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