using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class TMedicalhistoryBLL
    {

        TMedicalhistoryDAO td = new TMedicalhistoryDAO();

        /// <summary>
        /// 病史查询 
        /// </summary>
        /// <returns>返回json</returns>
        public String getMedicalhistory()
        {
            return JsonHelper.ToJson(td.SelectMedicalhistory());
        }
        /// <summary>
        /// 通过病人编号查询病史记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public String SelectByPatient(string patientid)
        {
            return JsonHelper.ToJson(td.SelectByPatient(patientid));
        }
        /// <summary>
        /// 通过病史编号查询
        /// </summary>
        /// <param name="droneid">无人机编号</param>
        /// <returns>返回json</returns>
        public String getDroneinfobydroneid(string medicalhistoryid)
        {
            return JsonHelper.ToJson(td.SelecttMedicalhistoryByID(medicalhistoryid));
        }

        /// <summary>
        /// 添加病史信息
        /// </summary>
        /// <param name="medicalhistoryreason">病因</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public Boolean insert(string medicalhistoryreason, string patientid,string remark,string doctor)
        {
            int row = td.insert(medicalhistoryreason, patientid, remark, doctor);
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 修改病史信息
        /// </summary>
        /// <param name="medicalhistoryreason">病因</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public Boolean update(string medicalhistoryreason, string medicalhistoryid ,string remark, string doctor)
        {
            int row = td.update(medicalhistoryreason, medicalhistoryid, remark, doctor);
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 删除病史信息
        /// </summary>
        /// <param name="medicalhistoryid">编号</param>
        /// <returns></returns>
        public Boolean delete(string medicalhistoryid)
        {
            int row = td.delete(medicalhistoryid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }

    }

}