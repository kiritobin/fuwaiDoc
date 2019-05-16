using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// TDiagnoser 的摘要说明
    /// </summary>
    public class TDiagnoser : IHttpHandler
    {
        TDiagnoseBLL tb = new TDiagnoseBLL();
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
            }
            else if (op == "all")
            {
                SelectAllDiagnose(context);
            }
            else if (op == "bydiagnoseid")
            {
                SelectDiagnoseBydiagnoseid(context);
            }
            else if (op == "bypatientid")
            {
                SelectDiagnoseBypatientid(context);
            }
        }

        private void insert(HttpContext context)
        {
            String diagnosetime = context.Request["diagnosetime"];
            String diagnose = context.Request["diagnose"];
            String doctor = context.Request["doctor"];
            String remark = context.Request["remark"];
            String patientid = context.Request["patientid"];

            if (tb.insert(diagnosetime, diagnose, doctor, remark, patientid))
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
            int diagnoseid = Convert.ToInt32(context.Request["diagnoseid"]);
            String diagnosetime = context.Request["diagnosetime"];
            String diagnose = context.Request["diagnose"];
            String doctor = context.Request["doctor"];
            String remark = context.Request["remark"];
            String patientid = context.Request["patientid"];

            if (tb.update(diagnoseid,diagnosetime, diagnose, doctor, remark, patientid))
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
            int diagnoseid = Convert.ToInt32(context.Request["diagnoseid"]);

            if (tb.delete(diagnoseid))
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

        private void SelectAllDiagnose(HttpContext context)
        {
            String json = tb.SelectAllDiagnose();
            context.Response.Write(json);
            context.Response.End();

        }

        private void SelectDiagnoseBydiagnoseid(HttpContext context)
        {
            String diagnoseid = context.Request["diagnoseid"];
            String json = tb.SelectDiagnoseBydiagnoseid(diagnoseid);
            context.Response.Write(json);
            context.Response.End();

        }

        private void SelectDiagnoseBypatientid(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = tb.SelectDiagnoseBypatientid(patientid);
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