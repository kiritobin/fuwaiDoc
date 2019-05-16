using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class VPatientUsedrugBLL
    {
        VPatientUsedrugDAO vdao = new VPatientUsedrugDAO();
        /// <summary>
        /// 查询所有用药记录
        /// </summary>
        /// <returns>DataTable</returns>
        public string SelectAllPatient()
        {
            return JsonHelper.ToJson(vdao.SelectAllPatient());
        }

        /// <summary>
        /// 根据病人id查询用药信息
        /// </summary>
        /// <param name="patientid">病人id</param>
        /// <returns>DataTable</returns>
        public string SelectPatientByPatientID(string patientid)
        {
            return JsonHelper.ToJson(vdao.SelectPatientByPatientID(patientid));
        }

        /// <summary>
        /// 根据用药记录id查询用药信息
        /// </summary>
        /// <param name="usedrugid">用药记录id</param>
        /// <returns>DataTable</returns>
        public string SelectPatientByUsedrugID(string usedrugid)
        {
            return JsonHelper.ToJson(vdao.SelectPatientByUsedrugID(usedrugid));
        }
    }
}