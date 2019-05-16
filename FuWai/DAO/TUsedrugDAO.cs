using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class TUsedrugDAO
    {
        SQLHelper db = new SQLHelper();
        /// <summary>
        /// 查询所有的用药记录
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable selectAllTUsedrug()
        {
            string sql = "select * from T_Usedrug";
            DataTable dt = db.FillDataSet(sql, null, null).Tables[0];
            return dt;
        }
        /// <summary>
        /// 根据病人编号查询用药记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns>DataTable</returns>
        public DataTable selectByPatientId(string patientid)
        {
            string sql = "select * from T_Usedrug where patientid=@patientid";
            string[] param = { "@patientid" };
            object[] value = { patientid };
            DataTable dt = db.FillDataSet(sql, param, value).Tables[0];
            return dt;
        }
        /// <summary>
        /// 根据主键（用药记录id）查询用药记录
        /// </summary>
        /// <param name="Usedrugid">主键</param>
        /// <returns>DataTable</returns>
        public DataTable selectByUsedrugId(string usedrugid)
        {
            string sql = "select * from T_Usedrug where usedrugid=@usedrugid";
            string[] param = { "@usedrugid" };
            object[] value = { usedrugid };
            DataTable dt = db.FillDataSet(sql, param, value).Tables[0];
            return dt;
        }
        /// <summary>
        /// 添加病人用药记录信息
        /// </summary>
        /// <param name="Usedrugid">编号</param>
        /// <param name="UsedrugBdate">开始时间</param>
        /// <param name="UsedrugEdate">结束时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public int insert(string usedrugidtime, string usedrugidname, string dosage, string remark, string patientid)
        {
            string sql = "insert into T_Usedrug(usedrugidtime,usedrugidname,dosage,remark,patientid) values (@usedrugidtime,@usedrugidname,@dosage,@remark,@patientid)";
            string[] param = { "@usedrugidtime", "@usedrugidname", "@dosage", "@remark", "@patientid" };
            object[] value = { usedrugidtime, usedrugidname, dosage, remark, patientid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 根据编号删除用药记录
        /// </summary>
        /// <param name="Usedrugid">编号</param>
        /// <returns></returns>
        public int delete(string usedrugid)
        {
            string sql = "delete from T_Usedrug where usedrugid=@usedrugid";
            string[] param = { "@usedrugid" };
            object[] value = { usedrugid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 根据病人编号删除用药记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public int deleteByPatientId(string patientid)
        {
            string sql = "delete from T_Usedrug where patientid=@patientid";
            string[] param = { "@patientid" };
            object[] value = { patientid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 根据编号更新病人用药记录
        /// </summary>
        /// <param name="usedrugid"></param>
        /// <param name="usedrugidtime"></param>
        /// <param name="usedrugidname"></param>
        /// <param name="dosage"></param>
        /// <param name="remark"></param>
        /// <param name="patientid"></param>
        /// <returns></returns>
        public int update(string usedrugid, string usedrugidtime, string usedrugidname, string dosage, string remark, string patientid)
        {
            string sql = "update T_Usedrug set usedrugidtime=@usedrugidtime,usedrugidname=@usedrugidname,dosage=@dosage,remark=@remark,patientid=@patientid where usedrugid=@usedrugid";
            string[] param = { "@usedrugidtime", "@usedrugidname", "@dosage", "@remark", "@patientid","@usedrugid" };
            object[] value = { usedrugidtime, usedrugidname, dosage, remark, patientid, usedrugid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
    }
}