using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class TGcontactBLL
    {
        TGcontactDAO td = new TGcontactDAO();
        /// <summary>
        /// 查询监护人联系方式
        /// </summary>
        /// <returns>返回json</returns>
        public String getGcontactinfo()
        {
            return JsonHelper.ToJson(td.SelectGcontact());
        }

        /// <summary>
        /// 通过监护人编号查询监护人联系方式
        /// </summary>
        /// <param name="guardianid">监护人编号</param>
        /// <returns>返回json</returns>
        public String getGcontactinfobyguardianid(string guardianid)
        {
            return JsonHelper.ToJson(td.SelectGcontactbyguardianid(guardianid));
        }


        /// <summary>
        /// 添加监护人联系方式
        /// </summary>
        /// <param name="contactphone">联系方式</param>
        /// <param name="guardianid">监护人编号</param>
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean insert(string contactphone, string guardianid)
        {
            int row = td.insert(contactphone, guardianid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 修改监护人联系方式
        /// </summary>
        /// <param name="contactphone">联系方式</param>
        /// <param name="guardianid">监护人编号</param>
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean update(string contactphone, string gcontactid)
        {
            int row = td.update(contactphone, gcontactid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 删除监护人联系方式
        /// </summary>
        /// <param name="gcontactid">联系方式编号</param>
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean delete(string gcontactid)
        {
            int row = td.delete(gcontactid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 判断删除监护人有没有外键约束
        /// </summary>
        /// <param name="gcontactid"></param>
        /// <returns></returns>
        public Boolean isdelete(string guardianid)
        {
            int row = td.isdelete(guardianid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
    }
}