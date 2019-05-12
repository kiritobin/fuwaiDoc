using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// TDiseasestatus 的摘要说明
    /// </summary>
    public class TDiseasestatus : IHttpHandler
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
            }
            else if (op == "all")
            {
                SelectAllTDiseasestatus(context);
            }
            else if (op == "bypatientid")
            {
                SelectByDiseasestatusid(context);
            }
        }

        TDiseasestatusBLL tb = new TDiseasestatusBLL();

        private void insert(HttpContext context)
        {
            String diseasestatusid = context.Request["diseasestatusid"];
            String statusname = context.Request["statusname"];

            if (tb.insert(diseasestatusid, statusname))
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
            String diseasestatusid = context.Request["diseasestatusid"];
            String statusname = context.Request["statusname"];

            if (tb.update(diseasestatusid, statusname))
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
            String diseasestatusid = context.Request["diseasestatusid"];

            if (tb.delete(diseasestatusid))
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

        private void SelectAllTDiseasestatus(HttpContext context)
        {
            String json = tb.SelectAllTDiseasestatus();
            context.Response.Write(json);
            context.Response.End();

        }

        private void SelectByDiseasestatusid(HttpContext context)
        {
            String diseasestatusid = context.Request["diseasestatusid"];
            String json = tb.SelectByDiseasestatusid(diseasestatusid);
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