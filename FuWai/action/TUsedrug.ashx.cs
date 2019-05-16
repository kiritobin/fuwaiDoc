using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// TUsedrug 的摘要说明
    /// </summary>
    public class TUsedrug : IHttpHandler
    {
        TUsedrugBLL tbll = new TUsedrugBLL();
        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];
            if (op == "insert")
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
            else if (op == "deletByPatientId")
            {
                deletByPatientId(context);
            }
            else if (op == "all")
            {
                selectAll(context);
            }
            else if (op == "selectByPid")
            {
                selectByPatientId(context);
            }
            else if (op == "selectById")
            {
                selectByUsedrugId(context);
            }
        }
        /// <summary>
        /// 查询所有的用药记录
        /// </summary>
        /// <returns></returns>
        private void selectAll(HttpContext context)
        {
            String json = tbll.selectAllTUsedrug();
            context.Response.Write(json);
            context.Response.End();
        }
        /// <summary>
        /// 根据病人编号查询用药记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        private void selectByPatientId(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            String json = tbll.selectByPatientId(patientid);
            context.Response.Write(json);
            context.Response.End();
        }
        /// <summary>
        /// 根据主键查询用药记录
        /// </summary>
        /// <param name="treatmentid">主键</param>
        /// <returns></returns>
        private void selectByUsedrugId(HttpContext context)
        {
            String usedrugid = context.Request["usedrugid"];
            String json = tbll.selectByUsedrugId(usedrugid);
            context.Response.Write(json);
            context.Response.End();
        }
        /// <summary>
        /// 添加病人用药记录信息
        /// </summary>
        private void insert(HttpContext context)
        {
            String usedrugidtime = context.Request["usedrugidtime"];
            String usedrugidname = context.Request["usedrugidname"];
            String dosage = context.Request["dosage"];
            String remark = context.Request["remark"];
            String patientid = context.Request["patientid"];

            bool result = tbll.insert(usedrugidtime, usedrugidname, dosage, remark, patientid);
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
        /// 根据编号删除用药记录
        /// </summary>
        private void delete(HttpContext context)
        {
            String usedrugid = context.Request["usedrugid"];
            bool result = tbll.delete(usedrugid);
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
        /// 根据病人编号删除用药记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        private void deletByPatientId(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            bool result = tbll.deleteByPatientId(patientid);
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
        /// 根据编号更新病人用药记录
        /// </summary>
        private void update(HttpContext context)
        {

            String usedrugid = context.Request["usedrugid"];
            String usedrugidtime = context.Request["usedrugidtime"];
            String usedrugidname = context.Request["usedrugidname"];
            String dosage = context.Request["dosage"];
            String remark = context.Request["remark"];
            String patientid = context.Request["patientid"];

            bool result = tbll.update(usedrugid,usedrugidtime, usedrugidname, dosage, remark, patientid);
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