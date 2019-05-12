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
            string op = context.Request["load"];

            if (op == "load")
            {
                loadDrop(context);
            }
            else if (op == "add") {
                addDrone(context);
            }
            else if (op == "update") {
                updateDrone(context);
            }
            else if (op == "delete")
            {
                updateDrone(context);
            }
        }
        TDroneBLL drone = new TDroneBLL();

        private void loadDrop(HttpContext context)
        {
            String json = drone.getDroneinfo();
            context.Response.Write(json);
            context.Response.End();

        }

        private void addDrone(HttpContext context) {
            String droneid = context.Request["droneid"];
            String dronemodel = context.Request["dronemodel"];
            String position = context.Request["position"];
            int flycount = Convert.ToInt32(context.Request["flycount"]);
            int status = Convert.ToInt32(context.Request["status"]);

            if (drone.insertDrone(droneid, dronemodel, position, flycount, status))
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

        private void updateDrone(HttpContext context)
        {
            String droneid = context.Request["droneid"];
            String dronemodel = context.Request["dronemodel"];
            String position = context.Request["position"];
            int flycount = Convert.ToInt32(context.Request["flycount"]);
            int status = Convert.ToInt32(context.Request["status"]);

            if (drone.updateDrone(droneid, dronemodel, position, flycount, status))
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
        private void deleteDrone(HttpContext context)
        {
            String droneid = context.Request["droneid"];

            if (drone.deleteDrone(droneid))
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