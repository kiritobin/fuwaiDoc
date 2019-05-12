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
        /// 病人病史信息查询
        /// </summary>
        /// <returns></returns>
        public String getDroneinfo()
        {
            DataTable dt = vmh.SelectVMedicalHistory();
            String json = "";
            json = JsonHelper.ToJson(dt);
            return json;
        }
    }
}