using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class TDiseasestatusBLL
    {
        TDiseasestatusDAO td = new TDiseasestatusDAO();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="diseasestatusid">编号</param>
        /// <param name="statusname">名称</param>
        /// <returns>Boolean true成功，否则失败</returns>
        public Boolean insert(string diseasestatusid, string statusname)
        {
            int row = td.insert(diseasestatusid, statusname);
            if (row > 0) return true;
            return false;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="diseasestatusid">编号</param>
        /// <param name="statusname">名称</param>
        /// <returns>Boolean true成功，否则失败</returns>
        public Boolean update(string diseasestatusid, string statusname)
        {
            int row = td.update(diseasestatusid, statusname);
            if (row > 0) return true;
            return false;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="diseasestatusid">编号</param>
        /// <returns>Boolean true成功，否则失败</returns>
        public Boolean delete(string diseasestatusid)
        {
            int row = td.delete(diseasestatusid);
            if (row > 0) return true;
            return false;
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns>DataTable</returns>
        public string SelectAllTDiseasestatus()
        {
            return JsonHelper.ToJson(td.SelectAllTDiseasestatus());
        }

        /// <summary>
        /// 根据编号查询
        /// </summary>
        /// <param name="diseasestatusid">编号</param>
        /// <returns>DataTable</returns>
        public string SelectByDiseasestatusid(string diseasestatusid)
        {
            return JsonHelper.ToJson(td.SelectByDiseasestatusid(diseasestatusid));
        }
    }
}