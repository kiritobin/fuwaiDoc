using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class TCheckDAO
    {
        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 添加检查记录
        /// </summary>
        /// <param name="checkid">检查记录编号</param>
        /// <param name="bloodpressure">血压</param>
        /// <param name="bodytemp">温度</param>
        /// <param name="checkdate">检查时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns>int 大于0添加成功，否则添加失败</returns>
        public int insert(string checkid, string bloodpressure, double bodytemp, string checkdate, string patientid)
        {
            string sql = "insert into T_Check values(@checkid,@bloodpressure,@bodytemp,@checkdate,@patientid)";
            string[] param = { "@checkid", "@bloodpressure", "@bodytemp", "@checkdate", "@patientid" };
            object[] values = { checkid, bloodpressure, bodytemp, checkdate, patientid };

            return db.ExecuteNoneQuery(sql, param, values);
        }

        /// <summary>
        /// 修改检查记录
        /// </summary>
        /// <param name="checkid">检查记录编号</param>
        /// <param name="bloodpressure">血压</param>
        /// <param name="bodytemp">温度</param>
        /// <param name="checkdate">检查时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns>int 大于0修改成功，否则修改失败</returns>
        public int update(string checkid, string bloodpressure, double bodytemp, string checkdate, string patientid)
        {
            string sql = "update T_Check set bloodpressure=@bloodpressure,bodytemp=@bodytemp,checkdate=@checkdate,patientid=@patientid where checkid=@checkid";
            string[] param = { "@bloodpressure", "@bodytemp", "@checkdate", "@patientid", "@checkid" };
            object[] values = { bloodpressure, bodytemp, checkdate, patientid, checkid };

            return db.ExecuteNoneQuery(sql, param, values);
        }

        /// <summary>
        /// 删除一条检查记录
        /// </summary>
        /// <param name="checkid">检查记录编号</param>
        /// <returns>int >0删除成功 否则删除失败</returns>
        public int delete(string checkid)
        {
            string sql = "delete from T_Check = where checkid=@checkid";
            string[] param = { "@checkid" };
            object[] values = { checkid };
            return db.ExecuteNoneQuery(checkid, param, values);
        }

        /// <summary>
        /// 查询所有检查记录
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SelectAllCheck()
        {
            string sql = "select * T_Check";
            return db.FillDataSet(sql, null, null).Tables[0];
        }

        /// <summary>
        /// 根据检查记录id查询检查记录
        /// </summary>
        /// <param name="checkid">检查记录编号</param>
        /// <returns>DataTable</returns>
        public DataTable SelectCheckByCheckID(string checkid)
        {
            string sql = "select * T_Check where by checkid = @checkid";
            string[] param = { "@checkid" };
            object[] values = { checkid };
            return db.FillDataSet(sql, param, values).Tables[0];
        }
    }
}