using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// TGuardian 的摘要说明
    /// </summary>
    public class TGuardian : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];

            if (op == "load")
            {
                load(context);
            }
            else if (op == "insert")
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
        }

        TGuardianBLL tb = new TGuardianBLL();

        private void load(HttpContext context)
        {
            String json = tb.getGuardianinfo();
            context.Response.Write(json);
            context.Response.End();

        }

        private void insert(HttpContext context)
        {
            String appellation = context.Request["appellation"];
            String guardianname = context.Request["guardianname"];
            String patientid = context.Request["patientid"];

            if (tb.insert(appellation, guardianname, patientid))
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
            String appellation = context.Request["appellation"];
            String guardianname = context.Request["guardianname"];
            String guardianid = context.Request["guardianid"];

            if (tb.update(appellation, guardianname, guardianid))
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
            String guardianid = context.Request["guardianid"];

            if (tb.delete(guardianid))
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