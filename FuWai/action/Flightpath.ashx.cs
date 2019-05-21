using FuWai.BLL;
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
        }

        TFlightpathBLL tb = new TFlightpathBLL();

        private void SelectFlightpathbyDroneid(HttpContext context)
        {
            String droneid = context.Request["droneid"];

            String json = tb.SelectFlightpathbyDroneid(droneid);
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

        private void insert(HttpContext context)
        {
            String droneid = context.Request["droneid"];
            String flighttime = context.Request["flighttime"];
            Double lat = Convert.ToDouble(context.Request["lat"]);
            Double lng = Convert.ToDouble(context.Request["lng"]);
            int status = Convert.ToInt32(context.Request["status"]);
            if (tb.insert(droneid, flighttime, lat, lng, status))
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

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}