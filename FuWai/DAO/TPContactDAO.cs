using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using FuWai.DBHelper;

namespace FuWai.DAO
{
    public class TPContactDAO
    {
        SQLHelper db = new SQLHelper();
        /// <summary>
        /// 查询所有的病人联系方式
        /// </summary>
        /// <returns></returns>
        public DataTable selectAllPContact()
        {
            string sql = "select * from T_PContact";
            DataTable dt = db.FillDataSet(sql, null, null).Tables[0];
            return dt;
        }
        /// <summary>
        /// 根据病人编号查询病人联系方式
        /// </summary>
        /// <returns></returns>
        public DataTable selectByPatientId(string patientid)
        {
            string sql = "select * from T_PContact where patientid=@patientid";
            string[] param = { "@patientid" };
            object[] value = { patientid };
            DataTable dt = db.FillDataSet(sql, param, value).Tables[0];
            return dt;
        }
        /// <summary>
        /// 添加病人联系方式
        /// </summary>
        /// <param name="pcontactphone">病人联系方式</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public int insertPContact(string pcontactphone,string patientid)
        {
            string sql = "insert into T_PContact(pcontactphone,patientid) value(@pcontactphone,@patientid)";
            string[] param = { "@pcontactphone", "@patientid" };
            object[] value = { pcontactphone, patientid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        ///  根据pcontactid来删除病人联系方式(删除单个联系方式)
        /// </summary>
        /// <param name="pcontactid">主键id</param>
        /// <returns></returns>
        public int deletByPContactId(int pcontactid)
        {
            string sql = "delete from T_PContact where pcontactid=@pcontactid";
            string[] param = { "@pcontactid" };
            object[] value = { pcontactid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        ///  根据病人编号来删除病人联系方式
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public int deletByPatientId(string patientid)
        {
            string sql = "delete from T_PContact where patientid=@patientid";
            string[] param = { "@patientid" };
            object[] value = { patientid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 根据pcontactid更新病人联系方式
        /// </summary>
        /// <param name="pcontactphone">新的联系方式</param>
        /// <param name="pcontactid">主键id</param>
        /// <returns></returns>
        public int updatePContact(string pcontactphone, int pcontactid)
        {
            string sql = "update T_PContact set pcontactphone=@pcontactphone where pcontactid=@pcontactid";
            string[] param = { "@pcontactphone", "@pcontactid" };
            object[] value = { pcontactphone, pcontactid };
            return db.ExecuteNoneQuery(sql, param, value);
        }
    }
}