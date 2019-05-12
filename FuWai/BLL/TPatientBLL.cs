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
        public String getDroneinfobydroneid(string patientid)
        {
            return JsonHelper.ToJson(td.SelectPatientByID(patientid));
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
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean insert(string patientid, string patientname, string gender, int guardianid, int diseasestatusid, string droneid,string tel)
        {
            int row = td.insert(patientid, patientname, gender, guardianid, diseasestatusid, droneid,tel);
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
        /// <param name="guardianid">监护人编号</param>
        /// <param name="diseasestatusid">病情等级编号</param>
        /// <param name="droneid">无人机编号</param>
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean update(string patientid, string patientname, string gender, int guardianid, int diseasestatusid, string droneid,string tel)
        {
            int row = td.update(patientid, patientname, gender, guardianid, diseasestatusid, droneid,tel);
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

    }
}