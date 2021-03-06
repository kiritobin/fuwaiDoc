﻿using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// VMedicalHistory 的摘要说明
    /// </summary>
    public class VMedicalHistory : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];
            if (op == "load")
            {
                loadDrop(context);
            }else if (op == "select")
            {
                SelectAll(context);
            }
        }

        VMedicalHistoryBLL vmh = new VMedicalHistoryBLL();

        private void loadDrop(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = vmh.getinfobypatientid(patientid);
            context.Response.Write(json);
            context.Response.End();

        }

        private void SelectAll(HttpContext context)
        {
            String json = vmh.SelectAll();
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