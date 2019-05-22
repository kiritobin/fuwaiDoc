using FuWai.DAO;
using FuWai.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FuWai.BLL
{
    public class TFlightpathBLL
    {
        TFlightpathDAO td = new TFlightpathDAO();
        /// <summary>
        /// 通过无人机id查询飞行路径
        /// </summary>
        /// <param name="droneid">无人机id</param>
        /// <returns>返回json</returns>
        public String SelectFlightpathbyDroneid(string droneid,int status)
        {
            return JsonHelper.ToJson(td.SelectFlightpathbyDroneid(droneid,status));
        }

        /// <summary>
        /// 通过时间查询飞行路径
        /// </summary>
        /// <param name="flighttime">飞行时间</param>
        /// <returns>返回json</returns>
        public String SelectFlightpathbytime(string flighttime, string droneid)
        {
            return JsonHelper.ToJson(td.SelectFlightpathbytime(flighttime,droneid));
        }


        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="droneid">无人机id</param>
        /// <param name="flighttime">飞行时间</param>
        /// <param name="lat">经度</param>
        /// <param name="lng">纬度</param>
        /// <returns>成功返回true失败返回fasle</returns>
        public Boolean insert(string droneid, string flighttime, double lat, double lng,int status)
        {
            int row = td.insert(droneid, flighttime, lat, lng, status);
            if (row > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 通过坐标改变已飞过状态
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <returns></returns>
        public Boolean changestatus(double lat,double lng)
        {
            int row = td.changestatus(lat, lng);
            if (row > 0)
            {
                return true;
            }
            return false;
        }
    }
}