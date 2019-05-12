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
        public DataTable selectVDronePatient()
        {
            string sql = "select * from V_DronePatient";
            DataTable dt = db.FillDataSet(sql, null, null).Tables[0];
            return dt;
        }

    }
}