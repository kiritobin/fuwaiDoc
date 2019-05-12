using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{

    public class VPatientBLL
    {
        VPatientDAO adao = new VPatientDAO();

        /// <summary>
        /// 查询所有病人信息
        /// </summary>
        /// <returns>json字符串</returns>
        public string SelectAllPatient()
        {
            return JsonHelper.ToJson(adao.SelectAllPatient());
        }

        /// <summary>
        /// 根据病人id查询病人信息
        /// </summary>
        /// <param name="patientid">病人id</param>
        /// <returns>json字符串</returns>
        public string SelectPatientByPatientID(string patientid)
        {
            return JsonHelper.ToJson(adao.SelectPatientByPatientID(patientid));
        }

        /// <summary>
        /// 根据监护人id查询病人信息
        /// </summary>
        /// <param name="guardianid">监护人id</param>
        /// <returns>json字符串</returns>
        public string SelectPatientByGuardianID(string guardianid)
        {
            return JsonHelper.ToJson(adao.SelectPatientByGuardianID(guardianid));
        }

        /// <summary>
        /// 根据病情等级id查询病人信息
        /// </summary>
        /// <param name="diseasestatusid">病情等级id</param>
        /// <returns>json字符串</returns>
        public string SelectPatientByDiseasestatusID(string diseasestatusid)
        {
            return JsonHelper.ToJson(adao.SelectPatientByDiseasestatusID(diseasestatusid));
        }

        /// <summary>
        /// 根据无人机id查询病人信息
        /// </summary>
        /// <param name="droneid">无人机id</param>
        /// <returns>json字符串</returns>
        public string SelectPatientByDroneID(string droneid)
        {
            return JsonHelper.ToJson(adao.SelectPatientByDroneID(droneid));
        }
    }
}