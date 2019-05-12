using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class TDiseasestatusDAO
    {
        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="diseasestatusid">编号</param>
        /// <param name="statusname">名称</param>
        /// <returns>int 大于0成功，否则失败</returns>
        public int insert(string diseasestatusid, string statusname)
        {
            string sql = "insert into T_Diseasestatus values(@diseasestatusid,@statusname)";
            string[] param = { "@diseasestatusid", "@statusname" };
            object[] values = { diseasestatusid, statusname };

            return db.ExecuteNoneQuery(sql, param, values);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="diseasestatusid">编号</param>
        /// <param name="statusname">名称</param>
        /// <returns>int 大于0成功，否则失败</returns>
        public int update(string diseasestatusid, string statusname)
        {
            string sql = "update T_Diseasestatus set statusname=@statusname where diseasestatusid=@diseasestatusid";
            string[] param = { "@statusname", "@diseasestatusid" };
            object[] values = { statusname, diseasestatusid };

            return db.ExecuteNoneQuery(sql, param, values);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="diseasestatusid">编号</param>
        /// <returns>int 大于0成功，否则失败</returns>
        public int delete(string diseasestatusid)
        {
            string sql = "delete from T_Diseasestatus where diseasestatusid=@diseasestatusid";
            string[] param = { "@diseasestatusid" };
            object[] values = {  diseasestatusid };

            return db.ExecuteNoneQuery(sql, param, values);
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SelectAllTDiseasestatus()
        {
            string sql = "select * from T_Diseasestatus";
            return db.FillDataSet(sql, null, null).Tables[0];
        }

        /// <summary>
        /// 根据编号查询
        /// </summary>
        /// <param name="diseasestatusid">编号</param>
        /// <returns>DataTable</returns>
        public DataTable SelectByDiseasestatusid(string diseasestatusid)
        {
            string sql = "select * T_Diseasestatus where by diseasestatusid = @diseasestatusid";
            string[] param = { "@diseasestatusid" };
            object[] values = { diseasestatusid };
            return db.FillDataSet(sql, param, values).Tables[0];
        }
    }
}