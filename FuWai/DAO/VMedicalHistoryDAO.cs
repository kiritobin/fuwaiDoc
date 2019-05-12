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
        /// 无人机信息查询
        /// </summary>
        /// <returns></returns>
        public DataTable SelectVMedicalHistory()
        {
            string sql = "select * from V_MedicalHistory";
            return db.FillDataSet(sql, null, null).Tables[0];
        }
    }
}