using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class TOperationDAO
    {
        SQLHelper db = new SQLHelper();
        /// <summary>
        /// 查询所有的手术记录
        /// </summary>
        /// <returns></returns>
        public DataTable selectAllTOperation()
        {
            string sql = "select * from T_Operation";
            DataTable dt = db.FillDataSet(sql, null, null).Tables[0];
            return dt;
        }
        /// <summary>
        /// 根据病人编号查询手术记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public DataTable selectByPatientId(string patientid)
        {
            string sql = "select * from T_Operation where patientid=@patientid";
            string[] param = { "@patientid" };
            object[] value = { patientid };
            DataTable dt = db.FillDataSet(sql, param, value).Tables[0];
            return dt;
        }
        /// <summary>
        /// 根据主键查询手术记录
        /// </summary>
        /// <param name="Operationid">主键</param>
        /// <returns></returns>
        public DataTable selectByOperationId(string operationid)
        {
            string sql = "select * from T_Operation where operationid=@operationid";
            string[] param = { "@operationid" };
            object[] value = { operationid };
            DataTable dt = db.FillDataSet(sql, param, value).Tables[0];
            return dt;
        }
        /// <summary>
        /// 添加病人手术记录信息
        /// </summary>
        /// <param name="Operationid">编号</param>
        /// <param name="OperationBdate">开始时间</param>
        /// <param name="OperationEdate">结束时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public int insertOperation(string operationtime, string operationname, string remark, string patientid)
        {
            string sql = "insert into T_Operation(operationtime,operationname,remark,patientid,doctor) values (@operationtime,@operationname,@remark,@patientid)";
            string[] param = { "@operationtime", "@operationname", "@remark", "@patientid" };
            object[] value = { operationtime, operationname, remark, patientid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 根据编号删除手术记录
        /// </summary>
        /// <param name="operationid">编号</param>
        /// <returns></returns>
        public int deleteByOperationId(string operationid)
        {
            string sql = "delete from T_Operation where operationid=@operationid";
            string[] param = { "@operationid" };
            object[] value = { operationid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 根据病人编号删除手术记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public int deletByPatientId(string patientid)
        {
            string sql = "delete from T_Operation where patientid=@patientid";
            string[] param = { "@patientid" };
            object[] value = { patientid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 根据编号更新病人手术记录
        /// </summary>
        /// <returns></returns>
        public int updateOperationId(string operationtime, string operationname, string remark, string patientid,string operationid)
        {
            string sql = "update T_Operation set operationtime=@operationtime,operationname=@operationname,remark=@remark,patientid=@patientid where operationid=@operationid";
            string[] param = { "@operationtime", "@operationname", "remark", "@patientid", "@operationid" };
            object[] value = { operationtime, operationname, remark, patientid, operationid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
    }
}