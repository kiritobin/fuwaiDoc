using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FuWai.DAO;
using FuWai.DBHelper;

namespace FuWai.BLL
{
    public class TPContactBLL
    {
        TPContactDAO dao = new TPContactDAO();
        /// <summary>
        /// 查询所有的病人联系方式
        /// </summary>
        /// <returns></returns>
        public String selectAllPContact()
        {
            return JsonHelper.ToJson(dao.selectAllPContact());
        }
        /// <summary>
        /// 根据病人编号查询病人联系方式
        /// </summary>
        /// <returns></returns>
        public String selectByPatientId(string patientid)
        {
            return JsonHelper.ToJson(dao.selectByPatientId(patientid));
        }
        /// <summary>
        /// 添加病人联系方式
        /// </summary>
        /// <param name="pcontactphone">病人联系方式</param>
        /// <param name="patientid">病人编号</param>
        /// <returns></returns>
        public bool insertPContact(string pcontactphone, string patientid)
        {
            int row = dao.insertPContact(pcontactphone, patientid);
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        ///  根据pcontactid来删除病人联系方式(删除单个联系方式)
        /// </summary>
        /// <param name="pcontactid">主键id</param>
        /// <returns></returns>
        public bool deletByPContactId(int pcontactid)
        {
            int row = dao.deletByPContactId(pcontactid);
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        ///  根据病人编号来删除病人联系方式
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
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 根据pcontactid更新病人联系方式
        /// </summary>
        /// <param name="pcontactphone">新的联系方式</param>
        /// <param name="pcontactid">主键id</param>
        /// <returns></returns>
        public bool updatePContact(string pcontactphone, int pcontactid)
        {
            int row = dao.updatePContact(pcontactphone, pcontactid);
            if (row > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}