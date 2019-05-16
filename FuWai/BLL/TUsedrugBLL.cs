using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class TUsedrugBLL
    {
        
        TUsedrugDAO dao = new TUsedrugDAO();
        /// <summary>
        /// 查询所有的用药记录
        /// </summary>
        /// <returns>DataTable</returns>
        public string selectAllTUsedrug()
        {
            return JsonHelper.ToJson(dao.selectAllTUsedrug());
        }
        /// <summary>
        /// 根据病人编号查询用药记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns>DataTable</returns>
        public string selectByPatientId(string patientid)
        {
            return JsonHelper.ToJson(dao.selectByPatientId(patientid));
        }
        /// <summary>
        /// 根据主键（用药记录id）查询用药记录
        /// </summary>
        /// <param name="Usedrugid">主键</param>
        /// <returns>DataTable</returns>
        public string selectByUsedrugId(string usedrugid)
        {
            return JsonHelper.ToJson(dao.selectByUsedrugId(usedrugid));
        }
        /// <summary>
        /// 添加病人用药记录信息
        /// </summary>
        /// <param name="Usedrugid">编号</param>
        /// <param name="UsedrugBdate">开始时间</param>
        /// <param name="UsedrugEdate">结束时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public Boolean insert(string usedrugidtime, string usedrugidname, string dosage, string remark, string patientid)
        {
            int row = dao.insert(usedrugidtime, usedrugidname, dosage, remark, patientid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 根据编号删除用药记录
        /// </summary>
        /// <param name="Usedrugid">编号</param>
        /// <returns></returns>
        public Boolean delete(string usedrugid)
        {
            int row = dao.delete(usedrugid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 根据病人编号删除用药记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public Boolean deleteByPatientId(string patientid)
        {
            int row = dao.deleteByPatientId(patientid);
            if (row > 0)
            {
                return true;
            }
            return false;
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
        public Boolean update(string usedrugid, string usedrugidtime, string usedrugidname, string dosage, string remark, string patientid)
        {
            int row = dao.update(usedrugid,usedrugidtime, usedrugidname, dosage, remark, patientid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
    }
}