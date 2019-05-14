using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// Drone 的摘要说明
    /// </summary>
    public class Drone : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];

            if (op == "load")
            {
                load(context);
            }
            else if (op == "insert") {
                insert(context);
            }
            else if (op == "update") {
                update(context);
            }
            else if (op == "delete")
            {
                delete(context);
            }
        }
        TDroneBLL tb = new TDroneBLL();

        private void load(HttpContext context)
        {
            String json = tb.getDroneinfo();
            context.Response.Write(json);
            context.Response.End();

        }

        private void insert(HttpContext context) {
            String droneid = context.Request["droneid"];
            String dronemodel = context.Request["dronemodel"];
            String position = context.Request["position"];
            int flycount = Convert.ToInt32(context.Request["flycount"]);
            int status = Convert.ToInt32(context.Request["status"]);

            if (tb.insert(droneid, dronemodel, position, flycount, status))
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
            String droneid = context.Request["droneid"];
            String dronemodel = context.Request["dronemodel"];
            String position = context.Request["position"];
            int flycount = Convert.ToInt32(context.Request["flycount"]);
            int status = Convert.ToInt32(context.Request["status"]);

            if (tb.update(droneid, dronemodel, position, flycount, status))
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
            String droneid = context.Request["droneid"];

            if (tb.delete(droneid))
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