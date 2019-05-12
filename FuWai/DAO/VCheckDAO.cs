using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using FuWai.DBHelper;

namespace FuWai.DAO
{
    public class VCheckDAO
    {
        SQLHelper db = new SQLHelper();
        /// <summary>
        /// 查询所有检查记录
        /// </summary>
        /// <returns>datatable的表格</returns>
        public DataTable selectVCheck()
        {
            string sql = "select * from V_Check";
            DataTable dt = db.FillDataSet(sql, null, null).Tables[0];
            return dt;
        }
        /// <summary>
        /// 根据病人编号获取病人的检查记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public DataTable selectByPatientId(string patientid)
        {
            String sql = "select * from V_Check where patientid=@patientid";
            String[] param = { "@patientid" };
            object[] value = { patientid };
            DataTable dt = db.FillDataSet(sql, param, value).Tables[0];
            return dt;
        }
    }
}