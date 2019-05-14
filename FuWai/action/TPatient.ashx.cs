using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// TPatient 的摘要说明
    /// </summary>
    public class TPatient : IHttpHandler
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

       TPatientBLL tb = new TPatientBLL();

        private void load(HttpContext context)
        {
            String json = tb.getPatient();
            context.Response.Write(json);
            context.Response.End();

        }

        private void insert(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String patientname = context.Request["patientname"];
            String gender = context.Request["gender"];
            int diseasestatusid = 1;
            String droneid = context.Request["droneid"];
            Double weight= Convert.ToDouble(context.Request["weight"]);
            Double height = Convert.ToDouble(context.Request["height"]);
            String headimg = context.Request["headimg"];
            String address = context.Request["address"];
            String xy = context.Request["xy"];

            if (tb.insert(patientid, patientname, gender, diseasestatusid, droneid, weight, height, headimg, address, xy))
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
            String patientid = context.Request["patientid"];
            String patientname = context.Request["patientname"];
            String gender = context.Request["gender"];
            int diseasestatusid = 1;
            String droneid = context.Request["droneid"];
            Double weight = Convert.ToDouble(context.Request["weight"]);
            Double height = Convert.ToDouble(context.Request["height"]);
            String headimg = context.Request["headimg"];
            String address = context.Request["address"];
            String xy = context.Request["xy"];

            if (tb.update(patientid, patientname, gender, diseasestatusid, droneid, weight, height, headimg, address, xy))
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
            String patientid = context.Request["patientid"];

            if (tb.delete(patientid))
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