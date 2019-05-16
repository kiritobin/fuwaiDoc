using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class TDiagnoseBLL
    {
        TDiagnoseDAO td = new TDiagnoseDAO();

        /// <summary>
        /// 添加诊断记录
        /// </summary>
        /// <param name="diagnosetime">时间</param>
        /// <param name="diagnose">诊断结果</param>
        /// <param name="doctor">主治医师</param>
        /// <param name="remark">备注</param>
        /// <param name="patientid">病人编号</param>
        /// <returns>boolean true添加成功，false添加失败</returns>
        public Boolean insert(string diagnosetime, string diagnose, string doctor, string remark, string patientid)
        {
            int row = td.insert(diagnosetime, diagnose, doctor, remark, patientid);
            if (row > 0) return true;
            return false;
        }

        /// <summary>
        /// 修改诊断记录
        /// </summary>
        /// <param name="diagnosetime">时间</param>
        /// <param name="diagnose">诊断结果</param>
        /// <param name="doctor">主治医师</param>
        /// <param name="remark">备注</param>
        /// <param name="patientid">病人编号</param>
        /// <returns>boolean true修改成功，false修改失败</returns>
        public Boolean update(int diagnoseid, string diagnosetime, string diagnose, string doctor, string remark, string patientid)
        {
            int row = td.update(diagnoseid, diagnosetime, diagnose, doctor, remark, patientid);
            if (row > 0) return true;
            return false;
        }

        /// <summary>
        /// 删除一条诊断记录
        /// </summary>
        /// <param name="diagnoseid">诊断记录编号</param>
        /// <returns>boolean true修改成功，false修改失败</returns>
        public Boolean delete(int diagnoseid)
        {
            int row = td.delete(diagnoseid);
            if (row > 0) return true;
            return false;
        }

        /// <summary>
        /// 查询所有诊断记录
        /// </summary>
        /// <returns>json</returns>
        public string SelectAllDiagnose()
        {
            return JsonHelper.ToJson(td.SelectAllDiagnose());
        }

        /// <summary>
        /// 根据诊断记录id查询检查记录
        /// </summary>
        /// <param name="diagnoseid">诊断记录编号</param>
        /// <returns>json</returns>
        public string SelectDiagnoseBydiagnoseid(string diagnoseid)
        {
            return JsonHelper.ToJson(td.SelectDiagnoseBydiagnoseid(diagnoseid));
        }

        /// <summary>
        ///  根据病人编号查询检查记录
        /// </summary>
        /// <param name="patientid">病人编号</param>
        /// <returns>json</returns>
        public string SelectDiagnoseBypatientid(string patientid)
        {
            return JsonHelper.ToJson(td.SelectDiagnoseBypatientid(patientid));
        }

    }
}