using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// testlist 的摘要说明
    /// </summary>
    public class testlist : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            test(context);
        }

        public void test(HttpContext context)
        {
            List<testmodel> tmlist = new List<testmodel>();
            testmodel tm = new testmodel();
            tm.Patientid = "0001";
            tm.Level = "1";
            tm.X = "198.7";
            tm.Y = "63.7";
            tmlist.Add(tm);

            testmodel tm1 = new testmodel();
            tm1.Patientid = "0002";
            tm1.Level = "1";
            tm1.X = "19.4";
            tm1.Y = "63.7";
            tmlist.Add(tm1);

            String json = JsonSerializer(tmlist);
            context.Response.Write(json);
            context.Response.End();

        }

        public static string JsonSerializer<T>(T t)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            using (MemoryStream ms = new MemoryStream())
            {
                ser.WriteObject(ms, t);
                return Encoding.UTF8.GetString(ms.ToArray());
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