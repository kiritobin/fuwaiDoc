using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class TOperationBLL
    {
        TOperationDAO tdao = new TOperationDAO();

        /// <summary>
        /// 查询所有的手术记录
        /// </summary>
        /// <returns></returns>
        public string selectAllTOperation()
        {
            return JsonHelper.ToJson(tdao.selectAllTOperation());
        }
        /// <summary>
        /// 根据病人编号查询手术记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public string selectByPatientId(string patientid)
        {
            return JsonHelper.ToJson(tdao.selectByOperationId(patientid));
        }
        /// <summary>
        /// 根据主键查询手术记录
        /// </summary>
        /// <param name="Operationid">主键</param>
        /// <returns></returns>
        public string selectByOperationId(string operationid)
        {
            return JsonHelper.ToJson(tdao.selectByOperationId(operationid));
        }
        /// <summary>
        /// 添加病人手术记录信息
        /// </summary>
        /// <param name="Operationid">编号</param>
        /// <param name="OperationBdate">开始时间</param>
        /// <param name="OperationEdate">结束时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public Boolean insertOperation(string operationtime, string operationname, string remark, string patientid)
        {
            int row = tdao.insertOperation(operationtime, operationname, remark, patientid);
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 根据编号删除手术记录
        /// </summary>
        /// <param name="operationid">编号</param>
        /// <returns></returns>
        public Boolean deleteByOperationId(string operationid)
        {
            int row = tdao.deleteByOperationId(operationid);
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 根据病人编号删除手术记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public Boolean deletByPatientId(string patientid)
        {
            int row = tdao.deleteByOperationId(patientid);
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 根据编号更新病人手术记录
        /// </summary>
        /// <returns></returns>
        public Boolean updateOperationId(string operationtime, string operationname, string remark, string patientid, string operationid)
        {
            int row = tdao.updateOperationId(operationtime, operationname, remark, patientid, operationid);
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}