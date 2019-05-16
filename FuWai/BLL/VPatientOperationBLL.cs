using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class VPatientOperationBLL
    {

        VPatientOperationDAO dao = new VPatientOperationDAO();
        /// <summary>
        /// 查询所有手术记录
        /// </summary>
        /// <returns>datatable的表格</returns>
        public string selectVPatientOperation()
        {
            DataTable dt = dao.selectVPatientOperation();
            string jsonString = string.Empty;
            jsonString = JsonHelper.ToJson(dt);
            return jsonString;
        }
        /// <summary>
        /// 根据病人编号获取病人的手术记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public string selectVPatientOperationById(string patientid)
        {
            DataTable dt = dao.selectVPatientOperationById(patientid);
            return JsonHelper.ToJson(dt);
        }

    }
}