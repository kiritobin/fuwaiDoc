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
        /// <param name="guardianid">无人机编号</param>
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
        public Boolean update(string contactphone, string guardianid)
        {
            int row = td.update(contactphone, guardianid);
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
        public Boolean delete(string droneid)
        {
            int row = td.delete(droneid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
    }
}