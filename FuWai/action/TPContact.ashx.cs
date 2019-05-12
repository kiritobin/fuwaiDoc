using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuWai.BLL;

namespace FuWai.action
{
    /// <summary>
    /// TPContact 的摘要说明
    /// </summary>
    public class TPContact : IHttpHandler
    {
        TPContactBLL tpbll = new TPContactBLL();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }
        /// <summary>
        /// 查询所有的病人联系方式
        /// </summary>
        /// <returns></returns>
        public void SelectDrone(HttpContext context)
        {
            String json = tpbll.selectAllPContact();
            context.Response.Write(json);
            context.Response.End();
        }
        /// <summary>
        /// 根据病人编号查询病人联系方式
        /// </summary>
        /// <returns></returns>
        public void selectByPatientId(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = tpbll.selectByPatientId(patientid);
            context.Response.Write(json);
            context.Response.End();
        }
        /// <summary>
        /// 添加病人联系方式
        /// </summary>
        /// <param name="pcontactphone">病人联系方式</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        private void insertPContact(HttpContext context)
        {
            String pcontactphone = context.Request["pcontactphone"];
            String patientid = context.Request["patientid"];
            bool result = tpbll.insertPContact(pcontactphone, patientid);
            if (result)
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
        /// <summary>
        ///  根据pcontactid来删除病人联系方式(删除单个联系方式)
        /// </summary>
        /// <param name="pcontactid">主键id</param>
        /// <returns></returns>
        private void deletByPContactId(HttpContext context)
        {
            String pcontactid = context.Request["pcontactid"];
            bool result = tpbll.deletByPContactId(int.Parse(pcontactid));
            if (result)
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
        /// <summary>
        ///  根据病人编号来删除病人联系方式
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        private void deletByPatientId(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            bool result = tpbll.deletByPatientId(patientid);
            if (result)
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
        /// <summary>
        /// 根据pcontactid更新病人联系方式
        /// </summary>
        /// <param name="pcontactphone">新的联系方式</param>
        /// <param name="pcontactid">主键id</param>
        /// <returns></returns>
        private void updatePContact(HttpContext context)
        {
            String pcontactphone = context.Request["pcontactphone"];
            String pcontactid = context.Request["pcontactid"];
            bool result = tpbll.updatePContact(pcontactphone, int.Parse(pcontactid));
            if (result)
            {
                context.Response.Write("更新成功");
                context.Response.End();
            }
            else
            {
                context.Response.Write("更新失败");
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