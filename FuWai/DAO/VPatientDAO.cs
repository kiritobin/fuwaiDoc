using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using FuWai.DBHelper;

namespace FuWai.DAO
{
	public class VPatientDAO
    {
        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 查询所有病人信息
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SelectAllPatient()
        {
            string sql = "select * from V_Patient";
            return db.FillDataSet(sql, null, null).Tables[0];
        }

        /// <summary>
        /// 根据病人id查询病人信息
        /// </summary>
        /// <param name="patientid">病人id</param>
        /// <returns>DataTable</returns>
        public DataTable SelectPatientByPatientID(string patientid)
        {
            string sql = "select * from V_Patient where patientid = @patientid";
            string[] param = { "@patientid" };
            object[] value = { patientid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }

        /// <summary>
        /// 根据监护人id查询病人信息
        /// </summary>
        /// <param name="guardianid">监护人id</param>
        /// <returns>DataTable</returns>
        public DataTable SelectPatientByGuardianID(string guardianid)
        {
            string sql = "select * from V_Patient where guardianid = @guardianid";
            string[] param = { "@guardianid" };
            object[] value = { guardianid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }

        /// <summary>
        /// 根据病情等级id查询病人信息
        /// </summary>
        /// <param name="diseasestatusid">病情等级id</param>
        /// <returns>DataTable</returns>
        public DataTable SelectPatientByDiseasestatusID(string diseasestatusid)
        {
            string sql = "select * from V_Patient where diseasestatusid = @diseasestatusid";
            string[] param = { "@diseasestatusid" };
            object[] value = { diseasestatusid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }

        /// <summary>
        /// 根据无人机id查询病人信息
        /// </summary>
        /// <param name="droneid">无人机id</param>
        /// <returns>DataTable</returns>
        public DataTable SelectPatientByDroneID(string droneid)
        {
            string sql = "select * from V_Patient where droneid = @droneid";
            string[] param = { "@droneid" };
            object[] value = { droneid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }
    }
}