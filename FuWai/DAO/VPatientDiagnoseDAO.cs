using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class VPatientDiagnoseDAO
    {
        SQLHelper db = new SQLHelper();
        /// <summary>
        /// 查询所有诊断记录
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable selectVPatientDiagnose()
        {
            string sql = "select * from V_PatientDiagnose";
            DataTable dt = db.FillDataSet(sql, null, null).Tables[0];
            return dt;
        }
        /// <summary>
        /// 根据病人编号获取病人的诊断记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public DataTable selectVPatientDiagnosebypatientid(string patientid)
        {
            String sql = "select * from V_PatientDiagnose where patientid=@patientid";
            String[] param = { "@patientid" };
            object[] value = { patientid };
            DataTable dt = db.FillDataSet(sql, param, value).Tables[0];
            return dt;
        }

        /// <summary>
        /// 根据诊断记录编号获取病人的诊断记录
        /// </summary>
        /// <param name="diagnoseid">诊断记录编号</param>
        /// <returns></returns>
        public DataTable selectVPatientDiagnosebydiagnoseid(string diagnoseid)
        {
            String sql = "select * from V_PatientDiagnose where diagnoseid=@diagnoseid";
            String[] param = { "@diagnoseid" };
            object[] value = { diagnoseid };
            DataTable dt = db.FillDataSet(sql, param, value).Tables[0];
            return dt;
        }

    }
}