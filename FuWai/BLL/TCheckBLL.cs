using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class TCheckBLL
    {
        TCheckDAO td = new TCheckDAO();

        /// <summary>
        /// 添加检查记录
        /// </summary>
        /// <param name="checkid">检查记录编号</param>
        /// <param name="bloodpressure">血压</param>
        /// <param name="bodytemp">温度</param>
        /// <param name="checkdate">检查时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns>boolean true添加成功，false添加失败</returns>
        public Boolean insert(string bloodpressure, double bodytemp, string checkdate, string patientid)
        {
            int row = td.insert(bloodpressure, bodytemp, checkdate, patientid);
            if (row > 0) return true;
            return false;
        }

        /// <summary>
        /// 修改检查记录
        /// </summary>
        /// <param name="checkid">检查记录编号</param>
        /// <param name="bloodpressure">血压</param>
        /// <param name="bodytemp">温度</param>
        /// <param name="checkdate">检查时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns>boolean true修改成功，false修改失败</returns>
        public Boolean update(string checkid, string bloodpressure, double bodytemp, string checkdate, string patientid)
        {
            int row = td.update(checkid, bloodpressure, bodytemp, checkdate, patientid);
            if (row > 0) return true;
            return false;
        }

        /// <summary>
        /// 删除一条检查记录
        /// </summary>
        /// <param name="checkid">检查记录编号</param>
        /// <returns>boolean true修改成功，false修改失败</returns>
        public Boolean delete(string checkid)
        {
            int row = td.delete(checkid);
            if (row > 0) return true;
            return false;
        }

        /// <summary>
        /// 查询所有检查记录
        /// </summary>
        /// <returns>json</returns>
        public string SelectAllCheck()
        {
            return JsonHelper.ToJson(td.SelectAllCheck());
        }

        /// <summary>
        /// 根据检查记录id查询检查记录
        /// </summary>
        /// <param name="checkid">检查记录编号</param>
        /// <returns>json</returns>
        public string SelectCheckByCheckID(string checkid)
        {
            return JsonHelper.ToJson(td.SelectCheckByCheckID(checkid));
        }
    }
}