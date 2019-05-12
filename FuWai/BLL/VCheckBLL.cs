using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using FuWai.DAO;
using FuWai.DBHelper;

namespace FuWai.BLL
{
    public class VCheckBLL
    {
        VCheckDAO dao = new VCheckDAO();
        /// <summary>
        /// 查询所有检查记录
        /// </summary>
        /// <returns>datatable的表格</returns>
        public string selectVCheck()
        {
            DataTable dt = dao.selectVCheck();
            string jsonString = string.Empty;
            jsonString = JsonHelper.ToJson(dt);
            return jsonString;
        }
        /// <summary>
        /// 根据病人编号获取病人的检查记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public string selectByPatientId(string patientid)
        {
            DataTable dt = dao.selectByPatientId(patientid);
            return JsonHelper.ToJson(dt);
        }
    }
}