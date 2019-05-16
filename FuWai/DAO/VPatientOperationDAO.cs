using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class VPatientOperationDAO
    {

        SQLHelper db = new SQLHelper();
        /// <summary>
        /// 查询所有手术记录
        /// </summary>
        /// <returns>datatable的表格</returns>
        public DataTable selectVPatientOperation()
        {
            string sql = "select * from V_PatientOperation";
            DataTable dt = db.FillDataSet(sql, null, null).Tables[0];
            return dt;
        }
        /// <summary>
        /// 根据病人编号获取病人的手术记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public DataTable selectVPatientOperationById(string patientid)
        {
            String sql = "select * from V_PatientOperation where patientid=@patientid";
            String[] param = { "@patientid" };
            object[] value = { patientid };
            DataTable dt = db.FillDataSet(sql, param, value).Tables[0];
            return dt;
        }

    }
}