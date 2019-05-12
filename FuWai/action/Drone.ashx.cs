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
            if (op=="load")
            {
                loadDrop(context);
            }
        }
        TDroneBLL drone = new TDroneBLL();

        private void loadDrop(HttpContext context)
        {
            String json = drone.getDroneinfo();
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