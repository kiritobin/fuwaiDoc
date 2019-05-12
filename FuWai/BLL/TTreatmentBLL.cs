using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuWai.DAO;
using FuWai.DBHelper;

namespace FuWai.BLL
{
    public class TTreatmentBLL
    {
        TTreatmentDAO dao = new TTreatmentDAO();
        /// <summary>
        /// 查询所有的治疗记录
        /// </summary>
        /// <returns></returns>
        public String selectAllTTreatment()
        {
            return JsonHelper.ToJson(dao.selectAllTTreatment());
        }
        /// <summary>
        /// 根据病人编号查询治疗记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public String selectByPatientId(string patientid)
        {
            return JsonHelper.ToJson(dao.selectByPatientId(patientid));
        }
        /// <summary>
        /// 根据主键查询治疗记录
        /// </summary>
        /// <param name="treatmentid">主键</param>
        /// <returns></returns>
        public String selectByTreatmentId(string treatmentid)
        {
            return JsonHelper.ToJson(dao.selectByTreatmentId(treatmentid));
        }
        /// <summary>
        /// 添加病人治疗记录信息
        /// </summary>
        /// <param name="treatmentid">编号</param>
        /// <param name="treatmentBdate">开始时间</param>
        /// <param name="treatmentEdate">结束时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public bool insertTreatment(string treatmentid, string treatmentBdate, string treatmentEdate, string patientid)
        {
            int row = dao.insertTreatment(treatmentid, treatmentBdate, treatmentEdate, patientid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 根据编号删除治疗记录
        /// </summary>
        /// <param name="treatmentid">编号</param>
        /// <returns></returns>
        public bool deleteByTreatmentId(string treatmentid)
        {
            int row = dao.deleteByTreatmentId(treatmentid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 根据病人编号删除治疗记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public bool deletByPatientId(string patientid)
        {
            int row = dao.deletByPatientId(patientid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 根据编号更新病人治疗记录
        /// </summary>
        /// <param name="treatmentid"></param>
        /// <param name="treatmentBdate"></param>
        /// <param name="treatmentEdate"></param>
        /// <returns></returns>
        public bool updateTreatmentId(string treatmentid, string treatmentBdate, string treatmentEdate)
        {
            int row = dao.updateTreatmentId(treatmentid, treatmentBdate, treatmentEdate);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 根据病人编号更新治疗记录
        /// </summary>
        /// <param name="treatmentid">编号</param>
        /// <param name="treatmentBdate">开始时间</param>
        /// <param name="treatmentEdate">结束时间</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public bool updatePatientId(string treatmentid, string treatmentBdate, string treatmentEdate, string patientid)
        {
            int row = dao.updatePatientId(treatmentid, treatmentBdate, treatmentEdate, patientid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
    }
}