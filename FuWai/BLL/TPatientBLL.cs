using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class TPatientBLL
    {

        TPatientDAO td = new TPatientDAO();
        /// <summary>
        /// 病人信息查询
        /// </summary>
        /// <returns>返回json</returns>
        public String getPatient()
        {
            return JsonHelper.ToJson(td.SelectPatient());
        }

        /// <summary>
        /// 通过病人编号查询
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns>返回json</returns>
        public String getinfobypatientid(string patientid)
        {
            return JsonHelper.ToJson(td.SelectPatientByID(patientid));
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
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean insert(string patientid, string patientname, string gender, int age,
            string addr, Double lat, Double lng, int diseasestatusid, string droneid, string weight, string height, string headimg)
        {
            int row = td.insert(patientid, patientname, gender, age, addr, lat, lng, diseasestatusid, droneid, weight, height, headimg);
            if (row > 0)
            {
                return true;
            }
            return false;
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
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean update(string patientid, string patientname, string gender, int age,
            string addr, Double lat, Double lng, int diseasestatusid, string droneid, string weight, string height, string headimg)
        {
            int row = td.update(patientid, patientname, gender, age, addr, lat, lng, diseasestatusid, droneid, weight, height, headimg);
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 通过病人编号删除
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean delete(string patientid)
        {
            int row = td.delete(patientid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 删除病人信息判断是否有外键约束
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public Boolean isdelete(string patientid)
        {
            int row = td.isdelete(patientid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 修改病人信息
        /// </summary>
        /// <param name="patientid">编号</param>
        /// <param name="diseasestatusid">病情等级编号</param>
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean updatebypatientid(string patientid, int diseasestatusid)
        {
            int row = td.updatebypatientid(patientid, diseasestatusid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }

    }
}