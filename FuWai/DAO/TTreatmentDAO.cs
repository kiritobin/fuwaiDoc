﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using FuWai.DBHelper;

namespace FuWai.DAO
{
    public class TTreatmentDAO
    {
        SQLHelper db = new SQLHelper();
        /// <summary>
        /// 查询所有的治疗记录
        /// </summary>
        /// <returns></returns>
        public DataTable selectAllTTreatment()
        {
            string sql = "select * from T_Treatment";
            DataTable dt = db.FillDataSet(sql, null, null).Tables[0];
            return dt;
        }
        /// <summary>
        /// 根据病人编号查询治疗记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public DataTable selectByPatientId(string patientid)
        {
            string sql = "select * from T_Treatment where patientid=@patientid";
            string[] param = { "@patientid" };
            object[] value = { patientid };
            DataTable dt = db.FillDataSet(sql, param, value).Tables[0];
            return dt;
        }
        /// <summary>
        /// 根据主键查询治疗记录
        /// </summary>
        /// <param name="treatmentid">主键</param>
        /// <returns></returns>
        public DataTable selectByTreatmentId(string treatmentid)
        {
            string sql = "select * from T_Treatment where treatmentid=@treatmentid";
            string[] param = { "@treatmentid" };
            object[] value = { treatmentid };
            DataTable dt = db.FillDataSet(sql, param, value).Tables[0];
            return dt;
        }
        /// <summary>
        /// 添加病人治疗记录信息
        /// </summary>
        /// <param name="treatmentid">编号</param>
        /// <param name="treatmentBdate">开始时间</param>
        /// <param name="treatmentEdate">结束时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public int insertTreatment(string treatmentid, string treatmentBdate, string treatmentEdate, string patientid)
        {
            string sql = "insert into T_Treatment(treatmentid,treatmentBdate,treatmentEdate,patientid) value(@treatmentid,@treatmentBdate,@treatmentEdate,@patientid)";
            string[] param = { "@treatmentid", "@treatmentBdate", "@treatmentEdate", "@patientid" };
            object[] value = { treatmentid, treatmentBdate, treatmentEdate, patientid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 根据编号删除治疗记录
        /// </summary>
        /// <param name="treatmentid">编号</param>
        /// <returns></returns>
        public int deleteByTreatmentId(string treatmentid)
        {
            string sql = "delete from T_Treatment where treatmentid=@treatmentid";
            string[] param = { "@treatmentid" };
            object[] value = { treatmentid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 根据病人编号删除治疗记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public int deletByPatientId(string patientid)
        {
            string sql = "delete from T_Treatment where patientid=@patientid";
            string[] param = { "@patientid" };
            object[] value = { patientid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 根据编号更新病人治疗记录
        /// </summary>
        /// <param name="treatmentid"></param>
        /// <param name="treatmentBdate"></param>
        /// <param name="treatmentEdate"></param>
        /// <returns></returns>
        public int updateTreatmentId(string treatmentid, string treatmentBdate, string treatmentEdate)
        {
            string sql = "update T_Treatment set treatmentBdate=@treatmentBdate or treatmentEdate=@treatmentEdate where treatmentid=@treatmentid";
            string[] param = { "@treatmentBdate", "@treatmentEdate", "treatmentid" };
            object[] value = { treatmentBdate, treatmentEdate, treatmentid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 根据病人编号更新治疗记录
        /// </summary>
        /// <param name="treatmentid">编号</param>
        /// <param name="treatmentBdate">开始时间</param>
        /// <param name="treatmentEdate">结束时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public int updatePatientId(string treatmentid, string treatmentBdate, string treatmentEdate, string patientid)
        {
            string sql = "update T_Treatment set treatmentid=@treatmentid or treatmentBdate=@treatmentBdate or treatmentEdate=@treatmentEdate where patientid=@patientid";
            string[] param = { "@treatmentBdate", "@treatmentEdate", "treatmentid", "@patientid" };
            object[] value = { treatmentBdate, treatmentEdate, treatmentid, patientid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
    }
}