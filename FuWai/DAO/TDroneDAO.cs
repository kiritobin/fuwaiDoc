using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace FuWai.DAO
{
    public class TDroneDAO
    {
        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 无人机信息查询
        /// </summary>
        /// <returns></returns>
        public DataTable SelectDrone() {
            string sql = "select * from T_Drone";
            return db.FillDataSet(sql, null, null).Tables[0];
        }
    }
}