using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuWai.BLL;

namespace FuWai.action
{
    /// <summary>
    /// TTreatment 的摘要说明
    /// </summary>
    public class TTreatment : IHttpHandler
    {
        TTreatmentBLL tbll = new TTreatmentBLL();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }
        /// <summary>
        /// 查询所有的治疗记录
        /// </summary>
        /// <returns></returns>
        private void selectAllTTreatment(HttpContext context)
        {
            String json = tbll.selectAllTTreatment();
            context.Response.Write(json);
            context.Response.End();
        }
        /// <summary>
        /// 根据病人编号查询治疗记录
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
        /// 根据主键查询治疗记录
        /// </summary>
        /// <param name="treatmentid">主键</param>
        /// <returns></returns>
        private void selectByTreatmentId(HttpContext context)
        {
            String treatmentid = context.Request["treatmentid"];
            String json = tbll.selectByTreatmentId(treatmentid);
            context.Response.Write(json);
            context.Response.End();
        }
        /// <summary>
        /// 添加病人治疗记录信息
        /// </summary>
        /// <param name="treatmentid">编号</param>
        /// <param name="treatmentBdate">开始时间</param>
        /// <param name="treatmentEdate">结束时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        private void insertTreatment(HttpContext context)
        {
            String treatmentid = context.Request["treatmentid"];
            String treatmentBdate = context.Request["treatmentBdate"];
            String treatmentEdate = context.Request["treatmentEdate"];
            String patientid = context.Request["patientid"];
            bool result = tbll.insertTreatment(treatmentid, treatmentBdate, treatmentEdate, patientid);
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
        /// 根据编号删除治疗记录
        /// </summary>
        /// <param name="treatmentid">编号</param>
        /// <returns></returns>
        private void deleteByTreatmentId(HttpContext context)
        {
            String treatmentid = context.Request["treatmentid"];
            bool result = tbll.deleteByTreatmentId(treatmentid);
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
        /// 根据病人编号删除治疗记录
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
        /// 根据编号更新病人治疗记录
        /// </summary>
        /// <param name="treatmentid"></param>
        /// <param name="treatmentBdate"></param>
        /// <param name="treatmentEdate"></param>
        /// <returns></returns>
        private void updateTreatmentId(HttpContext context)
        {
            String treatmentid = context.Request["treatmentid"];
            String treatmentBdate = context.Request["treatmentBdate"];
            String treatmentEdate = context.Request["treatmentEdate"];
            bool result = tbll.updateTreatmentId(treatmentid, treatmentBdate, treatmentEdate);
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
        /// <summary>
        /// 根据病人编号更新治疗记录
        /// </summary>
        /// <param name="treatmentid">编号</param>
        /// <param name="treatmentBdate">开始时间</param>
        /// <param name="treatmentEdate">结束时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        private void updatePatientId(HttpContext context)
        {
            String treatmentid = context.Request["treatmentid"];
            String treatmentBdate = context.Request["treatmentBdate"];
            String treatmentEdate = context.Request["treatmentEdate"];
            String patientid = context.Request["patientid"];
            bool result = tbll.updatePatientId(treatmentid, treatmentBdate, treatmentEdate, patientid);
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