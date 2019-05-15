using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// test 的摘要说明
    /// </summary>
    public class test : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string id1 = "001";
            string dj1 = "1";
            string xy1 = "102.75239,25.044353";

            string id2 = "002";
            string dj2 = "0";
            string xy2 = "122.75239,25.044353";

            string res = "{ id:'" + id1 + "', dj:'" + dj1 + "',xy:'" + xy1 + "'},{ id:'" + id2 + "', dj:'" + dj2 + "',xy:'" + xy2 + "'}";
            context.Response.Write(res);
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