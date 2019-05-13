using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// TMedicalhistory 的摘要说明
    /// </summary>
    public class TMedicalhistory : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];
            if (op == "insert")
            {
                insert(context);
            }
            else if (op == "update")
            {
                update(context);
            }
            else if (op == "delete")
            {
                delete(context);
            }else if (op == "select")
            {
                SelectByPatient(context);
            }
        }

        TMedicalhistoryBLL medic = new TMedicalhistoryBLL();

        private void loadMedicalhistory(HttpContext context)
        {
            String json = medic.getMedicalhistory();
            context.Response.Write(json);
            context.Response.End();

        }
        private void SelectByPatient(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = medic.SelectByPatient(patientid);
            context.Response.Write(json);
            context.Response.End();

        }
        private void insert(HttpContext context)
        {
            String medicalhistoryreason = context.Request["medicalhistoryreason"];
            String patientid = context.Request["patientid"];

            if (medic.insert(medicalhistoryreason, patientid))
            {
                context.Response.Write("添加成功");
                context.Response.End();

            }
            else
            {
                context.Response.Write("添加失败");
                context.Response.End();
            }
        }

        private void update(HttpContext context)
        {
            String medicalhistoryreason = context.Request["medicalhistoryreason"];
            String patientid = context.Request["patientid"];

            if (medic.update(medicalhistoryreason, patientid))
            {
                context.Response.Write("修改成功");
                context.Response.End();

            }
            else
            {
                context.Response.Write("修改失败");
                context.Response.End();
            }
        }
        private void delete(HttpContext context)
        {
            String medicalhistoryid = context.Request["medicalhistoryid"];

            if (medic.delete(medicalhistoryid))
            {
                context.Response.Write("删除成功");
                context.Response.End();

            }
            else
            {
                context.Response.Write("删除失败");
                context.Response.End();
            }
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