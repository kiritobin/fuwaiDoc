using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using FuWai.DBHelper;

namespace FuWai.DAO
{
    public class TGcontactDAO
    {
        SQLHelper db = new SQLHelper();

        /// <summary>
        /// 查询监护人联系方式
        /// </summary>
        /// <returns>返回数据集DataTable</returns>
        public DataTable SelectGcontact()
        {
            string sql = "select * from T_Gcontact";
            return db.FillDataSet(sql, null, null).Tables[0];
        }

        /// <summary>
        /// 通过监护人编号查询监护人联系方式
        /// </summary>
        /// <param name="guardianid">监护人编号</param>
        /// <returns>返回数据集DataTable</returns>
        public DataTable SelectGcontactbyguardianid(string guardianid)
        {
            string sql = "select * from T_Gcontact where guardianid=@guardianid";
            string[] param = { "@guardianid" };
            object[] value = { guardianid };
            return db.FillDataSet(sql, param, value).Tables[0];
        }

        /// <summary>
        /// 添加监护人联系方式
        /// </summary>
        /// <param name="contactphone">联系方式</param>
        /// <param name="guardianid">监护人编号</param>
        /// <returns>返回int</returns>
        public int insert(string contactphone, string guardianid)
        {
            string sql = "insert into T_Gcontact values(@contactphone,@guardianid)";

            string[] param = { "@contactphone", "@guardianid" };
            object[] value = { contactphone, guardianid };

            return db.ExecuteNoneQuery(sql, param, value);
        }

        /// <summary>
        /// 修改监护人联系方式
        /// </summary>
        /// <param name="contactphone">联系方式</param>
        /// <param name="guardianid">监护人编号</param>
        /// <returns>返回int</returns>
        public int update(string contactphone, string guardianid)
        {
            string sql = "update T_Gcontact set contactphone=@contactphone where guardianid=@guardianid ";

            string[] param = { "@contactphone", "@guardianid" };
            object[] value = { contactphone, guardianid };

            return db.ExecuteNoneQuery(sql, param, value);
        }

        /// <summary>
        /// 删除监护人联系方式
        /// </summary>
        /// <param name="gcontactid">联系方式编号</param>
        /// <returns>返回int</returns>
        public int delete(string gcontactid)
        {
            string sql = "delete from T_Gcontact where gcontactid=@gcontactid ";

            string[] param = { "@gcontactid" };
            object[] value = { gcontactid };

            return db.ExecuteNoneQuery(sql, param, value);
        }

    }
}