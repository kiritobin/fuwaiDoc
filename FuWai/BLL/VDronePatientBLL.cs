using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class VDronePatientBLL
    {

        VDronePatientDAO dao = new VDronePatientDAO();

        /// <summary>
        /// 查询视图V_DronePatient所有信息
        /// </summary>
        /// <returns></returns>
        public string selectVDronePatient()
        {
            DataTable dt = dao.selectVDronePatient();
            string json = string.Empty;
            json = JsonHelper.ToJson(dt);         
            return json;
        }

        /// <summary>
        /// 通过无人机编号（droneid）查询视图V_DronePatient所有信息
        /// </summary>
        /// <param name="droneid">无人机编号</param>
        /// <returns></returns>
        public string selectVDronePatientBydroneid(string droneid)
        {
            DataTable dt = dao.selectVDronePatientByDroneid(droneid);
            return JsonHelper.ToJson(dt);
        }

    }
}