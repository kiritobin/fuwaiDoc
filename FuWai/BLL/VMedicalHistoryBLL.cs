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
        public String getDroneinfobymedicalhistoryid(string medicalhistoryid)
        {
            DataTable dt = vmh.SelectVMedicalHistorybymedicalhistoryid(medicalhistoryid);
            String json = "";
            json = JsonHelper.ToJson(dt);
            return json;
        }

        /// <summary>
        /// 病人编号查询病史
        /// </summary>
        /// <returns></returns>
        public String getDroneinfobypatientid(string patientid)
        {
            DataTable dt = vmh.SelectVMedicalHistorybymedicalhistoryid(patientid);
            String json = "";
            json = JsonHelper.ToJson(dt);
            return json;
        }

    }
}