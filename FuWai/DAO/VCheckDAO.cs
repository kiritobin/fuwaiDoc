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
        public DataTable selectVCheck()
        {
            string sql = "select * from V_Check";
            DataTable dt = db.FillDataSet(sql, null, null).Tables[0];
            return dt;
        }
    }
}