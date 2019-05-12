using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class TMedicalhistoryDAO
    {

        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 病史查询
        /// </summary>
        /// <returns>返回所有数据集合DataTable</returns>
        public DataTable SelectMedicalhistory()
        {
            string sql = "select * from T_Medicalhistory";
            return db.FillDataSet(sql, null, null).Tables[0];
        }

        /// <summary>
        /// 通过病史编号（id）查询
        /// </summary>
        /// <param name="droneid">无人机编号</param>
        /// <returns>返回数据集合DataTable</returns>
        public DataTable SelecttMedicalhistoryByID(string medicalhistoryid)
        {
            string sql = "select * from T_Medicalhistory where medicalhistoryid=@medicalhistoryid";
            string[] param = { "@medicalhistoryid" };
            object[] value = { medicalhistoryid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }

        /// <summary>
        /// 添加病史信息
        /// </summary>
        /// <param name="medicalhistoryreason">病因</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public int insert(string medicalhistoryreason, string patientid)
        {
            string sql = "insert into T_Medicalhistory values(@medicalhistoryreason,@patientid)";

            string[] param = { "@medicalhistoryreason", "@patientid"};
            object[] value = { medicalhistoryreason, patientid };

            return db.ExecuteNoneQuery(sql, param, value);
        }

        /// <summary>
        /// 修改病史信息
        /// </summary>
        /// <param name="medicalhistoryreason">病因</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public int update(string medicalhistoryreason, string patientid)
        {
            string sql = "update T_Medicalhistory set medicalhistoryreason=@medicalhistoryreason ,patientid=@patientid";

            string[] param = { "@medicalhistoryreason", "@patientid"};
            object[] value = { medicalhistoryreason, patientid };

            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 删除病史信息
        /// </summary>
        /// <param name="medicalhistoryid">编号</param>
        /// <returns></returns>
        public int delete(string medicalhistoryid)
        {
            string sql = "delete from T_Medicalhistory where medicalhistoryid=@medicalhistoryid ";

            string[] param = { "@medicalhistoryid" };
            object[] value = { medicalhistoryid };

            return db.ExecuteNoneQuery(sql, param, value);
        }

    }
}