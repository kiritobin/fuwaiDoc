using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class VPatientDiagnoseBLL
    {
        VPatientDiagnoseDAO dao = new VPatientDiagnoseDAO();
        /// <summary>
        /// 查询所有诊断记录
        /// </summary>
        /// <returns>json</returns>
        public string selectVPatientDiagnose()
        {
            return JsonHelper.ToJson(dao.selectVPatientDiagnose());
        }
        /// <summary>
        /// 根据病人编号获取病人的诊断记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns>json</returns>
        public string selectVPatientDiagnosebypatientid(string patientid)
        {
            return JsonHelper.ToJson(dao.selectVPatientDiagnosebypatientid(patientid));
        }

        /// <summary>
        /// 根据诊断记录编号获取病人的诊断记录
        /// </summary>
        /// <param name="diagnoseid">诊断记录编号</param>
        /// <returns></returns>
        public string selectVPatientDiagnosebydiagnoseid(string diagnoseid)
        {
            return JsonHelper.ToJson(dao.selectVPatientDiagnosebydiagnoseid(diagnoseid));
        }

    }
}