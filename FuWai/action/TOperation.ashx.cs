using FuWai.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.action
{
    /// <summary>
    /// TOperation 的摘要说明
    /// </summary>
    public class TOperation : IHttpHandler
    {

        TOperationBLL tbll = new TOperationBLL();
        public void ProcessRequest(HttpContext context)
        {
            string op = context.Request["op"];
            if (op == "insert")
            {
                insertOperation(context);
            }
            else if (op == "update")
            {
                updateOperationId(context);
            }
            else if (op == "delete")
            {
                deleteByOperationId(context);
            }
            else if (op == "deletByPatientId")
            {
                deletByPatientId(context);
            }
            else if (op == "all")
            {
                selectAllTOperation(context);
            }
            else if (op == "selectByPid")
            {
                selectByPatientId(context);
            }
            else if (op == "selectById")
            {
                selectByOperationId(context);
            }
        }
        /// <summary>
        /// 查询所有的手术记录
        /// </summary>
        /// <returns></returns>
        private void selectAllTOperation(HttpContext context)
        {
            String json = tbll.selectAllTOperation();
            context.Response.Write(json);
            context.Response.End();
        }
        /// <summary>
        /// 根据病人编号查询手术记录
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
        /// 根据主键查询手术记录
        /// </summary>
        /// <param name="treatmentid">主键</param>
        /// <returns></returns>
        private void selectByOperationId(HttpContext context)
        {
            String operationid = context.Request["operationid"];
            String json = tbll.selectByOperationId(operationid);
            context.Response.Write(json);
            context.Response.End();
        }
        /// <summary>
        /// 添加病人手术记录信息
        /// </summary>
        private void insertOperation(HttpContext context)
        {
            String operationtime = context.Request["operationtime"];
            String operationname = context.Request["operationname"];
            String remark = context.Request["remark"];
            String patientid = context.Request["patientid"];

            bool result = tbll.insertOperation(operationtime, operationname, remark, patientid);
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
        /// 根据编号删除手术记录
        /// </summary>
        /// <param name="treatmentid">编号</param>
        /// <returns></returns>
        private void deleteByOperationId(HttpContext context)
        {
            String operationid = context.Request["operationid"];
            bool result = tbll.deleteByOperationId(operationid);
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
        /// 根据病人编号删除手术记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        private void deletByPatientId(HttpContext context)
        {
            String patientid = context.Request["patientid"];
            bool result = tbll.deletByPatientId(patientid);
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
        /// 根据编号更新病人手术记录
        /// </summary>
        /// <param name="treatmentid"></param>
        /// <param name="treatmentBdate"></param>
        /// <param name="treatmentEdate"></param>
        /// <returns></returns>
        private void updateOperationId(HttpContext context)
        {
            String operationtime = context.Request["operationtime"];
            String operationname = context.Request["operationname"];
            String remark = context.Request["remark"];
            String patientid = context.Request["patientid"];
            String operationid = context.Request["operationid"];

            bool result = tbll.updateOperationId(operationtime, operationname, remark, patientid, operationid);
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