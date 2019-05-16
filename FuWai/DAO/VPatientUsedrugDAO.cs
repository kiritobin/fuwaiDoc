using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class VPatientUsedrugDAO
    {
        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 查询所有用药记录
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SelectAllPatient()
        {
            string sql = "select * from V_PatientUsedrug";
            return db.FillDataSet(sql, null, null).Tables[0];
        }

        /// <summary>
        /// 根据病人id查询用药信息
        /// </summary>
        /// <param name="patientid">病人id</param>
        /// <returns>DataTable</returns>
        public DataTable SelectPatientByPatientID(string patientid)
        {
            string sql = "select * from V_PatientUsedrug where patientid = @patientid";
            string[] param = { "@patientid" };
            object[] value = { patientid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }

        /// <summary>
        /// 根据用药记录id查询用药信息
        /// </summary>
        /// <param name="usedrugid">用药记录id</param>
        /// <returns>DataTable</returns>
        public DataTable SelectPatientByUsedrugID(string usedrugid)
        {
            string sql = "select * from V_PatientUsedrug where usedrugid = @usedrugid";
            string[] param = { "@patientid" };
            object[] value = { usedrugid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }
    }
}