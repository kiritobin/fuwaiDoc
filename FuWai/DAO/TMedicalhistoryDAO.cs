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
        /// 通过病人编号查询病史记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public DataTable SelectByPatient(string patientid)
        {
            string sql = "select * from T_Medicalhistory where patientid=@patientid";
            string[] param = { "@patientid" };
            object[] value = { patientid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }
        /// <summary>
        /// 通过病史编号（id）查询
        /// </summary>
        /// <param name="medicalhistoryid">病史编号</param>
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
        /// <param name="medicalhistoryname">疾病名称</param>
        /// <param name="patientid">病人编号</param>
        /// <param name="remark">备注</param>
        /// <returns></returns>
        public int insert(string medicalhistoryname, string patientid, string remark)
        {
            string sql = "insert into T_Medicalhistory values(@medicalhistoryname,@patientid,@remark)";

            string[] param = { "@medicalhistoryname", "@patientid", "@remark"};
            object[] value = { medicalhistoryname, patientid, remark };

            return db.ExecuteNoneQuery(sql, param, value);
        }

        /// <summary>
        /// 修改病史信息
        /// </summary>
        /// <param name="medicalhistoryid">病史编号</param>
        /// <param name="medicalhistoryname">疾病名称</param>
        /// <param name="patientid">病人编号</param>
        /// <param name="remark">备注</param>
        /// <returns></returns>
        public int update(int medicalhistoryid,string medicalhistoryname, string patientid, string remark)
        {
            string sql = "update T_Medicalhistory set medicalhistoryname=@medicalhistoryname,remark=@remark,doctor=@doctor where medicalhistoryid=@medicalhistoryid";

            string[] param = { "@medicalhistoryid", "@medicalhistoryname", "@patientid", "@remark", "@doctor" };
            object[] value = { medicalhistoryid, medicalhistoryname, patientid,remark };

            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 删除病史信息
        /// </summary>
        /// <param name="medicalhistoryid">病史编号</param>
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