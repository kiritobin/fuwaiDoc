using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FuWai.DAO
{
    public class VGContactDAO
    {
        SQLHelper db = new SQLHelper();
        /// <summary>
        /// 查询监护人信息
        /// </summary>
        /// <returns>datatable的表格</returns>
        public DataTable selectVGContact()
        {
            String sql = "select patientid,guardianid,appellation,guardianname, " +
                         "stuff((select ',' + contactphone from V_GContact where c.guardianid = guardianid " +
                         "for xml path('')),1,1,'') as cp from V_GContact c group by guardianid,patientid,appellation,guardianname";
            return db.FillDataSet(sql, null, null).Tables[0];
        }
        /// <summary>
        /// 通过病人编号查询监护人信息
        /// </summary>
        /// <returns>datatable的表格</returns>
        public DataTable selectVGContactByPatientId(string patientid)
        {
            String sql = @"select * from(select patientid,guardianid,appellation,guardianname,stuff((select ',' + contactphone from V_GContact where c.guardianid = guardianid 
                    for xml path('')),1,1,'') as cp from V_GContact c group by guardianid,patientid,appellation,guardianname) as d 
            where patientid=@patientid";
            String[] param = { "@patientid" };
            object[] value = { patientid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }
    }
}