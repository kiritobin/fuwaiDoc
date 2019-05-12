using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class TGuardianBLL
    {
        TGuardianDAO td = new TGuardianDAO();
        /// <summary>
        /// 查询监护人
        /// </summary>
        /// <returns>返回json</returns>
        public String getGcontactinfo()
        {
            return JsonHelper.ToJson(td.SelectGuardian());
        }

        /// <summary>
        /// 通过监护人编号查询监护人
        /// </summary>
        /// <param name="guardianid">监护人编号</param>
        /// <returns>返回json</returns>
        public String getGcontactinfobyguardianid(string guardianid)
        {
            return JsonHelper.ToJson(td.SelectGuardianbyguardianid(guardianid));
        }


        /// <summary>
        /// 添加监护人
        /// </summary>
        /// <param name="appellation">成员关系</param>
        /// <param name="guardianname">监护人姓名</param>
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean insert(string appellation, string guardianname)
        {
            int row = td.insert(appellation, guardianname);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 修改监护人
        /// </summary>
        /// <param name="appellation">成员关系</param>
        /// <param name="guardianname">监护人姓名</param>
        /// <param name="guardianid">监护人编号</param>
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean update(string appellation, string guardianname, string guardianid)
        {
            int row = td.update(appellation, guardianname, guardianid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 删除监护人
        /// </summary>
        /// <param name="guardianid">监护人编号</param>
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean delete(string guardianid)
        {
            int row = td.delete(guardianid);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
    }
}