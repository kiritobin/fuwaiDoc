using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class VGContactBLL
    {
        VGContactDAO dao = new VGContactDAO();
        /// <summary>
        /// 查询监护人信息
        /// </summary>
        /// <returns>json</returns>
        public string selectVGContact()
        {
            return JsonHelper.ToJson(dao.selectVGContact());
        }
        /// <summary>
        /// 通过病人编号查询监护人信息
        /// </summary>
        /// <returns>json</returns>
        public string selectVGContactByPatientId(string patientid)
        {
            return JsonHelper.ToJson(dao.selectVGContactByPatientId(patientid));
        }
    }
}