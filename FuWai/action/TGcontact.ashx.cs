using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// TGcontact 的摘要说明
    /// </summary>
    public class TGcontact : IHttpHandler
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

        TGcontactBLL tb = new TGcontactBLL();

        private void load(HttpContext context)
        {
            String json = tb.getGcontactinfo();
            context.Response.Write(json);
            context.Response.End();

        }

        private void insert(HttpContext context)
        {
            String contactphone = context.Request["contactphone"];
            String guardianid = context.Request["guardianid"];

            if (tb.insert(contactphone, guardianid))
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
            String contactphone = context.Request["contactphone"];
            String guardianid = context.Request["guardianid"];

            if (tb.update(contactphone, guardianid))
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