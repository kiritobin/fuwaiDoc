using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class TPatientDAO
    {

        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 病人信息查询
        /// </summary>
        /// <returns>返回所有数据集合DataTable</returns>
        public DataTable SelectPatient()
        {
            string sql = "select * from T_Patient";
            return db.FillDataSet(sql, null, null).Tables[0];
        }

        /// <summary>
        /// 通过病人编号（id）查询
        /// </summary>
        /// <param name="patientid">无人机编号</param>
        /// <returns>返回数据集合DataTable</returns>
        public DataTable SelectPatientByID(string patientid)
        {
            string sql = "select * from T_Patient where patientid=@patientid";
            string[] param = { "@patientid" };
            object[] value = { patientid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }

        /// <summary>
        /// 添加病人信息
        /// </summary>
        /// <param name="patientid">编号</param>
        /// <param name="patientname">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="guardianid">监护人编号</param>
        /// <param name="diseasestatusid">病情等级编号</param>
        /// <param name="droneid">无人机编号</param>
        /// <returns>返回int</returns>
        public int insert(string patientid, string patientname, string gender, int guardianid, int diseasestatusid, string droneid,string tel)
        {
            string sql = "insert into T_Patient values(@patientid,@patientname,@gender,@guardianid,@diseasestatusid,@droneid,@tel)";

            string[] param = { "@patientid", "@patientname", "@gender", "@guardianid", "@diseasestatusid", "@droneid" ,"@tel"};
            object[] value = { patientid, patientname, gender, guardianid, diseasestatusid, droneid ,tel};

            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 修改无人机信息
        /// </summary>
        /// <param name="patientid">编号</param>
        /// <param name="patientname">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="guardianid">监护人编号</param>
        /// <param name="diseasestatusid">病情等级编号</param>
        /// <param name="droneid">无人机编号</param>
        /// <returns>返回int</returns>
        /// <returns>返回int</returns>
        public int update(string patientid, string patientname, string gender, int guardianid, int diseasestatusid, string droneid,string tel)
        {
            string sql = "update T_Patient set patientid=@patientid patientname=@patientname ,gender=@gender,guardianid=@guardianid,diseasestatusid=@diseasestatusid,droneid=@droneid,tel=@tel where patientid=@patientid ";

            string[] param = { "@patientid", "@patientname", "@gender", "@guardianid", "@diseasestatusid", "@droneid","@tel" };
            object[] value = { patientid, patientname, gender, guardianid, diseasestatusid, droneid ,tel};

            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 删除病人信息
        /// </summary>
        /// <param name="patientid">编号</param>
        /// <returns>返回int</returns>
        public int delete(string patientid)
        {
            string sql = "delete from T_Patient where patientid=@patientid ";

            string[] param = { "@patientid" };
            object[] value = { patientid };

            return db.ExecuteNoneQuery(sql, param, value);
        }

    }
}