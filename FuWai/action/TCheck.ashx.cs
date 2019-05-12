using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// TCheck 的摘要说明
    /// </summary>
    public class TCheck : IHttpHandler
    {
        TCheckBLL tb = new TCheckBLL();
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
                SelectAllPatient(context);
            }
            else if (op == "bypatientid")
            {
                SelectCheckByCheckID(context);
            }
        }
        private void insert(HttpContext context)
        {
            String checkid = context.Request["checkid"];
            String bloodpressure = context.Request["bloodpressure"];
            double bodytemp = Convert.ToDouble(context.Request["bodytemp"]);
            String checkdate = context.Request["checkdate"];
            String patientid = context.Request["patientid"];

            if (tb.insert(checkid, bloodpressure, bodytemp, checkdate, patientid))
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
            String checkid = context.Request["checkid"];
            String bloodpressure = context.Request["bloodpressure"];
            double bodytemp = Convert.ToDouble(context.Request["bodytemp"]);
            String checkdate = context.Request["checkdate"];
            String patientid = context.Request["patientid"];

            if (tb.update(checkid, bloodpressure, bodytemp, checkdate, patientid))
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
            String checkid = context.Request["checkid"];

            if (tb.delete(checkid))
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

        private void SelectAllPatient(HttpContext context)
        {
            String json = tb.SelectAllCheck();
            context.Response.Write(json);
            context.Response.End();

        }

        private void SelectCheckByCheckID(HttpContext context)
        {
            String checkid = context.Request["checkid"];
            String json = tb.SelectCheckByCheckID(checkid);
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