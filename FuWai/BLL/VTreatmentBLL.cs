using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class VTreatmentBLL
    {
        VTreatmentDAO tdao = new VTreatmentDAO();
        /// <summary>
        /// 查询所有治疗记录
        /// </summary>
        /// <returns>DataTable</returns>
        public string SelectAllTreatment()
        {
            return JsonHelper.ToJson(tdao.SelectAllTreatment());
        }

        /// <summary>
        /// 根据病人编号id所有治疗记录
        /// </summary>
        /// <param name="patientid">病人编号id</param>
        /// <returns>DataTable</returns>
        public string SelectTreatmentByPatientID(string patientid)
        {
            return JsonHelper.ToJson(tdao.SelectTreatmentByPatientID(patientid));
        }

        /// <summary>
        /// 根据治疗记录编号id查询所有治疗记录
        /// </summary>
        /// <param name="treatmentid">记录编号id</param>
        /// <returns>DataTable</returns>
        public string SelectTreatmentByTreatmentID(string treatmentid)
        {
            return JsonHelper.ToJson(tdao.SelectTreatmentByTreatmentID(treatmentid));
        }
    }
}