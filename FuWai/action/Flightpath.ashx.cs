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
    /// Flightpath 的摘要说明
    /// </summary>
    public class Flightpath : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];

            if (op == "bydroneid")
            {
                SelectFlightpathbyDroneid(context);
            }
            else if (op == "byteim")
            {
                SelectFlightpathbytime(context);
            }
            else if (op == "insert")
            {
                insert(context);
            }
            else if (op=="bydrone")
            {
                SelectFlightpathbyDrone(context);
            }
            else if (op=="change")
            {
                changestatus(context);
            }
            else if (op=="reset")
            {
                reset(context);
            }
        }

        TFlightpathBLL tb = new TFlightpathBLL();
        TDroneBLL drone = new TDroneBLL();
        Data data = new Data();

        private void SelectFlightpathbyDroneid(HttpContext context)
        {
            String droneid = context.Request["droneid"];

            String json = tb.SelectFlightpathbyDroneid(droneid,0);
            context.Response.Write(json);
            context.Response.End();

        }

        private void SelectFlightpathbytime(HttpContext context)
        {
            String flighttime = context.Request["flighttime"];
            String droneid = context.Request["droneid"];

            String json = tb.SelectFlightpathbytime(flighttime, droneid);
            context.Response.Write(json);
            context.Response.End();

        }

        private void SelectFlightpathbyDrone(HttpContext context)
        {
            String droneid = context.Request["droneid"];
            data.Data1 = tb.SelectFlightpathbyDroneid(droneid, 1);
            data.Data2 = drone.getDroneinfobydroneid(droneid);
            String json = JsonHelper.ObjectToJson(data);
            context.Response.Write(json);
            context.Response.End();
        }

        private void insert(HttpContext context)
        {
            String droneid = context.Request["droneid"];
            String flighttime = context.Request["flighttime"];
            Double lat = Convert.ToDouble(context.Request["lat"]);
            Double lng = Convert.ToDouble(context.Request["lng"]);
            //int status = Convert.ToInt32(context.Request["status"]);
            if (tb.insert(droneid, flighttime, lat, lng))
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

        public void changestatus(HttpContext context)
        {
            Double lat = Convert.ToDouble(context.Request["lat"]);
            Double lng = Convert.ToDouble(context.Request["lng"]);
            if (tb.changestatus(lat, lng))
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

        public void reset(HttpContext context)
        {
            if (tb.reset())
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

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}