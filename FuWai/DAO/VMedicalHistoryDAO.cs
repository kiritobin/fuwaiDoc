using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using FuWai.DBHelper;

namespace FuWai.DAO
{
    public class VMedicalHistoryDAO
    {
        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 病史信息查询
        /// </summary>
        /// <returns></returns>
        public DataTable SelectVMedicalHistorybymedicalhistoryid(string medicalhistoryid)
        {
            string sql = "select * from V_MedicalHistory where medicalhistoryid = @medicalhistoryid";

            string[] param = { "@medicalhistoryid" };
            object[] vlaue = { medicalhistoryid };

            return db.FillDataSet(sql, param, vlaue).Tables[0];
        }
        /// <summary>
        /// 查询所有病人病史记录
        /// </summary>
        /// <returns></returns>
        public DataTable SelectAll()
        {
            string sql = "select * from V_MedicalHistory";
            return db.FillDataSet(sql, null, null).Tables[0];
        }
        /// <summary>
        /// 病人病史信息查询
        /// </summary>
        /// <returns></returns>
        public DataTable SelectVMedicalHistorybypatientid(string patientid)
        {
            string sql = "select * from V_MedicalHistory where patientid = @patientid";

            string[] param = { "@patientid" };
            object[] vlaue = { patientid };

            return db.FillDataSet(sql, param, vlaue).Tables[0];
        }

    }
}