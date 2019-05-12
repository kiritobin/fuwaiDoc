using FuWai.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using FuWai.DBHelper;

namespace FuWai.BLL
{
    public class TDroneBLL
    {
        TDroneDAO td = new TDroneDAO();
        /// <summary>
        /// 无人机信息查询
        /// </summary>
        /// <returns></returns>
        public String getDroneinfo()
        {
            DataTable dt = td.SelectDrone();
            String json = "";
            json = JsonHelper.ToJson(dt);
            return json;
        }
    }
}