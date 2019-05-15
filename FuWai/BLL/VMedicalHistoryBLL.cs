using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class VMedicalHistoryBLL
    {
        VMedicalHistoryDAO vmh  = new VMedicalHistoryDAO();
        /// <summary>
        /// 历史信息编号查询病史
        /// </summary>
        /// <returns></returns>
        public String getinfobymedicalhistoryid(string medicalhistoryid)
        {
            DataTable dt = vmh.SelectVMedicalHistorybymedicalhistoryid(medicalhistoryid);
            String json = "";
            json = JsonHelper.ToJson(dt);
            return json;
        }
        /// <summary>
        /// 查询所有病人病史记录
        /// </summary>
        /// <returns></returns>
        public String SelectAll()
        {
            return JsonHelper.ToJson(vmh.SelectAll());
        }
        /// <summary>
        /// 病人编号查询病史
        /// </summary>
        /// <returns></returns>
        public String getinfobypatientid(string patientid)
        {
            DataTable dt = vmh.SelectVMedicalHistorybypatientid(patientid);
            String json = "";
            json = JsonHelper.ToJson(dt);
            return json;
        }

    }
}