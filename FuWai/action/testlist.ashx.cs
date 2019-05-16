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
            tm.X = "102.715239";
            tm.Y = "25.044353";
            tmlist.Add(tm);

            testmodel tm1 = new testmodel();
            tm1.Patientid = "0002";
            tm1.Level = "1";
            tm1.X = "102.719749";
            tm1.Y = "25.043919";
            tmlist.Add(tm1);

        //    [
        //    [102.715239, 25.044353],
        //    [102.719749, 25.043919],
        //    [102.718617, 25.04513],
        //    [102.735955, 25.04526],
        //    [102.736955, 25.04516],
        //    [102.733676, 25.045627],
        //    [102.738389, 25.043553]
        //    ];

            String json = JsonSerializer(tmlist);

            //string[,] values = { { "001", "1","198.7","63.7" }, { "002", "1", "19.4", "63.7" }, { "", "", "", "" } };

            context.Response.Write(json);
            context.Response.End();

        }
        /// <summary>
        /// list转化为json（.net内部方法）
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t">list对象</param>
        /// <returns>json字符串</returns>
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