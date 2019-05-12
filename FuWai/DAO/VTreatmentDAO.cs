using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using FuWai.DBHelper;

namespace FuWai.DAO
{
    public class VTreatmentDAO
    {
        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 查询所有治疗记录
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SelectAllTreatment()
        {
            string sql = "select * from V_Treatment";
            string[] param = { };
            object[] values = { };
            return db.FillDataSet(sql, param, values).Tables[0];
        }

        /// <summary>
        /// 根据病人编号id所有治疗记录
        /// </summary>
        /// <param name="patientid">病人编号id</param>
        /// <returns>DataTable</returns>
        public DataTable SelectTreatmentByPatientID(string patientid)
        {
            string sql = "select * from V_Treatment where patientid=@patientid";
            string[] param = { "@patientid" };
            object[] values = { patientid };
            return db.FillDataSet(sql, param, values).Tables[0];
        }

        /// <summary>
        /// 根据治疗记录编号id查询所有治疗记录
        /// </summary>
        /// <param name="treatmentid">记录编号id</param>
        /// <returns>DataTable</returns>
        public DataTable SelectTreatmentByTreatmentID(string treatmentid)
        {
            string sql = "select * from V_Treatment where treatmentid=@treatmentid";
            string[] param = { "@treatmentid" };
            object[] values = { treatmentid };
            return db.FillDataSet(sql, param, values).Tables[0];
        }
    }
}