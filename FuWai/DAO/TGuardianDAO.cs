using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class TGuardianDAO
    {
        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 查询所有监护人信息
        /// </summary>
        /// <returns>返回数据集DataTable</returns>
        public DataTable SelectGuardian()
        {
            string sql = "select * from V_GContact";
            return db.FillDataSet(sql, null, null).Tables[0];
        }

        /// <summary>
        /// 通过监护人编号查询监护人信息
        /// </summary>
        /// <param name="guardianid">监护人编号</param>
        /// <returns>返回数据集DataTable</returns>
        public DataTable SelectGuardianbyguardianid(string guardianid)
        {
            string sql = "select * from T_Guardian where guardianid=@guardianid";
            string[] param = { "@guardianid" };
            object[] value = { guardianid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }

        /// <summary>
        /// 添加监护人
        /// </summary>
        /// <param name="appellation">成员关系</param>
        /// <param name="guardianname">监护人姓名</param>
        /// <param name="guardianid">监护人编号</param>
        /// <returns>返回int</returns>
        public int insert(string appellation, string guardianname, string patientid)
        {
            string sql = "insert into T_Guardian values(@appellation,@guardianname,@patientid)";

            string[] param = { "@appellation", "@guardianname","@patientid" };
            object[] value = { appellation, guardianname, patientid };

            return db.ExecuteNoneQuery(sql, param, value);
        }

        /// <summary>
        /// 修改监护人
        /// </summary>
        /// <param name="appellation">成员关系</param>
        /// <param name="guardianname">监护人姓名</param>
        /// <param name="guardianid">监护人编号</param>
        /// <returns>返回int</returns>
        public int update(string appellation, string guardianname,string guardianid)
        {
            string sql = "update T_Guardian set appellation=@appellation,guardianname=@guardianname where guardianid=@guardianid ";

            string[] param = { "@appellation", "@guardianname", "@guardianid" };
            object[] value = { appellation, guardianname, guardianid };

            return db.ExecuteNoneQuery(sql, param, value);
        }

        /// <summary>
        /// 删除监护人
        /// </summary>
        /// <param name="gcontactid">监护人编号</param>
        /// <returns>返回int</returns>
        public int delete(string guardianid)
        {
            string sql = "delete from T_Guardian where guardianid=@guardianid ";

            string[] param = { "@guardianid" };
            object[] value = { guardianid };

            return db.ExecuteNoneQuery(sql, param, value);
        }
    }
}