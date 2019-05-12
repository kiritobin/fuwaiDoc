using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class VDronePatientDAO
    {
        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 查询视图V_DronePatient所有信息
        /// </summary>
        /// <returns></returns>
        public DataTable selectVDronePatient()
        {
            string sql = "select * from V_DronePatient";
            return db.FillDataSet(sql, null, null).Tables[0];
        }

        /// <summary>
        /// 通过无人机编号（droneid）查询视图V_DronePatient所有信息
        /// </summary>
        /// <param name="droneid">无人机编号</param>
        /// <returns></returns>
        public DataTable selectVDronePatientByDroneid(string droneid)
        {
            string sql = "select * from V_DronePatient where droneid = @droneid";
            string[] param = { "@droneid" };
            object[] value = { droneid };
            return db.FillDataSet(sql, param, value).Tables[0]; 
        }
    }
}