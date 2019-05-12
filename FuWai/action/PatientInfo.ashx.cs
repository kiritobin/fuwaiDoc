using FuWai.BLL;
using FuWai.DBHelper;
using FuWai.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// PatientInfo 的摘要说明
    /// </summary>
    public class PatientInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];
            if (op == "search")
            {
                patientAbout(context);
            }
        }

        TGuardianBLL guardianBLL = new TGuardianBLL();
        TDiseasestatusBLL diseasestatusBLL = new TDiseasestatusBLL();
        TDroneBLL droneBLL = new TDroneBLL();

        PatientAbout patient = new PatientAbout();


        private void patientAbout(HttpContext context)
        {
            String Contact = guardianBLL.getGuardianinfo();
            String Disease = diseasestatusBLL.SelectAllTDiseasestatus();
            String Drone = droneBLL.getDroneinfo();

            context.Response.Write(Contact+"|-|"+Disease + "|-|" + Drone);
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