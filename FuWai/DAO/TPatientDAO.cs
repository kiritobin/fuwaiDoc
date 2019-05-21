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
        /// <param name="age">年龄</param>
        /// <param name="addr">地址信息</param>
        /// <param name="lat">x轴</param>
        /// <param name="lng">y轴</param>
        /// <param name="diseasestatusid">病情等级编号</param>
        /// <param name="droneid">无人机编号</param>
        /// <returns>返回int</returns>
        public int insert(string patientid, string patientname, string gender, int age, string addr, Double lat, 
            Double lng, int diseasestatusid, string droneid,string weight,string height,string headimg)
        {
            string sql = "insert into T_Patient values(@patientid,@patientname,@gender,@age,@addr,@lat,@lng,@diseasestatusid,@droneid,@weight,@height,@headimg)";

            string[] param = { "@patientid", "@patientname", "@gender", "age", "addr", "lat", "lng", "@diseasestatusid", "@droneid", "@weight", "@height", "@headimg" };
            object[] value = { patientid, patientname, gender, age, addr, lat, lng, diseasestatusid, droneid, weight, height, headimg };

            return db.ExecuteNoneQuery(sql, param, value);
        }
        /// <summary>
        /// 修改病人信息
        /// </summary>
        /// <param name="patientid">编号</param>
        /// <param name="patientname">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="age">年龄</param>
        /// <param name="addr">地址信息</param>
        /// <param name="lat">x轴</param>
        /// <param name="lng">y轴</param>
        /// <param name="diseasestatusid">病情等级编号</param>
        /// <param name="droneid">无人机编号</param>
        /// <returns>返回int</returns>
        public int update(string patientid, string patientname, string gender, int age, string addr,
            Double lat, Double lng, int diseasestatusid, string droneid, string weight, string height, string headimg)
        {
            string sql = @"update T_Patient set patientid=@patientid, patientname=@patientname 
                        ,gender=@gender,age=@age,addr=@addr,lat=@lat,lng=@lng,diseasestatusid=@diseasestatusid, 
                        droneid=@droneid,weight=@weight,height=@height,headimg=@headimg where patientid=@patientid ";

            string[] param = { "@patientid", "@patientname", "@gender", "age", "addr", "lat", "lng", "@diseasestatusid", "@droneid", "@weight", "@height", "@headimg" };
            object[] value = { patientid, patientname, gender, age, addr, lat, lng, diseasestatusid, droneid, weight, height, headimg };

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

        /// <summary>
        /// 删除病人信息判断是否有外键约束
        /// </summary>
        /// <param name="patientid">编号</param>
        /// <returns>返回int</returns>
        public int isdelete(string patientid)
        {

            string sql = "select count(*) from T_PContact where patientid=@patientid ";

            string[] param = { "@patientid" };
            object[] value = { patientid };

            return Convert.ToInt32(db.ExecuteScalar(sql, param, value));
        }

        /// <summary>
        /// 修改病人信息
        /// </summary>
        /// <param name="patientid">编号</param>
        /// <param name="diseasestatusid">病情等级编号</param>
        /// <returns>返回int</returns>
        public int updatebypatientid(string patientid, int diseasestatusid)
        {
            string sql = @"update T_Patient set diseasestatusid=@diseasestatusid where patientid=@patientid ";

            string[] param = { "@patientid", "@diseasestatusid" };
            object[] value = { patientid, diseasestatusid};

            return db.ExecuteNoneQuery(sql, param, value);
        }

    }
}