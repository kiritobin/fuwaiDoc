using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class TDiagnoseDAO
    {
        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 添加诊断记录
        /// </summary>
        /// <param name="diagnosetime">时间</param>
        /// <param name="diagnose">诊断结果</param>
        /// <param name="doctor">主治医师</param>
        /// <param name="remark">备注</param>
        /// <param name="patientid">病人编号</param>
        /// <returns>返回int大于0修改成功，否则修改失败</returns>
        public int insert(string diagnosetime, string diagnose, string doctor, string remark, string patientid)
        {
            string sql = "insert into T_Diagnose values(@diagnosetime,@diagnose,@doctor,@remark,@patientid)";
            string[] param = { "@diagnosetime", "@diagnose", "@doctor", "@remark", "@patientid" };
            object[] values = { diagnosetime, diagnose, doctor, remark, patientid };

            return db.ExecuteNoneQuery(sql, param, values);
        }

        /// <summary>
        /// 修改诊断记录
        /// </summary>
        /// <param name="diagnosetime">时间</param>
        /// <param name="diagnose">诊断结果</param>
        /// <param name="doctor">主治医师</param>
        /// <param name="remark">备注</param>
        /// <param name="patientid">病人编号</param>
        /// <returns>返回int大于0修改成功，否则修改失败</returns>
        public int update(int diagnoseid, string diagnosetime, string diagnose, string doctor, string remark, string patientid)
        {
            string sql = "update T_Diagnose set diagnosetime=@diagnosetime,diagnose=@diagnose,doctor=@doctor,remark=@remark,patientid=@patientid where diagnoseid=@diagnoseid";
            string[] param = { "@diagnoseid", "@diagnosetime", "@diagnose", "@doctor", "@remark", "@patientid" };
            object[] values = { diagnoseid, diagnosetime, diagnose, doctor, remark, patientid };

            return db.ExecuteNoneQuery(sql, param, values);
        }

        /// <summary>
        /// 删除一条诊断记录
        /// </summary>
        /// <param name="diagnoseid">诊断记录编号</param>
        /// <returns>int >返回int</returns>
        public int delete(int diagnoseid)
        {
            string sql = "delete from T_Diagnose where diagnoseid=@diagnoseid";
            string[] param = { "@diagnoseid" };
            object[] values = { diagnoseid };
            return db.ExecuteNoneQuery(sql, param, values);
        }

        /// <summary>
        /// 查询所有诊断记录
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SelectAllDiagnose()
        {
            string sql = "select * T_Diagnose";
            return db.FillDataSet(sql, null, null).Tables[0];
        }

        /// <summary>
        /// 根据诊断记录id查询检查记录
        /// </summary>
        /// <param name="diagnoseid">诊断记录编号</param>
        /// <returns>DataTable</returns>
        public DataTable SelectDiagnoseBydiagnoseid(string diagnoseid)
        {
            string sql = "select * T_Diagnose where diagnoseid = @diagnoseid";
            string[] param = { "@diagnoseid" };
            object[] values = { diagnoseid };
            return db.FillDataSet(sql, param, values).Tables[0];
        }

        /// <summary>
        ///  根据病人编号查询检查记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns>DataTable</returns>
        public DataTable SelectDiagnoseBypatientid(string patientid)
        {
            string sql = "select * from T_Diagnose where patientid = @patientid";
            string[] param = { "@patientid" };
            object[] values = { patientid };
            return db.FillDataSet(sql, param, values).Tables[0];
        }

    }
}