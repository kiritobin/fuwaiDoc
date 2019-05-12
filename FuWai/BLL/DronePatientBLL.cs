using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class DronePatientBLL
    {

        DronePatientDAO dao = new DronePatientDAO();
        public string selectVDronePatient()
        {
            DataTable dt = dao.selectVDronePatient();
            string json = string.Empty;
            json = JsonHelper.ToJson(dt);         
            return json;
        }

    }
}