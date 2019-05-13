using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class VPatientCheckBLL
    {

        VPatientCheckDAO dao = new VPatientCheckDAO();
        /// <summary>
        /// 查询所有检查记录
        /// </summary>
        /// <returns>datatable的表格</returns>
        public string selectVPatientCheck()
        {
            DataTable dt = dao.selectVPatientCheck();
            string jsonString = string.Empty;
            jsonString = JsonHelper.ToJson(dt);
            return jsonString;
        }
        /// <summary>
        /// 根据病人编号获取病人的检查记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public string selectCheckByPatientId(string patientid)
        {
            DataTable dt = dao.selectCheckByPatientId(patientid);
            return JsonHelper.ToJson(dt);
        }

    }
}